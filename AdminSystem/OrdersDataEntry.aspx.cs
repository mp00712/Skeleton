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
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        {
            txtStockID.Text = Session["sTOCKID"].ToString();


            OrderID = Convert.ToInt32(Session["OrderID"]);

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblProduct_SelectAll");

            if (IsPostBack == false)
            {
                if (OrderID != -1)
                {
                    DisplayOrder();
                }
            }
        }

    }

    void DisplayOrder()
    {
        clsOrderCollection OrdersList = new clsOrderCollection();

        OrdersList.ThisOrder.Find(OrderID);

        txtOrderID.Text = OrdersList.ThisOrder.OrderID.ToString();
        txtStockID.Text = OrdersList.ThisOrder.StockID.ToString();
        txtItemQuantity.Text = OrdersList.ThisOrder.ItemQuantity.ToString();
        txtTotalPrice.Text = OrdersList.ThisOrder.TotalPrice.ToString();
        txtOrderDate.Text = OrdersList.ThisOrder.OrderDate.ToString();
        chKShipment.Checked = OrdersList.ThisOrder.Shipment;
    }



    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrders AnOrder = new clsOrders();
        String StockID = txtStockID.Text;
        String ItemQuantity = txtItemQuantity.Text;
        String TotalPrice = txtTotalPrice.Text;
        String OrderDate = txtOrderDate.Text;
        String Shipment = chKShipment.Checked.ToString();
        string Error = "";
        Error = AnOrder.Valid(StockID, ItemQuantity, TotalPrice, OrderDate);
        if (Error == "")
        {
            AnOrder.OrderID = OrderID;
            AnOrder.StockID = Convert.ToInt32(StockID);
            AnOrder.ItemQuantity = Convert.ToInt32(ItemQuantity);
            AnOrder.TotalPrice = Convert.ToDecimal(TotalPrice);
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            AnOrder.Shipment = Convert.ToBoolean(Shipment);

            clsOrderCollection OrdersList = new clsOrderCollection();

            if (OrderID == -1)
            {
                OrdersList.ThisOrder = AnOrder;

                OrdersList.Add();
            }
            else
            {
                OrdersList.ThisOrder.Find(OrderID);
                OrdersList.ThisOrder = AnOrder;
                OrdersList.Update();
            }

            Response.Redirect("OrdersList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
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

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrdersList.aspx");
    }
}



