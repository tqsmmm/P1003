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
    }
}
