﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmProjects_Import : Form
    {
        public DataTable dt = null;

        public frmProjects_Import()
        {
            InitializeComponent();

            dgvExcel = Class.Public.SetDataGridViewStyle(dgvExcel);
        }

        private void frmProjects_Import_Load(object sender, EventArgs e)
        {
            if (dt != null)
            {
                dgvExcel.DataSource = dt;

                btnCheck_Click(this, e);
            }
            else
            {
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvExcel.Rows.Count; i++)
            {
                int Types_id = Convert.ToInt16(Class.DB_Works.DataSetCmd($"SELECT id FROM Types WHERE Name = '{dgvExcel.Rows[i].Cells[1].Value}'").Tables[0].Rows[0][0]);

                int Tenders_id = Convert.ToInt16(Class.DB_Works.DataSetCmd($"SELECT id FROM Tenders WHERE Name = '{dgvExcel.Rows[i].Cells[9].Value}'").Tables[0].Rows[0][0]);
                Class.DB_Works.ExecuteCmd($"INSERT INTO Projects(Name, Types_id, Detail, Amount, Developing_Reply, Initial_Reply, Plan_Code, Begin_Date, End_Date, Tenders_id, Progress, Collect_Tag, Check_Tag, Grade_Tag, Amount_Order, Amount_Reality, Warranty, Users_id, DateTime) VALUES('{dgvExcel.Rows[i].Cells[0].Value}', {Types_id}, '{dgvExcel.Rows[i].Cells[2].Value}', {dgvExcel.Rows[i].Cells[3].Value}, '{dgvExcel.Rows[i].Cells[4].Value}', '{dgvExcel.Rows[i].Cells[5].Value}', '{dgvExcel.Rows[i].Cells[6].Value}', '{dgvExcel.Rows[i].Cells[7].Value}', '{dgvExcel.Rows[i].Cells[8].Value}', {Tenders_id}, '{dgvExcel.Rows[i].Cells[10].Value}', '{dgvExcel.Rows[i].Cells[11].Value}', '{dgvExcel.Rows[i].Cells[12].Value}', '{dgvExcel.Rows[i].Cells[13].Value}', 0, 0, '1900-01-01', {AppSetter.Current_User.id}, NOW())");
            }

            Class.DB_Works.ExecuteCmd($"INSERT INTO Logs(Users_id, Type, Detail, DateTime) VALUES({AppSetter.Current_User.id}, '导入', '【导入工程信息】导入工程数据【{dgvExcel.Rows.Count - 1}】条', NOW())");

            Class.Public.Sys_MsgBox("工程项目导入成功！");

            DialogResult = DialogResult.Yes;
            Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            btnImport.Enabled = true;

            for (int i = 0; i < dgvExcel.Rows.Count; i++)
            {
                dgvExcel.Rows[i].DefaultCellStyle.BackColor = Color.White;

                //Name
                if (dgvExcel.Rows[i].Cells[0].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[0].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //Types_id
                if (Class.DB_Works.DataSetCmd($"SELECT id FROM Types WHERE Name = '{dgvExcel.Rows[i].Cells[1].Value}'").Tables[0].Rows.Count == 0)
                {
                    dgvExcel.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //Detail

                //Amount
                try
                {
                    Convert.ToDecimal(dgvExcel.Rows[i].Cells[3].Value);
                }
                catch
                {
                    dgvExcel.Rows[i].Cells[3].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //Developing_Reply
                if (dgvExcel.Rows[i].Cells[4].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[4].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //Initial_Reply
                if (dgvExcel.Rows[i].Cells[5].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[5].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //Plan_Code
                if (dgvExcel.Rows[i].Cells[6].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[6].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //Begin_Date
                try
                {
                    Convert.ToDateTime(dgvExcel.Rows[i].Cells[7].Value);
                }
                catch
                {
                    dgvExcel.Rows[i].Cells[7].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //End_Date
                try
                {
                    Convert.ToDateTime(dgvExcel.Rows[i].Cells[8].Value);
                }
                catch
                {
                    dgvExcel.Rows[i].Cells[8].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //Tenders_id
                if (Class.DB_Works.DataSetCmd($"SELECT id FROM Tenders WHERE Name ='{dgvExcel.Rows[i].Cells[9].Value}'").Tables[0].Rows.Count == 0)
                {
                    dgvExcel.Rows[i].Cells[9].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //Progress
                if (dgvExcel.Rows[i].Cells[10].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[10].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //Collect_Tag
                if (dgvExcel.Rows[i].Cells[11].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[11].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //Check_Tag
                if (dgvExcel.Rows[i].Cells[12].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[12].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //Grade_Tag
                if (dgvExcel.Rows[i].Cells[13].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[13].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                if (Class.DB_Works.DataSetCmd($"SELECT Projects.id FROM Projects LEFT JOIN Types ON Types.id = Projects.Types_id WHERE Name = '{dgvExcel.Rows[i].Cells[0].Value}' AND Types.Name = '{dgvExcel.Rows[i].Cells[1].Value}' AND Projects_id IN (SELECT Types_id FROM Limits WHERE Users_id = {AppSetter.Current_User.id})").Tables[0].Rows.Count > 0)
                {
                    dgvExcel.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }
            }
        }
    }
}
