﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OES
{
    public partial class LoginForm : Form
    {        
        public LoginForm()
        {
            InitializeComponent();           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            ExamForm examForm = new ExamForm(this,this.SName.Text,this.ExamNo.Text,"123456789");
            examForm.Show();
            this.Hide();
        }
    }
}
