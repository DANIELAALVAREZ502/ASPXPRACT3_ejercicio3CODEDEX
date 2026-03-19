using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPXPRACT3_HttpSessionState6439050
{
    public partial class Aspxpract3_HttpSessionStateparte2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlCategory.Items.Add("Racquets");
                ddlCategory.Items.Add("Balls");
                ddlCategory.Items.Add("Accessories");

                ddlSupplier.Items.Add("Prince");
                ddlSupplier.Items.Add("Wilson");
                ddlSupplier.Items.Add("Penn");
            }
            
            if (Session["strProduct"] != null)
            {                
                ddlCategory.SelectedValue = Session["ddlCategory"].ToString();
                ddlSupplier.SelectedValue = Session["ddlSupplier"].ToString();

                lblProduct.Text = Session["strProduct"].ToString();
                txtDescription.Text = Session["strDescription"].ToString();
                lblImage.Text = Session["strImage"].ToString();
                lblReorderLevel.Text = Session["bytReorderLevel"].ToString();
              
                decimal decPrice = Convert.ToDecimal(Session["decPrice"]);
                lblPrice.Text = decPrice.ToString("c");
              
                byte bytNumberInStock = Convert.ToByte(Session["bytNumberInStock"]);
                byte bytNumberOnOrder = Convert.ToByte(Session["bytNumberOnOrder"]);

                lblNumberInStock.Text = bytNumberInStock.ToString();
                lblNumberOnOrder.Text = bytNumberOnOrder.ToString();
              
                decimal decValueInStock = decPrice * (decimal)bytNumberInStock;
                decimal decValueOnOrder = decPrice * (decimal)bytNumberOnOrder;
              
                lblValueInStock.Text = decValueInStock.ToString("c");
                lblValueOnOrder.Text = decValueOnOrder.ToString("c");
            }
        }
    }
}