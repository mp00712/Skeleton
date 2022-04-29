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
            DisplayOrders();
        }
    }
    void DisplayOrders()
    {
        clsOrderCollection Orders = new clsOrderCollection();

        lstOrdersList.DataSource = Orders.OrdersList;
        lstOrdersList.DataValueField = "OrderID";
        lstOrdersList.DataTextField = "OrderDate";

        lstOrdersList.DataBind();
    }



    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderID"] = -1;

        Response.Redirect("OrdersDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderID;

        if(lstOrdersList.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrdersList.SelectedValue);

            Session["OrderID"] = OrderID;

            Response.Redirect("OrdersDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderID;

        if (lstOrdersList.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrdersList.SelectedValue);

            Session["OrderID"] = OrderID;

            Response.Redirect("OrdersConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByStockID(txtFilter.Text);
        lstOrdersList.DataSource = Orders.OrdersList;
        lstOrdersList.DataValueField = "OrderID";
        lstOrdersList.DataTextField = "StockID";

        lstOrdersList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByStockID("");
        txtFilter.Text = "";
        lstOrdersList.DataSource = Orders.OrdersList;
        lstOrdersList.DataValueField = "OrderID";
        lstOrdersList.DataTextField = "StockID";

        lstOrdersList.DataBind();
    }
}
