using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace application_nest.Admin
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        BAL.complaint_BAL complbal = new BAL.complaint_BAL(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                

                for (int i = 1; i <= 31; i++)
                {
                    day.Items.Add(i.ToString());
                    Today.Items.Add(i.ToString());

                }
                for (int i = 1; i <= 12; i++)
                {
                    Month.Items.Add(i.ToString());
                    Tomonth.Items.Add(i.ToString());

                }

                for (int i = DateTime.Now.Year; i >= 2000; i--)
                {
                    year.Items.Add(i.ToString());
                    Toyear.Items.Add(i.ToString());
                }

                GridView1.DataSource = complbal.viewcomplaints();
                GridView1.DataBind();
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            
            complbal.Day = year.SelectedValue + "-" + Month.SelectedValue + "-" + day.SelectedValue;
            complbal.Today = Toyear.SelectedValue + "-" + Tomonth.SelectedValue + "-" + Today.SelectedValue;
            GridView1.DataSource = complbal.ViewDateComplaints();
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = complbal.viewcomplaints();
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = complbal.viewcomplaints();
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int comId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            TextBox status = (TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0];

            complbal.ComplaintId = comId;
            complbal.ComplaintStatus = status.Text;

            int i = complbal.UpdateCompl();

            GridView1.EditIndex = -1;
            GridView1.DataSource = complbal.viewcomplaints();
            GridView1.DataBind();
        }
    }
}