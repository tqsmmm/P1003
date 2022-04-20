using System;
using System.Drawing;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmProjects_Info : Form
    {
        public int id = 0;

        public frmProjects_Info()
        {
            InitializeComponent();

            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle
            {
                BackColor = Color.LightCyan
            };

            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter,//211, 223, 240
                BackColor = Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240))))),
                Font = new Font("微软雅黑", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134))),
                ForeColor = Color.Navy,
                SelectionBackColor = SystemColors.Highlight,
                SelectionForeColor = SystemColors.HighlightText
            };

            dgvPartitions.AllowUserToAddRows = false;
            dgvPartitions.AllowUserToDeleteRows = false;
            dgvPartitions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPartitions.BackgroundColor = Color.White;
            dgvPartitions.BorderStyle = BorderStyle.Fixed3D;
            dgvPartitions.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvPartitions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPartitions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartitions.EnableHeadersVisualStyles = false;
            dgvPartitions.GridColor = SystemColors.GradientInactiveCaption;
            dgvPartitions.ReadOnly = true;
            dgvPartitions.RowHeadersVisible = false;
            dgvPartitions.RowTemplate.Height = 23;
            dgvPartitions.RowTemplate.ReadOnly = true;
            dgvPartitions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            cmbTenders.DataSource = Class.DB_Works.DataSetCmd("SELECT id, Name FROM Tenders").Tables[0];
            cmbTenders.ValueMember = "id";
            cmbTenders.DisplayMember = "Name";

            cmbTenders.SelectedIndex = -1;

            cmbTypes.DataSource = Class.DB_Works.DataSetCmd($"SELECT id, Name FROM Types WHERE id IN (SELECT Types_id FROM Limits WHERE Users_id = {AppSetter.Current_User.id})").Tables[0];
            cmbTypes.ValueMember = "id";
            cmbTypes.DisplayMember = "Name";

            cmbTypes.SelectedIndex = -1;
        }

        private void frmProjects_Info_Load(object sender, EventArgs e)
        {
            if (Text == "修改" && id != 0)
            {
                //查询工程信息
                var Ds = Class.DB_Works.DataSetCmd($"SELECT Name, Types_id, Detail, Amount, Developing_Reply, Initial_Reply, Plan_Code, Begin_Date, End_Date, Tenders_id, Progress, Collect_Tag, Check_Tag, Grade_Tag, Amount_Order, Amount_Reality, Amount_Pay, Amount_Arrear, Warranty, Premises_id FROM Projects WHERE id = {id}");

                txtProjects.Text = Ds.Tables[0].Rows[0][0].ToString();
                cmbTypes.SelectedValue = Ds.Tables[0].Rows[0][1].ToString();
                txtDetail.Text = Ds.Tables[0].Rows[0][2].ToString();
                txtAmount.Text = Ds.Tables[0].Rows[0][3].ToString();
                txtDeveloping_Reply.Text = Ds.Tables[0].Rows[0][4].ToString();
                txtInitial_Reply.Text = Ds.Tables[0].Rows[0][5].ToString();
                txtPlan_Code.Text = Ds.Tables[0].Rows[0][6].ToString();
                dtpBegin_Date.Value = Convert.ToDateTime(Ds.Tables[0].Rows[0][7]);
                dtpEnd_Date.Value = Convert.ToDateTime(Ds.Tables[0].Rows[0][8]);
                cmbTenders.SelectedValue = Ds.Tables[0].Rows[0][9].ToString();
                txtProgress.Text = Ds.Tables[0].Rows[0][10].ToString();
                cmbCollect_Tag.Text = Ds.Tables[0].Rows[0][11].ToString();
                cmbCheck_Tag.Text = Ds.Tables[0].Rows[0][12].ToString();
                cmbGrade_Tag.Text = Ds.Tables[0].Rows[0][13].ToString();

                //查询结算信息
                txtAmount_Order.Text = Ds.Tables[0].Rows[0][14].ToString();
                txtAmount_Reality.Text = Ds.Tables[0].Rows[0][15].ToString();
                txtAmount_Pay.Text = Ds.Tables[0].Rows[0][16].ToString();
                txtAmount_Arrear.Text = Ds.Tables[0].Rows[0][17].ToString();
                dtpWarranty.Value = Convert.ToDateTime(Ds.Tables[0].Rows[0][18]);

                //查询房产信息
                Ds = Class.DB_Works.DataSetCmd($"SELECT Name, Code, Address, Date, Levels, Structure, Dimension, Purpose, Assets_Amount, Assets_Code, Device_Code, Region FROM Premises WHERE id = {Ds.Tables[0].Rows[0][19]}");

                txtPremises.Text = Ds.Tables[0].Rows[0][0].ToString();

                txtName.Text = Ds.Tables[0].Rows[0][0].ToString();
                txtCode.Text = Ds.Tables[0].Rows[0][1].ToString();
                txtAddress.Text = Ds.Tables[0].Rows[0][2].ToString();
                txtDate.Text = Ds.Tables[0].Rows[0][3].ToString();
                txtLevels.Text = Ds.Tables[0].Rows[0][4].ToString();
                txtStructure.Text = Ds.Tables[0].Rows[0][5].ToString();
                txtDimension.Text = Ds.Tables[0].Rows[0][6].ToString();
                txtPurpose.Text = Ds.Tables[0].Rows[0][7].ToString();
                txtAssets_Amount.Text = Ds.Tables[0].Rows[0][8].ToString();
                txtAssets_Code.Text = Ds.Tables[0].Rows[0][9].ToString();
                txtDevice_Code.Text = Ds.Tables[0].Rows[0][10].ToString();
                txtRegion.Text = Ds.Tables[0].Rows[0][11].ToString();

                //查询分包信息
                dgvPartitions.DataSource = Class.DB_Works.DataSetCmd($"SELECT Partitions.id AS 序号, Projects.Name AS 工程名称, Constructors.Name AS 施工单位, Partitions.Amount AS 分包金额, Partitions.Amount_Arrear AS 欠款金额, Partitions.Amount_Pay AS 付款金额, Management AS 管理费, Account AS 是否挂账 FROM Partitions LEFT JOIN Projects ON Projects.id = Partitions.Projects_id LEFT JOIN Constructors ON Constructors.id = Partitions.Constructors_id WHERE Partitions.Projects_id = {id}").Tables[0];
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtProjects.Text.Trim() == string.Empty)
            {
                Class.Public.Sys_MsgBox("工程名称不能为空！");
                return;
            }

            if (Text == "新建")
            {
                if (Class.DB_Works.DataSetCmd($"SELECT id FROM Projects WHERE Name = '{txtProjects.Text}' AND (DATE_ADD(Begin_Date, INTERVAL 1 YEAR) > NOW() OR DATE_ADD(End_Date, INTERVAL 1 YEAR) > NOW())").Tables[0].Rows.Count > 0)
                {
                    Class.Public.Sys_MsgBox("工程项目名称一年内不可重复！");
                    return;
                }

                var result = Class.DB_Works.ExecuteCmd($"INSERT INTO Projects(Name, Types_id, Detail, Amount, Developing_Reply, Initial_Reply, Plan_Code, Begin_Date, End_Date, Tenders_id, Progress, Collect_Tag, Check_Tag, Grade_Tag, Amount_Order, Amount_Reality, Warranty, Remark, Users_id, DateTime) VALUES('{txtProjects.Text}', {cmbTypes.SelectedValue}, '{txtDetail.Text}', {txtAmount.Text}, '{txtDeveloping_Reply.Text}', '{txtInitial_Reply.Text}', '{txtPlan_Code.Text}', '{dtpBegin_Date.Value}', '{dtpEnd_Date.Value}', {cmbTenders.SelectedValue}, '{txtProgress.Text}', '{cmbCollect_Tag.Text}', '{cmbCheck_Tag.Text}', '{cmbGrade_Tag.Text}', {txtAmount_Order.Text}, {txtAmount_Reality.Text}, '{dtpWarranty.Value:yyyy-MM-dd}', '{txtRemark.Text}', {AppSetter.Current_User.id}, NOW())");

                if (result)
                {
                    Class.DB_Works.ExecuteCmd($"INSERT INTO Logs(Users_id, Type, Detail, DateTime) VALUES({AppSetter.Current_User.id}, '新建', '【新建工程信息】工程名称【{txtProjects.Text}】，工程类型【{cmbTypes.Text}】，计划金额【{txtAmount.Text}】', NOW())");

                    Class.Public.Sys_MsgBox("新建工程信息成功！");
                    DialogResult = DialogResult.Yes;
                    Close();
                }
            }
            else if (Text == "修改")
            {
                var result = Class.DB_Works.ExecuteCmd($"UPDATE Projects SET Name = '{txtProjects.Text}', Types_id = {cmbTypes.SelectedValue}, Detail = '{txtDetail.Text}', Amount = {txtAmount.Text}, Developing_Reply = '{txtDeveloping_Reply.Text}', Initial_Reply = '{txtInitial_Reply.Text}', Plan_Code = '{txtPlan_Code.Text}', Begin_Date = '{dtpBegin_Date.Value}', End_Date = '{dtpEnd_Date.Value}', Tenders_id = {cmbTenders.SelectedValue}, Progress = '{txtProgress.Text}', Collect_Tag = '{cmbCollect_Tag.Text}', Check_Tag = '{cmbCheck_Tag.Text}', Grade_Tag = '{cmbGrade_Tag.Text}', Amount_Order = {txtAmount_Order.Text}, Amount_Reality = {txtAmount_Reality.Text}, Warranty = '{dtpWarranty.Value:yyyy-MM-dd}', Remark = '{txtRemark.Text}' WHERE id = {id}");

                if (result)
                {
                    Class.DB_Works.ExecuteCmd($"INSERT INTO Logs(Users_id, Type, Detail, DateTime) VALUES({AppSetter.Current_User.id}, '修改', '【修改工程信息】工程名称【{txtProjects.Text}】，工程类型【{cmbTypes.Text}】，计划金额【{txtAmount.Text}】', NOW())");

                    Class.Public.Sys_MsgBox("修改工程信息成功！");
                    DialogResult = DialogResult.Yes;
                    Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
