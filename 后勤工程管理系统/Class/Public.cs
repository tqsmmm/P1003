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
    }
}
