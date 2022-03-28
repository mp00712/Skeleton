using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsStock
    {

        private Boolean mActive;
        //public property for active
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }


        //private data member for active
        private Boolean mStockAvailability;
        //public property for active
        public bool StockAvailability
        {
            get
            {
                //return the private data
                return mStockAvailability;
            }
            set
            {
                //set the private data
                mStockAvailability = value;
            }
        }

        //private date added data member
        private DateTime mRestockDate;
        //public property for date added
        public DateTime RestockDate
        {
            get
            {
                //return the private data
                return mRestockDate;
            }
            set
            {
                //set the private data
                mRestockDate = value;
            }
        }

        //private data member for the StockNo property
        private Int32 mItemQuantity;
        //public property for the Stock number
        public int ItemQuantity
        {
            get
            {
                //return the private data
                return mItemQuantity;
            }
            set
            {
                //set the value of the private data member
                mItemQuantity = value;
            }
        }

        //private data member for the StockNo property
        private Int32 mStockID;
        //public property for the Stock number
        public int StockID
        {
            get
            {
                //return the private data
                return mStockID;
            }
            set
            {
                //set the value of the private data member
                mStockID = value;
            }
        }

        //private data member for county no
        private Int32 mTotalPrice;
        //public property for county no
        public int TotalPrice
        {
            get
            {
                //return the private data
                return mTotalPrice;
            }
            set
            {
                //set the private data
                mTotalPrice = value;
            }
        }

        //private data member for street
        private string mStockName;
        //public data member for street
        public string StockName
        {
            get
            {
                //return the private data
                return mStockName;
            }
            set
            {
                //set the private data
                mStockName = value;
            }
        }



        public bool Find(int StocID)
        {
            //set the private data members to the test data value
            mStockID = 1;
            mStockName = "Hand Sanitizer";
            mItemQuantity = 50;
            mTotalPrice = 2;
            mRestockDate = Convert.ToDateTime("02/02/2022");
            mStockAvailability = true;
            //always return true
            return true;
        }

        public bool Find(int StockID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter(StockID, StockID);
            DB.Execute("sproc_tblStock_FilterbyStockID");
            if (DB.Count == 1)
            {
                mStockID = Convert.ToInt32(DB.DataTable.Rows[0]["StockID"]);
                mStockName = Convert.ToString(DB.DataTable.Rows[0]["StockName"]);
                mItemQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["ItemQuantity"]);
                mTotalPrice = Convert.ToInt32(DB.DataTable.Rows[0]["TotalPrice"]);
                mRestockDate = Convert.ToDateTime(DB.DataTable.Rows[0]["RestockDate"]);
                mStockAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["StockAvailability"];

                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
