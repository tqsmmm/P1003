using System;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmProjects_Info : Form
    {
        public int id = 0;

        public frmProjects_Info()
        {
            InitializeComponent();

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
            if (Text == "修改")
            {
                var Ds = Class.DB_Works.DataSetCmd($"SELECT Name, Types_id, Detail, Amount, Developing_Reply, Initial_Reply, Plan_Code, Begin_Date, End_Date, Tenders_id, Progress, Collect_Tag, Check_Tag, Grade_Tag, Amount_Order, Amount_Reality, Amount_Pay, Amount_Arrear, Warranty FROM Projects WHERE id = {id}");

                txtName.Text = Ds.Tables[0].Rows[0][0].ToString();
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
                txtAmount_Order.Text = Ds.Tables[0].Rows[0][14].ToString();
                txtAmount_Reality.Text = Ds.Tables[0].Rows[0][15].ToString();
                txtAmount_Pay.Text = Ds.Tables[0].Rows[0][16].ToString();
                txtAmount_Arrear.Text = Ds.Tables[0].Rows[0][17].ToString();
                dtpWarranty.Value = Convert.ToDateTime(Ds.Tables[0].Rows[0][18]);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == string.Empty)
            {
                Class.Public.Sys_MsgBox("工程名称不能为空！");
                return;
            }

            if (Text == "新建")
            {
                if (Class.DB_Works.DataSetCmd($"SELECT id FROM Projects WHERE Name = '{txtName.Text}' AND (DATE_ADD(Begin_Date, INTERVAL 1 YEAR) > NOW() OR DATE_ADD(End_Date, INTERVAL 1 YEAR) > NOW())").Tables[0].Rows.Count > 0)
                {
                    Class.Public.Sys_MsgBox("工程项目名称一年内不可重复！");
                    return;
                }

                var result = Class.DB_Works.ExecuteCmd($"INSERT INTO Projects(Name, Types_id, Detail, Amount, Developing_Reply, Initial_Reply, Plan_Code, Begin_Date, End_Date, Tenders_id, Progress, Collect_Tag, Check_Tag, Grade_Tag, Amount_Order, Amount_Reality, Warranty, Users_id, DateTime) VALUES('{txtName.Text}', {cmbTypes.SelectedValue}, '{txtDetail.Text}', {txtAmount.Text}, '{txtDeveloping_Reply.Text}', '{txtInitial_Reply.Text}', '{txtPlan_Code.Text}', '{dtpBegin_Date.Value}', '{dtpEnd_Date.Value}', {cmbTenders.SelectedValue}, '{txtProgress.Text}', '{cmbCollect_Tag.Text}', '{cmbCheck_Tag.Text}', '{cmbGrade_Tag.Text}', {txtAmount_Order.Text}, {txtAmount_Reality.Text}, '{dtpWarranty.Value.ToString("yyyy-MM-dd")}', {AppSetter.Current_User.id}, NOW())");

                if (result)
                {
                    Class.DB_Works.ExecuteCmd($"INSERT INTO Logs(Users_id, Type, Detail, DateTime) VALUES({AppSetter.Current_User.id}, '新建', '【新建工程信息】工程名称【{txtName.Text}】，工程类型【{cmbTypes.Text}】，计划金额【{txtAmount.Text}】', NOW())");

                    Class.Public.Sys_MsgBox("新建工程信息成功！");
                    DialogResult = DialogResult.Yes;
                    Close();
                }
            }
            else if (Text == "修改")
            {
                var result = Class.DB_Works.ExecuteCmd($"UPDATE Projects SET Name = '{txtName.Text}', Types_id = {cmbTypes.SelectedValue}, Detail = '{txtDetail.Text}', Amount = {txtAmount.Text}, Developing_Reply = '{txtDeveloping_Reply.Text}', Initial_Reply = '{txtInitial_Reply.Text}', Plan_Code = '{txtPlan_Code.Text}', Begin_Date = '{dtpBegin_Date.Value}', End_Date = '{dtpEnd_Date.Value}', Tenders_id = {cmbTenders.SelectedValue}, Progress = '{txtProgress.Text}', Collect_Tag = '{cmbCollect_Tag.Text}', Check_Tag = '{cmbCheck_Tag.Text}', Grade_Tag = '{cmbGrade_Tag.Text}', Amount_Order = {txtAmount_Order.Text}, Amount_Reality = {txtAmount_Reality.Text}, Warranty = '{dtpWarranty.Value.ToString("yyyy-MM-dd")}' WHERE id = {id}");

                if (result)
                {
                    Class.DB_Works.ExecuteCmd($"INSERT INTO Logs(Users_id, Type, Detail, DateTime) VALUES({AppSetter.Current_User.id}, '修改', '【修改工程信息】工程名称【{txtName.Text}】，工程类型【{cmbTypes.Text}】，计划金额【{txtAmount.Text}】', NOW())");

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
