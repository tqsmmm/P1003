using System;
using System.Drawing;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmPremises_Info : Form
    {
        public frmPremises_Info()
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
        }

        public int id = 0;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == string.Empty)
            {
                Class.Public.Sys_MsgBox("房产名称不能为空！");
                return;
            }

            if (Text == "新建")
            {
                if (Class.DB_Works.DataSetCmd($"SELECT id FROM Premises WHERE Name = '{txtName.Text}'").Tables[0].Rows.Count > 0)
                {
                    Class.Public.Sys_MsgBox("房产名称重复！");
                    return;
                }

                var result = Class.DB_Works.ExecuteCmd($"INSERT INTO Premises(Name, Code, Address, Date, Levels, Structure, Dimension, Purpose, Assets_Amount, Assets_Code, Device_Code, Region, Users_id, DateTime) VALUES('{txtName.Text}', '{txtCode.Text}','{txtAddress.Text}' , '{txtDate.Text}', '{txtLevels.Text}', '{txtStructure.Text}', {txtDimension.Text}, '{txtPurpose.Text}', {txtAssets_Amount.Text}, '{txtAssets_Code.Text}', '{txtDevice_Code.Text}', '{txtRegion.Text}', {AppSetter.Current_User.id}, NOW())");

                if (result)
                {
                    Class.DB_Works.ExecuteCmd($"INSERT INTO Logs(Users_id, Type, Detail, DateTime) VALUES({AppSetter.Current_User.id}, '新建', '【新建房产信息】房产名称【{txtName.Text}】，房产编码【{txtCode.Text}】', NOW())");

                    Class.Public.Sys_MsgBox("新建房产信息成功！");
                    DialogResult = DialogResult.Yes;
                    Close();
                }
            }
            else if (Text == "修改")
            {
                var result = Class.DB_Works.ExecuteCmd($"UPDATE Premises SET Name = '{txtName.Text}', Code = '{txtCode.Text}', Address = '{txtAddress.Text}', Date = '{txtDate.Text}', Levels = '{txtLevels.Text}', Structure = '{txtStructure.Text}', Dimension = {txtDimension.Text}, Purpose = '{txtPurpose.Text}', Assets_Amount = {txtAssets_Amount.Text}, Assets_Code = '{txtAssets_Code.Text}', Device_Code = '{txtDevice_Code.Text}', Region = '{txtRegion.Text}' WHERE id = {id}");

                if (result)
                {
                    Class.DB_Works.ExecuteCmd($"INSERT INTO Logs(Users_id, Type, Detail, DateTime) VALUES({AppSetter.Current_User.id}, '修改', '【修改房产信息】房产名称【{txtName.Text}】，房产编码【{txtCode.Text}】', NOW())");

                    Class.Public.Sys_MsgBox("修改房产信息成功！");
                    DialogResult = DialogResult.Yes;
                    Close();
                }
            }
        }

        private void frmPremises_Info_Load(object sender, EventArgs e)
        {
            if (Text == "修改" && id != 0)
            {
                var Ds = Class.DB_Works.DataSetCmd($"SELECT Name, Code, Address, Date, Levels, Structure, Dimension, Purpose, Assets_Amount, Assets_Code, Device_Code, Region FROM Premises WHERE id = {id}");

                txtName.Text = Ds.Tables[0].Rows[0][0].ToString();
                txtCode.Text = Ds.Tables[0].Rows[0][1].ToString();
                txtAddress.Text = Ds.Tables[0].Rows[0][2].ToString();
                txtDate.Text = Ds.Tables[0].Rows[0][3].ToString();
                txtLevels.Text= Ds.Tables[0].Rows[0][4].ToString();
                txtStructure.Text = Ds.Tables[0].Rows[0][5].ToString();
                txtDimension.Text=Ds.Tables[0].Rows[0][6].ToString();
                txtPurpose.Text = Ds.Tables[0].Rows[0][7].ToString();
                txtAssets_Amount.Text = Ds.Tables[0].Rows[0][8].ToString();
                txtAssets_Code.Text = Ds.Tables[0].Rows[0][9].ToString();
                txtDevice_Code.Text = Ds.Tables[0].Rows[0][10].ToString();
                txtRegion.Text = Ds.Tables[0].Rows[0][11].ToString();

                string strSQL = $"SELECT Projects.id AS 序号, Projects.Name AS 工程名称, Types.Name AS 工程类型, Detail AS 工程内容, Amount AS 计划金额, Developing_Reply AS 可研批复, Initial_Reply AS 初始批复, Plan_Code AS 计划文号, Begin_Date AS 开工时间, End_Date AS 竣工时间, Tenders.Name AS 中标单位, Progress AS 形象进度, Collect_Tag AS 收集整理, Check_Tag AS 立卷检查, Grade_Tag AS 验收合格, Amount_Order AS 合同金额, Amount_Reality AS 实际发生额, Amount_Pay AS 付款金额, Amount_Arrear AS 欠款金额, Warranty AS 质保金支付时间 FROM Projects LEFT JOIN Tenders ON Tenders.id = Projects.Tenders_id LEFT JOIN Types ON Types.id = Projects.Types_id WHERE Projects.Premises_id = {id}";

                dgvList.DataSource = Class.DB_Works.DataSetCmd(strSQL).Tables[0];
            }
        }
    }
}
