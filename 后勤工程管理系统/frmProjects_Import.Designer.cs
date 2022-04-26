namespace 后勤工程管理系统
{
    partial class frmProjects_Import
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjects_Import));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.dgvExcel = new System.Windows.Forms.DataGridView();
            this.btnCheck = new System.Windows.Forms.Button();
            this.工程名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.工程类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.工程内容 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.计划金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.可研批复 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.初始批复 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.计划文号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.开工时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.竣工时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.中标单位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.形象进度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.收集整理 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.立卷检查 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.验收合格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(508, 499);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 50);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnImport
            // 
            this.btnImport.Enabled = false;
            this.btnImport.Location = new System.Drawing.Point(382, 499);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(120, 50);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "导入";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // dgvExcel
            // 
            this.dgvExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.工程名称,
            this.工程类型,
            this.工程内容,
            this.计划金额,
            this.可研批复,
            this.初始批复,
            this.计划文号,
            this.开工时间,
            this.竣工时间,
            this.中标单位,
            this.形象进度,
            this.收集整理,
            this.立卷检查,
            this.验收合格});
            this.dgvExcel.Location = new System.Drawing.Point(12, 12);
            this.dgvExcel.Name = "dgvExcel";
            this.dgvExcel.RowTemplate.Height = 23;
            this.dgvExcel.Size = new System.Drawing.Size(860, 481);
            this.dgvExcel.TabIndex = 3;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(256, 499);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(120, 50);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "检查";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // 工程名称
            // 
            this.工程名称.DataPropertyName = "工程名称";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.工程名称.DefaultCellStyle = dataGridViewCellStyle1;
            this.工程名称.HeaderText = "工程名称";
            this.工程名称.Name = "工程名称";
            this.工程名称.Width = 300;
            // 
            // 工程类型
            // 
            this.工程类型.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.工程类型.DataPropertyName = "工程类型";
            this.工程类型.HeaderText = "工程类型";
            this.工程类型.Name = "工程类型";
            this.工程类型.Width = 90;
            // 
            // 工程内容
            // 
            this.工程内容.DataPropertyName = "工程内容";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.工程内容.DefaultCellStyle = dataGridViewCellStyle2;
            this.工程内容.HeaderText = "工程内容";
            this.工程内容.Name = "工程内容";
            this.工程内容.Width = 500;
            // 
            // 计划金额
            // 
            this.计划金额.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.计划金额.DataPropertyName = "计划金额";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            this.计划金额.DefaultCellStyle = dataGridViewCellStyle3;
            this.计划金额.HeaderText = "计划金额";
            this.计划金额.Name = "计划金额";
            this.计划金额.Width = 90;
            // 
            // 可研批复
            // 
            this.可研批复.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.可研批复.DataPropertyName = "可研批复";
            this.可研批复.HeaderText = "可研批复";
            this.可研批复.Name = "可研批复";
            this.可研批复.Width = 90;
            // 
            // 初始批复
            // 
            this.初始批复.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.初始批复.DataPropertyName = "初始批复";
            this.初始批复.HeaderText = "初始批复";
            this.初始批复.Name = "初始批复";
            this.初始批复.Width = 90;
            // 
            // 计划文号
            // 
            this.计划文号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.计划文号.DataPropertyName = "计划文号";
            this.计划文号.HeaderText = "计划文号";
            this.计划文号.Name = "计划文号";
            this.计划文号.Width = 90;
            // 
            // 开工时间
            // 
            this.开工时间.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.开工时间.DataPropertyName = "开工时间";
            dataGridViewCellStyle4.Format = "yyyy-MM-dd";
            dataGridViewCellStyle4.NullValue = "1900-01-01";
            this.开工时间.DefaultCellStyle = dataGridViewCellStyle4;
            this.开工时间.HeaderText = "开工时间";
            this.开工时间.Name = "开工时间";
            this.开工时间.Width = 90;
            // 
            // 竣工时间
            // 
            this.竣工时间.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.竣工时间.DataPropertyName = "竣工时间";
            dataGridViewCellStyle5.Format = "yyyy-MM-dd";
            dataGridViewCellStyle5.NullValue = "1900-01-01";
            this.竣工时间.DefaultCellStyle = dataGridViewCellStyle5;
            this.竣工时间.HeaderText = "竣工时间";
            this.竣工时间.Name = "竣工时间";
            this.竣工时间.Width = 90;
            // 
            // 中标单位
            // 
            this.中标单位.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.中标单位.DataPropertyName = "中标单位";
            this.中标单位.HeaderText = "中标单位";
            this.中标单位.Name = "中标单位";
            this.中标单位.Width = 90;
            // 
            // 形象进度
            // 
            this.形象进度.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.形象进度.DataPropertyName = "形象进度";
            this.形象进度.HeaderText = "形象进度";
            this.形象进度.Name = "形象进度";
            this.形象进度.Width = 90;
            // 
            // 收集整理
            // 
            this.收集整理.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.收集整理.DataPropertyName = "收集整理";
            this.收集整理.HeaderText = "收集整理";
            this.收集整理.Name = "收集整理";
            this.收集整理.Width = 90;
            // 
            // 立卷检查
            // 
            this.立卷检查.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.立卷检查.DataPropertyName = "立卷检查";
            this.立卷检查.HeaderText = "立卷检查";
            this.立卷检查.Name = "立卷检查";
            this.立卷检查.Width = 90;
            // 
            // 验收合格
            // 
            this.验收合格.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.验收合格.DataPropertyName = "验收合格";
            this.验收合格.HeaderText = "验收合格";
            this.验收合格.Name = "验收合格";
            this.验收合格.Width = 90;
            // 
            // frmProjects_Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.dgvExcel);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProjects_Import";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmProjects_Import_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.DataGridView dgvExcel;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn 工程名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 工程类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 工程内容;
        private System.Windows.Forms.DataGridViewTextBoxColumn 计划金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 可研批复;
        private System.Windows.Forms.DataGridViewTextBoxColumn 初始批复;
        private System.Windows.Forms.DataGridViewTextBoxColumn 计划文号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 开工时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 竣工时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 中标单位;
        private System.Windows.Forms.DataGridViewTextBoxColumn 形象进度;
        private System.Windows.Forms.DataGridViewTextBoxColumn 收集整理;
        private System.Windows.Forms.DataGridViewTextBoxColumn 立卷检查;
        private System.Windows.Forms.DataGridViewTextBoxColumn 验收合格;
    }
}