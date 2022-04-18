using System;
using System.Drawing;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmConstructors_List : Form
    {
        public frmConstructors_List()
        {
            InitializeComponent();

            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewCellStyle1.BackColor = Color.LightCyan;

            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new Font("微软雅黑", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;

            dgvList.AllowUserToAddRows = false;
            dgvList.AllowUserToDeleteRows = false;
            dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvList.BackgroundColor = Color.White;
            dgvList.BorderStyle = BorderStyle.Fixed3D;
            dgvList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.EnableHeadersVisualStyles = false;
            dgvList.GridColor = SystemColors.GradientInactiveCaption;
            dgvList.ReadOnly = true;
            dgvList.RowHeadersVisible = false;
            dgvList.RowTemplate.Height = 23;
            dgvList.RowTemplate.ReadOnly = true;
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void frmConstructors_List_Load(object sender, EventArgs e)
        {
            if (AppSetter.Current_User.id != 1)
            {
                btnNew.Enabled = false;
                btnEdit.Enabled = false;
                btnDel.Enabled = false;
            }

            btnReload_Click(this, e);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            string strSQL = "SELECT id AS 序号, Name AS 施工单位, Manager AS 负责人, Contact AS 联系方式 FROM Constructors";

            if (txtName.Text.Trim() != string.Empty || txtManager.Text.Trim() != string.Empty)
            {
                strSQL = $"{strSQL} WHERE ";

                if (txtName.Text.Trim() != string.Empty)
                {
                    strSQL = $"{strSQL} Name = '{txtName.Text}' AND ";
                }
                
                if (txtManager.Text.Trim() != string.Empty)
                {
                    strSQL = $"{strSQL} Manager = '{txtManager.Text}' AND ";
                }

                strSQL = strSQL.Substring(0, strSQL.Length - 4);
            }

            dgvList.DataSource = Class.DB_Works.DataSetCmd(strSQL).Tables[0];
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmConstructors_Info frm = new frmConstructors_Info();
            frm.Text = "新建";
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.Yes)
            {
                btnReload_Click(this, e);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count > 0)
            {
                frmConstructors_Info frm = new frmConstructors_Info();
                frm.Text = "修改";
                frm.id = Convert.ToInt16(dgvList.SelectedRows[0].Cells[0].Value.ToString());
                frm.ShowDialog();

                if (frm.DialogResult == DialogResult.Yes)
                {
                    btnReload_Click(this, e);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count > 0 && Class.Public.Sys_MsgYN("是否确定删除？"))
            {
                var result = Class.DB_Works.ExecuteCmd($"DELETE FROM Constructors WHERE id = {dgvList.SelectedRows[0].Cells[0].Value}");

                if (result)
                {
                    btnReload_Click(this, e);
                }
            }
        }
    }
}
