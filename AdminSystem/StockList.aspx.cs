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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StockID"] = -1;
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StockID;
        if (lstStockList.SelectedIndex != -1)
                {
            StockID = Convert.ToInt32(lstStockList.SelectedValue);
            Session["StockID"] = StockID;
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please Select a record to edit from";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StockID;
        if (lstStockList.SelectedIndex != -1)
        {
            StockID = Convert.ToInt32(lstStockList.SelectedValue);
            Session["StockID"] = StockID;
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please Select a record to delete from the list";
        }

    }
}