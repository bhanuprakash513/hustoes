﻿namespace OES
{
    partial class CustomChoice
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ProblemRequest = new System.Windows.Forms.Label();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.LastProblem = new System.Windows.Forms.Button();
            this.NextProblem = new System.Windows.Forms.Button();
            this.groupchoice = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.groupchoice.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProblemRequest
            // 
            this.ProblemRequest.AutoSize = true;
            this.ProblemRequest.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProblemRequest.Location = new System.Drawing.Point(21, 32);
            this.ProblemRequest.Name = "ProblemRequest";
            this.ProblemRequest.Size = new System.Drawing.Size(110, 24);
            this.ProblemRequest.TabIndex = 0;
            this.ProblemRequest.Text = "题目要求";
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(6, 20);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(95, 16);
            this.radioButtonA.TabIndex = 4;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "radioButtonA";
            this.radioButtonA.UseVisualStyleBackColor = true;
            this.radioButtonA.CheckedChanged += new System.EventHandler(this.radioButtonA_CheckedChanged);
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(6, 51);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(95, 16);
            this.radioButtonB.TabIndex = 5;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "radioButtonB";
            this.radioButtonB.UseVisualStyleBackColor = true;
            this.radioButtonB.CheckedChanged += new System.EventHandler(this.radioButtonB_CheckedChanged);
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(6, 82);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(95, 16);
            this.radioButtonC.TabIndex = 6;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "radioButtonC";
            this.radioButtonC.UseVisualStyleBackColor = true;
            this.radioButtonC.CheckedChanged += new System.EventHandler(this.radioButtonC_CheckedChanged);
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Location = new System.Drawing.Point(6, 118);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(95, 16);
            this.radioButtonD.TabIndex = 7;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "radioButtonD";
            this.radioButtonD.UseVisualStyleBackColor = true;
            this.radioButtonD.CheckedChanged += new System.EventHandler(this.radioButtonD_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.ProblemRequest);
            this.panel1.Location = new System.Drawing.Point(18, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 87);
            this.panel1.TabIndex = 8;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(128, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(609, 79);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // LastProblem
            // 
            this.LastProblem.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LastProblem.Location = new System.Drawing.Point(18, 402);
            this.LastProblem.Name = "LastProblem";
            this.LastProblem.Size = new System.Drawing.Size(152, 42);
            this.LastProblem.TabIndex = 9;
            this.LastProblem.Text = "上一题";
            this.LastProblem.UseVisualStyleBackColor = true;
            this.LastProblem.Click += new System.EventHandler(this.laststep_Click);
            // 
            // NextProblem
            // 
            this.NextProblem.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NextProblem.Location = new System.Drawing.Point(608, 402);
            this.NextProblem.Name = "NextProblem";
            this.NextProblem.Size = new System.Drawing.Size(152, 42);
            this.NextProblem.TabIndex = 10;
            this.NextProblem.Text = "下一题";
            this.NextProblem.UseVisualStyleBackColor = true;
            this.NextProblem.Click += new System.EventHandler(this.nextstep_Click);
            // 
            // groupchoice
            // 
            this.groupchoice.Controls.Add(this.radioButtonA);
            this.groupchoice.Controls.Add(this.radioButtonB);
            this.groupchoice.Controls.Add(this.radioButtonC);
            this.groupchoice.Controls.Add(this.radioButtonD);
            this.groupchoice.Location = new System.Drawing.Point(3, 126);
            this.groupchoice.Name = "groupchoice";
            this.groupchoice.Size = new System.Drawing.Size(734, 150);
            this.groupchoice.TabIndex = 11;
            this.groupchoice.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.richTextBox2);
            this.panel2.Controls.Add(this.groupchoice);
            this.panel2.Location = new System.Drawing.Point(18, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 283);
            this.panel2.TabIndex = 12;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox2.Location = new System.Drawing.Point(3, 6);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(734, 104);
            this.richTextBox2.TabIndex = 12;
            this.richTextBox2.Text = "";
            // 
            // Fillingintheblank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.NextProblem);
            this.Controls.Add(this.LastProblem);
            this.Controls.Add(this.panel1);
            this.Name = "Fillingintheblank";
            this.Size = new System.Drawing.Size(763, 464);
            this.Load += new System.EventHandler(this.Fillingintheblank_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupchoice.ResumeLayout(false);
            this.groupchoice.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ProblemRequest;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LastProblem;
        private System.Windows.Forms.Button NextProblem;
        private System.Windows.Forms.GroupBox groupchoice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}
