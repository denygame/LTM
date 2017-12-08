using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Server.Controller
{
    public class DataProvider
    {
        private static MySqlConnection conn = new MySqlConnection(DBConnection.getStrConn());

        public static DataTable sqlQuery(string query, object[] bienSoTruyenVao = null)
        {
            DataTable data = new DataTable();
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            if (bienSoTruyenVao != null)
            {
                string[] listBienSo = query.Split(' ');
                int i = 0;
                foreach (string text in listBienSo)
                {
                    if (text.Contains("@"))
                    {
                        comm.Parameters.AddWithValue(text, bienSoTruyenVao[i]);
                        i++;
                    }
                }
            }
            MySqlDataAdapter adapter = new MySqlDataAdapter(comm);
            adapter.Fill(data);
            conn.Close();
            return data;
        }

        //dùng cho insert update 
        public static int sqlExecuteNonQuery(string query, object[] bienSoTruyenVao = null)
        {
            int traVe = -1;
            MySqlCommand comm = new MySqlCommand(query, conn);
            conn.Open();
            if (bienSoTruyenVao != null)
            {
                string[] listBienSo = query.Split(' ');
                int i = 0;
                foreach (string text in listBienSo)
                {
                    if (text.Contains("@"))
                    {
                        comm.Parameters.AddWithValue(text, bienSoTruyenVao[i]);
                        i++;
                    }
                }
            }
            traVe = comm.ExecuteNonQuery();
            conn.Close();
            return traVe;
        }

        //execute trả về object
        public static object sqlExecuteScalar(string query, object[] bienSoTruyenVao = null)
        {
            object traVe = -1;
            MySqlCommand comm = new MySqlCommand(query, conn);
            conn.Open();
            if (bienSoTruyenVao != null)
            {
                string[] listBienSo = query.Split(' ');
                int i = 0;
                foreach (string text in listBienSo)
                {
                    if (text.Contains("@"))
                    {
                        comm.Parameters.AddWithValue(text, bienSoTruyenVao[i]);
                        i++;
                    }
                }
            }
            traVe = comm.ExecuteScalar();
            conn.Close();
            return traVe;
        }

    }
}
