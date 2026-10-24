using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKhachSan.Data
{
    public static class Db
    {
        private static string _workingConnectionString = null;

        public static string ConnectionString
        {
            get
            {
                if (_workingConnectionString != null)
                    return _workingConnectionString;

                if (ConfigurationManager.ConnectionStrings["QuanLyKhachSan"] != null)
                    return ConfigurationManager.ConnectionStrings["QuanLyKhachSan"].ConnectionString;
                return @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyKhachSan;Integrated Security=True;TrustServerCertificate=True";
            }
        }

        public static SqlConnection OpenConnection()
        {
            if (_workingConnectionString != null)
            {
                var cn = new SqlConnection(_workingConnectionString);
                cn.Open();
                return cn;
            }

            string primary = ConnectionString;
            try
            {
                var cn = new SqlConnection(primary);
                cn.Open();
                _workingConnectionString = primary;
                return cn;
            }
            catch
            {
                // Try fallback connection strings (LocalDB or local MSSQLSERVER)
                string[] fallbacks = new string[]
                {
                    @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyKhachSan;Integrated Security=True;TrustServerCertificate=True",
                    @"Data Source=.;Initial Catalog=QuanLyKhachSan;Integrated Security=True;TrustServerCertificate=True",
                    @"Data Source=localhost;Initial Catalog=QuanLyKhachSan;Integrated Security=True;TrustServerCertificate=True",
                    @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True;TrustServerCertificate=True"
                };

                foreach (var fb in fallbacks)
                {
                    if (string.Equals(fb, primary, StringComparison.OrdinalIgnoreCase))
                        continue;

                    try
                    {
                        var cn = new SqlConnection(fb);
                        cn.Open();
                        _workingConnectionString = fb;
                        return cn;
                    }
                    catch
                    {
                        // continue checking next fallback
                    }
                }

                throw; // If all failed, rethrow the original exception
            }
        }

        public static DataTable Query(string sql, params SqlParameter[] ps)
        {
            using (var cn = OpenConnection())
            using (var cmd = new SqlCommand(sql, cn))
            using (var da = new SqlDataAdapter(cmd))
            {
                if (ps != null && ps.Length > 0)
                    cmd.Parameters.AddRange(ps);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static int Execute(string sql, params SqlParameter[] ps)
        {
            using (var cn = OpenConnection())
            using (var cmd = new SqlCommand(sql, cn))
            {
                if (ps != null && ps.Length > 0)
                    cmd.Parameters.AddRange(ps);
                return cmd.ExecuteNonQuery();
            }
        }

        public static object Scalar(string sql, params SqlParameter[] ps)
        {
            using (var cn = OpenConnection())
            using (var cmd = new SqlCommand(sql, cn))
            {
                if (ps != null && ps.Length > 0)
                    cmd.Parameters.AddRange(ps);
                return cmd.ExecuteScalar();
            }
        }
    }
}
