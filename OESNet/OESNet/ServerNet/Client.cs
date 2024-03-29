﻿
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Collections;
using System.Threading;
using System.IO;

namespace ServerNet
{
    public class Client
    {
        //客户端Socket--用于和服务端通信
        private TcpClient client;
        //命令端口大小
        private static int bufferSize = 2048;
        //Byte数据数组
        private Byte[] buffer = new Byte[bufferSize];
        //网络流
        private NetworkStream ns;
        //字符串类型的原始消息
        private string raw_msg = String.Empty;
        //得到的消息
        public string msg;
        /// <summary>
        /// 消息末尾字符
        /// </summary>
        public char EndOfMsg = '`';

        #region 事件定义
        /// <summary>
        /// 返回到Server处理的信息
        /// </summary>
        /// <param name="client">活动的Client</param>
        /// <param name="type">消息类型</param>
        public delegate void MsgFun(Client client,int type);
        public MsgFun MessageScheduler;
        /// <summary>
        /// 接收到消息
        /// </summary>
        public event ClientEventHandel ReceivedMsg;
        /// <summary>
        /// 接收到数据发送消息 服务端--->客户端
        /// </summary>
        public event ClientEventHandel ReceivedDataRequest;
        /// <summary>
        /// 准备发送数据（设置filePath）
        /// </summary>
        public event ClientEventHandel SendDataReady;
        /// <summary>
        /// 准备接收数据（设置filePath）
        /// </summary>
        public event ClientEventHandel ReceiveDataReady;
        /// <summary>
        /// 接收到数据请求消息 客户端--->服务端
        /// </summary>
        public event ClientEventHandel ReceivedDataSubmit;
        /// <summary>
        /// 接收到文字消息.第一个参数为String类型,表示收到的消息
        /// </summary>
        public event ClientEventHandel ReceivedTxt;
        /// <summary>
        /// 消息发送完成.第一个参数为String类型,表示发送出去的消息内容
        /// </summary>
        public event ClientEventHandel WrittenMsg;
        /// <summary>
        /// 客户端断开连接
        /// </summary>
        public event EventHandler DisConnect;
        /// <summary>
        /// 客户通讯端口出错
        /// </summary>
        /// <param name="c"></param>
        /// <param name="msg"></param>
        public delegate void ClientError(Client c, string msg);
        public event ClientError OnClientError;
        #endregion
        /// <summary>
        /// 客户端数据端口
        /// </summary>
        private DataPort port;
        /// <summary>
        /// 客户端数据端口
        /// </summary>
        public DataPort Port
        {
            get 
            {
                return port;
            }
            set 
            {
                port = value;
                if (value != null)
                {
                    port.InitDataPort(this.client.Client.RemoteEndPoint);
                    port.FileSizeError += new ErrorEventHandler(port_FileSizeError);
                }
            }
        }
        /// <summary>
        /// 客户端数据Ip
        /// </summary>
        public string ClientIp
        {
            get
            {
                return client.Client.RemoteEndPoint.ToString();
            }
        }

        public bool IsConnected
        {
            get
            {
                if (client == null) return false;
                if (client.Connected) return true;
                else return false;
            }
        }

        /// <summary>
        /// Client构造函数
        /// </summary>
        /// <param name="client">以连接好的Socket</param>
        public Client(TcpClient client)
        {
#if DEBUG
            OESServer.logForm.InsertMsg("Init [Client.Client]");
#endif
            this.client = client;
            ns = client.GetStream();
            ns.BeginRead(buffer, 0, bufferSize, new AsyncCallback(receive_callBack), client);
        }

        /// <summary>
        /// 文件大小出错,重传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void port_FileSizeError(object sender, ErrorEventArgs e)
        {
#if DEBUG
            OESServer.logForm.InsertMsg("In [Client.port_FileSizeError]");
#endif
            SendResend();
        }

        /// <summary>
        /// Receive回调函数
        /// </summary>
        /// <param name="asy"></param>
        private void receive_callBack(IAsyncResult asy)
        {
#if DEBUG
            OESServer.logForm.InsertMsg("In [Client.receive_callBack]");
#endif
            try
            {
                TcpClient tclient = (TcpClient)asy.AsyncState;
                int result = ns.EndRead(asy);
                DispatchMessage();
                ns.BeginRead(buffer, 0, bufferSize, new AsyncCallback(receive_callBack), client);
            }
            catch(Exception e)
            {
                if (DisConnect != null)
                    DisConnect(this, null);
                if (OnClientError != null)
                    OnClientError(this, e.ToString());
            }
        }

