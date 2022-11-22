using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace application_nest.Guest
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        BAL.reg_BAL objtwo = new BAL.reg_BAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objtwo.usrname = Name.Text;
            objtwo.Password = pwd.Text;
            DataTable dt = objtwo.login();
            
            if(dt.Rows.Count>0)
            {
               

                if(dt.Rows[0][4].ToString().Trim()=="admin")
                {
                    Response.Redirect("../Admin/admin_home.aspx");
                }

                else if (dt.Rows[0][3].ToString() == "1" && dt.Rows[0][4].ToString() == "Customer")
                {
                    Session["user_id"] = dt.Rows[0][5];
                    Response.Redirect("../User/user_home.aspx");
                    Response.Write("Successfully Loged in");
                }

                else if (dt.Rows[0][3].ToString() != "1" && dt.Rows[0][4].ToString() == "Customer")
                {
                    Response.Write("Waiting for Comfirmation");
                }
               
            }
            else
            {
                Response.Write("username or password is incorrect");
            }
        }
    }
}