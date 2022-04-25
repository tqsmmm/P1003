using System;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmLogs : Form
    {
        public frmLogs()
        {
            InitializeComponent();

            dgvLogs = Class.Public.SetDataGridViewStyle(dgvLogs);
        }

        private void frmLogs_Load(object sender, EventArgs e)
        {
            btnSearch_Click(this, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strSQL = $"SELECT Logs.id AS 序号, Users.Name AS 用户名, Type AS 操作类型, Detail AS 详情, DateTime AS 操作时间 FROM Logs LEFT JOIN Users ON Users.id = Logs.Users_id WHERE DATE_FORMAT(DateTime, '%Y-%m-%d') = '{dtpDateTime.Value:yyyy-MM-dd}' ";

            if (txtUsers.Text.Trim() != string.Empty || cmbTypes.SelectedIndex != -1)
            {
                strSQL = $"{strSQL} AND ";

                if (txtUsers.Text.Trim() != string.Empty)
                {
                    strSQL = $"{strSQL} Users.Name = '{txtUsers.Text}' AND ";
                }

                if (cmbTypes.SelectedIndex != -1)
                {
                    strSQL = $"{strSQL} Type = '{cmbTypes.Text}' AND ";
                }

                strSQL = strSQL.Substring(0, strSQL.Length - 4);
            }

            dgvLogs.DataSource = Class.DB_Works.DataSetCmd(strSQL).Tables[0];
        }
    }
}
