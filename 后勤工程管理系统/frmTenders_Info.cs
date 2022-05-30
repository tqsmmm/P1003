using System;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmTenders_Info : Form
    {
        public int id = 0;

        public frmTenders_Info()
        {
            InitializeComponent();
        }

        private void frmTenders_Info_Load(object sender, EventArgs e)
        {
            if (Text == "修改")
            {
                var Ds = Class.DB_Works.DataSetCmd($"SELECT Name, Manager, Contact FROM Tenders WHERE id = {id}");

                txtName.Text = Ds.Tables[0].Rows[0][0].ToString();
                txtManager.Text = Ds.Tables[0].Rows[0][1].ToString();
                txtContact.Text = Ds.Tables[0].Rows[0][2].ToString();
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                Class.Public.Sys_MsgBox("中标单位名称不能为空！");
                return;
            }

            if (Text == "新建")
            {
                if (Class.DB_Works.DataSetCmd($"SELECT id FROM Tenders WHERE Name = '{txtName.Text}'").Tables[0].Rows.Count > 0)
                {
                    Class.Public.Sys_MsgBox("中标单位名称重复！");
                    return;
                }

                var result = Class.DB_Works.ExecuteCmd($"INSERT INTO Tenders(Name, Manager, Contact) VALUES('{txtName.Text}', '{txtManager.Text}', '{txtContact.Text}')");

                if (result)
                {
                    Class.Public.Sys_MsgBox("新建中标单位信息成功！");
                    DialogResult = DialogResult.Yes;
                    Close();
                }
            }
            else if (Text == "修改")
            {
                var result = Class.DB_Works.ExecuteCmd($"UPDATE Tenders SET Name = '{txtName.Text}', Manager = '{txtManager.Text}', Contact = '{txtContact.Text}' WHERE id = {id}");

                if (result)
                {
                    Class.Public.Sys_MsgBox("修改中标单位信息成功！");
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
