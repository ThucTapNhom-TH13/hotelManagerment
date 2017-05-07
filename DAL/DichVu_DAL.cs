using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class DichVu_DAL
    {
        public static DataTable DichVu_getAll()
        {
            SqlConnection conn = SqlConnect.Connect();
            SqlCommand command = new SqlCommand("XEM_THAM_GIA", conn);
            command.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static bool DichVu_update(DichVu dichvu)
        {
            SqlConnection connection = SqlConnect.Connect();
            connection.Open();
            SqlCommand cmd = new SqlCommand("DichVu_update", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@madv", dichvu.Madv));
            cmd.Parameters.Add(new SqlParameter("@tendv", dichvu.Tendv));
            cmd.Parameters.Add(new SqlParameter("@soluong", dichvu.Soluong));
            cmd.Parameters.Add(new SqlParameter("@gia", dichvu.Gia));
            int msg = cmd.ExecuteNonQuery();
            if (msg > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DichVu_add(DichVu dichvu)
        {
            SqlConnection connection = SqlConnect.Connect();
            connection.Open();
            SqlCommand cmd = new SqlCommand("DichVu_add", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@tendv", dichvu.Tendv));
            cmd.Parameters.Add(new SqlParameter("@soluong", dichvu.Soluong));
            cmd.Parameters.Add(new SqlParameter("@gia", dichvu.Gia));
            int msg = cmd.ExecuteNonQuery();
            if (msg > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
