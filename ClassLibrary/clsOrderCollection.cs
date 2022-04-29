using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrders> mOrdersList = new List<clsOrders>();
        clsOrders mThisOrder = new clsOrders();

        public List<clsOrders> OrdersList
        {
            get
            {
                return mOrdersList;
            }
            set
            {
                mOrdersList = value;
            }
        }
        public int Count
        {
            get
            {
                return mOrdersList.Count;
            }
            set
            {

            }
        }

        public clsOrders ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StockID", mThisOrder.StockID);
            DB.AddParameter("@ItemQuantity", mThisOrder.ItemQuantity);
            DB.AddParameter("@TotalPrice", mThisOrder.TotalPrice);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@Shipment", mThisOrder.Shipment);

            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@StockID", mThisOrder.StockID);
            DB.AddParameter("@ItemQuantity", mThisOrder.ItemQuantity);
            DB.AddParameter("@TotalPrice", mThisOrder.TotalPrice);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);


            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@orderID", mThisOrder.OrderID);

            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByStockID(string StockID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockID", StockID);
            DB.Execute("sproc_tblOrder_FilterByStockID");

            PopulateArray(DB);
        }

        private void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;

            RecordCount = DB.Count;

            mOrdersList = new List<clsOrders>();

            while (Index < RecordCount)
            {
                clsOrders AnOrder = new clsOrders();

                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.StockID = Convert.ToInt32(DB.DataTable.Rows[Index]["StockID"]);                
                AnOrder.ItemQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemQuantity"]);
                AnOrder.TotalPrice  = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalPrice"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.Shipment = Convert.ToBoolean(DB.DataTable.Rows[Index]["Shipment"]);

                mOrdersList.Add(AnOrder);

                Index++;
            }
    }
}   
    
}