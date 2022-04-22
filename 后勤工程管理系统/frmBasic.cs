using System;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmBasic : Form
    {
        public frmBasic()
        {
            InitializeComponent();

            dgvConstructors = Class.Public.SetDataGridViewStyle(dgvConstructors);

            dgvTenders = Class.Public.SetDataGridViewStyle(dgvTenders);

            dgvTypes = Class.Public.SetDataGridViewStyle(dgvTypes);

            dgvUsers = Class.Public.SetDataGridViewStyle(dgvUsers);
        }

        private void frmBasic_Load(object sender, EventArgs e)
        {
            btnTenders_Reload_Click(this, e);

            btnConstructors_Reload_Click(this, e);
            

            dgvTypes.DataSource = Class.DB_Works.DataSetCmd("SELECT id AS 序号, Name AS 类型名称 FROM Types").Tables[0];

            dgvUsers.DataSource = Class.DB_Works.DataSetCmd("SELECT id AS 序号, Name AS 用户名 FROM Users").Tables[0];
        }

        private void btnTenders_New_Click(object sender, EventArgs e)
        {
            frmTenders_Info frm = new frmTenders_Info
            {
                Text = "新建"
            };
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.Yes)
            {
                btnTenders_Reload_Click(this, e);
            }
        }

        private void btnTenders_Edit_Click(object sender, EventArgs e)
        {
            if (dgvTenders.SelectedRows.Count > 0)
            {
                frmTenders_Info frm = new frmTenders_Info
                {
                    Text = "修改",
                    id = Convert.ToInt16(dgvTenders.SelectedRows[0].Cells[0].Value.ToString())
                };
                frm.ShowDialog();

                if (frm.DialogResult == DialogResult.Yes)
                {
                    btnTenders_Reload_Click(this, e);
                }
            }
        }

        private void btnTenders_Del_Click(object sender, EventArgs e)
        {
            if (dgvTenders.SelectedRows.Count > 0 && Class.Public.Sys_MsgYN("是否确定删除？"))
            {
                var result = Class.DB_Works.ExecuteCmd($"DELETE FROM Tenders WHERE id = {dgvTenders.SelectedRows[0].Cells[0].Value}");

                if (result)
                {
                    btnTenders_Reload_Click(this, e);
                }
            }
        }

        private void btnTenders_Reload_Click(object sender, EventArgs e)
        {
            dgvTenders.DataSource = Class.DB_Works.DataSetCmd("SELECT id AS 序号, Name AS 中标单位, Manager AS 负责人, Contact AS 联系方式 FROM Tenders").Tables[0];
        }

        private void btnConstructors_New_Click(object sender, EventArgs e)
        {
            frmConstructors_Info frm = new frmConstructors_Info
            {
                Text = "新建"
            };
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.Yes)
            {
                btnConstructors_Reload_Click(this, e);
            }
        }

        private void btnConstructors_Edit_Click(object sender, EventArgs e)
        {
            if (dgvConstructors.SelectedRows.Count > 0)
            {
                frmConstructors_Info frm = new frmConstructors_Info
                {
                    Text = "修改",
                    id = Convert.ToInt16(dgvConstructors.SelectedRows[0].Cells[0].Value.ToString())
                };
                frm.ShowDialog();

                if (frm.DialogResult == DialogResult.Yes)
                {
                    btnConstructors_Reload_Click(this, e);
                }
            }
        }

        private void btnConstructors_Del_Click(object sender, EventArgs e)
        {
            if (dgvConstructors.SelectedRows.Count > 0 && Class.Public.Sys_MsgYN("是否确定删除？"))
            {
                var result = Class.DB_Works.ExecuteCmd($"DELETE FROM Constructors WHERE id = {dgvConstructors.SelectedRows[0].Cells[0].Value}");

                if (result)
                {
                    btnConstructors_Reload_Click(this, e);
                }
            }
        }

        private void btnConstructors_Reload_Click(object sender, EventArgs e)
        {
            dgvConstructors.DataSource = Class.DB_Works.DataSetCmd("SELECT id AS 序号, Name AS 施工单位, Manager AS 负责人, Contact AS 联系方式 FROM Constructors").Tables[0];
        }

        private void btnTypes_Add_Click(object sender, EventArgs e)
        {
            frmTypes_Info frm = new frmTypes_Info
            {
                Text = "新建"
            };
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.Yes)
            {
                btnTypes_Reload_Click(this, e);
            }
        }

        private void btnTypes_Edit_Click(object sender, EventArgs e)
        {
            if (dgvTypes.SelectedRows.Count > 0)
            {
                frmTypes_Info frm = new frmTypes_Info
                {
                    Text = "修改",
                    id = Convert.ToInt16(dgvTypes.SelectedRows[0].Cells[0].Value.ToString())
                };
                frm.ShowDialog();

                if (frm.DialogResult == DialogResult.Yes)
                {
                    btnTypes_Reload_Click(this, e);
                }
            }
        }

        private void btnTypes_Del_Click(object sender, EventArgs e)
        {
            if (dgvTypes.SelectedRows.Count > 0 && Class.Public.Sys_MsgYN("是否确定删除？"))
            {
                var result = Class.DB_Works.ExecuteCmd($"DELETE FROM Types WHERE id = {dgvTypes.SelectedRows[0].Cells[0].Value}");

                if (result)
                {
                    btnTypes_Reload_Click(this, e);
                }
            }
        }

        private void btnTypes_Reload_Click(object sender, EventArgs e)
        {
            dgvTypes.DataSource = Class.DB_Works.DataSetCmd("SELECT id AS 序号, Name AS 类型名称 FROM Types").Tables[0];
        }

        private void btnUser_Add_Click(object sender, EventArgs e)
        {
            frmUsers_Info frm = new frmUsers_Info
            {
                Text = "新建"
            };
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.Yes)
            {
                btnUser_Reload_Click(this, e);
            }
        }

        private void btnUsers_Edit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                frmUsers_Info frm = new frmUsers_Info
                {
                    Text = "修改",
                    id = Convert.ToInt16(dgvUsers.SelectedRows[0].Cells[0].Value.ToString())
                };
                frm.ShowDialog();

                if (frm.DialogResult == DialogResult.Yes)
                {
                    btnUser_Reload_Click(this, e);
                }
            }
        }

        private void btnUser_Del_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0 && Class.Public.Sys_MsgYN("是否确定删除？"))
            {
                var result = Class.DB_Works.ExecuteCmd($"DELETE FROM Users WHERE id = {dgvUsers.SelectedRows[0].Cells[0].Value}");

                if (result)
                {
                    btnUser_Reload_Click(this, e);
                }
            }
        }

        private void btnUser_Reload_Click(object sender, EventArgs e)
        {
            dgvUsers.DataSource = Class.DB_Works.DataSetCmd("SELECT id AS 序号, Name AS 用户名 FROM Users").Tables[0];
        }
    }
}
