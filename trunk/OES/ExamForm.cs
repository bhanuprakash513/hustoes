﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OES.Model;
using System.IO;

namespace OES
{
    public partial class ExamForm : Form
    {
        Config config;
        public ExamForm()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            //读考卷内容
            ClientControl.paper.ReadPaper();

            ClientControl.isResume = false;
            ClientControl.ControlBar.Show();
            ClientControl.MainForm.Show();
            this.Hide();
        }

        private void ExamForm_Load(object sender, EventArgs e)
        {
            this.ExamNo.Text = ClientControl.student.examID;
            this.SName.Text = ClientControl.student.sName;
            this.ID.Text = ClientControl.student.ID;
            config = new Config(System.Environment.CurrentDirectory + @"\config.ini");
            Config.stuPath = Config.stuPath + ClientControl.student.examID + @"\";
            Config.paperPath = Config.paperPath + Paper.pName + @"\";

            if (!File.Exists(Config.paperPath))
            {
                Directory.CreateDirectory(Config.paperPath);
            }

            if (!File.Exists(Config.stuPath))
            {
                Directory.CreateDirectory(Config.stuPath);
            }
        }

        private void Resume_Click(object sender, EventArgs e)
        {
            //读考卷内容
            ClientControl.paper.ReadPaper();

            ClientControl.isResume = true;
            ClientControl.ControlBar.Show();
            ClientControl.MainForm.Show();
            this.Hide();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            ClientControl.LoginForm.Show();
            this.Hide();
        }

    }
}
