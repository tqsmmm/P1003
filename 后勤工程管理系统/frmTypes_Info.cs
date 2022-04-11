using System;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmTypes_Info : Form
    {
        public int id = 0;

        public frmTypes_Info()
        {
            InitializeComponent();
        }

        private void frmTypes_Info_Load(object sender, EventArgs e)
        {
            if (Text == "修改")
            {
                var Ds = Class.DB_Works.DataSetCmd($"SELECT Name FROM Types WHERE id = {id}");

                txtName.Text = Ds.Tables[0].Rows[0][0].ToString();
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == string.Empty)
            {
                Class.Public.Sys_MsgBox("类型名称不能为空！");
                return;
            }

            if (Text == "新建")
            {
                if (Class.DB_Works.DataSetCmd($"SELECT id FROM Types WHERE Name = '{txtName.Text}'").Tables[0].Rows.Count > 0)
                {
                    Class.Public.Sys_MsgBox("工程类型名称重复！");
                    return;
                }

                var result = Class.DB_Works.ExecuteCmd($"INSERT INTO Types(Name) VALUES('{txtName.Text}')");

                if (result)
                {
                    Class.Public.Sys_MsgBox("新建工程类型成功！");
                    DialogResult = DialogResult.Yes;
                    Close();
                }
            }
            else if (Text == "修改")
            {
                var result = Class.DB_Works.ExecuteCmd($"UPDATE Types SET Name = '{txtName.Text}' WHERE id = {id}");

                if (result)
                {
                    Class.Public.Sys_MsgBox("修改工程类型成功！");
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
