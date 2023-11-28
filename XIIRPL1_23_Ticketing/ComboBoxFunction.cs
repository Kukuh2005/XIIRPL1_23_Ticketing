using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace XIIRPL1_23_Ticketing
{
    class ComboBoxFunction
    {
        static NpgsqlConnection conn;
        static NpgsqlDataReader reader;
        static NpgsqlDataAdapter adapter;
        static DataTable dt;
        static NpgsqlCommand cmd;

        public static void Set_ComboBox(string Query, string row, ComboBox box)
        {
            try
            {
                conn = koneksi.conn;
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand(Query, conn);
                reader = command.ExecuteReader();
                box.Items.Clear();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        box.Items.Add(reader[row]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(reader != null)
                    reader.Close();
                conn.Close();
            }
        }

        public DataTable getData(string sql)
        {
            conn = koneksi.conn;
            try
            {
                adapter = new NpgsqlDataAdapter();
                dt = new DataTable();
                cmd = new NpgsqlCommand(sql, conn);
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                return dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public string getValue(string sql, string col)
        {
            string value = "";
            conn = koneksi.conn;
            try
            {
                cmd = new NpgsqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                reader.Read();

                value = reader.GetValue(reader.GetOrdinal(col)).ToString();
                return value;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
