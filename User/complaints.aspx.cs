using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace application_nest.User
{
    public partial class complaints : System.Web.UI.Page
    {
        BAL.product_BAL prod = new BAL.product_BAL();
        BAL.complaint_BAL complBAL = new BAL.complaint_BAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dr = prod.GetProduct();
                DropDownList1.DataTextField = "product";
                DropDownList1.DataValueField = "p_Id";
                DropDownList1.DataSource = dr;
                DropDownList1.DataBind();

            }

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            complBAL.ProductId = Convert.ToInt32(DropDownList1.SelectedValue);
            complBAL.UserId = Convert.ToInt32(Session["user_id"]);
            complBAL.Complaint = TextBox1.Text;
            int i = complBAL.InsertingComplaints();
            if (i == 1)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + "Complaint Registered Successfully" + "');", true);

            }
        }
    }
}