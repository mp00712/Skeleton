using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStock AnStock = new clsStock();
        AnStock.StockID = Convert.ToInt32(txtStockID.Text);


        AnStock.StockName = txtStockName.Text;


        AnStock.ItemQuantity = Convert.ToInt32(txtItemQuantity.Text);


        AnStock.TotalPrice = Convert.ToInt32(txtTotalPrice.Text);


        AnStock.RestockDate = Convert.ToDateTime(txtRestockDate.Text);

        AnStock.StockAvailability = Convert.ToBoolean(chkStockAvailability.Checked);
        Session["AnStock"] = AnStock;
        Response.Redirect("StockViewer.aspx");

    }
}