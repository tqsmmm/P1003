using System;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Text = AppSetter.strApplicationName;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var obj = Class.Users_Info.Login(txtName.Text, txtPassword.Text);

            if (obj != null)
            {
                AppSetter.Current_User = obj;

                Class.DB_Works.ExecuteCmd($"INSERT INTO Logs(Users_id, Type, Detail, DateTime) VALUES({AppSetter.Current_User.id}, '登录', '【登录信息】{AppSetter.Current_User.Name}', NOW())");

                DialogResult = DialogResult.Yes;
                Close();
            }
            else
            {
                Class.Public.Sys_MsgBox("用户名或密码错误！");
            }
        }
    }
}
