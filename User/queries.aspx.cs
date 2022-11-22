using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace application_nest.User
{
    public partial class queries : System.Web.UI.Page
    {
        BAL.product_BAL prod = new BAL.product_BAL();
        BAL.Query_BAL qrybal = new BAL.Query_BAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dr = prod.GetProduct();
                DropDownList1.DataTextField = "product";
                DropDownList1.DataValueField = "p_Id";
                DropDownList1.DataSource = dr;
                DropDownList1.DataBind();


                int userid = Convert.ToInt32(Session["user_id"]);
                qrybal.UserId = userid;

                GridView1.DataSource = qrybal.UserViewSpecificQuery();
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            qrybal.ProductId = Convert.ToInt32(DropDownList1.SelectedValue);
            qrybal.UserId = Convert.ToInt32(Session["user_id"]);
            qrybal.Query = TextBox3.Text;

            int i = qrybal.Insertingquery();
            if (i == 1)
            {
                Response.Write("Submitted");
                TextBox3.Text = string.Empty;
            }

            int userid = Convert.ToInt32(Session["user_id"]);
            qrybal.QueryId = userid;

            GridView1.DataSource = qrybal.UserViewSpecificQuery();
            GridView1.DataBind();
        }
    }
}