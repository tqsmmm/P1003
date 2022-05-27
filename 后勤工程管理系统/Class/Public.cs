using System.Text.RegularExpressions;
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

        public static bool IsNumber(string number)
        {
            Regex regex = new Regex(@"^-?\d+$|^(-?\d+)(\.\d+)?$");

            return regex.IsMatch(number);
        }

        public static string Sys_OpenExcelFile()
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "excel文件(*.xlsx,*.xls)|*.xlsx;*.xls"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return ofd.FileName;
            }
            else
            {
                return null;
            }
        }

        public static string Sys_SaveExcelFile()
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Excel表格（*.xlsx）|*.xlsx",
                FilterIndex = 1,
                RestoreDirectory = true
            };

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
            Dgv.AllowUserToAddRows = false;
            Dgv.AllowUserToDeleteRows = false;
            Dgv.ColumnHeadersHeight = 30;
            Dgv.RowTemplate.Height = 30;

            return Dgv;
        }
    }
}
