using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace application_nest.DAL
{
    public class product_DAL
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public product_DAL()
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

        public object Insert(BAL.product_BAL objpro)
        {
            string qry = "insert into  product values('" + objpro.product +"')";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteScalar();
        }

        public int Complaints(BAL.product_BAL objpro)
        {
            string qry1 = "insert into complaints(cmpl,status,p_id,u_id,date) values('" + objpro.Compl + "',0,'" + objpro.proid + "','" + objpro.usrid+ "',GETDATE())";
            SqlCommand cmd1 = new SqlCommand(qry1, Getcon());
            return cmd1.ExecuteNonQuery();
        }

        public DataTable GetProductDetails()
        {
            string qry = "select * from product";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            DataTable ds = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(ds);
            return ds;
        }

        public int UpdateProductDetails(BAL.product_BAL objpro)
        {
            string qry = "update product set product = '" + objpro.product + "' where p_Id = '" + objpro.proid + "'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public int DeleteProductDetails(BAL.product_BAL objdel)
        {
            string qry = "delete from product where p_Id ='" + objdel.proid + "' ";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }
    }
}