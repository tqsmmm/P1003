﻿using System;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmPartitions_List : Form
    {
        public frmPartitions_List()
        {
            InitializeComponent();

            dgvList = Class.Public.SetDataGridViewStyle(dgvList);
        }

        private void frmPartitions_List_Load(object sender, EventArgs e)
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
            frmPartitions_Info frm = new frmPartitions_Info
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
                frmPartitions_Info frm = new frmPartitions_Info
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
                var result = Class.DB_Works.ExecuteCmd($"DELETE FROM Partitions WHERE id = {dgvList.SelectedRows[0].Cells[0].Value}");

                if (result)
                {
                    Class.DB_Works.ExecuteCmd($"INSERT INTO Logs(Users_id, Type, Detail, DateTime) VALUES({AppSetter.Current_User.id}, '删除', '【删除分包信息】工程名称【{dgvList.SelectedRows[0].Cells[1].Value}】，施工单位【{dgvList.SelectedRows[0].Cells[2].Value}】，分包金额【{dgvList.SelectedRows[0].Cells[3].Value}】', NOW())");

                    btnReload_Click(this, e);
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvList.DataSource = Class.DB_Works.DataSetCmd("SELECT Partitions.id AS 序号, Projects.Name AS 工程名称, Constructors.Name AS 施工单位, Partitions.Amount AS 分包金额, Partitions.Amount_Arrear AS 欠款金额, Partitions.Amount_Pay AS 付款金额, Management AS 管理费, Account AS 是否挂账 FROM Partitions LEFT JOIN Projects ON Projects.id = Partitions.Projects_id LEFT JOIN Constructors ON Constructors.id = Partitions.Constructors_id").Tables[0];
        }
    }
}
