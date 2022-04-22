using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmDesktop : Form
    {
        public string strSQL = string.Empty;

        public frmDesktop()
        {
            InitializeComponent();

            dgvList = Class.Public.SetDataGridViewStyle(dgvList);

            cmbTenders.DataSource = Class.DB_Works.DataSetCmd("SELECT id, Name FROM Tenders").Tables[0];
            cmbTenders.DisplayMember = "Name";
            cmbTenders.ValueMember = "id";

            cmbTenders.SelectedIndex = -1;

            cmbTypes.DataSource = Class.DB_Works.DataSetCmd("SELECT id, Name FROM Types").Tables[0];
            cmbTypes.DisplayMember = "Name";
            cmbTypes.ValueMember = "id";

            cmbTypes.SelectedIndex = -1;
        }

        private void frmDesktop_Load(object sender, EventArgs e)
        {
            btnReload_Click(this, e);
        }

        private void 编辑列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColumns frm = new frmColumns();

            for (int i = 0; i < dgvList.Columns.Count; i++)
            {
                if (dgvList.Columns[i].Visible)
                {
                    frm.lbxSelected.Items.Add(dgvList.Columns[i].Name);
                }
                else
                {
                    frm.lbxList.Items.Add(dgvList.Columns[i].Name);
                }
            }

            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.Yes)
            {
                for (int i = 0; i < dgvList.Columns.Count; i++)
                {
                    dgvList.Columns[i].Visible = false;

                    for (int j = 0; j < frm.lbxSelected.Items.Count; j++)
                    {
                        if (dgvList.Columns[i].Name == frm.lbxSelected.Items[j].ToString())
                        {
                            dgvList.Columns[i].Visible = true;
                        }
                    }
                }
            }
        }

        private void 导出模版ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModels frm = new frmModels
            {
                Text = "导出模版",
                Types = "主界面"
            };
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.Yes)
            {
                for (int i = 0; i < dgvList.Columns.Count; i++)
                {
                    Class.DB_Works.ExecuteCmd($"INSERT INTO Models(Name, Types, Columns) VALUES('{frm.txtName.Text}', '{frm.Types}', '{dgvList.Columns[i].Name}')");
                }

                Class.Public.Sys_MsgBox("导出模版成功！");
            }
        }

        private void 导入模版ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModels frm = new frmModels
            {
                Text = "导入模版",
                Types = "主界面"
            };
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.Yes)
            {
                DataSet Ds = Class.DB_Works.DataSetCmd($"SELECT Columns FROM Models WHERE Name = '{frm.lbxList.SelectedItem}' AND Types = '{frm.Types}'");

                for (int i = 0; i < dgvList.Columns.Count; i++)
                {
                    dgvList.Columns[i].Visible = false;

                    for (int j = 0; j < Ds.Tables[0].Rows.Count; j++)
                    {
                        if (dgvList.Columns[i].Name == Ds.Tables[0].Rows[j][0].ToString())
                        {
                            dgvList.Columns[i].Visible = true;
                        }
                    }
                }

                Class.Public.Sys_MsgBox("导入模版成功！");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (strSQL == string.Empty)
            {
                strSQL = "SELECT Premises.Name AS 房产名称, Code AS 房产编号, Date AS 建筑年代, Levels AS 建筑层数, Structure AS 建筑结构, Purpose AS 建筑用途, Assets_Amount AS 资产原值, Assets_Code AS 资产编码, Device_Code AS 设备编码, Region AS 地区, Projects.Name AS 工程名称, Types.Name AS 工程类型, Projects.Detail AS 工程内容, Projects.Amount AS 计划金额, Projects.Developing_Reply AS 可研批复, Projects.Initial_Reply AS 初始批复, Projects.Plan_Code AS 计划文号, Projects.Begin_Date AS 开工时间, Projects.End_Date AS 竣工时间, Tenders.Name AS 中标单位, Projects.Progress AS 形象进度, Projects.Amount_Order AS 合同金额, Projects.Amount_Reality AS 实际发生额, Projects.Amount_Pay AS 支付金额, Projects.Amount_Arrear AS 欠款金额, Projects.Warranty AS 质保金支付时间, Constructors.Name AS 施工单位, Constructors.Manager AS 负责人, Constructors.Contact AS 联系方式, Partitions.Amount AS 分包金额, Partitions.Amount_Pay AS 支付金额1, Partitions.Amount_Arrear AS 欠款金额1, Partitions.Management AS 管理费, Partitions.Account AS 是否挂账, Projects.Collect_Tag AS 收集整理, Projects.Check_Tag AS 立卷检查, Projects.Grade_Tag AS 验收合格 FROM Premises LEFT JOIN Projects ON Projects.Premises_id = Premises.id LEFT JOIN Types ON Types.id = Projects.Types_id LEFT JOIN Tenders ON Tenders.id = Projects.Tenders_id LEFT JOIN Partitions ON Partitions.Projects_id = Projects.id LEFT JOIN Constructors ON Partitions.Constructors_id = Constructors.id";

                if (txtName.Text.Trim() != string.Empty || txtCode.Text.Trim() != string.Empty || txtRegion.Text.Trim() != string.Empty || txtYear.Text.Trim() != string.Empty || cmbTypes.SelectedIndex != -1 || txtDetail.Text.Trim() != string.Empty || txtPlan_Code.Text.Trim() != string.Empty || cmbTenders.SelectedIndex != -1 || cmbConstructors.SelectedIndex != -1 || txtManager.Text.Trim() != string.Empty)
                {
                    strSQL = $"{strSQL} WHERE ";

                    if (txtName.Text.Trim() != string.Empty)
                    {
                        strSQL = $"{strSQL} Premises.Name = '{txtName.Text}' AND ";

                        dgvList.Columns[0].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                    if (txtCode.Text.Trim() != string.Empty)
                    {
                        strSQL = $"{strSQL} Code ='{txtCode.Text}' AND ";

                        dgvList.Columns[1].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                    if (txtRegion.Text.Trim() != string.Empty)
                    {
                        strSQL = $"{strSQL} Code ='{txtRegion.Text}' AND ";

                        dgvList.Columns[9].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                    if (txtYear.Text.Trim() != string.Empty)
                    {
                        strSQL = $"{strSQL} Projects.Begin_Date >= '{txtYear.Text}-01-01' AND Projects.End_Date <= '{txtYear.Text}-12-31' AND ";

                        dgvList.Columns[17].DefaultCellStyle.BackColor = Color.Yellow;
                        dgvList.Columns[18].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                    if (cmbTypes.SelectedIndex != -1)
                    {
                        strSQL = $"{strSQL} Types_id = {cmbTypes.SelectedValue} AND ";

                        dgvList.Columns[11].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                    if (txtDetail.Text.Trim() != string.Empty)
                    {
                        strSQL = $"{strSQL} Projects.Detail LIKE '%{txtDetail.Text}%' AND ";

                        dgvList.Columns[12].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                    if (txtPlan_Code.Text.Trim() != string.Empty)
                    {
                        strSQL = $"{strSQL} Plan_Code = '{txtPlan_Code.Text}' AND ";

                        dgvList.Columns[16].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                    if (cmbTenders.SelectedIndex != -1)
                    {
                    }
                    strSQL = $"{strSQL} Tenders_id = {cmbTenders.SelectedValue} AND ";

                    dgvList.Columns[19].DefaultCellStyle.BackColor = Color.Yellow;
                }

                if (cmbConstructors.SelectedIndex != -1)
                {
                    strSQL = $"{strSQL} Partitions.Constructors_id = {cmbConstructors.SelectedValue} AND ";

                    dgvList.Columns[26].DefaultCellStyle.BackColor = Color.Yellow;
                }

                if (txtManager.Text.Trim() != string.Empty)
                {
                    strSQL = $"{strSQL} (Constructors.Manager = '{txtManager.Text}' OR Tenders.Manager = '{txtManager.Text}') AND ";

                    dgvList.Columns[27].DefaultCellStyle.BackColor = Color.Yellow;
                }

                strSQL = strSQL.Substring(0, strSQL.Length - 4);
            }            

            dgvList.DataSource = Class.DB_Works.DataSetCmd(strSQL).Tables[0];
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string strExcel = Class.Public.Sys_SaveExcelFile();

            if (strExcel != null)
            {
                Class.Excel.TableToExcel(Class.Excel.GetDgvToTable(dgvList), strExcel);

                Class.DB_Works.ExecuteCmd($"INSERT INTO Logs(Users_id, Type, Detail, DateTime) VALUES({AppSetter.Current_User.id}, '导出', '【导出概要信息】导出概要数据【{dgvList.Rows.Count}】条', NOW())");

                Class.Public.Sys_MsgBox(strExcel);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string strExcel = Class.Public.Sys_OpenExcelFile();

            if (strExcel != null)
            {
                DataTable dt = Class.Excel.ExcelToTable(strExcel);

                if (dt.Columns.Count == 11)
                {
                    frmPremises_Import frm = new frmPremises_Import
                    {
                        dt = dt
                    };
                    frm.ShowDialog();

                    if (frm.DialogResult == DialogResult.Yes)
                    {
                        btnReload_Click(this, e);
                    }
                }
                else if (dt.Columns.Count == 14)
                {
                    frmProjects_Import frm = new frmProjects_Import
                    {
                        dt = dt
                    };
                    frm.ShowDialog();

                    if (frm.DialogResult == DialogResult.Yes)
                    {
                        btnReload_Click(this, e);
                    }
                }
                else
                {
                    Class.Public.Sys_MsgBox("选择的导入文件错误！");
                }
            }
            else
            {
                Class.Public.Sys_MsgBox("选择的导入文件错误！");
            }
        }
    }
}
