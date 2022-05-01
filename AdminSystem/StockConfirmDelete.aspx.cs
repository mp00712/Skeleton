using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 StockID;
    protected void Page_Load(object sender, EventArgs e)
    {
        StockID = Convert.ToInt32(Session["StockID"]);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStockcollection StockBook = new clsStockcollection();
        StockBook.ThisStock.Find(StockID);
        StockBook.Delete();
        Response.Redirect("StockList.aspx");
    }
}