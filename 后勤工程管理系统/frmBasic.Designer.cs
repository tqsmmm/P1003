namespace 后勤工程管理系统
{
    partial class frmBasic
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnPremises_Export = new System.Windows.Forms.Button();
            this.btnPremises_Import = new System.Windows.Forms.Button();
            this.btnPremises_Reload = new System.Windows.Forms.Button();
            this.btnPremises_Del = new System.Windows.Forms.Button();
            this.btnPremises_Edit = new System.Windows.Forms.Button();
            this.btnPremises_New = new System.Windows.Forms.Button();
            this.dgvPremises = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnTenders_Reload = new System.Windows.Forms.Button();
            this.btnTenders_Del = new System.Windows.Forms.Button();
            this.btnTenders_Edit = new System.Windows.Forms.Button();
            this.btnTenders_New = new System.Windows.Forms.Button();
            this.dgvTenders = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.中标单位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.负责人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.联系方式 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnConstructors_Reload = new System.Windows.Forms.Button();
            this.btnConstructors_Del = new System.Windows.Forms.Button();
            this.btnConstructors_Edit = new System.Windows.Forms.Button();
            this.btnConstructors_New = new System.Windows.Forms.Button();
            this.dgvConstructors = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.施工单位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnTypes_Reload = new System.Windows.Forms.Button();
            this.btnTypes_Del = new System.Windows.Forms.Button();
            this.btnTypes_Edit = new System.Windows.Forms.Button();
            this.btnTypes_Add = new System.Windows.Forms.Button();
            this.dgvTypes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.类型名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnUser_Reload = new System.Windows.Forms.Button();
            this.btnUser_Del = new System.Windows.Forms.Button();
            this.btnUsers_Edit = new System.Windows.Forms.Button();
            this.btnUser_Add = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPremises)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTenders)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConstructors)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypes)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 30);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1011, 638);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnPremises_Export);
            this.tabPage5.Controls.Add(this.btnPremises_Import);
            this.tabPage5.Controls.Add(this.btnPremises_Reload);
            this.tabPage5.Controls.Add(this.btnPremises_Del);
            this.tabPage5.Controls.Add(this.btnPremises_Edit);
            this.tabPage5.Controls.Add(this.btnPremises_New);
            this.tabPage5.Controls.Add(this.dgvPremises);
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1003, 600);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "房产信息";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnPremises_Export
            // 
            this.btnPremises_Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPremises_Export.Location = new System.Drawing.Point(636, 544);
            this.btnPremises_Export.Name = "btnPremises_Export";
            this.btnPremises_Export.Size = new System.Drawing.Size(120, 50);
            this.btnPremises_Export.TabIndex = 20;
            this.btnPremises_Export.Text = "导出信息";
            this.btnPremises_Export.UseVisualStyleBackColor = true;
            this.btnPremises_Export.Click += new System.EventHandler(this.btnPremises_Export_Click);
            // 
            // btnPremises_Import
            // 
            this.btnPremises_Import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPremises_Import.Location = new System.Drawing.Point(510, 544);
            this.btnPremises_Import.Name = "btnPremises_Import";
            this.btnPremises_Import.Size = new System.Drawing.Size(120, 50);
            this.btnPremises_Import.TabIndex = 19;
            this.btnPremises_Import.Text = "导入信息";
            this.btnPremises_Import.UseVisualStyleBackColor = true;
            this.btnPremises_Import.Click += new System.EventHandler(this.btnPremises_Import_Click);
            // 
            // btnPremises_Reload
            // 
            this.btnPremises_Reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPremises_Reload.Location = new System.Drawing.Point(384, 544);
            this.btnPremises_Reload.Name = "btnPremises_Reload";
            this.btnPremises_Reload.Size = new System.Drawing.Size(120, 50);
            this.btnPremises_Reload.TabIndex = 18;
            this.btnPremises_Reload.Text = "刷新列表";
            this.btnPremises_Reload.UseVisualStyleBackColor = true;
            this.btnPremises_Reload.Click += new System.EventHandler(this.btnPremises_Reload_Click);
            // 
            // btnPremises_Del
            // 
            this.btnPremises_Del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPremises_Del.Location = new System.Drawing.Point(258, 544);
            this.btnPremises_Del.Name = "btnPremises_Del";
            this.btnPremises_Del.Size = new System.Drawing.Size(120, 50);
            this.btnPremises_Del.TabIndex = 17;
            this.btnPremises_Del.Text = "删除房产信息";
            this.btnPremises_Del.UseVisualStyleBackColor = true;
            this.btnPremises_Del.Click += new System.EventHandler(this.btnPremises_Del_Click);
            // 
            // btnPremises_Edit
            // 
            this.btnPremises_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPremises_Edit.Location = new System.Drawing.Point(132, 544);
            this.btnPremises_Edit.Name = "btnPremises_Edit";
            this.btnPremises_Edit.Size = new System.Drawing.Size(120, 50);
            this.btnPremises_Edit.TabIndex = 16;
            this.btnPremises_Edit.Text = "修改房产信息";
            this.btnPremises_Edit.UseVisualStyleBackColor = true;
            this.btnPremises_Edit.Click += new System.EventHandler(this.btnPremises_Edit_Click);
            // 
            // btnPremises_New
            // 
            this.btnPremises_New.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPremises_New.Location = new System.Drawing.Point(6, 544);
            this.btnPremises_New.Name = "btnPremises_New";
            this.btnPremises_New.Size = new System.Drawing.Size(120, 50);
            this.btnPremises_New.TabIndex = 15;
            this.btnPremises_New.Text = "新建房产信息";
            this.btnPremises_New.UseVisualStyleBackColor = true;
            this.btnPremises_New.Click += new System.EventHandler(this.btnPremises_New_Click);
            // 
            // dgvPremises
            // 
            this.dgvPremises.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPremises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPremises.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
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
            this.dgvPremises.Location = new System.Drawing.Point(6, 6);
            this.dgvPremises.Name = "dgvPremises";
            this.dgvPremises.RowTemplate.Height = 23;
            this.dgvPremises.Size = new System.Drawing.Size(991, 532);
            this.dgvPremises.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnTenders_Reload);
            this.tabPage1.Controls.Add(this.btnTenders_Del);
            this.tabPage1.Controls.Add(this.btnTenders_Edit);
            this.tabPage1.Controls.Add(this.btnTenders_New);
            this.tabPage1.Controls.Add(this.dgvTenders);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1003, 600);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "中标单位";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnTenders_Reload
            // 
            this.btnTenders_Reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTenders_Reload.Location = new System.Drawing.Point(384, 544);
            this.btnTenders_Reload.Name = "btnTenders_Reload";
            this.btnTenders_Reload.Size = new System.Drawing.Size(120, 50);
            this.btnTenders_Reload.TabIndex = 18;
            this.btnTenders_Reload.Text = "刷新列表";
            this.btnTenders_Reload.UseVisualStyleBackColor = true;
            this.btnTenders_Reload.Click += new System.EventHandler(this.btnTenders_Reload_Click);
            // 
            // btnTenders_Del
            // 
            this.btnTenders_Del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTenders_Del.Location = new System.Drawing.Point(258, 544);
            this.btnTenders_Del.Name = "btnTenders_Del";
            this.btnTenders_Del.Size = new System.Drawing.Size(120, 50);
            this.btnTenders_Del.TabIndex = 17;
            this.btnTenders_Del.Text = "删除中标单位";
            this.btnTenders_Del.UseVisualStyleBackColor = true;
            this.btnTenders_Del.Click += new System.EventHandler(this.btnTenders_Del_Click);
            // 
            // btnTenders_Edit
            // 
            this.btnTenders_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTenders_Edit.Location = new System.Drawing.Point(132, 544);
            this.btnTenders_Edit.Name = "btnTenders_Edit";
            this.btnTenders_Edit.Size = new System.Drawing.Size(120, 50);
            this.btnTenders_Edit.TabIndex = 16;
            this.btnTenders_Edit.Text = "修改中标单位";
            this.btnTenders_Edit.UseVisualStyleBackColor = true;
            this.btnTenders_Edit.Click += new System.EventHandler(this.btnTenders_Edit_Click);
            // 
            // btnTenders_New
            // 
            this.btnTenders_New.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTenders_New.Location = new System.Drawing.Point(6, 544);
            this.btnTenders_New.Name = "btnTenders_New";
            this.btnTenders_New.Size = new System.Drawing.Size(120, 50);
            this.btnTenders_New.TabIndex = 15;
            this.btnTenders_New.Text = "新建中标单位";
            this.btnTenders_New.UseVisualStyleBackColor = true;
            this.btnTenders_New.Click += new System.EventHandler(this.btnTenders_New_Click);
            // 
            // dgvTenders
            // 
            this.dgvTenders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTenders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTenders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.中标单位,
            this.负责人,
            this.联系方式});
            this.dgvTenders.Location = new System.Drawing.Point(6, 6);
            this.dgvTenders.Name = "dgvTenders";
            this.dgvTenders.RowTemplate.Height = 23;
            this.dgvTenders.Size = new System.Drawing.Size(991, 532);
            this.dgvTenders.TabIndex = 14;
            // 
            // 序号
            // 
            this.序号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.序号.DataPropertyName = "序号";
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            this.序号.Width = 62;
            // 
            // 中标单位
            // 
            this.中标单位.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.中标单位.DataPropertyName = "中标单位";
            this.中标单位.HeaderText = "中标单位";
            this.中标单位.Name = "中标单位";
            this.中标单位.Width = 90;
            // 
            // 负责人
            // 
            this.负责人.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.负责人.DataPropertyName = "负责人";
            this.负责人.HeaderText = "负责人";
            this.负责人.Name = "负责人";
            this.负责人.Width = 76;
            // 
            // 联系方式
            // 
            this.联系方式.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.联系方式.DataPropertyName = "联系方式";
            this.联系方式.HeaderText = "联系方式";
            this.联系方式.Name = "联系方式";
            this.联系方式.Width = 90;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnConstructors_Reload);
            this.tabPage2.Controls.Add(this.btnConstructors_Del);
            this.tabPage2.Controls.Add(this.btnConstructors_Edit);
            this.tabPage2.Controls.Add(this.btnConstructors_New);
            this.tabPage2.Controls.Add(this.dgvConstructors);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1003, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "施工单位";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnConstructors_Reload
            // 
            this.btnConstructors_Reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConstructors_Reload.Location = new System.Drawing.Point(384, 544);
            this.btnConstructors_Reload.Name = "btnConstructors_Reload";
            this.btnConstructors_Reload.Size = new System.Drawing.Size(120, 50);
            this.btnConstructors_Reload.TabIndex = 11;
            this.btnConstructors_Reload.Text = "刷新列表";
            this.btnConstructors_Reload.UseVisualStyleBackColor = true;
            this.btnConstructors_Reload.Click += new System.EventHandler(this.btnConstructors_Reload_Click);
            // 
            // btnConstructors_Del
            // 
            this.btnConstructors_Del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConstructors_Del.Location = new System.Drawing.Point(258, 544);
            this.btnConstructors_Del.Name = "btnConstructors_Del";
            this.btnConstructors_Del.Size = new System.Drawing.Size(120, 50);
            this.btnConstructors_Del.TabIndex = 10;
            this.btnConstructors_Del.Text = "删除施工单位";
            this.btnConstructors_Del.UseVisualStyleBackColor = true;
            this.btnConstructors_Del.Click += new System.EventHandler(this.btnConstructors_Del_Click);
            // 
            // btnConstructors_Edit
            // 
            this.btnConstructors_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConstructors_Edit.Location = new System.Drawing.Point(132, 544);
            this.btnConstructors_Edit.Name = "btnConstructors_Edit";
            this.btnConstructors_Edit.Size = new System.Drawing.Size(120, 50);
            this.btnConstructors_Edit.TabIndex = 9;
            this.btnConstructors_Edit.Text = "修改施工单位";
            this.btnConstructors_Edit.UseVisualStyleBackColor = true;
            this.btnConstructors_Edit.Click += new System.EventHandler(this.btnConstructors_Edit_Click);
            // 
            // btnConstructors_New
            // 
            this.btnConstructors_New.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConstructors_New.Location = new System.Drawing.Point(6, 544);
            this.btnConstructors_New.Name = "btnConstructors_New";
            this.btnConstructors_New.Size = new System.Drawing.Size(120, 50);
            this.btnConstructors_New.TabIndex = 8;
            this.btnConstructors_New.Text = "新建施工单位";
            this.btnConstructors_New.UseVisualStyleBackColor = true;
            this.btnConstructors_New.Click += new System.EventHandler(this.btnConstructors_New_Click);
            // 
            // dgvConstructors
            // 
            this.dgvConstructors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConstructors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConstructors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.施工单位,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvConstructors.Location = new System.Drawing.Point(6, 6);
            this.dgvConstructors.Name = "dgvConstructors";
            this.dgvConstructors.RowTemplate.Height = 23;
            this.dgvConstructors.Size = new System.Drawing.Size(991, 532);
            this.dgvConstructors.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "序号";
            this.dataGridViewTextBoxColumn1.HeaderText = "序号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 62;
            // 
            // 施工单位
            // 
            this.施工单位.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.施工单位.DataPropertyName = "施工单位";
            this.施工单位.HeaderText = "施工单位";
            this.施工单位.Name = "施工单位";
            this.施工单位.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "负责人";
            this.dataGridViewTextBoxColumn2.HeaderText = "负责人";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 76;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "联系方式";
            this.dataGridViewTextBoxColumn3.HeaderText = "联系方式";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 90;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnTypes_Reload);
            this.tabPage3.Controls.Add(this.btnTypes_Del);
            this.tabPage3.Controls.Add(this.btnTypes_Edit);
            this.tabPage3.Controls.Add(this.btnTypes_Add);
            this.tabPage3.Controls.Add(this.dgvTypes);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1003, 600);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "工程类型";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnTypes_Reload
            // 
            this.btnTypes_Reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTypes_Reload.Location = new System.Drawing.Point(384, 544);
            this.btnTypes_Reload.Name = "btnTypes_Reload";
            this.btnTypes_Reload.Size = new System.Drawing.Size(120, 50);
            this.btnTypes_Reload.TabIndex = 11;
            this.btnTypes_Reload.Text = "刷新列表";
            this.btnTypes_Reload.UseVisualStyleBackColor = true;
            this.btnTypes_Reload.Click += new System.EventHandler(this.btnTypes_Reload_Click);
            // 
            // btnTypes_Del
            // 
            this.btnTypes_Del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTypes_Del.Location = new System.Drawing.Point(258, 544);
            this.btnTypes_Del.Name = "btnTypes_Del";
            this.btnTypes_Del.Size = new System.Drawing.Size(120, 50);
            this.btnTypes_Del.TabIndex = 10;
            this.btnTypes_Del.Text = "删除工程类型";
            this.btnTypes_Del.UseVisualStyleBackColor = true;
            this.btnTypes_Del.Click += new System.EventHandler(this.btnTypes_Del_Click);
            // 
            // btnTypes_Edit
            // 
            this.btnTypes_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTypes_Edit.Location = new System.Drawing.Point(132, 544);
            this.btnTypes_Edit.Name = "btnTypes_Edit";
            this.btnTypes_Edit.Size = new System.Drawing.Size(120, 50);
            this.btnTypes_Edit.TabIndex = 9;
            this.btnTypes_Edit.Text = "修改工程类型";
            this.btnTypes_Edit.UseVisualStyleBackColor = true;
            this.btnTypes_Edit.Click += new System.EventHandler(this.btnTypes_Edit_Click);
            // 
            // btnTypes_Add
            // 
            this.btnTypes_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTypes_Add.Location = new System.Drawing.Point(6, 544);
            this.btnTypes_Add.Name = "btnTypes_Add";
            this.btnTypes_Add.Size = new System.Drawing.Size(120, 50);
            this.btnTypes_Add.TabIndex = 8;
            this.btnTypes_Add.Text = "新建工程类型";
            this.btnTypes_Add.UseVisualStyleBackColor = true;
            this.btnTypes_Add.Click += new System.EventHandler(this.btnTypes_Add_Click);
            // 
            // dgvTypes
            // 
            this.dgvTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.类型名称});
            this.dgvTypes.Location = new System.Drawing.Point(6, 6);
            this.dgvTypes.Name = "dgvTypes";
            this.dgvTypes.RowTemplate.Height = 23;
            this.dgvTypes.Size = new System.Drawing.Size(991, 532);
            this.dgvTypes.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "序号";
            this.dataGridViewTextBoxColumn4.HeaderText = "序号";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 62;
            // 
            // 类型名称
            // 
            this.类型名称.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.类型名称.DataPropertyName = "类型名称";
            this.类型名称.HeaderText = "类型名称";
            this.类型名称.Name = "类型名称";
            this.类型名称.Width = 90;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnUser_Reload);
            this.tabPage4.Controls.Add(this.btnUser_Del);
            this.tabPage4.Controls.Add(this.btnUsers_Edit);
            this.tabPage4.Controls.Add(this.btnUser_Add);
            this.tabPage4.Controls.Add(this.dgvUsers);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1003, 600);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "用户信息";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnUser_Reload
            // 
            this.btnUser_Reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUser_Reload.Location = new System.Drawing.Point(384, 544);
            this.btnUser_Reload.Name = "btnUser_Reload";
            this.btnUser_Reload.Size = new System.Drawing.Size(120, 50);
            this.btnUser_Reload.TabIndex = 31;
            this.btnUser_Reload.Text = "刷新列表";
            this.btnUser_Reload.UseVisualStyleBackColor = true;
            this.btnUser_Reload.Click += new System.EventHandler(this.btnUser_Reload_Click);
            // 
            // btnUser_Del
            // 
            this.btnUser_Del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUser_Del.Location = new System.Drawing.Point(258, 544);
            this.btnUser_Del.Name = "btnUser_Del";
            this.btnUser_Del.Size = new System.Drawing.Size(120, 50);
            this.btnUser_Del.TabIndex = 30;
            this.btnUser_Del.Text = "删除用户信息";
            this.btnUser_Del.UseVisualStyleBackColor = true;
            this.btnUser_Del.Click += new System.EventHandler(this.btnUser_Del_Click);
            // 
            // btnUsers_Edit
            // 
            this.btnUsers_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUsers_Edit.Location = new System.Drawing.Point(132, 544);
            this.btnUsers_Edit.Name = "btnUsers_Edit";
            this.btnUsers_Edit.Size = new System.Drawing.Size(120, 50);
            this.btnUsers_Edit.TabIndex = 29;
            this.btnUsers_Edit.Text = "修改用户信息";
            this.btnUsers_Edit.UseVisualStyleBackColor = true;
            this.btnUsers_Edit.Click += new System.EventHandler(this.btnUsers_Edit_Click);
            // 
            // btnUser_Add
            // 
            this.btnUser_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUser_Add.Location = new System.Drawing.Point(6, 544);
            this.btnUser_Add.Name = "btnUser_Add";
            this.btnUser_Add.Size = new System.Drawing.Size(120, 50);
            this.btnUser_Add.TabIndex = 28;
            this.btnUser_Add.Text = "新建用户信息";
            this.btnUser_Add.UseVisualStyleBackColor = true;
            this.btnUser_Add.Click += new System.EventHandler(this.btnUser_Add_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.用户名});
            this.dgvUsers.Location = new System.Drawing.Point(6, 6);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowTemplate.Height = 23;
            this.dgvUsers.Size = new System.Drawing.Size(991, 532);
            this.dgvUsers.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "序号";
            this.dataGridViewTextBoxColumn5.HeaderText = "序号";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 62;
            // 
            // 用户名
            // 
            this.用户名.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.用户名.DataPropertyName = "用户名";
            this.用户名.HeaderText = "用户名";
            this.用户名.Name = "用户名";
            this.用户名.Width = 76;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "序号";
            this.dataGridViewTextBoxColumn6.HeaderText = "序号";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 62;
            // 
            // 房产名称
            // 
            this.房产名称.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.房产名称.DataPropertyName = "房产名称";
            this.房产名称.HeaderText = "房产名称";
            this.房产名称.Name = "房产名称";
            this.房产名称.ReadOnly = true;
            this.房产名称.Width = 90;
            // 
            // 房产编号
            // 
            this.房产编号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.房产编号.DataPropertyName = "房产编号";
            this.房产编号.HeaderText = "房产编号";
            this.房产编号.Name = "房产编号";
            this.房产编号.ReadOnly = true;
            this.房产编号.Width = 90;
            // 
            // 房产地址
            // 
            this.房产地址.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.房产地址.DataPropertyName = "房产地址";
            this.房产地址.HeaderText = "房产地址";
            this.房产地址.Name = "房产地址";
            this.房产地址.ReadOnly = true;
            this.房产地址.Width = 90;
            // 
            // 建筑年代
            // 
            this.建筑年代.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.建筑年代.DataPropertyName = "建筑年代";
            this.建筑年代.HeaderText = "建筑年代";
            this.建筑年代.Name = "建筑年代";
            this.建筑年代.ReadOnly = true;
            this.建筑年代.Width = 90;
            // 
            // 建筑层数
            // 
            this.建筑层数.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.建筑层数.DataPropertyName = "建筑层数";
            this.建筑层数.HeaderText = "建筑层数";
            this.建筑层数.Name = "建筑层数";
            this.建筑层数.ReadOnly = true;
            this.建筑层数.Width = 90;
            // 
            // 建筑结构
            // 
            this.建筑结构.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.建筑结构.DataPropertyName = "建筑结构";
            this.建筑结构.HeaderText = "建筑结构";
            this.建筑结构.Name = "建筑结构";
            this.建筑结构.ReadOnly = true;
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
            this.建筑面积.ReadOnly = true;
            this.建筑面积.Width = 90;
            // 
            // 建筑用途
            // 
            this.建筑用途.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.建筑用途.DataPropertyName = "建筑用途";
            this.建筑用途.HeaderText = "建筑用途";
            this.建筑用途.Name = "建筑用途";
            this.建筑用途.ReadOnly = true;
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
            this.资产原值.ReadOnly = true;
            this.资产原值.Width = 90;
            // 
            // 资产编码
            // 
            this.资产编码.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.资产编码.DataPropertyName = "资产编码";
            this.资产编码.HeaderText = "资产编码";
            this.资产编码.Name = "资产编码";
            this.资产编码.ReadOnly = true;
            this.资产编码.Width = 90;
            // 
            // 设备编码
            // 
            this.设备编码.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.设备编码.DataPropertyName = "设备编码";
            this.设备编码.HeaderText = "设备编码";
            this.设备编码.Name = "设备编码";
            this.设备编码.ReadOnly = true;
            this.设备编码.Width = 90;
            // 
            // 地区
            // 
            this.地区.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.地区.DataPropertyName = "地区";
            this.地区.HeaderText = "地区";
            this.地区.Name = "地区";
            this.地区.ReadOnly = true;
            this.地区.Width = 62;
            // 
            // frmBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 662);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBasic";
            this.Text = "frmBasic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBasic_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPremises)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTenders)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConstructors)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypes)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvConstructors;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 中标单位;
        private System.Windows.Forms.DataGridViewTextBoxColumn 负责人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 联系方式;
        private System.Windows.Forms.Button btnTenders_Reload;
        private System.Windows.Forms.Button btnTenders_Del;
        private System.Windows.Forms.Button btnTenders_Edit;
        private System.Windows.Forms.Button btnTenders_New;
        private System.Windows.Forms.DataGridView dgvTenders;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 施工单位;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnConstructors_Reload;
        private System.Windows.Forms.Button btnConstructors_Del;
        private System.Windows.Forms.Button btnConstructors_Edit;
        private System.Windows.Forms.Button btnConstructors_New;
        private System.Windows.Forms.DataGridView dgvTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类型名称;
        private System.Windows.Forms.Button btnTypes_Reload;
        private System.Windows.Forms.Button btnTypes_Del;
        private System.Windows.Forms.Button btnTypes_Edit;
        private System.Windows.Forms.Button btnTypes_Add;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户名;
        private System.Windows.Forms.Button btnUser_Reload;
        private System.Windows.Forms.Button btnUser_Del;
        private System.Windows.Forms.Button btnUsers_Edit;
        private System.Windows.Forms.Button btnUser_Add;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgvPremises;
        private System.Windows.Forms.Button btnPremises_Export;
        private System.Windows.Forms.Button btnPremises_Import;
        private System.Windows.Forms.Button btnPremises_Reload;
        private System.Windows.Forms.Button btnPremises_Del;
        private System.Windows.Forms.Button btnPremises_Edit;
        private System.Windows.Forms.Button btnPremises_New;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
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
    }
}