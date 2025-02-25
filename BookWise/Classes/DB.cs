using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace BookWise.Classes
{
    public static class DB
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        private static SqlParameter[] CreateParameters(string query, object[] values)
        {
            SqlParameter[] parameters = new SqlParameter[values.Length];
            string[] paramNames = query.Split(' ');
            int paramIdx = 0;
            for(int i=0;i< paramNames.Length;i++)
            {
                string word = paramNames[i];
                if (word.StartsWith("@")) {
                    parameters[paramIdx] = new SqlParameter(word, values[paramIdx]);
                    paramIdx++;
                };
            }

            return parameters;
        }

        public static int ExecuteQuery(string query, params object[] values)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlParameter[] parameters = CreateParameters(query, values);
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    return cmd.ExecuteNonQuery(); 
                }
            }
        }


        public static object ExecuteScalar(string query, params object[] values)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlParameter[] parameters = CreateParameters(query, values);
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        public static DataTable ExecuteSelect(string query, params object[] values)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlParameter[] parameters = CreateParameters(query, values);
                    cmd.Parameters.AddRange(parameters);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
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
