using System;

namespace 后勤工程管理系统.Class
{
    public class Users_Info
    {
        public int id = 0;
        public string Name = "匿名";
        public string Password = string.Empty;
        public string[] Limits = null;

        public static Users_Info Login(string Name, string Password)
        {
            var obj = new Users_Info();

            var Ds = DB_Works.DataSetCmd($"SELECT id, Name, Password FROM Users WHERE Name = '{Name}' AND Password = '{Password}'");

            if (Ds != null && Ds.Tables[0].Rows.Count > 0)
            {
                obj.id = Convert.ToInt16(Ds.Tables[0].Rows[0][0]);
                obj.Name = Ds.Tables[0].Rows[0][1].ToString();
                obj.Password = Ds.Tables[0].Rows[0][2].ToString();
            }

            if (Name == obj.Name && Password == obj.Password)
            {
                return obj;
            }
            else
            {
                return null;
            }
        }
    }
}
