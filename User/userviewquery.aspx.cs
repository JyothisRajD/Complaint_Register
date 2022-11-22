using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace application_nest.User
{
    public partial class userviewquery : System.Web.UI.Page
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
                if (dt!= null)
                {
                    ProductBox.Text = dt.Rows[0]["product"].ToString();
                    QuestionBox.Text = dt.Rows[0]["qry"].ToString();
                    ReplyBox.Text = dt.Rows[0]["reply"].ToString();
                }
            }
        }

    }
}