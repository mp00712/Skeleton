using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 

namespace ClassLibrary
{
    public class clsOrders
    {
        private Int32 mOrderID;
        private Int32 mStockID;
        private Int32 mItemQuantity;
        private Decimal mTotalPrice;
        private DateTime mOrderDate;
        private Boolean mShipment;

        public int OrderID
        {
            get
            {
                return mOrderID;
            }
            set
            {
                mOrderID = value;
            }
        }
        public int StockID
        {
            get
            {
                return mStockID;
            }
            set
            {
                mStockID = value;
            }
        }
        public int ItemQuantity
        {
            get
            {
                return mItemQuantity;
            }
            set
            {
                mItemQuantity = value;
            }
        }

        public decimal TotalPrice 
        {
            get
            {
                return mTotalPrice;
            }
            set
            {
                mTotalPrice = value;
            }
        }
        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }
        public bool Shipment
        {
            get
            {
                return mShipment;
            }
            set
            {
                mShipment = value;
            }
        }

        public bool Find(int OrderID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", OrderID);
            DB.Execute("sproc_tblOrders_FilterByOrderID");
            if (DB.Count == 1)
            {
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mStockID = Convert.ToInt32(DB.DataTable.Rows[0]["StockID"]);
                mItemQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["ItemQuantity"]);
                mTotalPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalPrice"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mShipment = Convert.ToBoolean(DB.DataTable.Rows[0]["Shipment"]);

                return true;
            }
            else
            {
                return false;
            }
        }
        public string Valid(string StockID, string ItemQuantity, string TotalPrice, string OrderDate)
        {
            String Error = "";

            DateTime DateTemp;

            if (StockID.Length == 0)
            {
                Error = Error + "The StockID no may not be blank : ";
            }

            if (StockID.Length > 6)
            {
                Error = Error + "The StockID no must be less than 6 characters :";
            }

            try
            {

                DateTemp = Convert.ToDateTime(OrderDate);

                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "Order Date cannot be in the past : ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "Order Date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : "; 
            }

            if (ItemQuantity.Length == 0)
            {
                Error = Error + "The ItemQuantity no may not be blank : ";
            }

            if (ItemQuantity.Length > 50)
            {
                Error = Error + "The ItemQuantity must be less than 100 characters :";
            }
            if (TotalPrice.Length == 0)
            {
                Error = Error + "The TotalPrice no may not be blank : ";
            }
            if (TotalPrice.Length > 9)
            {
                Error = Error + "The TotalPrice must be less than 10000 characters :";
            }

            return Error;
        }
    }
}