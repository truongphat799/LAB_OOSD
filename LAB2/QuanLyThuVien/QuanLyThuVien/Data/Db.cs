using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien.Data
{
    public static class Db
    {
        public static string ConnectionString
        {
            get
            {
                var setting = ConfigurationManager.ConnectionStrings["QuanLyThuVien"];
                return setting != null ? setting.ConnectionString : @"Data Source=.;Initial Catalog=QuanLyThuVien;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=True";
            }
        }

        public static SqlConnection OpenConnection()
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConnectionString);
                cn.Open();
                return cn;
            }
            catch
            {
                // Fallback to (localdb)\MSSQLLocalDB or . if initial config fails
                string fallback = ConnectionString.Contains("(localdb)") || ConnectionString.Contains("(LocalDB)")
                    ? @"Data Source=.;Initial Catalog=QuanLyThuVien;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=True"
                    : @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyThuVien;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=True";
                SqlConnection fallbackCn = new SqlConnection(fallback);
                fallbackCn.Open();
                return fallbackCn;
            }
        }

        public static DataTable Query(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection cn = OpenConnection())
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);
                DataTable table = new DataTable();
                da.Fill(table);
                return table;
            }
        }

        public static int Execute(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection cn = OpenConnection())
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteNonQuery();
            }
        }

        public static object Scalar(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection cn = OpenConnection())
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteScalar();
            }
        }
    }
}
