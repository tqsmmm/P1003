using System.Drawing;
using System.Windows.Forms;

namespace 后勤工程管理系统.Class
{
    internal class Public
    {
        public static void Sys_MsgBox(string strMsg)
        {
            MessageBox.Show(strMsg, AppSetter.strApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool Sys_MsgYN(string strMsg)
        {
            if (MessageBox.Show(strMsg, AppSetter.strApplicationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string Sys_OpenExcelFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "excel文件(*.xlsx,*.xls)|*.xlsx;*.xls";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return ofd.FileName;
            }
            else
            {
                //MessageBox.Show("返回文件路径失败");
                return null;
            }
        }

        public static string Sys_SaveExcelFile()
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Excel表格（*.xlsx）|*.xlsx";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                return sfd.FileName;
            }
            else
            {
                return null;
            }
        }

        public static DataGridView SetDataGridViewStyle(DataGridView Dgv)
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle
            {
                BackColor = Color.LightCyan
            };

            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter,//211, 223, 240
                BackColor = Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240))))),
                Font = new Font("微软雅黑", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134))),
                ForeColor = Color.Navy,
                SelectionBackColor = SystemColors.Highlight,
                SelectionForeColor = SystemColors.HighlightText
            };

            Dgv.AllowUserToAddRows = false;
            Dgv.AllowUserToDeleteRows = false;
            Dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            Dgv.BackgroundColor = Color.White;
            Dgv.BorderStyle = BorderStyle.Fixed3D;
            Dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            Dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            Dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv.EnableHeadersVisualStyles = false;
            Dgv.GridColor = SystemColors.GradientInactiveCaption;
            Dgv.ReadOnly = true;
            Dgv.RowHeadersVisible = false;
            Dgv.RowTemplate.Height = 23;
            Dgv.RowTemplate.ReadOnly = true;
            Dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            return Dgv;
        }
    }
}
