using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace BookWise
{
    public static class DB
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        private static MySqlParameter[] CreateParameters(string query, object[] values)
        {
            MySqlParameter[] parameters = new MySqlParameter[values.Length];
            string[] paramNames = query.Split(' ');
            int paramIdx = 0;
            for (int i = 0; i < paramNames.Length; i++)
            {
                string word = paramNames[i];
                if (word.StartsWith("@"))
                {
                    parameters[paramIdx] = new MySqlParameter(word, values[paramIdx]);
                    paramIdx++;
                }
                ;
            }

            return parameters;
        }

        public static int ExecuteQuery(string query, params object[] values)
        {
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    MySqlParameter[] parameters = CreateParameters(query, values);
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }


        public static object ExecuteScalar(string query, params object[] values)
        {
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    MySqlParameter[] parameters = CreateParameters(query, values);
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        public static DataTable ExecuteSelect(string query, params object[] values)
        {
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    MySqlParameter[] parameters = CreateParameters(query, values);
                    cmd.Parameters.AddRange(parameters);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}
