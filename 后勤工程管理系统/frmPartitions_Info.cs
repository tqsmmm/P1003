using System;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmPartitions_Info : Form
    {
        public int id = 0;

        public frmPartitions_Info()
        {
            InitializeComponent();

            cmbProjects.DataSource = Class.DB_Works.DataSetCmd($"SELECT id, Name FROM Projects WHERE Types_id IN (SELECT Types_id FROM Limits WHERE Users_id = {AppSetter.Current_User.id})").Tables[0];
            cmbProjects.ValueMember = "id";
            cmbProjects.DisplayMember = "Name";

            cmbProjects.SelectedIndex = -1;

            cmbConstructors.DataSource = Class.DB_Works.DataSetCmd("SELECT id, Name FROM Constructors").Tables[0];
            cmbConstructors.ValueMember = "id";
            cmbConstructors.DisplayMember = "Name";

            cmbConstructors.SelectedIndex = -1;
        }

        private void frmPartitions_Info_Load(object sender, EventArgs e)
        {
            if (Text == "修改")
            {
                var Ds = Class.DB_Works.DataSetCmd($"SELECT Projects_id, Constructors_id, Amount, Amount_Arrear, Amount_Pay, Management, Account FROM Partitions WHERE id = {id}");

                cmbProjects.SelectedValue = Ds.Tables[0].Rows[0][0].ToString();
                cmbConstructors.SelectedValue = Ds.Tables[0].Rows[0][1].ToString();
                txtAmount.Text = Ds.Tables[0].Rows[0][2].ToString();
                txtAmount_Arear.Text = Ds.Tables[0].Rows[0][3].ToString();
                txtAmount_Pay.Text = Ds.Tables[0].Rows[0][4].ToString();
                txtManagement.Text = Ds.Tables[0].Rows[0][5].ToString();

                if (Convert.ToBoolean(Ds.Tables[0].Rows[0][6]))
                {
                    rbnAccount_True.Checked = true;
                }
                else
                {
                    rbnAccount_False.Checked = true;
                }
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (cmbProjects.SelectedIndex == -1)
            {
                Class.Public.Sys_MsgBox("工程名称选择不能为空！");
                return;
            }

            if (cmbConstructors.SelectedIndex == -1)
            {
                Class.Public.Sys_MsgBox("施工单位不能不为空！");
                return;
            }

            bool bAccount = false;

            if (rbnAccount_True.Checked)
            {
                bAccount = true;
            }
            else
            {
                bAccount = false;
            }

            if (Text == "新建")
            {
                var result = Class.DB_Works.ExecuteCmd($"INSERT INTO Partitions(Projects_id, Constructors_id, Amount, Amount_Arrear, Amount_Pay, Management, Account, Users_id, DateTime) VALUES({cmbProjects.SelectedValue}, {cmbConstructors.SelectedValue}, {txtAmount.Text}, {txtAmount_Arear.Text}, {txtAmount_Pay.Text}, {txtManagement.Text},{bAccount}, {AppSetter.Current_User.id}, NOW())");

                if (result)
                {
                    Class.DB_Works.ExecuteCmd($"INSERT INTO Logs(Users_id, Type, Detail, DateTime) VALUES({AppSetter.Current_User.id}, '新建', '【新建分包信息】工程名称【{cmbProjects.Text}】，施工单位【{cmbConstructors.Text}】，分包金额【{txtAmount.Text}】', NOW())");

                    Class.Public.Sys_MsgBox("新建分包信息成功！");
                    DialogResult = DialogResult.Yes;
                    Close();
                }
            }
            else if (Text == "修改")
            {
                var result = Class.DB_Works.ExecuteCmd($"UPDATE Partitions SET Projects_id = {cmbProjects.SelectedValue}, Constructors_id = {cmbConstructors.SelectedValue}, Amount = {txtAmount.Text}, Amount_Arrear = {txtAmount_Arear.Text}, Amount_Pay = {txtAmount_Pay.Text}, Management = {txtManagement.Text}, Account = {bAccount} WHERE id = {id}");

                if (result)
                {
                    Class.DB_Works.ExecuteCmd($"INSERT INTO Logs(Users_id, Type, Detail, DateTime) VALUES({AppSetter.Current_User.id}, '修改', '【修改分包信息】工程名称【{cmbProjects.Text}】，施工单位【{cmbConstructors.Text}】，分包金额【{txtAmount.Text}】', NOW())");

                    Class.Public.Sys_MsgBox("修改分包信息成功！");
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
