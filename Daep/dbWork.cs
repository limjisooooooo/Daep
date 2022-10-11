using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Daep
{   
    public static class dbWork
    {
        public static string connStr;
        public static DataSet ds = new DataSet();        
        public static void selectQry(string sql, Dictionary<string, object> pairs, DataTable table)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    if (pairs != null)
                    {
                        foreach (KeyValuePair<string, object> pair in pairs)
                        {
                            adapter.SelectCommand.Parameters.AddWithValue(pair.Key, pair.Value);
                        }
                    }

                    if (table != null)
                    {
                        table.Clear();
                    }
                    adapter.Fill(table);
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("DB 연결에 실패했습니다.");
            }
        }
        public static void selectQry(string sql, Dictionary<string, object> pairs, DataSet ds, string tableName)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    if (pairs != null)
                    {
                        foreach (KeyValuePair<string, object> pair in pairs)
                        {
                            adapter.SelectCommand.Parameters.AddWithValue(pair.Key, pair.Value);
                        }
                    }

                    if (ds.Tables[tableName] != null)
                    {
                        ds.Tables[tableName].Clear();
                    }
                    adapter.Fill(ds, tableName);
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("DB 연결에 실패했습니다.");
            }
        }
        public static int excuteQry(string sql, Dictionary<string, object> pairs)
        {
            int result = 0;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    foreach (KeyValuePair<string, object> pair in pairs)
                    {
                        command.Parameters.AddWithValue(pair.Key, pair.Value);
                    }
                    result = command.ExecuteNonQuery();
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("DB 연결에 실패했습니다.");
            }
            return result;
        }
    }
}
