﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrders AnOrder = new clsOrders();
        AnOrder = (clsOrders)Session["AnOrder"];
        Response.Write(AnOrder.OrderID + "\n");

        Response.Write(AnOrder.StockID + "\n");

        Response.Write(AnOrder.ItemQuantity + "\n");

        Response.Write(AnOrder.TotalPrice + "\n");

        Response.Write(AnOrder.OrderDate + "\n");

        Response.Write(AnOrder.Shipment + "\n");
    }
}