using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace application_nest.DAL
{
    public class complaint_DAL
    {
            public SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            public complaint_DAL()
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
            public int InsertComplaint(BAL.complaint_BAL complaintbal)
            {
                string q = "INSERT INTO complaints values('" + complaintbal.Complaint + "','not processed','" + complaintbal.ProductId + "','" + complaintbal.UserId + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
                SqlCommand cmd = new SqlCommand(q, Getcon());
                return cmd.ExecuteNonQuery();
            }
            public int Insertqry(BAL.complaint_BAL complaintbal)
            {
                string q = "INSERT INTO  query values('" + complaintbal.query + "',' ','" + complaintbal.ProductId + "','" + complaintbal.UserId + "')";
                SqlCommand cmd = new SqlCommand(q, Getcon());
                return cmd.ExecuteNonQuery();
            }


        public DataTable ViewComplaintDetails(BAL.complaint_BAL complaintbal)
            {
                string qry = "SELECT p.*,c.*,d.* FROM complaints p JOIN product c ON p.p_id = c.p_Id JOIN login d ON p.u_id = d.user_id";
                SqlCommand cmd = new SqlCommand(qry, Getcon());
                DataTable dt = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dt);
                return dt;
            }

        public DataTable UserViewComplaintDetails(BAL.complaint_BAL complaintbal)
        {
            string qry = "SELECT p.*,c.* FROM complaints c INNER JOIN product p ON p.p_Id = c.p_id AND u_id ='" + complaintbal.UserId + "'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            return dt;
        }

        public DataTable ViewAllComplaint(BAL.complaint_BAL complaintbal)
            {
                string qry = "SELECT l.username,p.*,c.* FROM complaints c INNER JOIN login l ON l.u_id= c.user_id INNER JOIN product p ON p.p_Id = c.p_id";
                SqlCommand cmd = new SqlCommand(qry, Getcon());
                DataTable dt = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dt);
                return dt;
            }

            public DataTable ViewDateComplaint(BAL.complaint_BAL complaintbal)
            {
                string qry = "SELECT l.username,p.*,c.* FROM complaints c INNER JOIN login l ON l.user_id= c.u_id INNER JOIN product p ON p.p_Id = c.p_id WHERE c.date BETWEEN '" + complaintbal.Day + "'  AND '" + complaintbal.Today + "' ";
                SqlCommand cmd = new SqlCommand(qry, Getcon());
                DataTable dt = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dt);
                return dt;
            }

            public int UpdateComplaint(BAL.complaint_BAL complaintbal)
            {
                string qry = "update complaints set status = '" + complaintbal.ComplaintStatus + "' where c_Id = '" + complaintbal.ComplaintId + "'";
                SqlCommand cmd = new SqlCommand(qry, Getcon());
                return cmd.ExecuteNonQuery();
            }
    }

    }