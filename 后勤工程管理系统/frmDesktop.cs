using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmDesktop : Form
    {
        public string strTypes = string.Empty;

        public frmDesktop()
        {
            InitializeComponent();

            dgvList = Class.Public.SetDataGridViewStyle(dgvList);

            cmbTenders.DataSource = Class.DB_Works.DataSetCmd("SELECT id, Name FROM Tenders").Tables[0];
            cmbTenders.DisplayMember = "Name";
            cmbTenders.ValueMember = "id";

            cmbConstructors.DataSource = Class.DB_Works.DataSetCmd("SELECT id, Name FROM Constructors").Tables[0];
            cmbConstructors.DisplayMember = "Name";
            cmbConstructors.ValueMember = "id";

            cmbPartitions_Account.SelectedIndex = 0;
            cmbCollect_Tag.SelectedIndex = 0;
            cmbCheck_Tag.SelectedIndex = 0;
            cmbGrade_Tag.SelectedIndex = 0;

            DataSet Ds = Class.DB_Works.DataSetCmd("SELECT Name FROM Premises");

            AutoCompleteStringCollection filtervals = new AutoCompleteStringCollection();

            foreach (DataRow dr in Ds.Tables[0].Rows)
            {
                filtervals.Add(dr["Name"].ToString());
            }

            txtPremises_Name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtPremises_Name.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtPremises_Name.AutoCompleteCustomSource = filtervals;

            Ds = Class.DB_Works.DataSetCmd("SELECT Name FROM Types");

            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                clbProjects_Types.Items.Add(Ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void frmDesktop_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(strTypes))
            {
                tabControl1.SelectTab(1);

                btnReload_Click(this, e);
            }
        }

        private void 编辑列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColumns frm = new frmColumns();

            for (int i = 0; i < dgvList.Columns.Count; i++)
            {
                if (dgvList.Columns[i].Name != "Checked")
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
            string strSQL = "SELECT Projects.id AS 序号, Premises.Name AS 房产名称, Code AS 房产编号, Premises.Date AS 建筑年代, Levels AS 建筑层数, Structure AS 建筑结构, Dimension AS 建筑面积, Purpose AS 建筑用途, Assets_Amount AS 资产原值, Assets_Code AS 资产编码, Device_Code AS 设备编码, Region AS 地区, Projects.OrderID AS 工程编号, Projects.Name AS 工程名称, Types.Name AS 工程类型, Projects.Detail AS 工程内容, Projects.Date AS 工程年份, Projects.Amount AS 计划金额, Projects.Developing_Reply AS 可研批复, Projects.Initial_Reply AS 初始批复, Projects.Plan_Code AS 计划文号, Projects.Begin_Date AS 开工时间, Projects.End_Date AS 竣工时间, Tenders.Name AS 中标单位, Projects.Progress AS 形象进度, Projects.Amount_Order AS 合同金额, Projects.Amount_Reality AS 实际发生额, Projects.Amount_Pay AS 合同支付金额, Projects.Amount_Arrear AS 合同欠款金额, Projects.Warranty AS 质保金支付时间, Constructors.Name AS 施工单位, Constructors.Manager AS 负责人, Constructors.Contact AS 联系方式, Partitions.Amount AS 分包金额, Partitions.Amount_Pay AS 分包支付金额, Partitions.Amount_Arrear AS 分包欠款金额, Partitions.Management AS 管理费, Partitions.Account AS 是否挂账, Projects.Collect_Tag AS 收集整理, Projects.Check_Tag AS 立卷检查, Projects.Grade_Tag AS 验收合格 FROM Premises LEFT JOIN Projects ON Projects.Premises_id = Premises.id LEFT JOIN Types ON Types.id = Projects.Types_id LEFT JOIN Tenders ON Tenders.id = Projects.Tenders_id LEFT JOIN Partitions ON Partitions.Projects_id = Projects.id LEFT JOIN Constructors ON Partitions.Constructors_id = Constructors.id";

            for (int i = 0; i < dgvList.ColumnCount; i++)
            {
                dgvList.Columns[i].DefaultCellStyle.BackColor = Color.White;
            }

            if (!string.IsNullOrEmpty(strTypes))
            {
                strSQL = $"{strSQL} WHERE Types.Name = '{strTypes}'";

                dgvList.Columns["工程类型"].DefaultCellStyle.BackColor = Color.Yellow;

                dgvList.DataSource = Class.DB_Works.DataSetCmd(strSQL).Tables[0];
            }
            else
            {
                bool bChecked = false;

                foreach (Control item in tableLayoutPanel1.Controls)
                {
                    if (item is CheckBox)
                    {
                        var comm = item as CheckBox;
                        if (comm.Checked == true)
                        {
                            bChecked = true;
                        }
                    }
                }

                if (bChecked == true)
                {
                    strSQL = $"{strSQL} WHERE ";

                    if (ckbPremises_Name.Checked)
                    {
                        strSQL = $"{strSQL} Premises.Name = '{txtPremises_Name.Text}' AND ";

                        dgvList.Columns["房产名称"].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                    if (ckbDate.Checked && !string.IsNullOrEmpty(ckbDate.Text))
                    {
                        if (txtDate.Text.IndexOf("年") >= 0)
                        {
                            strSQL = $"{strSQL} LEFT(Premises.Date, 4) = '{txtDate.Text.Substring(txtDate.Text.IndexOf("年"), 1)}' AND ";
                        }
                        else
                        {
                            strSQL = $"{strSQL} LEFT(Premises.Date, 4) = '{txtDate.Text}' AND ";
                        }

                        dgvList.Columns["建筑年代"].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                    if (ckbProjects_Types.Checked)
                    {
                        if (clbProjects_Types.CheckedItems.Count > 0)
                        {
                            string strTypes = "'";

                            for (int i = 0; i < clbProjects_Types.CheckedItems.Count; i++)
                            {
                                strTypes = $"{strTypes}{clbProjects_Types.CheckedItems[i]}', '";
                            }

                            strTypes = strTypes.Substring(0, strTypes.Length - 3);

                            strSQL = $"{strSQL} Types.Name IN ({strTypes}) AND ";
                        }
                        else
                        {
                            strSQL = $"{strSQL} 1=1 AND ";
                        }

                        dgvList.Columns["工程类型"].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                    if (ckbPremises_Date.Checked)
                    {
                        if (string.IsNullOrEmpty(txtPremises_Date_From.Text) && string.IsNullOrEmpty(txtPremises_Date_To.Text))
                        {
                            strSQL = $"{strSQL} (Projects.Begin_Date = '1900-01-01' OR Projects.End_Date = '1900-01-01') AND ";

                            dgvList.Columns["开工时间"].DefaultCellStyle.BackColor = Color.Yellow;
                            dgvList.Columns["竣工时间"].DefaultCellStyle.BackColor = Color.Yellow;
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(txtPremises_Date_From.Text))
                            {
                                strSQL = $"{strSQL} Projects.Begin_Date >= '{txtPremises_Date_From.Text}-01-01' AND ";

                                dgvList.Columns["开工时间"].DefaultCellStyle.BackColor = Color.Yellow;
                            }

                            if (!string.IsNullOrEmpty(txtPremises_Date_To.Text))
                            {
                                strSQL = $"Projects.End_Date <= '{txtPremises_Date_From.Text}-12-31' AND ";

                                dgvList.Columns["竣工时间"].DefaultCellStyle.BackColor = Color.Yellow;
                            }
                        }
                    }

                    if (ckbTenders.Checked)
                    {
                        strSQL = $"{strSQL} Tenders_id = {cmbTenders.SelectedValue} AND ";

                        dgvList.Columns["中标单位"].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                    if (ckbConstructors.Checked)
                    {
                        strSQL = $"{strSQL} Partitions.Constructors_id = {cmbConstructors.SelectedValue} AND ";

                        dgvList.Columns["施工单位"].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                    if (ckbContact.Checked)
                    {
                        strSQL = $"{strSQL} (Constructors.Manager = '{txtContact.Text}' OR Tenders.Manager = '{txtContact.Text}') AND ";

                        dgvList.Columns["负责人"].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                    if (ckbProjects_Amount.Checked)
                    {
                        strSQL = $"{strSQL} Projects.Amount = {txtProjects_Amount.Text} AND ";

                        dgvList.Columns["计划金额"].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                    if (ckbProjects_Amount_Order.Checked)
                    {
                        strSQL = $"{strSQL} Projects.Amount_Order = {txtProjects_Amount_Order.Text} AND ";

                        dgvList.Columns["合同金额"].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                    if (ckbProjects_Amount_Reality.Checked)
                    {
                        strSQL = $"{strSQL} Projects.Amount_Reality = {txtProjects_Amount_Reality.Text} AND ";

                        dgvList.Columns["实际发生额"].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                    if (ckbProjects_Amount_Pay.Checked)
                    {
                        strSQL = $"{strSQL} Projects.Amount_Pay = {txtProjects_Amount_Pay.Text} AND ";

                        dgvList.Columns["合同支付金额"].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                    if (ckbProjects_Amount_Arrear.Checked)
                    {
                        strSQL = $"{strSQL} Projects.Amount_Arrear = {txtProjects_Amount_Arrear.Text} AND ";

                        dgvList.Columns["合同欠款金额"].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                    if (ckbPartitions_Amount.Checked)
                    {
                        strSQL = $"{strSQL} Partitions.Amount = {txtPartitions_Amount.Text} AND ";

                        dgvList.Columns["分包金额"].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                    if (ckbPartitions_Amount_Pay.Checked)
                    {
                        strSQL = $"{strSQL} Partitions.Amount_Pay = {txtPartitions_Amount_Pay.Text} AND ";

                        dgvList.Columns["分包支付金额"].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                    if (ckbPartitions_Amount_Arrear.Checked)
                    {
                        strSQL = $"{strSQL} Partitions.Amount_Arrear = {txtPartitions_Amount_Arrear.Text} AND ";

                        dgvList.Columns["分包欠款金额"].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                    if (ckbPartitions_Management.Checked)
                    {
                        strSQL = $"{strSQL} Partitions.Management = {txtPartitions_Amount_Management.Text} AND ";

                        dgvList.Columns["管理费"].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                    if (ckbPartitions_Account.Checked)
                    {
                        if (cmbPartitions_Account.Text == "是")
                        {
                            strSQL = $"{strSQL} Partitions.Account = 1 AND ";
                        }
                        else
                        {
                            strSQL = $"{strSQL} Partitions.Account = 0 AND ";
                        }

                        dgvList.Columns["是否挂账"].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                    if (ckbProjects_Collect_Tag.Checked)
                    {
                        strSQL = $"{strSQL} Projects.Collect_Tag = '{cmbCollect_Tag.Text}' AND ";

                        dgvList.Columns["收集整理"].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                    if (ckbProjects_Check_Tag.Checked)
                    {
                        strSQL = $"{strSQL} Projects.Check_Tag = '{cmbCheck_Tag.Text}' AND ";

                        dgvList.Columns["立卷检查"].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                    if (ckbProjects_Grade_Tag.Checked)
                    {
                        strSQL = $"{strSQL} Projects.Grade_Tag = '{cmbGrade_Tag.Text}' AND ";

                        dgvList.Columns["验收合格"].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                    strSQL = strSQL.Substring(0, strSQL.Length - 4);
                }

                dgvList.DataSource = Class.DB_Works.DataSetCmd(strSQL).Tables[0];
            }

            txtSum_Partitions_Amount.Text = "0.000000";
            txtSum_Partitions_Amount_Arrear.Text = "0.000000";
            txtSum_Partitions_Amount_Management.Text = "0.000000";
            txtSum_Partitions_Amount_Pay.Text = "0.000000";
            txtSum_Projects_Amount.Text = "0.000000";
            txtSum_Projects_Amount_Arrear.Text = "0.000000";
            txtSum_Projects_Amount_Order.Text = "0.000000";
            txtSum_Projects_Amount_Pay.Text = "0.000000";
            txtSum_Projects_Amount_Reality.Text = "0.000000";

            for (int i = 0; i < dgvList.RowCount; i++)
            {
                if (dgvList.Rows[i].Cells["工程内容"].Value.ToString().Length > 0)
                {
                    dgvList.AutoResizeRow(i, DataGridViewAutoSizeRowMode.AllCells);
                }

                txtSum_Partitions_Amount.Text = (Convert.ToDecimal(txtSum_Partitions_Amount.Text) + Convert.ToDecimal(dgvList.Rows[i].Cells["分包金额"].Value)).ToString();
                txtSum_Partitions_Amount_Arrear.Text = (Convert.ToDecimal(txtSum_Partitions_Amount_Arrear.Text) + Convert.ToDecimal(dgvList.Rows[i].Cells["分包欠款金额"].Value)).ToString();
                txtSum_Partitions_Amount_Management.Text = (Convert.ToDecimal(txtSum_Partitions_Amount_Management.Text) + Convert.ToDecimal(dgvList.Rows[i].Cells["管理费"].Value)).ToString();
                txtSum_Partitions_Amount_Pay.Text = (Convert.ToDecimal(txtSum_Partitions_Amount_Pay.Text) + Convert.ToDecimal(dgvList.Rows[i].Cells["分包支付金额"].Value)).ToString();
                txtSum_Projects_Amount.Text = (Convert.ToDecimal(txtSum_Projects_Amount.Text) + Convert.ToDecimal(dgvList.Rows[i].Cells["计划金额"].Value)).ToString();
                txtSum_Projects_Amount_Arrear.Text = (Convert.ToDecimal(txtSum_Projects_Amount_Arrear.Text) + Convert.ToDecimal(dgvList.Rows[i].Cells["合同欠款金额"].Value)).ToString();
                txtSum_Projects_Amount_Order.Text = (Convert.ToDecimal(txtSum_Projects_Amount_Order.Text) + Convert.ToDecimal(dgvList.Rows[i].Cells["合同金额"].Value)).ToString();
                txtSum_Projects_Amount_Pay.Text = (Convert.ToDecimal(txtSum_Projects_Amount_Pay.Text) + Convert.ToDecimal(dgvList.Rows[i].Cells["合同支付金额"].Value)).ToString();
                txtSum_Projects_Amount_Reality.Text = (Convert.ToDecimal(txtSum_Projects_Amount_Reality.Text) + Convert.ToDecimal(dgvList.Rows[i].Cells["实际发生额"].Value)).ToString();
            }

            lblCount.Text = $"共计：{dgvList.RowCount}条";
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DataTable dt = Class.Excel.GetDgvToTable(dgvList);

            DataRow[] rows = dt.Select("Checked = 'True'");

            if (rows.Length > 0)
            {
                string strExcel = Class.Public.Sys_SaveExcelFile();

                if (strExcel != null)
                {
                    DataTable dt_new = dt.Clone();

                    foreach (DataRow row in rows)
                    {
                        dt_new.Rows.Add(row.ItemArray);
                    }

                    dt_new.Columns.Remove("Checked");
                    dt_new.Columns.Remove("序号");

                    if (Class.Excel.TableToExcel(dt_new, strExcel))
                    {
                        Class.DB_Works.ExecuteCmd($"INSERT INTO Logs(Users_id, Type, Detail, DateTime) VALUES({AppSetter.Current_User.id}, '导出', '【导出概要信息】导出概要数据【{dgvList.Rows.Count}】条', NOW())");

                        Class.Public.Sys_MsgBox(strExcel);
                    }
                }
            }
            else
            {
                Class.Public.Sys_MsgBox("请勾选要导出的数据！");
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string strExcel = Class.Public.Sys_OpenExcelFile();

            if (strExcel != null)
            {
                DataTable dt = Class.Excel.ExcelToTable(strExcel);

                if (dt != null)
                {
                    if (dt.Columns.Count == 40)
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
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (Control item in tableLayoutPanel1.Controls)
            {
                if (item is CheckBox)
                {
                    var comm = item as CheckBox;
                    comm.Checked = true;
                }
            }
        }

        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            foreach (Control item in tableLayoutPanel1.Controls)
            {
                if (item is CheckBox)
                {
                    var comm = item as CheckBox;
                    comm.Checked = false;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);

            btnReload_Click(this, e);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count > 0)
            {
                frmProjects_Info frm = new frmProjects_Info
                {
                    Text = "新建",
                    strName = dgvList.SelectedRows[0].Cells[2].Value.ToString()
                };
                frm.ShowDialog();

                if (frm.DialogResult == DialogResult.Yes)
                {
                    btnReload_Click(this, e);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count > 0)
            {
                if (AppSetter.Current_User.Limits.IndexOf(dgvList.SelectedRows[0].Cells["工程类型"].Value) != -1)
                {
                    frmProjects_Info frm = new frmProjects_Info
                    {
                        Text = "修改",
                        id = Convert.ToInt16(dgvList.SelectedRows[0].Cells[1].Value.ToString())
                    };
                    frm.ShowDialog();

                    if (frm.DialogResult == DialogResult.Yes)
                    {
                        btnReload_Click(this, e);
                    }
                }
                else
                {
                    Class.Public.Sys_MsgBox("没有操作此工程类型权限！");
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count > 0 && Class.Public.Sys_MsgYN("是否确定删除？"))
            {
                if (AppSetter.Current_User.Limits.IndexOf(dgvList.SelectedRows[0].Cells["工程类型"].Value) != -1)
                {
                    var result = Class.DB_Works.ExecuteCmd($"DELETE FROM Prjects WHERE id = {dgvList.SelectedRows[0].Cells[1].Value}");

                    if (result)
                    {
                        Class.DB_Works.ExecuteCmd($"INSERT INTO Logs(Users_id, Type, Detail, DateTime) VALUES({AppSetter.Current_User.id}, '删除', '【删除工程信息】工程名称【{dgvList.SelectedRows[0].Cells[12].Value}】，工程类型【{dgvList.SelectedRows[0].Cells[13].Value}】，计划金额【{dgvList.SelectedRows[0].Cells[15].Value}】', NOW())");

                        btnReload_Click(this, e);
                    }
                }
                else
                {
                    Class.Public.Sys_MsgBox("没有操作此工程类型权限！");
                }
            }
        }
    }
}
