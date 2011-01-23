﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OES.XMLFile;
using OES.Model;

//using OES.XMLFile;

namespace OES.UPanel
{
    public partial class PaperInfo : UserPanel
    {
        public List<TextBox> scoreList = new List<TextBox>(9);
        public List<TextBox> countList = new List<TextBox>(3);
        public int[] flag = new int[9];
        public OESData oesData;
        public int programstate;

        public PaperInfo()
        {
            InitializeComponent();

            countList.Add(ChoiceCount);
            countList.Add(CompletionCount);
            countList.Add(JudgeCount);

            scoreList.Add(ChoiceWeight);
            scoreList.Add(CompletionWeight);
            scoreList.Add(JudgeWeight);
            scoreList.Add(WordWeight);
            scoreList.Add(ExcelWeight);
            scoreList.Add(PPTWeight);
            scoreList.Add(PCompletionWeight);
            scoreList.Add(PModifWeight);
            scoreList.Add(PFunctionWeight);

            this.ReLoad();
            this.Visible = false;
        }

        public void count()
        {
            int count = 0;
            int score = 0;
            for (int i = 0; i < 3; i++)
            {
                count = count + flag[i] * Convert.ToInt32(countList[i].Text);
                score = score + flag[i] * Convert.ToInt32(countList[i].Text) * Convert.ToInt32(scoreList[i].Text);
            }
            for (int i = 3; i < 9; i++)
            {
                count = count + flag[i];
                score = score + flag[i] * Convert.ToInt32(scoreList[i].Text);
            }
            this.ProCount.Text = count.ToString() + "题";
            this.Score.Text = score.ToString() + "分";
        }

        public int GetTag(Control con)
        {
            return Convert.ToInt32(con.Tag);
        }

        private void Count_Click(object sender, EventArgs e)
        {
            this.count();
        }

        override public void ReLoad()
        {
            this.Visible = true;
            for (int i = 0; i < 9; i++)
            {
                flag[i] = 1;
                scoreList[i].Enabled = true;
                scoreList[i].Text = "0";
            }
            CppPro.Checked = true;
            countList[0].Enabled = true;
            countList[1].Enabled = true;
            countList[2].Enabled = true;
            this.count();
        }

        override public void ReLoad(Paper p)
        {
            this.Visible = true;
        }

        private void CountButton_Click(object sender, EventArgs e)
        {
            int x = this.GetTag((Control)sender);
            flag[x] = 1 - flag[x];
            scoreList[x].Enabled = Convert.ToBoolean(flag[x]);
            if (x < 3)
            {
                countList[x].Enabled = Convert.ToBoolean(flag[x]);
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (flag[6] + flag[7] + flag[8] > 0)
            {
                if (CPro.Checked)
                {
                    programstate = 2;
                }
                if (CppPro.Checked)
                {
                    programstate = 2;
                }
            }
            else
            {
                programstate = 0;
            }
            InfoControl.TmpPaper.paperID = InfoControl.OesData.AddPaper(DateTime.Today.ToString(), TestTime.Text, Config.TempPaperPath, PaperName.Text, InfoControl.User.Id, programstate);
            InfoControl.TmpPaper.paperName = PaperName.Text;
            InfoControl.TmpPaper.programState = programstate;
            InfoControl.TmpPaper.paperPath = Config.TempPaperPath + InfoControl.TmpPaper.paperID + ".xml";
            
            XMLControl.CreatePaperXML(InfoControl.TmpPaper.paperPath, InfoControl.TmpPaper.paperID);
            PanelControl.ChangPanel(13);
        }

        private void EditPaper_Click(object sender, EventArgs e)
        {

        }
    }

}