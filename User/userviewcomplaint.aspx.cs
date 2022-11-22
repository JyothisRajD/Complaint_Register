using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace application_nest.User
{
    public partial class userviewcomplaint : System.Web.UI.Page
    {
        BAL.complaint_BAL complaintbal = new BAL.complaint_BAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                complaintbal.UserId = Convert.ToInt32(Session["user_id"].ToString());
                GridView1.DataSource = complaintbal.Userviewcomplaint();
                GridView1.DataBind();
            }
        }
    }
}