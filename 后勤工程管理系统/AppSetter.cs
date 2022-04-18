using MySql.Data.MySqlClient;
using System.Configuration;

namespace 后勤工程管理系统
{
    internal class AppSetter
    {
        public static string strApplicationName = "后勤工程管理系统";

        public static string strConnect = ConfigurationManager.ConnectionStrings["MySqlConn"].ConnectionString;

        public static MySqlConnection Connect = new MySqlConnection(strConnect);

        public static Class.Users_Info Current_User = null;
    }
}
