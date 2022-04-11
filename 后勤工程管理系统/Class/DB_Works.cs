using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace 后勤工程管理系统.Class
{
    internal class DB_Works
    {
        public static bool ExecuteCmd(string strSQL)
        {
            try
            {
                MySqlCommand CmdObj = new MySqlCommand(strSQL, AppSetter.Connect);
                AppSetter.Connect.Open();
                CmdObj.ExecuteNonQuery();
                AppSetter.Connect.Close();

                return true;
            }
            catch (Exception Ex)
            {
                Public.Sys_MsgBox(Ex.Message);
                return false;
            }
            finally
            {
                if (AppSetter.Connect.State != ConnectionState.Closed)
                {
                    AppSetter.Connect.Close();
                }
            }
        }

        public static DataSet DataSetCmd(string strSQL)
        {
            try
            {
                DataSet Ds = new DataSet();
                MySqlDataAdapter DaPayType = new MySqlDataAdapter(strSQL, AppSetter.Connect);
                DaPayType.Fill(Ds, "Table");
                AppSetter.Connect.Close();

                return Ds;
            }
            catch (Exception Ex)
            {
                Public.Sys_MsgBox(Ex.Message);
                return null;
            }
            finally
            {
                if (AppSetter.Connect.State != ConnectionState.Closed)
                {
                    AppSetter.Connect.Close();
                }
            }
        }
    }
}
