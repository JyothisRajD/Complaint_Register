using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace application_nest.DAL
{
    class reg_DAL
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public reg_DAL()
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

        public object Insert(BAL.reg_BAL objone)
        {
            string qry = "insert into registration values('" + objone.Name + "','" + objone.Email + "', '" + objone.phone + "');select @@IDENTITY";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteScalar();
        }

        public int loginInsert(BAL.reg_BAL objone)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into login values('" + objone.usrname + "','" + objone.Password + "',0,'Customer',"+objone.Userid+");select @@IDENTITY";
            int id = cmd.ExecuteNonQuery();
            return id;
        }

        public DataTable checklog(BAL.reg_BAL objone)
        {
            string qry = "SELECT * FROM login WHERE username='" + objone.usrname + "'AND password='" + objone.Password + "'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            return dt;
        }

        public int UserConfirm(BAL.reg_BAL objone)
        {
            string qry = "update login set status = '1' where user_id='" + objone.Userid + "'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            int i = cmd.ExecuteNonQuery();
            return i;
        }

        public DataTable registerationView()
        {
            string qry = "select r.*,l.* from registration r inner join login l on r.user_id = l.user_id where l.role='Customer' and status='0'";
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
    }
}