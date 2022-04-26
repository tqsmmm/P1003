using System;
using System.Data;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmPremises_List : Form
    {
        public frmPremises_List()
        {
            InitializeComponent();

            dgvList = Class.Public.SetDataGridViewStyle(dgvList);
        }

        private void frmPremises_List_Load(object sender, EventArgs e)
        {
            if (AppSetter.Current_User.id != 1 || AppSetter.Current_User.id == 0)
            {
                btnNew.Enabled = false;
                btnEdit.Enabled = false;
                btnDel.Enabled = false;

                btnImport.Enabled = false;
            }

            btnReload_Click(this, e);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            string strSQL = "SELECT id AS 序号, Name AS 房产名称, Code AS 房产编号, Address AS 房产地址, Date AS 建筑年代, Levels AS 建筑层数, Structure AS 建筑结构, Dimension AS 建筑面积, Purpose AS 建筑用途, Assets_Amount AS 资产原值, Assets_Code AS 资产编码, Device_Code AS 设备编码, Region AS 地区 FROM Premises";

            if (txtName.Text.Trim() != string.Empty || txtCode.Text.Trim() != string.Empty || txtRegion.Text.Trim() != string.Empty)
            {
                strSQL = $"{strSQL} WHERE ";

                if (txtName.Text.Trim() != string.Empty)
                {
                    strSQL = $"{strSQL} Name = '{txtName.Text}' AND ";
                }

                if (txtCode.Text.Trim() != string.Empty)
                {
                    strSQL = $"{strSQL} Code = '{txtCode.Text}' AND ";
                }

                if (txtRegion.Text.Trim() != string.Empty)
                {
                    strSQL = $"{strSQL} Region ='{txtRegion.Text}' AND ";
                }

                strSQL = strSQL.Substring(0, strSQL.Length - 4);
            }

            dgvList.DataSource = Class.DB_Works.DataSetCmd(strSQL).Tables[0];
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmPremises_Info frm = new frmPremises_Info
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
                frmPremises_Info frm = new frmPremises_Info
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
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count > 0 && Class.Public.Sys_MsgYN("是否确定删除？"))
            {
                var result = Class.DB_Works.ExecuteCmd($"DELETE FROM Premises WHERE id = {dgvList.SelectedRows[0].Cells[0].Value}");

                if (result)
                {
                    Class.DB_Works.ExecuteCmd($"INSERT INTO Logs(Users_id, Type, Detail, DateTime) VALUES({AppSetter.Current_User.id}, '删除', '【删除房产信息】房产名称【{dgvList.SelectedRows[0].Cells[1].Value}】，房产编码【{dgvList.SelectedRows[0].Cells[2].Value}】', NOW())");

                    btnReload_Click(this, e);
                }
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
            }
            else
            {
                Class.Public.Sys_MsgBox("选择的导入文件错误！");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string strExcel = Class.Public.Sys_SaveExcelFile();

            if (strExcel != null)
            {
                DataTable dt = Class.Excel.GetDgvToTable(dgvList);

                DataRow[] rows = dt.Select("Checked = 'True'");

                DataTable dt_new = dt.Clone();

                foreach (DataRow row in rows)
                {
                    dt_new.Rows.Add(row.ItemArray);
                }

                dt_new.Columns.Remove("Checked");
                dt_new.Columns.Remove("序号");

                Class.Excel.TableToExcel(dt_new, strExcel);

                Class.DB_Works.ExecuteCmd($"INSERT INTO Logs(Users_id, Type, Detail, DateTime) VALUES({AppSetter.Current_User.id}, '导出', '【导出房产信息】导出房产数据【{dgvList.Rows.Count}】条', NOW())");

                Class.Public.Sys_MsgBox(strExcel);
            }
        }

        private void 导入模版ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModels frm = new frmModels
            {
                Text = "导入模版",
                Types = "房产资源"
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

        private void 导出模版ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModels frm = new frmModels
            {
                Text = "导出模版",
                Types = "房产资源"
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
    }
}
