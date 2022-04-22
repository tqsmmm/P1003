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
            lblApplication.Text = AppSetter.strApplicationName;
            Text = AppSetter.strApplicationName;

            DataSet ds = Class.DB_Works.DataSetCmd("SELECT Name FROM Types");

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                lbTypes.Items.Add(ds.Tables[0].Rows[i][0]);
            }

            btnMain_Click(this, e);
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

        private void btnMain_Click(object sender, EventArgs e)
        {
            frmSearch frm = new frmSearch
            {
                TopLevel = false
            };
            pal_Main.Controls.Add(frm);
            frm.Show();
        }

        private void btnBasic_Click(object sender, EventArgs e)
        {
            frmBasic frm = new frmBasic
            {
                TopLevel = false
            };
            pal_Main.Controls.Add(frm);
            frm.Show();
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            frmLogs frm = new frmLogs
            {
                TopLevel = false
            };
            pal_Main.Controls.Add(frm);
            frm.Show();
        }
    }
}
