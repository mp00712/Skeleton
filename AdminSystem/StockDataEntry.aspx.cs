using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StockID;
    protected void Page_Load(object sender, EventArgs e)
    {
        StockID = Convert.ToInt32(Session["StockID"]);
        if (IsPostBack == false)
        {
            if (StockID != -1)
            {
                DisplayStock();
            }
        }
        
    }

     void DisplayStock()
    {
        clsStockcollection StockBook = new clsStockcollection();
        StockBook.ThisStock.Find(StockID);
        txtStockID.Text = StockBook.ThisStock.StockID.ToString();
        txtStockName.Text = StockBook.ThisStock.StockName;
        txtItemQuantity.Text = StockBook.ThisStock.ItemQuantity.ToString();
        txtTotalPrice.Text = StockBook.ThisStock.TotalPrice.ToString();
        txtRestockDate.Text = StockBook.ThisStock.RestockDate.ToString();

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStock AnStock = new clsStock();
        String StockID = txtStockID.Text;
        String StockName = txtStockName.Text;
        String ItemQuantity = txtItemQuantity.Text;
        String TotalPrice = txtTotalPrice.Text;
        String RestockDate = txtRestockDate.Text;
        String StockAvailability = chkStockAvailability.Checked.ToString();
        string Error = "";
        Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
        if (Error == "")
        {

            AnStock.StockID = Convert.ToInt32(StockID);
            AnStock.StockName = StockName;
            AnStock.ItemQuantity = Convert.ToInt32(ItemQuantity);
            AnStock.TotalPrice = Convert.ToInt32(TotalPrice);
            AnStock.RestockDate = Convert.ToDateTime(RestockDate);
            AnStock.Active = Convert.ToBoolean(StockAvailability);

            clsStockcollection StockList = new clsStockcollection();
            if (Convert.ToInt32(StockID) == -1)
            {
                StockList.ThisStock = AnStock;
                StockList.Add();
            }
            else
            {
                StockList.ThisStock.Find(Convert.ToInt32(StockID));
                StockList.ThisStock = AnStock;
                StockList.Update();
            }
        }

        else
        {
            lblError.Text = Error;
        }
        

    }

    protected void btnFind_Click1(object sender, EventArgs e)
    {
        clsStock AnStock = new clsStock();
        Int32 StockID;
        Boolean Found = false;
        StockID = Convert.ToInt32(txtStockID.Text);
        Found = AnStock.Find(StockID);
        if (Found == true)
        {
            txtStockName.Text = AnStock.StockName;
            txtItemQuantity.Text = AnStock.ItemQuantity.ToString();
            txtTotalPrice.Text = AnStock.TotalPrice.ToString();
            txtRestockDate.Text = AnStock.RestockDate.ToString();
            chkStockAvailability.Checked = AnStock.StockAvailability;
            lblError.Text = "";
        }
        else
        {
            txtStockName.Text = "--";
            txtItemQuantity.Text = "--";
            txtTotalPrice.Text = "--";
            txtRestockDate.Text = "--";
            chkStockAvailability.Checked = AnStock.StockAvailability;
            lblError.Text = "Error - No Stock Found" + StockID;

        }
    }
}