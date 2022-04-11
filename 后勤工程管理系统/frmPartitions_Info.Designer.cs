namespace 后勤工程管理系统
{
    partial class frmPartitions_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPartitions_Info));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount_Pay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount_Arear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtManagement = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnAccount_False = new System.Windows.Forms.RadioButton();
            this.rbnAccount_True = new System.Windows.Forms.RadioButton();
            this.cmbConstructors = new System.Windows.Forms.ComboBox();
            this.cmbProjects = new System.Windows.Forms.ComboBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "工程名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "施工单位：";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(122, 93);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 26);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.Text = "0.00";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "分包金额：";
            // 
            // txtAmount_Pay
            // 
            this.txtAmount_Pay.Location = new System.Drawing.Point(122, 125);
            this.txtAmount_Pay.Name = "txtAmount_Pay";
            this.txtAmount_Pay.ReadOnly = true;
            this.txtAmount_Pay.Size = new System.Drawing.Size(200, 26);
            this.txtAmount_Pay.TabIndex = 7;
            this.txtAmount_Pay.Text = "0.00";
            this.txtAmount_Pay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "支付金额：";
            // 
            // txtAmount_Arear
            // 
            this.txtAmount_Arear.Location = new System.Drawing.Point(413, 93);
            this.txtAmount_Arear.Name = "txtAmount_Arear";
            this.txtAmount_Arear.ReadOnly = true;
            this.txtAmount_Arear.Size = new System.Drawing.Size(200, 26);
            this.txtAmount_Arear.TabIndex = 9;
            this.txtAmount_Arear.Text = "0.00";
            this.txtAmount_Arear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "欠款金额：";
            // 
            // txtManagement
            // 
            this.txtManagement.Location = new System.Drawing.Point(122, 157);
            this.txtManagement.Name = "txtManagement";
            this.txtManagement.Size = new System.Drawing.Size(200, 26);
            this.txtManagement.TabIndex = 11;
            this.txtManagement.Text = "0.00";
            this.txtManagement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "管理费：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "是否挂账：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnAccount_False);
            this.groupBox1.Controls.Add(this.rbnAccount_True);
            this.groupBox1.Controls.Add(this.cmbConstructors);
            this.groupBox1.Controls.Add(this.cmbProjects);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtManagement);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAmount_Arear);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAmount_Pay);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 231);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分包信息";
            // 
            // rbnAccount_False
            // 
            this.rbnAccount_False.AutoSize = true;
            this.rbnAccount_False.Checked = true;
            this.rbnAccount_False.Location = new System.Drawing.Point(169, 190);
            this.rbnAccount_False.Name = "rbnAccount_False";
            this.rbnAccount_False.Size = new System.Drawing.Size(41, 24);
            this.rbnAccount_False.TabIndex = 17;
            this.rbnAccount_False.TabStop = true;
            this.rbnAccount_False.Text = "否";
            this.rbnAccount_False.UseVisualStyleBackColor = true;
            // 
            // rbnAccount_True
            // 
            this.rbnAccount_True.AutoSize = true;
            this.rbnAccount_True.Location = new System.Drawing.Point(122, 190);
            this.rbnAccount_True.Name = "rbnAccount_True";
            this.rbnAccount_True.Size = new System.Drawing.Size(41, 24);
            this.rbnAccount_True.TabIndex = 16;
            this.rbnAccount_True.Text = "是";
            this.rbnAccount_True.UseVisualStyleBackColor = true;
            // 
            // cmbConstructors
            // 
            this.cmbConstructors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConstructors.FormattingEnabled = true;
            this.cmbConstructors.Location = new System.Drawing.Point(122, 59);
            this.cmbConstructors.Name = "cmbConstructors";
            this.cmbConstructors.Size = new System.Drawing.Size(491, 28);
            this.cmbConstructors.TabIndex = 15;
            // 
            // cmbProjects
            // 
            this.cmbProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjects.FormattingEnabled = true;
            this.cmbProjects.Location = new System.Drawing.Point(122, 25);
            this.cmbProjects.Name = "cmbProjects";
            this.cmbProjects.Size = new System.Drawing.Size(491, 28);
            this.cmbProjects.TabIndex = 14;
            // 
            // btnAccept
            // 
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAccept.Location = new System.Drawing.Point(219, 249);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(120, 50);
            this.btnAccept.TabIndex = 15;
            this.btnAccept.Text = "确定";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(345, 249);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 50);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmPartitions_Info
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPartitions_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPartitions_Info_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmount_Pay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount_Arear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtManagement;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbProjects;
        private System.Windows.Forms.ComboBox cmbConstructors;
        private System.Windows.Forms.RadioButton rbnAccount_False;
        private System.Windows.Forms.RadioButton rbnAccount_True;
    }
}