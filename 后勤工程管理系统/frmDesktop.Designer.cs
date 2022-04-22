﻿namespace 后勤工程管理系统
{
    partial class frmDesktop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.房产名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房产编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.建筑年代 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.建筑层数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.建筑结构 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.建筑用途 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.资产原值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.资产编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.设备编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.地区 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.合同金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.实际发生额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.支付金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.欠款金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.质保金支付时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.施工单位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.负责人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.联系方式 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.分包金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.支付金额1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.欠款金额1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.管理费 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.是否挂账 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.收集整理 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.立卷检查 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.验收合格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.编辑列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.导入模版ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出模版ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbConstructors = new System.Windows.Forms.ComboBox();
            this.txtManager = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbTenders = new System.Windows.Forms.ComboBox();
            this.cmbTypes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlan_Code = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.cmsList.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvList);
            this.groupBox1.Location = new System.Drawing.Point(12, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1346, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "综合数据";
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.房产名称,
            this.房产编号,
            this.建筑年代,
            this.建筑层数,
            this.建筑结构,
            this.建筑用途,
            this.资产原值,
            this.资产编码,
            this.设备编码,
            this.地区,
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
            this.合同金额,
            this.实际发生额,
            this.支付金额,
            this.欠款金额,
            this.质保金支付时间,
            this.施工单位,
            this.负责人,
            this.联系方式,
            this.分包金额,
            this.支付金额1,
            this.欠款金额1,
            this.管理费,
            this.是否挂账,
            this.收集整理,
            this.立卷检查,
            this.验收合格});
            this.dgvList.ContextMenuStrip = this.cmsList;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(3, 22);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(1340, 425);
            this.dgvList.TabIndex = 0;
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
            // 工程名称
            // 
            this.工程名称.DataPropertyName = "工程名称";
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.工程名称.DefaultCellStyle = dataGridViewCellStyle9;
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
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.工程内容.DefaultCellStyle = dataGridViewCellStyle10;
            this.工程内容.HeaderText = "工程内容";
            this.工程内容.Name = "工程内容";
            this.工程内容.Width = 500;
            // 
            // 计划金额
            // 
            this.计划金额.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.计划金额.DataPropertyName = "计划金额";
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
            this.开工时间.HeaderText = "开工时间";
            this.开工时间.Name = "开工时间";
            this.开工时间.Width = 90;
            // 
            // 竣工时间
            // 
            this.竣工时间.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.竣工时间.DataPropertyName = "竣工时间";
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
            // 合同金额
            // 
            this.合同金额.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.合同金额.DataPropertyName = "合同金额";
            this.合同金额.HeaderText = "合同金额";
            this.合同金额.Name = "合同金额";
            this.合同金额.Width = 90;
            // 
            // 实际发生额
            // 
            this.实际发生额.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.实际发生额.DataPropertyName = "实际发生额";
            this.实际发生额.HeaderText = "实际发生额";
            this.实际发生额.Name = "实际发生额";
            this.实际发生额.Width = 104;
            // 
            // 支付金额
            // 
            this.支付金额.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.支付金额.DataPropertyName = "支付金额";
            this.支付金额.HeaderText = "支付金额";
            this.支付金额.Name = "支付金额";
            this.支付金额.Width = 90;
            // 
            // 欠款金额
            // 
            this.欠款金额.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.欠款金额.DataPropertyName = "欠款金额";
            this.欠款金额.HeaderText = "欠款金额";
            this.欠款金额.Name = "欠款金额";
            this.欠款金额.Width = 90;
            // 
            // 质保金支付时间
            // 
            this.质保金支付时间.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.质保金支付时间.DataPropertyName = "质保金支付时间";
            this.质保金支付时间.HeaderText = "质保金支付时间";
            this.质保金支付时间.Name = "质保金支付时间";
            this.质保金支付时间.Width = 132;
            // 
            // 施工单位
            // 
            this.施工单位.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.施工单位.DataPropertyName = "施工单位";
            this.施工单位.HeaderText = "施工单位";
            this.施工单位.Name = "施工单位";
            this.施工单位.Width = 90;
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
            // 分包金额
            // 
            this.分包金额.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.分包金额.DataPropertyName = "分包金额";
            this.分包金额.HeaderText = "分包金额";
            this.分包金额.Name = "分包金额";
            this.分包金额.Width = 90;
            // 
            // 支付金额1
            // 
            this.支付金额1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.支付金额1.DataPropertyName = "支付金额1";
            this.支付金额1.HeaderText = "支付金额";
            this.支付金额1.Name = "支付金额1";
            this.支付金额1.Width = 90;
            // 
            // 欠款金额1
            // 
            this.欠款金额1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.欠款金额1.DataPropertyName = "欠款金额1";
            this.欠款金额1.HeaderText = "欠款金额";
            this.欠款金额1.Name = "欠款金额1";
            this.欠款金额1.Width = 90;
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
            this.是否挂账.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.是否挂账.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.是否挂账.Width = 90;
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
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReload.Location = new System.Drawing.Point(12, 604);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(120, 50);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "刷新列表";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImport.Location = new System.Drawing.Point(138, 604);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(120, 50);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "导入信息";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExport.Location = new System.Drawing.Point(264, 604);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(120, 50);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "导出信息";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cmbConstructors);
            this.groupBox2.Controls.Add(this.txtManager);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmbTenders);
            this.groupBox2.Controls.Add(this.cmbTypes);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPlan_Code);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDetail);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtYear);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtRegion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtCode);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1346, 130);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "筛选条件";
            // 
            // cmbConstructors
            // 
            this.cmbConstructors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConstructors.FormattingEnabled = true;
            this.cmbConstructors.Location = new System.Drawing.Point(100, 91);
            this.cmbConstructors.Name = "cmbConstructors";
            this.cmbConstructors.Size = new System.Drawing.Size(200, 28);
            this.cmbConstructors.TabIndex = 32;
            // 
            // txtManager
            // 
            this.txtManager.Location = new System.Drawing.Point(391, 90);
            this.txtManager.Name = "txtManager";
            this.txtManager.Size = new System.Drawing.Size(200, 26);
            this.txtManager.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(320, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "联系人：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "施工单位：";
            // 
            // cmbTenders
            // 
            this.cmbTenders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenders.FormattingEnabled = true;
            this.cmbTenders.Location = new System.Drawing.Point(973, 57);
            this.cmbTenders.Name = "cmbTenders";
            this.cmbTenders.Size = new System.Drawing.Size(200, 28);
            this.cmbTenders.TabIndex = 27;
            // 
            // cmbTypes
            // 
            this.cmbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypes.FormattingEnabled = true;
            this.cmbTypes.Location = new System.Drawing.Point(100, 57);
            this.cmbTypes.Name = "cmbTypes";
            this.cmbTypes.Size = new System.Drawing.Size(200, 28);
            this.cmbTypes.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(888, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "中标单位：";
            // 
            // txtPlan_Code
            // 
            this.txtPlan_Code.Location = new System.Drawing.Point(682, 57);
            this.txtPlan_Code.Name = "txtPlan_Code";
            this.txtPlan_Code.Size = new System.Drawing.Size(200, 26);
            this.txtPlan_Code.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "计划文号：";
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(391, 57);
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(200, 26);
            this.txtDetail.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "工程内容：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "工程类型：";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(973, 25);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(200, 26);
            this.txtYear.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(888, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "工程年份：";
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(682, 25);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(200, 26);
            this.txtRegion.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(625, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "地区：";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(391, 25);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(200, 26);
            this.txtCode.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "房产编号：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 26);
            this.txtName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "房产名称：";
            // 
            // frmDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 666);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDesktop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDesktop_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.cmsList.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房产名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房产编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 建筑年代;
        private System.Windows.Forms.DataGridViewTextBoxColumn 建筑层数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 建筑结构;
        private System.Windows.Forms.DataGridViewTextBoxColumn 建筑用途;
        private System.Windows.Forms.DataGridViewTextBoxColumn 资产原值;
        private System.Windows.Forms.DataGridViewTextBoxColumn 资产编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设备编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 地区;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn 合同金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 实际发生额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 支付金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 欠款金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 质保金支付时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 施工单位;
        private System.Windows.Forms.DataGridViewTextBoxColumn 负责人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 联系方式;
        private System.Windows.Forms.DataGridViewTextBoxColumn 分包金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 支付金额1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 欠款金额1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 管理费;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 是否挂账;
        private System.Windows.Forms.DataGridViewTextBoxColumn 收集整理;
        private System.Windows.Forms.DataGridViewTextBoxColumn 立卷检查;
        private System.Windows.Forms.DataGridViewTextBoxColumn 验收合格;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPlan_Code;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ContextMenuStrip cmsList;
        private System.Windows.Forms.ToolStripMenuItem 编辑列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 导入模版ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出模版ToolStripMenuItem;
        public System.Windows.Forms.ComboBox cmbTypes;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.ComboBox cmbTenders;
        public System.Windows.Forms.ComboBox cmbConstructors;
        public System.Windows.Forms.TextBox txtManager;
    }
}