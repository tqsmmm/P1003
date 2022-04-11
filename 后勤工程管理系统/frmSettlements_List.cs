using System;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmSettlements_List : Form
    {
        public frmSettlements_List()
        {
            InitializeComponent();

            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;

            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;

            dgvList.AllowUserToAddRows = false;
            dgvList.AllowUserToDeleteRows = false;
            dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvList.BackgroundColor = System.Drawing.Color.White;
            dgvList.BorderStyle = BorderStyle.Fixed3D;
            dgvList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.EnableHeadersVisualStyles = false;
            dgvList.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dgvList.ReadOnly = true;
            dgvList.RowHeadersVisible = false;
            dgvList.RowTemplate.Height = 23;
            dgvList.RowTemplate.ReadOnly = true;
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void frmSettlements_List_Load(object sender, EventArgs e)
        {
            if (AppSetter.Current_User.id == 0)
            {
                btnNew.Enabled = false;
                btnEdit.Enabled = false;
                btnDel.Enabled = false;
            }

            btnReload_Click(this, e);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmSettlements_Info frm = new frmSettlements_Info();
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
                frmSettlements_Info frm = new frmSettlements_Info();
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
                var result = Class.DB_Works.ExecuteCmd($"DELETE FROM Settlements WHERE id = {dgvList.SelectedRows[0].Cells[0].Value}");

                if (result)
                {
                    Class.DB_Works.ExecuteCmd($"INSERT INTO Logs(Users_id, Type, Detail, DateTime) VALUES({AppSetter.Current_User.id}, '删除', '【删除结算信息】工程名称【{dgvList.SelectedRows[0].Cells[1].Value}】，是否分包【{dgvList.SelectedRows[0].Cells[2].Value}】，结算金额【{dgvList.SelectedRows[0].Cells[3].Value}】', NOW())");

                    btnReload_Click(this, e);
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvList.DataSource = Class.DB_Works.DataSetCmd("SELECT Settlements.id AS 序号, Projects.Name AS 工程名称, Partitions AS 是否分包, Settlements.Amount AS 支付金额, Settlements.DateTime AS 支付时间 FROM Settlements LEFT JOIN Projects ON Projects.id = Settlements.Projects_id").Tables[0];
        }
    }
}
