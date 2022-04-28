using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        clsOrders AnOrder = new clsOrders();
        String OrderID = txtOrderID.Text;
        String StockID = txtStockID.Text;
        String ItemQuantity = txtItemQuantity.Text;
        String TotalPrice = txtTotalPrice.Text;
        String OrderDate = txtOrderDate.Text;
        String Shipment = chKShipment.Checked.ToString();
        string Error = "";
        Error = AnOrder.Valid( StockID, ItemQuantity, TotalPrice, OrderDate);
        if (Error == "")
        {
            AnOrder.OrderID = Convert.ToInt32(OrderID);
            AnOrder.StockID = Convert.ToInt32(StockID);
            AnOrder.ItemQuantity = Convert.ToInt32(ItemQuantity);
            AnOrder.TotalPrice = Convert.ToInt32(TotalPrice);
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            AnOrder.Shipment = Convert.ToBoolean(Shipment);
        }

        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrdersViewer.aspx");
    }

    protected void btnFind_Click1(object sender, EventArgs e)
    {
        clsOrders AnOrder = new clsOrders();
        Int32 OrderID;
        Boolean Found = false;
        OrderID = Convert.ToInt32(txtOrderID.Text);
        Found = AnOrder.Find(OrderID);
        if (Found == true)
        {
            txtStockID.Text = AnOrder.StockID.ToString();
            txtItemQuantity.Text = AnOrder.ItemQuantity.ToString();
            txtTotalPrice.Text = AnOrder.TotalPrice.ToString();
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            chKShipment.Checked = AnOrder.Shipment;
            lblError.Text = "";
        }
    }
}