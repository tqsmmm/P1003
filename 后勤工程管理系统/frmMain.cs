using System;
using System.Data;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            AppSetter.Current_User = new Class.Users_Info();

            lblApplication.Text = AppSetter.strApplicationName;
            Text = AppSetter.strApplicationName;

            //登录状态
            lblUsers.Text = $"欢迎：{AppSetter.Current_User.Name}";

            if (AppSetter.Current_User.id == 0)
            {
                llbLogin.Text = "登录";
            }
            else
            {
                llbLogin.Text = "登出";
            }

            //构造树状结构
            tvwList.Nodes.Add("主界面");
            TreeNode treeNode = new TreeNode();
            treeNode.Text = "工程类型";
            tvwList.Nodes.Add(treeNode);

            DataSet ds = Class.DB_Works.DataSetCmd("SELECT Name FROM Types");

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                TreeNode treeNode1 = new TreeNode();
                treeNode1.Text = ds.Tables[0].Rows[i][0].ToString();
                treeNode.Nodes.Add(treeNode1);
            }

            tvwList.Nodes.Add("基础数据维护");
            tvwList.Nodes.Add("操作日志");

            tvwList.ExpandAll();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Class.Public.Sys_MsgYN($"是否确定关闭 {AppSetter.strApplicationName} ?"))
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void llbLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();

            if (frm.DialogResult==DialogResult.Yes)
            {
                lblUsers.Text = $"欢迎：{AppSetter.Current_User.Name}";

                if (AppSetter.Current_User.id == 0)
                {
                    llbLogin.Text = "登录";
                }
                else
                {
                    llbLogin.Text = "登出";
                }
            }
        }

        private void tvwList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvwList.SelectedNode.Level == 0)
            {
                switch (tvwList.SelectedNode.Text)
                {
                    case "主界面":
                        frmSearch frm = new frmSearch
                        {
                            TopLevel = false
                        };
                        pal_Main.Controls.Add(frm);
                        frm.Show();
                        break;
                    case "基础数据维护":
                        frmBasic frm1 = new frmBasic
                        {
                            TopLevel = false
                        };
                        pal_Main.Controls.Add(frm1);
                        frm1.Show();
                        break;
                    case "操作日志":
                        frmLogs frm2 = new frmLogs
                        {
                            TopLevel = false
                        };
                        pal_Main.Controls.Add(frm2);
                        frm2.Show();
                        break;
                    case "工程类型":
                        frmDesktop frm3 = new frmDesktop
                        {
                            TopLevel = false
                        };
                        pal_Main.Controls.Add(frm3);
                        frm3.Show();
                        break;
                    default:
                        
                        break;
                }
            }
            else if (tvwList.SelectedNode.Level == 1)
            {
                frmDesktop frm3 = new frmDesktop();
                frm3.cmbTypes.Text = tvwList.SelectedNode.Text;
                frm3.TopLevel = false;
                pal_Main.Controls.Add(frm3);
                frm3.Show();
            }
        }
    }
}
