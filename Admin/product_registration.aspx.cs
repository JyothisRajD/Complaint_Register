using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace application_nest.Admin
{
    public partial class product_registration : System.Web.UI.Page
    {
        BAL.product_BAL objbal = new BAL.product_BAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = objbal.GetProduct();
                GridView1.DataBind();
            }
        }

        protected void Btn_reg_Click(object sender, EventArgs e)
        {
            objbal.product = txtpro.Text;
            object ob = objbal.Insert();

            GridView1.DataSource = objbal.GetProduct();
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = objbal.GetProduct();
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = objbal.GetProduct();
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int productId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            TextBox productName = (TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0];

            objbal.proid = productId;
            objbal.product = productName.Text;

            int i = objbal.UpdateProducts();

            GridView1.EditIndex = -1;
            GridView1.DataSource = objbal.GetProduct();
            GridView1.DataBind();


        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int productId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objbal.proid = productId;
            int i = objbal.DeleteProducts();
            GridView1.DataSource = objbal.GetProduct();
            GridView1.DataBind();
        }
    }
}