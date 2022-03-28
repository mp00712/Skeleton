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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock AnStock = new clsStock();
        Int32 StockID;
        Boolean Found = false;
        StockID = Convert.ToInt32(txtStockID.Text);
        Found = AnStock.Find(StockID);
        if (Found == true)
        {
            txtStockID.Text = AnStock.StockID;
            txtStockName.Text = AnStock.StockName;
            txtItemQuantity.Text = AnStock.ItemQuantity;
            txtTotalPrice.Text = AnStock.TotalPrice;
            txtRestockDate.Text = AnStock.RestockDate.ToString;
        }
    }
}