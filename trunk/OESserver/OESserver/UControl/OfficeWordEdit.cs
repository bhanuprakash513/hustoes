﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OES.UPanel;
using OES.Model;

namespace OES.UControl
{
    public partial class OfficeWordEdit : UserControl
    {
        ProMan aProMan;
        public bool isnew = false;
        public OfficeWordEdit(ProMan pm)
        {
            InitializeComponent();
            aProMan = pm;
        }

        public void fill(List<OfficeWord> aOfficeWord)
        {
            procon.Text = aOfficeWord[0].problem;
            propath.Text = aOfficeWord[0].rawPath;
            anspath.Text = aOfficeWord[0].ansPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                anspath.Text = (openFileDialog2.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                propath.Text=(openFileDialog1.FileName);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!isnew)
            {
                InfoControl.OesData.UpdateOffice(ProList.click_proid, procon.Text, anspath.Text, propath.Text, "1");
            }
            else
            {
                InfoControl.OesData.AddOffice(procon.Text, anspath.Text, propath.Text, "1");
            }

            MessageBox.Show("保存成功！");
            aProMan.bottomPanel.Show();
            aProMan.titlePanel.Show();
            this.Hide();
            ProMan.isediting = false;
            aProMan.aChptList.newpl();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            aProMan.bottomPanel.Show();
            aProMan.titlePanel.Show();
            aProMan.aProList.Show();
            this.Hide();
            ProMan.isediting = false;
        }
    }
}
