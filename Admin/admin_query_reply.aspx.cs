using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace application_nest.Admin
{
    public partial class admin_query_reply : System.Web.UI.Page
    {
        BAL.Query_BAL Query_BAL = new BAL.Query_BAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int qid = Convert.ToInt32(Request.QueryString["qry_Id"]);
                Session["qryid"] = qid;
                Query_BAL.QueryId = qid;
                DataTable dt = Query_BAL.ViewSpecificQuery();
                if (dt != null)
                {
                    productBox.Text = dt.Rows[0]["product"].ToString();
                    questionBox.Text = dt.Rows[0]["qry"].ToString();

                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Query_BAL.QueryReply = replyBox.Text;
            int queryid = Convert.ToInt32(Session["qryid"]);
            Query_BAL.QueryId = queryid;
            int i = Query_BAL.GiveReply();
            if (i == 1)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + "Replyed Successfully" + "');", true);
                Response.Redirect("../Admin/admin_view_query.aspx");
            }
        }
    }
}