﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OES.Model;

namespace OES.UControl
{
    public partial class ClassAdd : UserControl
    {
        private Classes currentClass;

        public ClassAdd(int mode, Classes cls)
        {
            InitializeComponent();
            currentClass = null;
            if (mode == 1)
            {
                currentClass = cls;
                textDept.Text = currentClass.dept;
                textClass.Text = currentClass.className;
                textTeacherUserName.Text = currentClass.teacherUserName;
                btnAdd.Text = "修改班级";
                labelInfo.Text = "当前要修改的班级为：" + currentClass.dept + " " + currentClass.className;
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
