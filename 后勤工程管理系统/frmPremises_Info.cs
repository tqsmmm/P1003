using System;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmPremises_Info : Form
    {
        public frmPremises_Info()
        {
            InitializeComponent();
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
            if (Text == "修改")
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
            }
        }
    }
}