        /// <summary>
        /// 内部消息处理函数
        /// </summary>
        private void DispatchMessage()
        {
#if DEBUG
            OESServer.logForm.InsertMsg("In [Client.DispatchMessage]");
#endif
             string raw_msgs = System.Text.Encoding.Default.GetString(buffer, 0, buffer.Length).Trim('\0');
             foreach (string onemsg in raw_msgs.Split(EndOfMsg))
             {
                 if (!String.IsNullOrEmpty(onemsg))
                 {
                     string[] messages;
                     char[] sparator = new char[] { '#' };

                     raw_msg = onemsg;
                     Array.Clear(buffer, 0, bufferSize);

                     if (ReceivedMsg != null)
                     {
                         ReceivedMsg(this, raw_msg);
                     }

                     messages = raw_msg.Split(sparator, StringSplitOptions.RemoveEmptyEntries);

                     switch (messages[0])
                     {
                         case "cmd":                             //命令
                             switch (messages[1])
                             {
                                 case "0":                       //申请数据端口
                                     switch (messages[2])
                                     {
                                         case "0":               //上传文件
                                             if (ReceivedDataSubmit != null)
                                             {
                                                 ReceivedDataSubmit(this, raw_msg);
                                             }
                                             MessageScheduler(this, 0);
                                             break;
                                         case "1":               //下载文件
                                             if (ReceivedDataRequest != null)
                                             {
                                                 ReceivedDataRequest(this, raw_msg);
                                             }
                                             MessageScheduler(this, 1);
                                             break;
                                     }
                                     break;
                                 case "2":
                                     port.fileLength = Int64.Parse(messages[2]);
                                     break;
                                 case "-1":
                                     MessageScheduler(this, -1);
                                     break;
                                 default:
                                     break;
                             }
                             break;
                         case "txt":
                             if (ReceivedTxt != null)
                             {
                                 ReceivedTxt(this, messages[1]);
                             }
                             break;
                         default:
                             break;
                     }
                 }
             }
        }

        /// <summary>
        /// 发出发送文件消息
        /// </summary>
        public void sendData()
        {
#if DEBUG
            OESServer.logForm.InsertMsg("In [Client.sendData]");
#endif
            if (SendDataReady != null)
                SendDataReady(this,null);
            WriteMsg(SendFileMsg(port.FilePath));
        }

        /// <summary>
        /// 发出接收文件消息
        /// </summary>
        public void fetchData()
        {
#if DEBUG
            OESServer.logForm.InsertMsg("In [Client.fetchData]");
#endif
            if (ReceiveDataReady != null)
                ReceiveDataReady(this, null);
            WriteMsg(RecieveFileMsg());
        }

        /// <summary>
        /// Write回调函数
        /// </summary>
        /// <param name="asy"></param>
        private void write_callBack(IAsyncResult asy)
        {
#if DEBUG
            OESServer.logForm.InsertMsg("In [Client.write_callBack]");
#endif
            try
            {
                ns.EndWrite(asy);
            }
            catch (Exception e)
            {
                if (OnClientError != null)
                    OnClientError(this, e.ToString());
            }
        }

        /// <summary>
        /// 传送文件消息
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        private string SendFileMsg(string filename)
        {
#if DEBUG
            OESServer.logForm.InsertMsg("In [Client.SendFileMsg]");
#endif
            if (File.Exists(filename))
            {
                FileInfo fi = new FileInfo(filename);
                return "cmd#1#1#" + port.ip.ToString() + "#" + port.localPort.ToString() + "#" + fi.Name.ToString() + "#" + fi.Length.ToString();
            }
            return "cmd#-1#Send";
        }

        /// <summary>
        /// 接收文件消息
        /// </summary>
        /// <returns></returns>
        private string RecieveFileMsg()
        {
#if DEBUG
            OESServer.logForm.InsertMsg("In [Client.InsertMsg]");
#endif
            return "cmd#1#0#" + port.ip.ToString() + "#" + port.localPort.ToString();
        }

        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="msg"></param>
        private void WriteMsg(String msg)
        {
#if DEBUG
            OESServer.logForm.InsertMsg("In [Client.WriteMsg]");
#endif
            byte[] tBuffer = System.Text.Encoding.Default.GetBytes(msg+EndOfMsg);
            try
            {
                ns.BeginWrite(tBuffer, 0, tBuffer.Length, new AsyncCallback(write_callBack), client);
                if (WrittenMsg != null)
                {
                    WrittenMsg(this,msg);
                }
            }
            catch (Exception e)
            {
                //网络出错处理程序
                if (OnClientError != null)
                    OnClientError(this, e.ToString());
            }
        }

        /// <summary>
        /// 文字消息
        /// </summary>
        /// <param name="content"></param>
        public void SendTxt(String content)
        {
#if DEBUG
            OESServer.logForm.InsertMsg("In [Client.SendTxt]");
#endif
            string tmsg = "txt#" + content;
            WriteMsg(tmsg);
        }

        /// <summary>
        /// 通知客户端服务端出错
        /// </summary>
        /// <param name="error">错误消息</param>
        public void SendError(String error)
        {
#if DEBUG
            OESServer.logForm.InsertMsg("In [Client.SendError]");
#endif
            string tmsg = "cmd#-1#" + error;
            WriteMsg(tmsg);
        }

        /// <summary>
        /// 重传消息
        /// </summary>
        public void SendResend()
        {
#if DEBUG
            OESServer.logForm.InsertMsg("In [Client.InsertMsg]");
#endif
            string tmsg = "cmd#-2";
            WriteMsg(tmsg);
        }
    }
    public delegate void ClientEventHandel(Client client, String msg);
}
