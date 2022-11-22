using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace application_nest.Guest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        BAL.reg_BAL objbal = new BAL.reg_BAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objbal.Name = txtname.Text;
            objbal.Email = txtemail.Text;
            objbal.phone = txtphone.Text;
            object ob = objbal.Insert();
            objbal.Userid =Convert.ToInt32(ob);
            objbal.usrname = txtuser.Text;
            objbal.Password = txtpass.Text;

            int i = objbal.Insertlogin();
            if (i == 1)
            {
                Response.Write("Successfully Inserted");
            }
            else
            {
                Response.Write("Failed To Insert");
            }
        }
    }
}