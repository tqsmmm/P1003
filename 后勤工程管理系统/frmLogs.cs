using System;
using System.Windows.Forms;

namespace 后勤工程管理系统
{
    public partial class frmLogs : Form
    {
        public frmLogs()
        {
            InitializeComponent();

            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;

            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;

            dgvLogs.AllowUserToAddRows = false;
            dgvLogs.AllowUserToDeleteRows = false;
            dgvLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvLogs.BackgroundColor = System.Drawing.Color.White;
            dgvLogs.BorderStyle = BorderStyle.Fixed3D;
            dgvLogs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogs.EnableHeadersVisualStyles = false;
            dgvLogs.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dgvLogs.ReadOnly = true;
            dgvLogs.RowHeadersVisible = false;
            dgvLogs.RowTemplate.Height = 23;
            dgvLogs.RowTemplate.ReadOnly = true;
            dgvLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void frmLogs_Load(object sender, EventArgs e)
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
