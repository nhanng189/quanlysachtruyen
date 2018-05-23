using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLopVe.DAO
{
    class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider(); return instance;
            }
            private set
            {
                DataProvider.instance = value;
            }
        }

        private DataProvider() { }

        private string connectStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLiSachTruyen1;Integrated Security=True";

        public DataTable ExcuteQuery(string query, object[] param = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (param != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public int ExcuteNonQuery(string query, object[] param = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (param != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }
    }
}
