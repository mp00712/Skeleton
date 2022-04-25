using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStock();
        }

    }

    void DisplayStock()
    {
        clsStockcollection AnStock = new clsStockcollection();
        lstStockList.DataSource = AnStock.StockList;
        lstStockList.DataValueField = "StockID";
        lstStockList.DataTextField = "StockName";
        lstStockList.DataBind();



    }
}