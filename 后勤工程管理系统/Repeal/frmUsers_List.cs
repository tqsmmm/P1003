﻿using System;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmUsers_List : Form
    {
        public frmUsers_List()
        {
            InitializeComponent();

            dgvList = Class.Public.SetDataGridViewStyle(dgvList);
        }

        private void frmUsers_List_Load(object sender, EventArgs e)
        {
            if (AppSetter.Current_User.id != 1)
            {
                btnNew.Enabled = false;
                btnEdit.Enabled = false;
                btnDel.Enabled = false;
            }

            btnReload_Click(this, e);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmUsers_Info frm = new frmUsers_Info
            {
                Text = "新建"
            };
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
                frmUsers_Info frm = new frmUsers_Info
                {
                    Text = "修改",
                    id = Convert.ToInt16(dgvList.SelectedRows[0].Cells[0].Value.ToString())
                };
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
                var result = Class.DB_Works.ExecuteCmd($"DELETE FROM Users WHERE id = {dgvList.SelectedRows[0].Cells[0].Value}");

                if (result)
                {
                    btnReload_Click(this, e);
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvList.DataSource = Class.DB_Works.DataSetCmd("SELECT id AS 序号, Name AS 用户名 FROM Users").Tables[0];
        }
    }
}
