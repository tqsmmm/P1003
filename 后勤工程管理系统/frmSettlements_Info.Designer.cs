namespace 后勤工程管理系统
{
    partial class frmSettlements_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettlements_Info));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount_Order = new System.Windows.Forms.TextBox();
            this.txtAmount_Reality = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount_Arrear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDivisions = new System.Windows.Forms.ComboBox();
            this.cmbProjects = new System.Windows.Forms.ComboBox();
            this.ckbPartition = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmount_Pay = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "合同金额：";
            // 
            // txtAmount_Order
            // 
            this.txtAmount_Order.Location = new System.Drawing.Point(148, 93);
            this.txtAmount_Order.Name = "txtAmount_Order";
            this.txtAmount_Order.ReadOnly = true;
            this.txtAmount_Order.Size = new System.Drawing.Size(200, 26);
            this.txtAmount_Order.TabIndex = 1;
            this.txtAmount_Order.Text = "0.00";
            this.txtAmount_Order.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAmount_Reality
            // 
            this.txtAmount_Reality.Location = new System.Drawing.Point(148, 125);
            this.txtAmount_Reality.Name = "txtAmount_Reality";
            this.txtAmount_Reality.ReadOnly = true;
            this.txtAmount_Reality.Size = new System.Drawing.Size(200, 26);
            this.txtAmount_Reality.TabIndex = 3;
            this.txtAmount_Reality.Text = "0.00";
            this.txtAmount_Reality.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "实际发生额：";
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(148, 25);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(200, 26);
            this.txtPay.TabIndex = 5;
            this.txtPay.Text = "0.00";
            this.txtPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "本次支付额：";
            // 
            // txtAmount_Arrear
            // 
            this.txtAmount_Arrear.Location = new System.Drawing.Point(439, 93);
            this.txtAmount_Arrear.Name = "txtAmount_Arrear";
            this.txtAmount_Arrear.ReadOnly = true;
            this.txtAmount_Arrear.Size = new System.Drawing.Size(200, 26);
            this.txtAmount_Arrear.TabIndex = 7;
            this.txtAmount_Arrear.Text = "0.00";
            this.txtAmount_Arrear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "欠款金额：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDivisions);
            this.groupBox1.Controls.Add(this.cmbProjects);
            this.groupBox1.Controls.Add(this.ckbPartition);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAmount_Pay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAmount_Arrear);
            this.groupBox1.Controls.Add(this.txtAmount_Order);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAmount_Reality);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 200);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "合同信息";
            // 
            // cmbDivisions
            // 
            this.cmbDivisions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDivisions.FormattingEnabled = true;
            this.cmbDivisions.Location = new System.Drawing.Point(148, 59);
            this.cmbDivisions.Name = "cmbDivisions";
            this.cmbDivisions.Size = new System.Drawing.Size(491, 28);
            this.cmbDivisions.TabIndex = 16;
            this.cmbDivisions.SelectionChangeCommitted += new System.EventHandler(this.cmbDivisions_SelectionChangeCommitted);
            // 
            // cmbProjects
            // 
            this.cmbProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjects.FormattingEnabled = true;
            this.cmbProjects.Location = new System.Drawing.Point(148, 25);
            this.cmbProjects.Name = "cmbProjects";
            this.cmbProjects.Size = new System.Drawing.Size(401, 28);
            this.cmbProjects.TabIndex = 15;
            this.cmbProjects.SelectionChangeCommitted += new System.EventHandler(this.cmbProjects_SelectionChangeCommitted);
            // 
            // ckbPartition
            // 
            this.ckbPartition.AutoSize = true;
            this.ckbPartition.Location = new System.Drawing.Point(555, 27);
            this.ckbPartition.Name = "ckbPartition";
            this.ckbPartition.Size = new System.Drawing.Size(84, 24);
            this.ckbPartition.TabIndex = 14;
            this.ckbPartition.Text = "是否分包";
            this.ckbPartition.UseVisualStyleBackColor = true;
            this.ckbPartition.CheckedChanged += new System.EventHandler(this.ckbPartition_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "工程名称：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "中标单位：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "支付金额：";
            // 
            // txtAmount_Pay
            // 
            this.txtAmount_Pay.Location = new System.Drawing.Point(148, 157);
            this.txtAmount_Pay.Name = "txtAmount_Pay";
            this.txtAmount_Pay.ReadOnly = true;
            this.txtAmount_Pay.Size = new System.Drawing.Size(200, 26);
            this.txtAmount_Pay.TabIndex = 9;
            this.txtAmount_Pay.Text = "0.00";
            this.txtAmount_Pay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpDateTime);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPay);
            this.groupBox2.Location = new System.Drawing.Point(12, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 60);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "支付信息";
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.Location = new System.Drawing.Point(439, 25);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(200, 26);
            this.dtpDateTime.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "支付时间：";
            // 
            // btnAccept
            // 
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAccept.Location = new System.Drawing.Point(219, 299);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(120, 50);
            this.btnAccept.TabIndex = 10;
            this.btnAccept.Text = "确定";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(345, 299);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 50);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSettlements_Info
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettlements_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSettlements_Info_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount_Order;
        private System.Windows.Forms.TextBox txtAmount_Reality;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmount_Arrear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAmount_Pay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.CheckBox ckbPartition;
        private System.Windows.Forms.ComboBox cmbProjects;
        private System.Windows.Forms.ComboBox cmbDivisions;
    }
}