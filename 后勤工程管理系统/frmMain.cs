using System;
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
            Text = AppSetter.strApplicationName;

            frmDesktop frm = new frmDesktop
            {
                TopLevel = false
            };
            pal_Main.Controls.Add(frm);
            frm.Show();
        }

        private void 房产信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPremises_List frm = new frmPremises_List
            {
                TopLevel = false
            };
            pal_Main.Controls.Add(frm);
            frm.Show();
        }

        private void 工程信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProjects_List frm = new frmProjects_List
            {
                TopLevel = false
            };
            pal_Main.Controls.Add(frm);
            frm.Show();
        }

        private void 施工单位ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConstructors_List frm = new frmConstructors_List
            {
                TopLevel = false
            };
            pal_Main.Controls.Add(frm);
            frm.Show();
        }

        private void 中标单位ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTenders_List frm = new frmTenders_List
            {
                TopLevel = false
            };
            pal_Main.Controls.Add(frm);
            frm.Show();
        }

        private void 工程结算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettlements_List frm = new frmSettlements_List
            {
                TopLevel = false
            };
            pal_Main.Controls.Add(frm);
            frm.Show();
        }

        private void 工程分包ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPartitions_List frm = new frmPartitions_List
            {
                TopLevel = false
            };
            pal_Main.Controls.Add(frm);
            frm.Show();
        }

        private void 工程类型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTypes_List frm = new frmTypes_List
            {
                TopLevel = false
            };
            pal_Main.Controls.Add(frm);
            frm.Show();
        }

        private void 用户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers_List frm = new frmUsers_List
            {
                TopLevel = false
            };
            pal_Main.Controls.Add(frm);
            frm.Show();
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

        private void 操作日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogs frm = new frmLogs
            {
                TopLevel = false
            };
            pal_Main.Controls.Add(frm);
            frm.Show();
        }

        private void 主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDesktop frm = new frmDesktop
            {
                TopLevel = false
            };
            pal_Main.Controls.Add(frm);
            frm.Show();
        }
    }
}
