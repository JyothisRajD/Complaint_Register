using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace application_nest.DAL
{
    public class Query_DAL
    {
            public SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            public Query_DAL()
            {
                string conn = ConfigurationManager.ConnectionStrings["bro"].ConnectionString;
                con = new SqlConnection(conn);
                cmd.Connection = con;
            }
            public SqlConnection Getcon()
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                return con;
            }
            public int InsertQuerys(BAL.Query_BAL querybal)
            {
                string q = "INSERT INTO query values('" + querybal.Query + "',' ','" + querybal.ProductId + "','" + querybal.UserId + "')";
                SqlCommand cmd = new SqlCommand(q, Getcon());
                return cmd.ExecuteNonQuery();
            }

            public DataTable ViewAllQuerys()
            {
                string qry = "SELECT l.username,p.*,q.* FROM query q INNER JOIN login l ON l.user_id= q.user_id INNER JOIN product p ON p.p_Id = q.p_id";
                SqlCommand cmd = new SqlCommand(qry, Getcon());
                DataTable dt = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dt);
                return dt;
            }

            public DataTable ViewSpecificQueryDetails(BAL.Query_BAL querybal)
            {
                string qry = "SELECT l.username,p.*,q.* FROM query q INNER JOIN login l ON l.user_id= q.user_id INNER JOIN product p ON p.p_Id = q.p_id WHERE q.qry_Id='" + querybal.QueryId + "'";
                SqlCommand cmd = new SqlCommand(qry, Getcon());
                DataTable dt = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dt);
                return dt;
            }
        

            public DataTable UserViewSpecificQueryDetails(BAL.Query_BAL querybal)
        {
            string qry = "SELECT l.username,p.*,q.* FROM query q INNER JOIN login l ON l.user_id= q.user_id INNER JOIN product p ON p.p_Id = q.p_id WHERE q.user_id='" + querybal.UserId + "'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            return dt;
        }

        public int GiveReplyDetails(BAL.Query_BAL querybal)
            {
                string qry = "UPDATE  query SET reply = '" + querybal.QueryReply + "' where qry_Id = '" + querybal.QueryId + "'";
                SqlCommand cmd = new SqlCommand(qry, Getcon());
                return cmd.ExecuteNonQuery();
            }

        public int Insertqry(BAL.Query_BAL qrybal)
        {
            string q = "INSERT INTO  query values('" + qrybal.Query + "',' ','" + qrybal.ProductId + "','" + qrybal.UserId + "')";
            SqlCommand cmd = new SqlCommand(q, Getcon());
            return cmd.ExecuteNonQuery();
        }
    }
}