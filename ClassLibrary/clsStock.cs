using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool StockAvailability;
        private Int32 mStockID;

        public Boolean Active { get; set; }
        public string StockName { get; set; }
        public Int32 ItemQuantity { get; set; }
        public Int32 TotalPrice { get; set; }
        public DateTime RestockDate { get; set; }

        public Int32 StockID
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

        public bool Find(int StockID)
        {
            return true;
        }
    }
}