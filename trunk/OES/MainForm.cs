﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OES.UControl;
using OES.XMLFile;
using OES.Model;

namespace OES
{
    public partial class MainForm : Form
    {

        static public bool wordExists = false;
        static public bool pptExists = false;
        static public bool excelExists = false;
        static public bool pCompletionExists = false;
        static public bool pModifExists = false;
        static public bool pFunctionExists = false;
        static public bool choiceExists = false;
        static public bool judgeExists = false;
        static public bool completionExists = false;

        static private CustomWord officeWord;
        static private CustomPPT officePpt;
        static private CustomExcel officeExcel;
        static private CustomProgramInfo pCompletion;
        static private CustomProgramInfo pModif;
        static private CustomProgramInfo pFunction;
        static private CustomJudge judge;
        static private CustomChoice choice;
        static private CustomCompletion completion;      

        static private TabPage oficeWordPage;
        static private TabPage oficePptPage;
        static private TabPage oficeExcelPage;
        static private TabPage pCompletionPage;
        static private TabPage pModifPage;
        static private TabPage pFunctionPage;
        static private TabPage judgePage;
        static private TabPage choicePage;
        static private TabPage completionPage;

        static public ProblemsList problemsList;
        public MainForm()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
        }

        public void addChoicePage()
        {
            choice = new CustomChoice();
            choice.Font = new Font("宋体", 9);
            choicePage = new TabPage("选择题");
            choicePage.Controls.Add(choice);
            tabControl.TabPages.Add(choicePage);
        }

        public void addCompletionPage()
        {
            completion = new CustomCompletion();
            completion.Font = new Font("宋体", 9);
            completionPage = new TabPage("填空题");
            completionPage.Controls.Add(completion);
            tabControl.TabPages.Add(completionPage);
        }

        public void addJudgePage()
        {
            judge = new CustomJudge();
            judge.Font = new Font("宋体", 9);
            judgePage = new TabPage("判断题");
            judgePage.Controls.Add(judge);
            tabControl.TabPages.Add(judgePage);
        }

        public void addWordPage()
        {
            officeWord = new CustomWord();
            officeWord.Font = new Font("宋体", 9);
            oficeWordPage = new TabPage("Word操作题");
            oficeWordPage.Controls.Add(officeWord);
            tabControl.TabPages.Add(oficeWordPage);
        }

        public void addPptPage()
        {
            officePpt = new CustomPPT();
            officePpt.Font = new Font("宋体", 9);
            oficePptPage = new TabPage("PowerPoint操作题");
            oficePptPage.Controls.Add(officePpt);
            tabControl.TabPages.Add(oficePptPage);
        }

        public void addExcelPage()
        {
            officeExcel = new CustomExcel();
            officeExcel.Font = new Font("宋体", 9);
            oficeExcelPage = new TabPage("Excel操作题");
            oficeExcelPage.Controls.Add(officeExcel);
            tabControl.TabPages.Add(oficeExcelPage);
        }

        public void addPCompletionPage()
        {
            pCompletion = new CustomProgramInfo(1);
            pCompletion.Font = new Font("宋体", 9);
            pCompletionPage = new TabPage("程序填空题");
            pCompletionPage.Controls.Add(pCompletion);
            tabControl.TabPages.Add(pCompletionPage);
        }

        public void addPModifPage()
        {
            pModif = new CustomProgramInfo(2);
            pModif.Font = new Font("宋体", 9);
            pModifPage = new TabPage("程序改错题");
            pModifPage.Controls.Add(pModif);
            tabControl.TabPages.Add(pModifPage);
        }

        public void addpFunctionPage()
        {
            pFunction = new CustomProgramInfo(3);
            pFunction.Font = new Font("宋体", 9);
            pFunctionPage = new TabPage("程序综合题");
            pFunctionPage.Controls.Add(pFunction);
            tabControl.TabPages.Add(pFunctionPage);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
          

            //这里初始化右边的问题列表
            //构造函数里面的值是列表的题目数量
            problemsList = new ProblemsList(ClientControl.paper.problemList.Count);
            panelProList.Controls.Add(problemsList);
            //为问题列表添加选中事件，事件函数为problemsList_OnChoose
            problemsList.OnChoose += new EventHandler(problemsList_OnChoose);

            //this.addChoicePage();

            tabControl.SelectedIndexChanged += new EventHandler(tabControl_SelectedIndexChanged);
            tabControl_SelectedIndexChanged(tabControl, null);
        }

        void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((TabControl)sender).SelectedTab.Text.ToString())
            {
                case "选择题":
                    ClientControl.CurrentProblemNum = ClientControl.paper.choice[choice.GetQuestion()].problemId;
                    break;
                case "填空题":
                    ClientControl.CurrentProblemNum = ClientControl.paper.completion[completion.GetQuestion()].problemId;
                    break;
                case "判断题":
                    ClientControl.CurrentProblemNum = ClientControl.paper.judge[judge.GetQuestion()].problemId;
                    break;
                case "程序填空题":
                    ClientControl.CurrentProblemNum = ClientControl.paper.pCompletion.problemId;
                    break;
                case "程序综合题":
                    ClientControl.CurrentProblemNum = ClientControl.paper.pFunction.problemId;
                    break;
                case "程序改错题":
                    ClientControl.CurrentProblemNum = ClientControl.paper.pModif.problemId;
                    break;
                case "Word操作题":
                    ClientControl.CurrentProblemNum = ClientControl.paper.officeWord.problemId;
                    break;
                case "PowerPoint操作题":
                    ClientControl.CurrentProblemNum = ClientControl.paper.officePPT.problemId;
                    break;
                case "Excel操作题":
                    ClientControl.CurrentProblemNum = ClientControl.paper.officeExcel.problemId;
                    break;

            }
        }

        //这里就是问题列表选中时触发的事件
        void problemsList_OnChoose(object sender, EventArgs e)
        {
            //主要是将选中的题目号传到总控类
            ClientControl.JumpToPro((int)sender);
        }

        internal void JumpPro(string tab, int index)
        {
            foreach (TabPage tp in tabControl.TabPages)
            {
                if (tp.Text == tab)
                {
                    tabControl.SelectedIndexChanged -= tabControl_SelectedIndexChanged;
                    tabControl.SelectedTab = tp;
                    tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
                    switch (tab)
                    {
                        case "选择题":
                            choice.SetQuestion(index);
                            break;
                        case "填空题":
                            completion.SetQuestion(index);
                            break;
                        case "判断题":
                            judge.SetQuestion(index);
                            break;
                        case "程序填空题":
                            
                            break;
                        case "程序综合题":
                            
                            break;
                        case "程序改错题":

                            break;
                        case "Word操作题":
                           
                            break;
                        case "PowerPoint操作题":
                           
                            break;
                        case "Excel操作题":
                           
                            break;
                    }
                    break;
                }
            }

        }
    }
}
