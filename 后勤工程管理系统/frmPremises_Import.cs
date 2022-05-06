using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmPremises_Import : Form
    {
        public DataTable dt = null;

        public frmPremises_Import()
        {
            InitializeComponent();

            dgvExcel = Class.Public.SetDataGridViewStyle(dgvExcel);
        }

        private void frmPremises_Import_Load(object sender, EventArgs e)
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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            btnImport.Enabled = true;

            for (int i = 0; i < dgvExcel.Rows.Count; i++)
            {
                dgvExcel.Rows[i].DefaultCellStyle.BackColor = Color.White;

                if (Class.DB_Works.DataSetCmd($"SELECT id FROM Premises WHERE Name = '{dgvExcel.Rows[i].Cells[0].Value}'").Tables[0].Rows.Count > 0)
                {
                    dgvExcel.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    btnImport.Enabled = false;
                }
                else
                {
                    //房产名称
                    if (dgvExcel.Rows[i].Cells[0].Value.ToString().Length > 50)
                    {
                        dgvExcel.Rows[i].Cells[0].Style.BackColor = Color.Red;
                        btnImport.Enabled = false;
                    }
                    else
                    {
                        dgvExcel.Rows[i].Cells[0].Style.BackColor = Color.White;
                    }

                    //房产编号
                    if (dgvExcel.Rows[i].Cells[1].Value.ToString().Length > 50)
                    {
                        dgvExcel.Rows[i].Cells[1].Style.BackColor = Color.Red;
                        btnImport.Enabled = false;
                    }
                    else
                    {
                        dgvExcel.Rows[i].Cells[1].Style.BackColor = Color.White;
                    }

                    //建筑年代
                    try
                    {
                        Convert.ToInt16(dgvExcel.Rows[i].Cells[2].Value);
                        dgvExcel.Rows[i].Cells[2].Style.BackColor = Color.White;
                    }
                    catch
                    {
                        dgvExcel.Rows[i].Cells[2].Style.BackColor = Color.Red;
                        btnImport.Enabled = false;
                    }

                    //建筑层数
                    if (dgvExcel.Rows[i].Cells[3].Value.ToString().Length > 50)
                    {
                        dgvExcel.Rows[i].Cells[3].Style.BackColor = Color.Red;
                        btnImport.Enabled = false;
                    }
                    else
                    {
                        dgvExcel.Rows[i].Cells[3].Style.BackColor = Color.White;
                    }

                    //建筑结构
                    if (dgvExcel.Rows[i].Cells[4].Value.ToString().Length > 50)
                    {
                        dgvExcel.Rows[i].Cells[4].Style.BackColor = Color.Red;
                        btnImport.Enabled = false;
                    }
                    else
                    {
                        dgvExcel.Rows[i].Cells[4].Style.BackColor = Color.White;
                    }

                    //建筑面积
                    try
                    {
                        Convert.ToDecimal(dgvExcel.Rows[i].Cells[5].Value);
                        dgvExcel.Rows[i].Cells[5].Style.BackColor = Color.White;
                    }
                    catch
                    {
                        dgvExcel.Rows[i].Cells[5].Style.BackColor = Color.Red;
                        btnImport.Enabled = false;
                    }

                    //建筑用途
                    if (dgvExcel.Rows[i].Cells[6].Value.ToString().Length > 50)
                    {
                        dgvExcel.Rows[i].Cells[6].Style.BackColor = Color.Red;
                        btnImport.Enabled = false;
                    }
                    else
                    {
                        dgvExcel.Rows[i].Cells[6].Style.BackColor = Color.White;
                    }

                    //资产原值
                    try
                    {
                        Convert.ToDecimal(dgvExcel.Rows[i].Cells[7].Value);
                        dgvExcel.Rows[i].Cells[7].Style.BackColor = Color.White;
                    }
                    catch
                    {
                        dgvExcel.Rows[i].Cells[7].Style.BackColor = Color.Red;
                        btnImport.Enabled = false;
                    }

                    //资产编码
                    if (dgvExcel.Rows[i].Cells[8].Value.ToString().Length > 50)
                    {
                        dgvExcel.Rows[i].Cells[8].Style.BackColor = Color.Red;
                        btnImport.Enabled = false;
                    }
                    else
                    {
                        dgvExcel.Rows[i].Cells[8].Style.BackColor = Color.White;
                    }

                    //设备编码
                    if (dgvExcel.Rows[i].Cells[9].Value.ToString().Length > 50)
                    {
                        dgvExcel.Rows[i].Cells[9].Style.BackColor = Color.Red;
                        btnImport.Enabled = false;
                    }
                    else
                    {
                        dgvExcel.Rows[i].Cells[9].Style.BackColor = Color.White;
                    }

                    //地区
                    if (dgvExcel.Rows[i].Cells[10].Value.ToString().Length > 50)
                    {
                        dgvExcel.Rows[i].Cells[10].Style.BackColor = Color.Red;
                        btnImport.Enabled = false;
                    }
                    else
                    {
                        dgvExcel.Rows[i].Cells[10].Style.BackColor = Color.White;
                    }
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvExcel.Rows.Count; i++)
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
