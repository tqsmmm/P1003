namespace 后勤工程管理系统
{
    partial class frmColumns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmColumns));
            this.lbxSelected = new System.Windows.Forms.ListBox();
            this.lbxList = new System.Windows.Forms.ListBox();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnSubtracts = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAdds = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxSelected
            // 
            this.lbxSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxSelected.FormattingEnabled = true;
            this.lbxSelected.ItemHeight = 20;
            this.lbxSelected.Location = new System.Drawing.Point(3, 22);
            this.lbxSelected.Name = "lbxSelected";
            this.lbxSelected.Size = new System.Drawing.Size(225, 356);
            this.lbxSelected.TabIndex = 0;
            // 
            // lbxList
            // 
            this.lbxList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxList.FormattingEnabled = true;
            this.lbxList.ItemHeight = 20;
            this.lbxList.Location = new System.Drawing.Point(3, 22);
            this.lbxList.Name = "lbxList";
            this.lbxList.Size = new System.Drawing.Size(225, 356);
            this.lbxList.TabIndex = 1;
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(249, 108);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(86, 40);
            this.btnSubtract.TabIndex = 2;
            this.btnSubtract.Text = ">";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnSubtracts
            // 
            this.btnSubtracts.Location = new System.Drawing.Point(249, 154);
            this.btnSubtracts.Name = "btnSubtracts";
            this.btnSubtracts.Size = new System.Drawing.Size(86, 40);
            this.btnSubtracts.TabIndex = 3;
            this.btnSubtracts.Text = ">>";
            this.btnSubtracts.UseVisualStyleBackColor = true;
            this.btnSubtracts.Click += new System.EventHandler(this.btnSubtracts_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(249, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "<";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAdds
            // 
            this.btnAdds.Location = new System.Drawing.Point(249, 246);
            this.btnAdds.Name = "btnAdds";
            this.btnAdds.Size = new System.Drawing.Size(86, 40);
            this.btnAdds.TabIndex = 5;
            this.btnAdds.Text = "<<";
            this.btnAdds.UseVisualStyleBackColor = true;
            this.btnAdds.Click += new System.EventHandler(this.btnAdds_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(160, 399);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(120, 50);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "确定";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(286, 399);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 50);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxSelected);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 381);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "显示列";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbxList);
            this.groupBox2.Location = new System.Drawing.Point(341, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 381);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "待选列";
            // 
            // frmColumns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnAdds);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSubtracts);
            this.Controls.Add(this.btnSubtract);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmColumns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmColumns_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnSubtracts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAdds;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.ListBox lbxSelected;
        public System.Windows.Forms.ListBox lbxList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}