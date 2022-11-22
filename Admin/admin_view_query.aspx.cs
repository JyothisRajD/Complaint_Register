using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace application_nest.Admin
{
    public partial class admin_view_query : System.Web.UI.Page
    {
        BAL.Query_BAL qrybal = new BAL.Query_BAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = qrybal.ViewAllQuery();
                GridView1.DataBind();

            }


        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("../Admin/admin_qery_reply.aspx");
        }
    }
}