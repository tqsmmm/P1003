using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmProjects_List : Form
    {
        public frmProjects_List()
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

            dgvList.AllowUserToAddRows = false;
            dgvList.AllowUserToDeleteRows = false;
            dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvList.BackgroundColor = Color.White;
            dgvList.BorderStyle = BorderStyle.Fixed3D;
            dgvList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.EnableHeadersVisualStyles = false;
            dgvList.GridColor = SystemColors.GradientInactiveCaption;
            dgvList.ReadOnly = true;
            dgvList.RowHeadersVisible = false;
            dgvList.RowTemplate.Height = 23;
            dgvList.RowTemplate.ReadOnly = true;
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvDetail.AllowUserToAddRows = false;
            dgvDetail.AllowUserToDeleteRows = false;
            dgvDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDetail.BackgroundColor = Color.White;
            dgvDetail.BorderStyle = BorderStyle.Fixed3D;
            dgvDetail.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetail.EnableHeadersVisualStyles = false;
            dgvDetail.GridColor = SystemColors.GradientInactiveCaption;
            dgvDetail.ReadOnly = true;
            dgvDetail.RowHeadersVisible = false;
            dgvDetail.RowTemplate.Height = 23;
            dgvDetail.RowTemplate.ReadOnly = true;
            dgvDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void frmProjects_List_Load(object sender, EventArgs e)
        {
            if (AppSetter.Current_User.id == 0)
            {
                btnNew.Enabled = false;
                btnEdit.Enabled = false;
                btnDel.Enabled = false;

                btnImport.Enabled = false;
            }

            cmbTenders.DataSource = Class.DB_Works.DataSetCmd("SELECT id, Name FROM Tenders").Tables[0];
            cmbTenders.DisplayMember = "Name";
            cmbTenders.ValueMember = "id";

            cmbTenders.SelectedIndex = -1;

            cmbTypes.DataSource = Class.DB_Works.DataSetCmd("SELECT id, Name FROM Types").Tables[0];
            cmbTypes.DisplayMember = "Name";
            cmbTypes.ValueMember = "id";

            cmbTypes.SelectedIndex = -1;

            btnReload_Click(this, e);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            string strSQL = "SELECT Projects.id AS 序号, Projects.Name AS 工程名称, Types.Name AS 工程类型, Detail AS 工程内容, Amount AS 计划金额, Developing_Reply AS 可研批复, Initial_Reply AS 初始批复, Plan_Code AS 计划文号, Begin_Date AS 开工时间, End_Date AS 竣工时间, Tenders.Name AS 中标单位, Progress AS 形象进度, Collect_Tag AS 收集整理, Check_Tag AS 立卷检查, Grade_Tag AS 验收合格, Amount_Order AS 合同金额, Amount_Reality AS 实际发生额, Amount_Pay AS 付款金额, Amount_Arrear AS 欠款金额, Warranty AS 质保金支付时间 FROM Projects LEFT JOIN Tenders ON Tenders.id = Projects.Tenders_id LEFT JOIN Types ON Types.id = Projects.Types_id";

            if (txtYear.Text.Trim() != string.Empty || txtPlan_Code.Text.Trim() != string.Empty || txtDetail.Text.Trim() != string.Empty || cmbTenders.SelectedIndex != -1 || cmbTypes.SelectedIndex != -1)
            {
                strSQL = $"{strSQL} WHERE ";

                if (txtYear.Text.Trim() != string.Empty)
                {
                    strSQL = $"{strSQL} Begin_Date >= '{txtYear.Text}-01-01' AND End_Date <= '{txtYear.Text}-12-31' AND ";

                    dgvList.Columns[8].DefaultCellStyle.BackColor = Color.Yellow;
                    dgvList.Columns[9].DefaultCellStyle.BackColor = Color.Yellow;
                }

                if (txtPlan_Code.Text.Trim() != string.Empty)
                {
                    strSQL = $"{strSQL} Plan_Code = '{txtPlan_Code.Text}' AND ";

                    dgvList.Columns[7].DefaultCellStyle.BackColor = Color.Yellow;
                }

                if (txtDetail.Text.Trim() != string.Empty)
                {
                    strSQL = $"{strSQL} Detail LIKE '%{txtDetail.Text}%' AND ";

                    dgvList.Columns[3].DefaultCellStyle.BackColor = Color.Yellow;
                }

                if (cmbTenders.SelectedIndex != -1)
                {
                    strSQL = $"{strSQL} Tenders_id = {cmbTenders.SelectedValue} AND ";

                    dgvList.Columns[10].DefaultCellStyle.BackColor = Color.Yellow;
                }

                if (cmbTypes.SelectedIndex != -1)
                {
                    strSQL = $"{strSQL} Types_id = {cmbTypes.SelectedValue} AND ";

                    dgvList.Columns[2].DefaultCellStyle.BackColor = Color.Yellow;
                }

                strSQL = strSQL.Substring(0, strSQL.Length - 4);
            }

            dgvList.DataSource = Class.DB_Works.DataSetCmd(strSQL).Tables[0];
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmProjects_Info frm = new frmProjects_Info();
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
                frmProjects_Info frm = new frmProjects_Info();
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
                var result = Class.DB_Works.ExecuteCmd($"DELETE FROM Prjects WHERE id = {dgvList.SelectedRows[0].Cells[0].Value}");

                if (result)
                {
                    Class.DB_Works.ExecuteCmd($"INSERT INTO Logs(Users_id, Type, Detail, DateTime) VALUES({AppSetter.Current_User.id}, '删除', '【删除工程信息】工程名称【{dgvList.SelectedRows[0].Cells[1].Value}】，工程类型【{dgvList.SelectedRows[0].Cells[2].Value}】，计划金额【{dgvList.SelectedRows[0].Cells[4].Value}】', NOW())");

                    btnReload_Click(this, e);
                }
            }
        }

        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count > 0)
            {
                dgvDetail.DataSource = Class.DB_Works.DataSetCmd($"SELECT Partitions.id AS 序号, Projects.Name AS 工程名称, Constructors.Name AS 施工单位, Partitions.Amount AS 分包金额, Partitions.Amount_Arrear AS 欠款金额, Partitions.Amount_Pay AS 付款金额, Management AS 管理费, Account AS 是否挂账 FROM Partitions LEFT JOIN Projects ON Projects.id = Partitions.Projects_id LEFT JOIN Constructors ON Constructors.id = Partitions.Constructors_id WHERE Partitions.Projects_id = {dgvList.SelectedRows[0].Cells[0].Value}").Tables[0];
            }
        }

        private void cmbTypes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnReload_Click(this, e);
        }

        private void cmbTenders_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnReload_Click(this, e);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            frmProjects_Import frm = new frmProjects_Import();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.Yes)
            {
                btnReload_Click(this, e);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Excel表格（*.xlsx）|*.xlsx";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Class.Excel.TableToExcel(Class.Excel.GetDgvToTable(dgvList), sfd.FileName);

                Class.DB_Works.ExecuteCmd($"INSERT INTO Logs(Users_id, Type, Detail, DateTime) VALUES({AppSetter.Current_User.id}, '导出', '【导出工程信息】导出工程数据【{dgvList.Rows.Count}】条', NOW())");

                MessageBox.Show(sfd.FileName.ToString());
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

        private void 导入模版ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModels frm = new frmModels();
            frm.Text = "导入模版";
            frm.Types = "工程项目";
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
            frmModels frm = new frmModels();
            frm.Text = "导出模版";
            frm.Types = "工程项目";
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
    }
}
