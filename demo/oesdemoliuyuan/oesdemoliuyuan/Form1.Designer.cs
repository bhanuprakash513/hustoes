﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace oesdemoliuyuan
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.fillingintheblank = new oesdemoliuyuan.Fillingintheblank();
            this.SuspendLayout();
            // 
            // fillingintheblank
            // 
            this.fillingintheblank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fillingintheblank.Location = new System.Drawing.Point(12, 12);
            this.fillingintheblank.Name = "fillingintheblank";
            this.fillingintheblank.Size = new System.Drawing.Size(450, 429);
            this.fillingintheblank.TabIndex = 0;
            this.fillingintheblank.Load += new System.EventHandler(this.fillingintheblank_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 443);
            this.Controls.Add(this.fillingintheblank);
            this.Name = "Form1";
            this.Text = "OES V1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Fillingintheblank fillingintheblank;


    }
}
