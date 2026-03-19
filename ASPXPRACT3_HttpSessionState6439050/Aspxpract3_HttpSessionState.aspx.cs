using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPXPRACT3_HttpSessionState6439050
{
    public partial class Aspxpract3_HttpSessionState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Datos de deportes según tus nuevas fotos
                ddlCategory.Items.Add("Racquets");
                ddlCategory.Items.Add("Balls");
                ddlCategory.Items.Add("Accessories");

                ddlSupplier.Items.Add("Prince");
                ddlSupplier.Items.Add("Wilson");
                ddlSupplier.Items.Add("Penn");
            }
        }
        protected void btnConfirm_Click(object sender, EventArgs e)
        {           
            Session["ddlCategory"] = ddlCategory.SelectedValue;
            Session["ddlSupplier"] = ddlSupplier.SelectedValue;
            Session["strProduct"] = txtProduct.Text;
            Session["strDescription"] = txtDescription.Text;
            Session["strImage"] = txtImage.Text;
            Session["decPrice"] = txtPrice.Text;
            Session["bytNumberInStock"] = txtNumberInStock.Text;
            Session["bytNumberOnOrder"] = txtNumberOnOrder.Text;
            Session["bytReorderLevel"] = txtReorderLevel.Text;

            Response.Redirect("Aspxpract3_HttpSessionStateparte2.aspx");
        }
    }
}