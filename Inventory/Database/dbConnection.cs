using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Database
{
    public abstract class dbConnection
    {
        protected static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-NITRO;Initial Catalog=Inventory;Integrated Security=True;Max Pool Size=10000;");
            conn.Open();
            return conn;
        }
        protected static SqlConnection GetConnectionClose()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-NITRO;Initial Catalog=Inventory;Integrated Security=True;Max Pool Size=10000;");
            conn.Close();
            return conn;
        }
        public static void BindParameters(SqlCommand _cmd, params object[] parameters)
        {
            SqlCommand cmd = _cmd;
            cmd.Parameters.Clear();
            for (int i = 0; i < parameters.Length; i++)
            {
                cmd.Parameters.AddWithValue("@p" + (i + 1), parameters[i]);
            }
        }
        public static SqlCommand CreateCommand(string query)
        {
            return new SqlCommand(query, GetConnection());
        }
        public static bool IsExist(string table, string column, object value)
        {
            bool result = false;
            using (var cmd = CreateCommand("SELECT COUNT(*) FROM " + table + " WHERE " + column + " = @p1"))
            {
                BindParameters(cmd, value);
                GetConnection();
                result = int.Parse(cmd.ExecuteScalar().ToString()) > 0;
                GetConnectionClose();
            }
            return result;
        }
    }
}
