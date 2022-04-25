using System;
using System.Collections;

namespace 后勤工程管理系统.Class
{
    public class Users_Info
    {
        public int id = 0;
        public string Name = "匿名";
        public string Password = string.Empty;
        public ArrayList Limits = new ArrayList();

        public static Users_Info Login(string Name, string Password)
        {
            var obj = new Users_Info();

            var Ds = DB_Works.DataSetCmd($"SELECT id, Name, Password FROM Users WHERE Name = '{Name}' AND Password = '{Password}'");

            if (Ds != null && Ds.Tables[0].Rows.Count > 0)
            {
                obj.id = Convert.ToInt16(Ds.Tables[0].Rows[0][0]);
                obj.Name = Ds.Tables[0].Rows[0][1].ToString();
                obj.Password = Ds.Tables[0].Rows[0][2].ToString();

                Ds = DB_Works.DataSetCmd($"SELECT Types.Name FROM Limits LEFT JOIN Types ON Limits.Types_id = Types.id");

                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    obj.Limits.Add(Ds.Tables[0].Rows[i][0].ToString());
                }
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
