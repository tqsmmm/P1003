using System;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmUsers_Info : Form
    {
        public int id = 0;

        public frmUsers_Info()
        {
            InitializeComponent();
        }

        private void frmUsers_Info_Load(object sender, EventArgs e)
        {
            if (Text == "修改")
            {
                var Ds = Class.DB_Works.DataSetCmd($"SELECT Name, Password FROM Users WHERE id = {id}");

                txtName.Text = Ds.Tables[0].Rows[0][0].ToString();
                txtPassword.Text = Ds.Tables[0].Rows[0][1].ToString();
                txtVerify.Text = Ds.Tables[0].Rows[0][1].ToString();

                Ds = Class.DB_Works.DataSetCmd($"SELECT Types.id, Types.Name, CASE WHEN Types_id IS NULL THEN 0 ELSE 1 END AS 'Limits' FROM Types LEFT JOIN Limits ON Limits.Types_id = Types.id AND Limits.Users_id = {id}");

                for (int i = 0; Ds.Tables[0].Rows.Count > i; i++)
                {
                    clbLimits.Items.Add(Ds.Tables[0].Rows[i][1].ToString(), Convert.ToBoolean(Ds.Tables[0].Rows[i][2]));
                }
            }
            else
            {
                var Ds = Class.DB_Works.DataSetCmd("SELECT id, Name FROM Types");

                for (int i = 0; Ds.Tables[0].Rows.Count > i; i++)
                {
                    clbLimits.Items.Add(Ds.Tables[0].Rows[i][1].ToString());
                }
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                Class.Public.Sys_MsgBox("用户名不允许为空！");
                return;
            }

            if (txtPassword.Text != txtVerify.Text)
            {
                Class.Public.Sys_MsgBox("密码验证不一致！");
                return;
            }

            if (Text == "新建")
            {
                if (Class.DB_Works.DataSetCmd($"SELECT id FROM Users WHERE Name = '{txtName.Text}'").Tables[0].Rows.Count > 0)
                {
                    Class.Public.Sys_MsgBox("用户名重复！");
                    return;
                }

                var result = Class.DB_Works.ExecuteCmd($"INSERT INTO Users(Name, Password) VALUES('{txtName.Text}', '{txtPassword.Text}')");

                if (result)
                {
                    if (clbLimits.CheckedItems.Count > 0)
                    {
                        id = Convert.ToInt16(Class.DB_Works.DataSetCmd($"SELECT id FROM Users WHERE Name = '{txtName.Text}' AND Password = '{txtPassword.Text}'").Tables[0].Rows[0][0]);

                        for (int i = 0; i < clbLimits.CheckedItems.Count; i++)
                        {
                            int Types_id = Convert.ToInt16(Class.DB_Works.DataSetCmd($"SELECT id FROM Types WHERE Name = '{clbLimits.CheckedItems[i]}'").Tables[0].Rows[0][0]);
                            Class.DB_Works.ExecuteCmd($"INSERT INTO Limits(Users_id, Types_id) VALUES({id}, {Types_id})");
                        }
                    }

                    Class.Public.Sys_MsgBox("新建用户信息成功！");
                    DialogResult = DialogResult.Yes;
                    Close();
                }
            }
            else if (Text == "修改")
            {
                var result = Class.DB_Works.ExecuteCmd($"UPDATE Users SET Name = '{txtName.Text}', Password = '{txtPassword.Text}' WHERE id = {id}");

                if (result)
                {
                    if (clbLimits.CheckedItems.Count > 0)
                    {
                        Class.DB_Works.ExecuteCmd($"DELETE FROM Limits WHERE Users_id = {id}");

                        for (int i = 0; i < clbLimits.CheckedItems.Count; i++)
                        {
                            int Types_id = Convert.ToInt16(Class.DB_Works.DataSetCmd($"SELECT id FROM Types WHERE Name = '{clbLimits.CheckedItems[i]}'").Tables[0].Rows[0][0]);
                            Class.DB_Works.ExecuteCmd($"INSERT INTO Limits(Users_id, Types_id) VALUES({id}, {Types_id})");
                        }
                    }

                    Class.Public.Sys_MsgBox("修改用户信息成功！");
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
