using System;
using System.Data;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmModels : Form
    {
        public string Types = string.Empty;

        public frmModels()
        {
            InitializeComponent();
        }

        private void frmModels_Load(object sender, EventArgs e)
        {
            if (Text == "导入模版")
            {
                label1.Visible = false;
                txtName.Visible = false;
            }

            DataSet Ds = Class.DB_Works.DataSetCmd($"SELECT DISTINCT Name FROM Models WHERE Types = '{Types}'");

            for (int i = 0; i < Ds.Tables[0].Rows.Count;i++)
            {
                lbxList.Items.Add(Ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
