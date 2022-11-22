using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace application_nest.Admin
{
    public partial class admin_confirmation : System.Web.UI.Page
    {
        BAL.reg_BAL loginBal = new BAL.reg_BAL();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                GridView1.DataSource = loginBal.viewRegisteration();
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int userId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            loginBal.Userid= userId;
            int i = loginBal.Confirmation();
            if (i == 1)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + "Confirmed Successfully" + "');", true);

            }
            GridView1.DataSource = loginBal.viewRegisteration();
            GridView1.DataBind();
        }

    }
}