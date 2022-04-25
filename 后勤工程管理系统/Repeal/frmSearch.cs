using System;
using System.Data;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            DataSet Ds = Class.DB_Works.DataSetCmd("SELECT Name FROM Types");

            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                clbProjects_Types.Items.Add(Ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (Control item in tableLayoutPanel1.Controls)
            {
                if (item is CheckBox)
                {
                    var comm = item as CheckBox;
                    comm.Checked = true;
                }
            }
        }

        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            foreach (Control item in tableLayoutPanel1.Controls)
            {
                if (item is CheckBox)
                {
                    var comm = item as CheckBox;
                    comm.Checked = false;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmDesktop frm = new frmDesktop
            {
                TopLevel = false
            };

            
        }
    }
}
