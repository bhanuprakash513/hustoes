﻿namespace OES.UPanel
{
    partial class ClassManage
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.classInfoGroup = new System.Windows.Forms.GroupBox();
            this.classInfoDGV = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.classInfoGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classInfoDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.651163F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.34884F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnQuery, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnEdit, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.classInfoGroup, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.714286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 227F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(742, 666);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(175, 547);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 37);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加班级";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuery.Location = new System.Drawing.Point(468, 547);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(117, 37);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查找班级";
            this.btnQuery.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(175, 600);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 37);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除班级";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.Location = new System.Drawing.Point(468, 600);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(117, 37);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "修改班级";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // classInfoGroup
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.classInfoGroup, 7);
            this.classInfoGroup.Controls.Add(this.classInfoDGV);
            this.classInfoGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classInfoGroup.Font = new System.Drawing.Font("宋体", 12F);
            this.classInfoGroup.Location = new System.Drawing.Point(11, 8);
            this.classInfoGroup.Name = "classInfoGroup";
            this.tableLayoutPanel1.SetRowSpan(this.classInfoGroup, 3);
            this.classInfoGroup.Size = new System.Drawing.Size(719, 518);
            this.classInfoGroup.TabIndex = 5;
            this.classInfoGroup.TabStop = false;
            this.classInfoGroup.Text = "班级信息";
            // 
            // classInfoDGV
            // 
            this.classInfoDGV.AllowUserToAddRows = false;
            this.classInfoDGV.AllowUserToDeleteRows = false;
            this.classInfoDGV.AllowUserToResizeRows = false;
            this.classInfoDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classInfoDGV.Location = new System.Drawing.Point(3, 22);
            this.classInfoDGV.Name = "classInfoDGV";
            this.classInfoDGV.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.classInfoDGV.ReadOnly = true;
            this.classInfoDGV.RowTemplate.Height = 23;
            this.classInfoDGV.Size = new System.Drawing.Size(713, 493);
            this.classInfoDGV.TabIndex = 0;
            // 
            // ClassManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ClassManage";
            this.Size = new System.Drawing.Size(742, 666);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.classInfoGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.classInfoDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView classInfoDGV;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox classInfoGroup;
    }
}