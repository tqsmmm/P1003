using System;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmSettlements_Info : Form
    {
        public int id = 0;

        public frmSettlements_Info()
        {
            InitializeComponent();

            dtpDateTime.Value = DateTime.Now;

            cmbProjects.DataSource = Class.DB_Works.DataSetCmd($"SELECT id, Name FROM Projects WHERE Types_id IN (SELECT Types_id FROM Limits WHERE Users_id = {AppSetter.Current_User.id})").Tables[0];
            cmbProjects.ValueMember = "id";
            cmbProjects.DisplayMember = "Name";

            cmbProjects.SelectedIndex = -1;
        }

        private void frmSettlements_Info_Load(object sender, EventArgs e)
        {
            if (Text == "修改")
            {
                cmbProjects.Enabled = false;
                cmbDivisions.Enabled = false;
                ckbPartition.Enabled = false;

                var Ds = Class.DB_Works.DataSetCmd($"SELECT Settlements.Partitions, Projects.Name AS Project_Name, Partitions.Constructors_id, Projects.Tenders_id, Projects.Amount_Order AS Project_Amount_Order, Projects.Amount_Reality AS Project_Amount_Reality, Projects.Amount_Pay AS Project_Amount_Pay, Projects.Amount_Arrear AS Project_Amount_Arrear, Partitions.Account AS Partition_Amount, Partitions.Amount_Pay AS Partition_Amount_Pay, Partitions.Amount_Arrear AS Partitions_Amount_Arrear, Settlements.Amount, Settlements.DateTime FROM Settlements LEFT JOIN Projects ON Projects.id = Settlements.Projects_id LEFT JOIN Partitions ON Partitions.id = Settlements.Projects_id WHERE Settlements.id = {id}");

                cmbProjects.Text = Ds.Tables[0].Rows[0][1].ToString();

                ckbPartition.Checked = Convert.ToBoolean(Ds.Tables[0].Rows[0][0]);

                if (ckbPartition.Checked)
                {
                    cmbDivisions.SelectedValue = Ds.Tables[0].Rows[0][2].ToString();
                    txtAmount_Order.Text = Ds.Tables[0].Rows[0][8].ToString();
                    txtAmount_Reality.Text = Ds.Tables[0].Rows[0][8].ToString();
                    txtAmount_Pay.Text = Ds.Tables[0].Rows[0][9].ToString();
                    txtAmount_Arrear.Text = Ds.Tables[0].Rows[0][10].ToString();
                }
                else
                {
                    cmbDivisions.DataSource = Class.DB_Works.DataSetCmd("SELECT id, Name FROM Tenders").Tables[0];
                    cmbDivisions.DisplayMember = "Name";
                    cmbDivisions.ValueMember = "id";

                    cmbDivisions.SelectedValue = Ds.Tables[0].Rows[0][3].ToString();
                    txtAmount_Order.Text = Ds.Tables[0].Rows[0][4].ToString();
                    txtAmount_Reality.Text = Ds.Tables[0].Rows[0][5].ToString();
                    txtAmount_Pay.Text = Ds.Tables[0].Rows[0][6].ToString();
                    txtAmount_Arrear.Text = Ds.Tables[0].Rows[0][7].ToString();
                }

                txtPay.Text = Ds.Tables[0].Rows[0][11].ToString();
                dtpDateTime.Text = Ds.Tables[0].Rows[0][12].ToString();
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (cmbProjects.SelectedIndex == -1)
            {
                Class.Public.Sys_MsgBox("项目名称不能为空！");
                return;
            }

            try
            {
                if (Convert.ToDecimal(txtPay.Text) > Convert.ToDecimal(txtAmount_Arrear.Text))
                {
                    Class.Public.Sys_MsgBox("支付金额不能大于欠款金额！");
                    return;
                }

                if (Convert.ToDecimal(txtPay.Text) > Convert.ToDecimal(txtAmount_Reality.Text))
                {
                    Class.Public.Sys_MsgBox("支付金额不能大于实际发生额！");
                    return;
                }
            }
            catch
            {
                Class.Public.Sys_MsgBox("输入支付金额有误！");
                return;
            }

            if (Text == "新建")
            {
                var result = Class.DB_Works.ExecuteCmd($"INSERT INTO Settlements(Projects_id, Partitions, Amount, Users_id, DateTime) VALUES({cmbProjects.SelectedValue}, {ckbPartition.Checked}, {txtPay.Text}, {AppSetter.Current_User.id}, '{dtpDateTime.Value.ToString("yyyy-MM-dd")}')");

                if (result)
                {
                    Class.DB_Works.ExecuteCmd($"INSERT INTO Logs(Users_id, Type, Detail, DateTime) VALUES({AppSetter.Current_User.id}, '新建', '【新建结算信息】工程名称【{cmbProjects.Text}】，是否分包【{ckbPartition.Checked}】，结算金额【{txtPay.Text}】', NOW())");

                    Class.Public.Sys_MsgBox("新建结算信息成功！");
                    DialogResult = DialogResult.Yes;
                    Close();
                }
            }
            else if (Text == "修改")
            {
                var result = Class.DB_Works.ExecuteCmd($"UPDATE Settlements SET Amount = {txtPay.Text}, DateTime = '{dtpDateTime.Value.ToString("yyyy-MM-dd")}' WHERE id = {id}");

                if (result)
                {
                    Class.DB_Works.ExecuteCmd($"INSERT INTO Logs(Users_id, Type, Detail, DateTime) VALUES({AppSetter.Current_User.id}, '修改', '【修改结算信息】工程名称【{cmbProjects.Text}】，是否分包【{ckbPartition.Checked}】，结算金额【{txtPay.Text}】', NOW())");

                    Class.Public.Sys_MsgBox("修改结算信息成功！");
                    DialogResult = DialogResult.Yes;
                    Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ckbPartition_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPartition.Checked)
            {
                label8.Text = "施工单位：";

                cmbDivisions.DataSource = Class.DB_Works.DataSetCmd($"SELECT Constructors.id, Constructors.Name FROM Partitions LEFT JOIN Constructors ON Constructors.id = Partitions.Constructors_id WHERE Projects_id = {cmbProjects.SelectedValue}").Tables[0];
                cmbDivisions.DisplayMember = "Name";
                cmbDivisions.ValueMember = "id";

                cmbDivisions.Enabled = true;

                if (cmbDivisions.SelectedIndex > -1)
                {
                    var Ds = Class.DB_Works.DataSetCmd($"SELECT Amount, Amount_Pay, Amount_Arrear FROM Partitions WHERE Projects_id = {cmbProjects.SelectedValue} AND Constructors_id = {cmbDivisions.SelectedValue}");

                    txtAmount_Order.Text = Ds.Tables[0].Rows[0][0].ToString();
                    txtAmount_Reality.Text = Ds.Tables[0].Rows[0][0].ToString();
                    txtAmount_Pay.Text = Ds.Tables[0].Rows[0][1].ToString();
                    txtAmount_Arrear.Text = Ds.Tables[0].Rows[0][2].ToString();
                }
            }
            else
            {
                label8.Text = "中标单位：";

                cmbDivisions.DataSource = Class.DB_Works.DataSetCmd("SELECT id, Name FROM Tenders").Tables[0];
                cmbDivisions.DisplayMember = "Name";
                cmbDivisions.ValueMember = "id";

                cmbDivisions.SelectedValue = Class.DB_Works.DataSetCmd($"SELECT Tenders_id FROM Projects WHERE id = {cmbProjects.SelectedValue}").Tables[0].Rows[0][0].ToString();

                cmbDivisions.Enabled = false;

                var Ds = Class.DB_Works.DataSetCmd($"SELECT Amount_Order, Amount_Reality, Amount_Pay, Amount_Arrear FROM Projects WHERE id = {cmbProjects.SelectedValue}");

                txtAmount_Order.Text = Ds.Tables[0].Rows[0][0].ToString();
                txtAmount_Reality.Text = Ds.Tables[0].Rows[0][1].ToString();
                txtAmount_Pay.Text = Ds.Tables[0].Rows[0][2].ToString();
                txtAmount_Arrear.Text = Ds.Tables[0].Rows[0][3].ToString();
            }
        }

        private void cmbProjects_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (ckbPartition.Checked)
            {
                cmbDivisions.DataSource = Class.DB_Works.DataSetCmd($"SELECT Constructors.id, Constructors.Name FROM Partitions LEFT JOIN Constructors ON Constructors.id = Partitions.Constructors_id WHERE Projects_id = {cmbProjects.SelectedValue}").Tables[0];
                cmbDivisions.DisplayMember = "Name";
                cmbDivisions.ValueMember = "id";

                cmbDivisions.Enabled = true;

                if (cmbDivisions.SelectedIndex > -1)
                {
                    var Ds = Class.DB_Works.DataSetCmd($"SELECT Amount, Amount_Pay, Amount_Arrear FROM Partitions WHERE Projects_id = {cmbProjects.SelectedValue} AND Constructors_id = {cmbDivisions.SelectedValue}");

                    txtAmount_Order.Text = Ds.Tables[0].Rows[0][0].ToString();
                    txtAmount_Reality.Text = Ds.Tables[0].Rows[0][0].ToString();
                    txtAmount_Pay.Text = Ds.Tables[0].Rows[0][1].ToString();
                    txtAmount_Arrear.Text = Ds.Tables[0].Rows[0][2].ToString();
                }
            }
            else
            {
                cmbDivisions.DataSource = Class.DB_Works.DataSetCmd("SELECT id, Name FROM Tenders").Tables[0];
                cmbDivisions.DisplayMember = "Name";
                cmbDivisions.ValueMember = "id";

                cmbDivisions.SelectedValue = Class.DB_Works.DataSetCmd($"SELECT Tenders_id FROM Projects WHERE id = {cmbProjects.SelectedValue}").Tables[0].Rows[0][0].ToString();

                cmbDivisions.Enabled = false;

                var Ds = Class.DB_Works.DataSetCmd($"SELECT Amount_Order, Amount_Reality, Amount_Pay, Amount_Arrear FROM Projects WHERE id = {cmbProjects.SelectedValue}");

                txtAmount_Order.Text = Ds.Tables[0].Rows[0][0].ToString();
                txtAmount_Reality.Text = Ds.Tables[0].Rows[0][1].ToString();
                txtAmount_Pay.Text = Ds.Tables[0].Rows[0][2].ToString();
                txtAmount_Arrear.Text = Ds.Tables[0].Rows[0][3].ToString();
            }
        }

        private void cmbDivisions_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (ckbPartition.Checked)
            {
                if (cmbDivisions.SelectedIndex > -1)
                {
                    var Ds = Class.DB_Works.DataSetCmd("SELECT Amount, Amount_Pay, Amount_Arrear FROM Partitions WHERE Projects_id = " + cmbProjects.SelectedValue + " AND Constructors_id = " + cmbDivisions.SelectedValue + "");

                    txtAmount_Order.Text = Ds.Tables[0].Rows[0][0].ToString();
                    txtAmount_Reality.Text = Ds.Tables[0].Rows[0][0].ToString();
                    txtAmount_Pay.Text = Ds.Tables[0].Rows[0][1].ToString();
                    txtAmount_Arrear.Text = Ds.Tables[0].Rows[0][2].ToString();
                }
            }
        }
    }
}
