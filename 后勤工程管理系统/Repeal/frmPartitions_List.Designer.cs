namespace 后勤工程管理系统
{
    partial class frmPartitions_List
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.工程名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.施工单位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.分包金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.欠款金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.付款金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.管理费 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.是否挂账 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(12, 124);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(120, 50);
            this.btnDel.TabIndex = 21;
            this.btnDel.Text = "删除分包信息";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 68);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 50);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "修改分包信息";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(120, 50);
            this.btnNew.TabIndex = 19;
            this.btnNew.Text = "新建分包信息";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(12, 180);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(120, 50);
            this.btnReload.TabIndex = 22;
            this.btnReload.Text = "刷新列表";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvList);
            this.groupBox1.Location = new System.Drawing.Point(138, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 726);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分包信息列表";
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.工程名称,
            this.施工单位,
            this.分包金额,
            this.欠款金额,
            this.付款金额,
            this.管理费,
            this.是否挂账});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(3, 22);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(911, 701);
            this.dgvList.TabIndex = 13;
            // 
            // 序号
            // 
            this.序号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.序号.DataPropertyName = "序号";
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            this.序号.Width = 62;
            // 
            // 工程名称
            // 
            this.工程名称.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.工程名称.DataPropertyName = "工程名称";
            this.工程名称.HeaderText = "工程名称";
            this.工程名称.Name = "工程名称";
            this.工程名称.Width = 90;
            // 
            // 施工单位
            // 
            this.施工单位.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.施工单位.DataPropertyName = "施工单位";
            this.施工单位.HeaderText = "施工单位";
            this.施工单位.Name = "施工单位";
            this.施工单位.Width = 90;
            // 
            // 分包金额
            // 
            this.分包金额.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.分包金额.DataPropertyName = "分包金额";
            this.分包金额.HeaderText = "分包金额";
            this.分包金额.Name = "分包金额";
            this.分包金额.Width = 90;
            // 
            // 欠款金额
            // 
            this.欠款金额.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.欠款金额.DataPropertyName = "欠款金额";
            this.欠款金额.HeaderText = "欠款金额";
            this.欠款金额.Name = "欠款金额";
            this.欠款金额.Width = 90;
            // 
            // 付款金额
            // 
            this.付款金额.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.付款金额.DataPropertyName = "付款金额";
            this.付款金额.HeaderText = "付款金额";
            this.付款金额.Name = "付款金额";
            this.付款金额.Width = 90;
            // 
            // 管理费
            // 
            this.管理费.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.管理费.DataPropertyName = "管理费";
            this.管理费.HeaderText = "管理费";
            this.管理费.Name = "管理费";
            this.管理费.Width = 76;
            // 
            // 是否挂账
            // 
            this.是否挂账.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.是否挂账.DataPropertyName = "是否挂账";
            this.是否挂账.HeaderText = "是否挂账";
            this.是否挂账.Name = "是否挂账";
            this.是否挂账.Width = 71;
            // 
            // frmPartitions_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 750);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPartitions_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPartitions_List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPartitions_List_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 工程名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 施工单位;
        private System.Windows.Forms.DataGridViewTextBoxColumn 分包金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 欠款金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 付款金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 管理费;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 是否挂账;
    }
}