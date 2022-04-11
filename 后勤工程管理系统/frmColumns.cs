using System;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmColumns : Form
    {
        public frmColumns()
        {
            InitializeComponent();
        }

        private void frmColumns_Load(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (lbxSelected.SelectedItems.Count>0)
            {
                lbxList.Items.Add(lbxSelected.SelectedItems[0].ToString());
                lbxSelected.Items.Remove(lbxSelected.SelectedItem);
            }
        }

        private void btnSubtracts_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbxSelected.Items.Count; i++)
            {
                lbxList.Items.Add(lbxSelected.Items[i].ToString());
            }

            lbxSelected.Items.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lbxList.SelectedItems.Count > 0)
            {
                lbxSelected.Items.Add(lbxList.SelectedItems[0].ToString());
                lbxList.Items.Remove(lbxList.SelectedItem);
            }
        }

        private void btnAdds_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbxList.Items.Count; i++)
            {
                lbxSelected.Items.Add(lbxList.Items[i].ToString());
            }

            lbxList.Items.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
