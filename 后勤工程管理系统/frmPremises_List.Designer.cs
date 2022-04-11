namespace 后勤工程管理系统
{
    partial class frmPremises_List
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
            this.components = new System.ComponentModel.Container();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房产名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房产编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房产地址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.建筑年代 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.建筑层数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.建筑结构 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.建筑面积 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.建筑用途 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.资产原值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.资产编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.设备编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.地区 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.编辑列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.导入模版ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出模版ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.cmsList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.房产名称,
            this.房产编号,
            this.房产地址,
            this.建筑年代,
            this.建筑层数,
            this.建筑结构,
            this.建筑面积,
            this.建筑用途,
            this.资产原值,
            this.资产编码,
            this.设备编码,
            this.地区});
            this.dgvList.ContextMenuStrip = this.cmsList;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(3, 22);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(957, 453);
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
            // 房产名称
            // 
            this.房产名称.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.房产名称.DataPropertyName = "房产名称";
            this.房产名称.HeaderText = "房产名称";
            this.房产名称.Name = "房产名称";
            this.房产名称.Width = 90;
            // 
            // 房产编号
            // 
            this.房产编号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.房产编号.DataPropertyName = "房产编号";
            this.房产编号.HeaderText = "房产编号";
            this.房产编号.Name = "房产编号";
            this.房产编号.Width = 90;
            // 
            // 房产地址
            // 
            this.房产地址.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.房产地址.DataPropertyName = "房产地址";
            this.房产地址.HeaderText = "房产地址";
            this.房产地址.Name = "房产地址";
            this.房产地址.Width = 90;
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
            // cmsList
            // 
            this.cmsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑列ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.导入模版ToolStripMenuItem,
            this.导出模版ToolStripMenuItem});
            this.cmsList.Name = "cmsList";
            this.cmsList.Size = new System.Drawing.Size(181, 98);
            // 
            // 编辑列ToolStripMenuItem
            // 
            this.编辑列ToolStripMenuItem.Name = "编辑列ToolStripMenuItem";
            this.编辑列ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.编辑列ToolStripMenuItem.Text = "编辑列";
            this.编辑列ToolStripMenuItem.Click += new System.EventHandler(this.编辑列ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // 导入模版ToolStripMenuItem
            // 
            this.导入模版ToolStripMenuItem.Name = "导入模版ToolStripMenuItem";
            this.导入模版ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.导入模版ToolStripMenuItem.Text = "导入模版";
            this.导入模版ToolStripMenuItem.Click += new System.EventHandler(this.导入模版ToolStripMenuItem_Click);
            // 
            // 导出模版ToolStripMenuItem
            // 
            this.导出模版ToolStripMenuItem.Name = "导出模版ToolStripMenuItem";
            this.导出模版ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.导出模版ToolStripMenuItem.Text = "导出模版";
            this.导出模版ToolStripMenuItem.Click += new System.EventHandler(this.导出模版ToolStripMenuItem_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(12, 292);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(120, 50);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "导出信息";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(12, 236);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(120, 50);
            this.btnImport.TabIndex = 11;
            this.btnImport.Text = "导入信息";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(12, 180);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(120, 50);
            this.btnReload.TabIndex = 10;
            this.btnReload.Text = "刷新列表";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(12, 124);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(120, 50);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "删除房产信息";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 68);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 50);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "修改房产信息";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(120, 50);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "新建房产信息";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvList);
            this.groupBox1.Location = new System.Drawing.Point(138, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(963, 478);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "房产信息列表";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtRegion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtCode);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(141, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(960, 75);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "筛选条件";
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(680, 25);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(200, 26);
            this.txtRegion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(623, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "地区：";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(417, 25);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(200, 26);
            this.txtCode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "房产编号：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 26);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "房产名称：";
            // 
            // frmPremises_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 583);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPremises_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPremises_List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPremises_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.cmsList.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房产名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房产编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房产地址;
        private System.Windows.Forms.DataGridViewTextBoxColumn 建筑年代;
        private System.Windows.Forms.DataGridViewTextBoxColumn 建筑层数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 建筑结构;
        private System.Windows.Forms.DataGridViewTextBoxColumn 建筑面积;
        private System.Windows.Forms.DataGridViewTextBoxColumn 建筑用途;
        private System.Windows.Forms.DataGridViewTextBoxColumn 资产原值;
        private System.Windows.Forms.DataGridViewTextBoxColumn 资产编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设备编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 地区;
        private System.Windows.Forms.ContextMenuStrip cmsList;
        private System.Windows.Forms.ToolStripMenuItem 编辑列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 导入模版ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出模版ToolStripMenuItem;
    }
}