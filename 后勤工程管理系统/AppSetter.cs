using MySql.Data.MySqlClient;

namespace 后勤工程管理系统
{
    internal class AppSetter
    {
        public static string strApplicationName = "后勤工程管理系统";

        public static string strConnect = "server=127.0.0.1; user id=root; password=LongXiu3; database=hq_mana;";

        public static MySqlConnection Connect = new MySqlConnection(strConnect);

        public static Class.Users_Info Current_User = null;
    }
}
