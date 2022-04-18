﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmPremises_Import : Form
    {
        public frmPremises_Import()
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

            dgvExcel.AllowUserToAddRows = true;
            dgvExcel.AllowUserToDeleteRows = true;
            dgvExcel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvExcel.BackgroundColor = Color.White;
            dgvExcel.BorderStyle = BorderStyle.Fixed3D;
            dgvExcel.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvExcel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvExcel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExcel.EnableHeadersVisualStyles = false;
            dgvExcel.GridColor = SystemColors.GradientInactiveCaption;
            dgvExcel.ReadOnly = false;
            dgvExcel.RowHeadersVisible = false;
            dgvExcel.RowTemplate.Height = 23;
            dgvExcel.RowTemplate.ReadOnly = false;
            dgvExcel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void frmPremises_Import_Load(object sender, EventArgs e)
        {
            string strExcel = null;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "excel文件(*.xlsx,*.xls)|*.xlsx;*.xls";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                strExcel = dialog.FileName;
            }
            else
            {
                //MessageBox.Show("返回文件路径失败");
                strExcel = null;
            }

            if (strExcel == null)
            {
                Close();
            }
            else
            {
                DataTable dt = Class.Excel.ExcelToTable(strExcel);

                if (dt != null)
                {
                    dgvExcel.DataSource = dt;

                    if (dgvExcel.Columns.Count == 11)
                    {
                        btnCheck_Click(this, e);
                    }
                    else
                    {
                        Close();
                    }
                }
                else
                {
                    Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            btnImport.Enabled = true;

            for (int i = 0; i < dgvExcel.Rows.Count - 1; i++)
            {
                //Name
                if (dgvExcel.Rows[i].Cells[0].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[0].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //Code
                if (dgvExcel.Rows[i].Cells[1].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //Date
                try
                {
                    Convert.ToDateTime(dgvExcel.Rows[i].Cells[2].Value);
                }
                catch
                {
                    dgvExcel.Rows[i].Cells[2].Style.BackColor= Color.Red;
                    btnImport.Enabled = false;
                }
                
                //Levels
                if (dgvExcel.Rows[i].Cells[3].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[3].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //Structure
                if (dgvExcel.Rows[i].Cells[4].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[4].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //Dimenson
                try
                {
                    Convert.ToDecimal(dgvExcel.Rows[i].Cells[5].Value);
                }
                catch
                {
                    dgvExcel.Rows[i].Cells[5].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //Purpose
                if (dgvExcel.Rows[i].Cells[6].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[6].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //Assets_Amount
                try
                {
                    Convert.ToDecimal(dgvExcel.Rows[i].Cells[7].Value);
                }
                catch
                {
                    dgvExcel.Rows[i].Cells[7].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //Assets_Code
                if (dgvExcel.Rows[i].Cells[8].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[8].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //Device_Code
                if (dgvExcel.Rows[i].Cells[9].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[9].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                //Region
                if (dgvExcel.Rows[i].Cells[10].Value.ToString().Length > 50)
                {
                    dgvExcel.Rows[i].Cells[10].Style.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }

                if (Class.DB_Works.DataSetCmd($"SELECT id FROM Premises WHERE Name = '{dgvExcel.Rows[i].Cells[0].Value}'").Tables[0].Rows.Count > 0)
                {
                    dgvExcel.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvExcel.Rows.Count - 1; i++)
            {
                Class.DB_Works.ExecuteCmd($"INSERT INTO Premises(Name, Code, Address, Date, Levels, Structure, Dimension, Purpose, Assets_Amount, Assets_Code, Device_Code, Region, Users_id, DateTime) VALUES('{dgvExcel.Rows[i].Cells[0].Value}', '{dgvExcel.Rows[i].Cells[1].Value}', '', '{dgvExcel.Rows[i].Cells[2].Value}', '{dgvExcel.Rows[i].Cells[3].Value}', '{dgvExcel.Rows[i].Cells[4].Value}', {dgvExcel.Rows[i].Cells[5].Value}, '{dgvExcel.Rows[i].Cells[6].Value}', {dgvExcel.Rows[i].Cells[7].Value}, '{dgvExcel.Rows[i].Cells[8].Value}', '{dgvExcel.Rows[i].Cells[9].Value}', '{dgvExcel.Rows[i].Cells[10].Value}', {AppSetter.Current_User.id}, NOW())");
            }

            Class.DB_Works.ExecuteCmd($"INSERT INTO Logs(Users_id, Type, Detail, DateTime) VALUES({AppSetter.Current_User.id}, '导入', '【导入房产信息】导入房产数据【{dgvExcel.Rows.Count - 1}】条', NOW())");

            Class.Public.Sys_MsgBox("房产信息导入成功！");

            DialogResult = DialogResult.Yes;
            Close();
        }
    }
}
