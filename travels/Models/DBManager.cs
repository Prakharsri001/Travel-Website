using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace travels.Models
{
    public class DBManager
    {
        SqlConnection con = new SqlConnection("Data Source=PRAKHAR-PC1\\SQLEXPRESS;Initial Catalog=travels;Integrated Security=True");
        
      

        public bool MyInsertUpdateDelete(string command)
        {
            SqlCommand cmd = new SqlCommand(command, con);
            con.Open();
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                con.Close();
                return true;
            }
            else { 
                con.Close();
                return false;
            }
        }
        public DataTable GetAllRecord(string command)
        {
            con.Open();
           DataTable dt = new DataTable();
            SqlDataAdapter sa = new SqlDataAdapter(command, con);
            sa.Fill(dt);
            return dt;


        }

        public DataTable DisplayAllRecord(string command)
        {
        DataTable dt = new DataTable();
            SqlDataAdapter sa = new SqlDataAdapter(command, con);
            sa.Fill(dt);
            return dt;
        }
    }
}