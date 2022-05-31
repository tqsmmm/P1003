namespace 后勤工程管理系统
{
    partial class frmPremises_Import
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPremises_Import));
            this.dgvExcel = new System.Windows.Forms.DataGridView();
            this.房产名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房产编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.建筑年代 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.建筑层数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.建筑结构 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.建筑面积 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.建筑用途 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.资产原值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.资产编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.设备编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.地区 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExcel
            // 
            this.dgvExcel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.房产名称,
            this.房产编码,
            this.建筑年代,
            this.建筑层数,
            this.建筑结构,
            this.建筑面积,
            this.建筑用途,
            this.资产原值,
            this.资产编码,
            this.设备编码,
            this.地区});
            this.dgvExcel.Location = new System.Drawing.Point(12, 12);
            this.dgvExcel.Name = "dgvExcel";
            this.dgvExcel.RowTemplate.Height = 23;
            this.dgvExcel.Size = new System.Drawing.Size(960, 581);
            this.dgvExcel.TabIndex = 0;
            // 
            // 房产名称
            // 
            this.房产名称.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.房产名称.DataPropertyName = "房产名称";
            this.房产名称.HeaderText = "房产名称";
            this.房产名称.Name = "房产名称";
            this.房产名称.Width = 90;
            // 
            // 房产编码
            // 
            this.房产编码.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.房产编码.DataPropertyName = "房产编码";
            this.房产编码.HeaderText = "房产编码";
            this.房产编码.Name = "房产编码";
            this.房产编码.Width = 90;
            // 
            // 建筑年代
            // 
            this.建筑年代.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.建筑年代.DataPropertyName = "建筑年代";
            this.建筑年代.HeaderText = "建筑年代";
            this.建筑年代.Name = "建筑年代";
            this.建筑年代.Width = 90;
            // 
            // 建筑层数
            // 
            this.建筑层数.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.建筑层数.DataPropertyName = "建筑层数";
            this.建筑层数.HeaderText = "建筑层数";
            this.建筑层数.Name = "建筑层数";
            this.建筑层数.Width = 90;
            // 
            // 建筑结构
            // 
            this.建筑结构.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.建筑结构.DataPropertyName = "建筑结构";
            this.建筑结构.HeaderText = "建筑结构";
            this.建筑结构.Name = "建筑结构";
            this.建筑结构.Width = 90;
            // 
            // 建筑面积
            // 
            this.建筑面积.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.建筑面积.DataPropertyName = "建筑面积";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.建筑面积.DefaultCellStyle = dataGridViewCellStyle1;
            this.建筑面积.HeaderText = "建筑面积";
            this.建筑面积.Name = "建筑面积";
            this.建筑面积.Width = 90;
            // 
            // 建筑用途
            // 
            this.建筑用途.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.建筑用途.DataPropertyName = "建筑用途";
            this.建筑用途.HeaderText = "建筑用途";
            this.建筑用途.Name = "建筑用途";
            this.建筑用途.Width = 90;
            // 
            // 资产原值
            // 
            this.资产原值.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.资产原值.DataPropertyName = "资产原值";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0";
            this.资产原值.DefaultCellStyle = dataGridViewCellStyle2;
            this.资产原值.HeaderText = "资产原值";
            this.资产原值.Name = "资产原值";
            this.资产原值.Width = 90;
            // 
            // 资产编码
            // 
            this.资产编码.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.资产编码.DataPropertyName = "资产编码";
            this.资产编码.HeaderText = "资产编码";
            this.资产编码.Name = "资产编码";
            this.资产编码.Width = 90;
            // 
            // 设备编码
            // 
            this.设备编码.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.设备编码.DataPropertyName = "设备编码";
            this.设备编码.HeaderText = "设备编码";
            this.设备编码.Name = "设备编码";
            this.设备编码.Width = 90;
            // 
            // 地区
            // 
            this.地区.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.地区.DataPropertyName = "地区";
            this.地区.HeaderText = "地区";
            this.地区.Name = "地区";
            this.地区.Width = 62;
            // 
            // btnImport
            // 
            this.btnImport.Enabled = false;
            this.btnImport.Location = new System.Drawing.Point(432, 599);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(120, 50);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "导入";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(558, 599);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 50);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(306, 599);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(120, 50);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "检查";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // frmPremises_Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
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
            this.Name = "frmPremises_Import";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPremises_Import_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExcel;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房产名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房产编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 建筑年代;
        private System.Windows.Forms.DataGridViewTextBoxColumn 建筑层数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 建筑结构;
        private System.Windows.Forms.DataGridViewTextBoxColumn 建筑面积;
        private System.Windows.Forms.DataGridViewTextBoxColumn 建筑用途;
        private System.Windows.Forms.DataGridViewTextBoxColumn 资产原值;
        private System.Windows.Forms.DataGridViewTextBoxColumn 资产编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设备编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 地区;
    }
}