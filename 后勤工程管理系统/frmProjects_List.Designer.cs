namespace 后勤工程管理系统
{
    partial class frmProjects_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvList = new System.Windows.Forms.DataGridView();
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
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.施工单位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.分包金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.欠款金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.付款金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.管理费 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.是否挂账 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbTenders = new System.Windows.Forms.ComboBox();
            this.cmbTypes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlan_Code = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Checked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.cmsList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checked,
            this.序号,
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
            this.dgvList.ContextMenuStrip = this.cmsList;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(3, 22);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(1249, 318);
            this.dgvList.TabIndex = 13;
            this.dgvList.SelectionChanged += new System.EventHandler(this.dgvList_SelectionChanged);
            // 
            // cmsList
            // 
            this.cmsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑列ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.导入模版ToolStripMenuItem,
            this.导出模版ToolStripMenuItem});
            this.cmsList.Name = "cmsList";
            this.cmsList.Size = new System.Drawing.Size(125, 76);
            // 
            // 编辑列ToolStripMenuItem
            // 
            this.编辑列ToolStripMenuItem.Name = "编辑列ToolStripMenuItem";
            this.编辑列ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.编辑列ToolStripMenuItem.Text = "编辑列";
            this.编辑列ToolStripMenuItem.Click += new System.EventHandler(this.编辑列ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 6);
            // 
            // 导入模版ToolStripMenuItem
            // 
            this.导入模版ToolStripMenuItem.Name = "导入模版ToolStripMenuItem";
            this.导入模版ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.导入模版ToolStripMenuItem.Text = "导入模版";
            this.导入模版ToolStripMenuItem.Click += new System.EventHandler(this.导入模版ToolStripMenuItem_Click);
            // 
            // 导出模版ToolStripMenuItem
            // 
            this.导出模版ToolStripMenuItem.Name = "导出模版ToolStripMenuItem";
            this.导出模版ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
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
            this.btnDel.Text = "删除工程信息";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 68);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 50);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "修改工程信息";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(120, 50);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "新建工程信息";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvList);
            this.groupBox1.Location = new System.Drawing.Point(138, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1255, 343);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "工程信息列表";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvDetail);
            this.groupBox2.Location = new System.Drawing.Point(141, 467);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1252, 175);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "分包信息列表";
            // 
            // dgvDetail
            // 
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Name,
            this.施工单位,
            this.分包金额,
            this.欠款金额,
            this.付款金额,
            this.管理费,
            this.是否挂账});
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetail.Location = new System.Drawing.Point(3, 22);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.RowHeadersWidth = 51;
            this.dgvDetail.RowTemplate.Height = 23;
            this.dgvDetail.Size = new System.Drawing.Size(1246, 150);
            this.dgvDetail.TabIndex = 14;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "序号";
            this.id.HeaderText = "序号";
            this.id.Name = "id";
            this.id.Width = 62;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Name.DataPropertyName = "工程名称";
            this.Name.HeaderText = "工程名称";
            this.Name.Name = "Name";
            this.Name.Width = 90;
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
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cmbTenders);
            this.groupBox3.Controls.Add(this.cmbTypes);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtPlan_Code);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtDetail);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtYear);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(138, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1255, 100);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "筛选条件";
            // 
            // cmbTenders
            // 
            this.cmbTenders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenders.FormattingEnabled = true;
            this.cmbTenders.Location = new System.Drawing.Point(145, 57);
            this.cmbTenders.Name = "cmbTenders";
            this.cmbTenders.Size = new System.Drawing.Size(200, 28);
            this.cmbTenders.TabIndex = 17;
            this.cmbTenders.SelectionChangeCommitted += new System.EventHandler(this.cmbTenders_SelectionChangeCommitted);
            // 
            // cmbTypes
            // 
            this.cmbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypes.FormattingEnabled = true;
            this.cmbTypes.Location = new System.Drawing.Point(436, 25);
            this.cmbTypes.Name = "cmbTypes";
            this.cmbTypes.Size = new System.Drawing.Size(200, 28);
            this.cmbTypes.TabIndex = 16;
            this.cmbTypes.SelectionChangeCommitted += new System.EventHandler(this.cmbTypes_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "中标单位：";
            // 
            // txtPlan_Code
            // 
            this.txtPlan_Code.Location = new System.Drawing.Point(1018, 25);
            this.txtPlan_Code.Name = "txtPlan_Code";
            this.txtPlan_Code.Size = new System.Drawing.Size(200, 26);
            this.txtPlan_Code.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(933, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "计划文号：";
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(727, 25);
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(200, 26);
            this.txtDetail.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(642, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "工程内容：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "工程类型：";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(145, 25);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(200, 26);
            this.txtYear.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "工程年份：";
            // 
            // Checked
            // 
            this.Checked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Checked.HeaderText = "";
            this.Checked.Name = "Checked";
            this.Checked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Checked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Checked.Width = 21;
            // 
            // 序号
            // 
            this.序号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.序号.DataPropertyName = "序号";
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            this.序号.ReadOnly = true;
            this.序号.Width = 62;
            // 
            // 工程名称
            // 
            this.工程名称.DataPropertyName = "工程名称";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.工程名称.DefaultCellStyle = dataGridViewCellStyle1;
            this.工程名称.HeaderText = "工程名称";
            this.工程名称.Name = "工程名称";
            this.工程名称.ReadOnly = true;
            this.工程名称.Width = 300;
            // 
            // 工程类型
            // 
            this.工程类型.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.工程类型.DataPropertyName = "工程类型";
            this.工程类型.HeaderText = "工程类型";
            this.工程类型.Name = "工程类型";
            this.工程类型.ReadOnly = true;
            this.工程类型.Width = 90;
            // 
            // 工程内容
            // 
            this.工程内容.DataPropertyName = "工程内容";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.工程内容.DefaultCellStyle = dataGridViewCellStyle2;
            this.工程内容.HeaderText = "工程内容";
            this.工程内容.Name = "工程内容";
            this.工程内容.ReadOnly = true;
            this.工程内容.Width = 500;
            // 
            // 计划金额
            // 
            this.计划金额.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.计划金额.DataPropertyName = "计划金额";
            this.计划金额.HeaderText = "计划金额";
            this.计划金额.Name = "计划金额";
            this.计划金额.ReadOnly = true;
            this.计划金额.Width = 90;
            // 
            // 可研批复
            // 
            this.可研批复.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.可研批复.DataPropertyName = "可研批复";
            this.可研批复.HeaderText = "可研批复";
            this.可研批复.Name = "可研批复";
            this.可研批复.ReadOnly = true;
            this.可研批复.Width = 90;
            // 
            // 初始批复
            // 
            this.初始批复.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.初始批复.DataPropertyName = "初始批复";
            this.初始批复.HeaderText = "初始批复";
            this.初始批复.Name = "初始批复";
            this.初始批复.ReadOnly = true;
            this.初始批复.Width = 90;
            // 
            // 计划文号
            // 
            this.计划文号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.计划文号.DataPropertyName = "计划文号";
            this.计划文号.HeaderText = "计划文号";
            this.计划文号.Name = "计划文号";
            this.计划文号.ReadOnly = true;
            this.计划文号.Width = 90;
            // 
            // 开工时间
            // 
            this.开工时间.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.开工时间.DataPropertyName = "开工时间";
            this.开工时间.HeaderText = "开工时间";
            this.开工时间.Name = "开工时间";
            this.开工时间.ReadOnly = true;
            this.开工时间.Width = 90;
            // 
            // 竣工时间
            // 
            this.竣工时间.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.竣工时间.DataPropertyName = "竣工时间";
            this.竣工时间.HeaderText = "竣工时间";
            this.竣工时间.Name = "竣工时间";
            this.竣工时间.ReadOnly = true;
            this.竣工时间.Width = 90;
            // 
            // 中标单位
            // 
            this.中标单位.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.中标单位.DataPropertyName = "中标单位";
            this.中标单位.HeaderText = "中标单位";
            this.中标单位.Name = "中标单位";
            this.中标单位.ReadOnly = true;
            this.中标单位.Width = 90;
            // 
            // 形象进度
            // 
            this.形象进度.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.形象进度.DataPropertyName = "形象进度";
            this.形象进度.HeaderText = "形象进度";
            this.形象进度.Name = "形象进度";
            this.形象进度.ReadOnly = true;
            this.形象进度.Width = 90;
            // 
            // 收集整理
            // 
            this.收集整理.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.收集整理.DataPropertyName = "收集整理";
            this.收集整理.HeaderText = "收集整理";
            this.收集整理.Name = "收集整理";
            this.收集整理.ReadOnly = true;
            this.收集整理.Width = 90;
            // 
            // 立卷检查
            // 
            this.立卷检查.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.立卷检查.DataPropertyName = "立卷检查";
            this.立卷检查.HeaderText = "立卷检查";
            this.立卷检查.Name = "立卷检查";
            this.立卷检查.ReadOnly = true;
            this.立卷检查.Width = 90;
            // 
            // 验收合格
            // 
            this.验收合格.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.验收合格.DataPropertyName = "验收合格";
            this.验收合格.HeaderText = "验收合格";
            this.验收合格.Name = "验收合格";
            this.验收合格.ReadOnly = true;
            this.验收合格.Width = 90;
            // 
            // frmProjects_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 654);
            this.Controls.Add(this.groupBox3);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProjects_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.cmsList.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPlan_Code;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTenders;
        private System.Windows.Forms.ComboBox cmbTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn 施工单位;
        private System.Windows.Forms.DataGridViewTextBoxColumn 分包金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 欠款金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 付款金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 管理费;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 是否挂账;
        private System.Windows.Forms.ContextMenuStrip cmsList;
        private System.Windows.Forms.ToolStripMenuItem 编辑列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 导入模版ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出模版ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checked;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
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