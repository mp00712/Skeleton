using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        public int OrderID { get; set; }
        public int StockID { get; set; }
        public int ItemQuantity { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public bool Shipment { get; set; }

        public bool Find(int OrderID)
        {
            return true;
        }
    }
}