using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Testing4
{
    [TestClass]
    public class tstOrders
    {
        string OrderID = "1";
        string StockID = "1";
        string ItemQuantity = "2";
        string TotalPrice = "4";
        string OrderDate = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderIDOK()
        {
            clsOrders AnOrder = new clsOrders();
            Int32 TestData = 1;
            AnOrder.OrderID = TestData;
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void StockIDOK()
        {
            clsOrders AnOrder = new clsOrders();
            Int32 TestData = 1;
            AnOrder.StockID = TestData;
            Assert.AreEqual(AnOrder.StockID, TestData);
        }

        [TestMethod]
        public void ItemQuantityOK()
        {
            clsOrders AnOrder = new clsOrders();
            Int32 TestData = 2;
            AnOrder.ItemQuantity = TestData;
            Assert.AreEqual(AnOrder.ItemQuantity, TestData);
        }

        [TestMethod]
        public void TotalPriceOK()
        {
            clsOrders AnOrder = new clsOrders();
            Decimal TestData = 4;
            AnOrder.TotalPrice = TestData;
            Assert.AreEqual(AnOrder.TotalPrice, TestData);
        }

        [TestMethod]
        public void OrderDateOK()
        {
            clsOrders AnOrder = new clsOrders();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.OrderDate = TestData;
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void ShipmentOK()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean TestData = true;
            AnOrder.Shipment = TestData;
            Assert.AreEqual(AnOrder.Shipment, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Int32 OrderID = 5;
            Found = AnOrder.Find(OrderID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderIDFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 5;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.OrderID != 5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockIDFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 5;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.StockID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemQuantityFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 5;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.ItemQuantity != 6)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalPriceFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 5;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.TotalPrice != 20)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.OrderDate != Convert.ToDateTime("20/02/2022"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestShipmentFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.Shipment != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            Error = AnOrder.Valid(StockID,ItemQuantity,TotalPrice,OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockIDMinLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            String StockID = "";
            Error = AnOrder.Valid(StockID,ItemQuantity,TotalPrice,OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockIDMin()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string StockID = "a";
            Error = AnOrder.Valid(StockID, ItemQuantity, TotalPrice, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockIDMinPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string StockID = "aa";
            Error = AnOrder.Valid(StockID, ItemQuantity, TotalPrice, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockIDMaxLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string StockID = "aaaaa";
            Error = AnOrder.Valid(StockID, ItemQuantity, TotalPrice, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockIDMax()
        {
            clsOrders AnOrder = new clsOrders();           
            String Error = "";
            string StockID = "aaaaaa"; //this should be ok
            Error = AnOrder.Valid(StockID, ItemQuantity, TotalPrice, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockIDMid()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string StockID = "aaa"; //this should be ok
            Error = AnOrder.Valid(StockID, ItemQuantity, TotalPrice, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockIDMaxPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string StockID = "aaaaaaa"; //this should be ok
            Error = AnOrder.Valid(StockID, ItemQuantity, TotalPrice, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockIDExtremeMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string StockID = "";
            StockID = StockID.PadRight(500, 'a');
            Error = AnOrder.Valid(StockID, ItemQuantity, TotalPrice, OrderDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void OrderDateExtremeMin()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(StockID, ItemQuantity, TotalPrice, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(StockID, ItemQuantity, TotalPrice, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMin()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(StockID, ItemQuantity, TotalPrice, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(StockID, ItemQuantity, TotalPrice, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(StockID, ItemQuantity, TotalPrice, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateInvalidDataType()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string OrderDate = "this is not a date!";
            Error = AnOrder.Valid(StockID, ItemQuantity, TotalPrice, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ItemQuantityMinLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string ItemQuantity = "";
            Error = AnOrder.Valid(StockID, ItemQuantity, TotalPrice, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ItemQuantityMin()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string ItemQuantity = "1";
            Error = AnOrder.Valid(StockID, ItemQuantity, TotalPrice, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ItemQuantityMinPlusOne()
        {
                clsOrders AnOrder = new clsOrders();
                String Error = "";
                string ItemQuantity = "2";
                Error = AnOrder.Valid(StockID, ItemQuantity, TotalPrice, OrderDate);
                Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ItemQuantityMaxLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string ItemQuantity = "49";
            Error = AnOrder.Valid(StockID, ItemQuantity, TotalPrice, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ItemQuantityMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string ItemQuantity = "50";
            Error = AnOrder.Valid(StockID, ItemQuantity, TotalPrice, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ItemQuantityMaxPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string ItemQuantity = "";
            ItemQuantity = ItemQuantity.PadRight(51, 'a');
            Error = AnOrder.Valid(StockID, ItemQuantity, TotalPrice, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityMid()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string ItemQuantity = "aaaa";
            Error = AnOrder.Valid(StockID, ItemQuantity, TotalPrice, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMinLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string TotalPrice = "";
            Error = AnOrder.Valid(StockID, ItemQuantity, TotalPrice, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMin()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string TotalPrice = "a";
            Error = AnOrder.Valid(StockID, ItemQuantity, TotalPrice, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMinPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string TotalPrice = "aa";
            Error = AnOrder.Valid(StockID, ItemQuantity, TotalPrice, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMaxLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string TotalPrice = "aaaaaaaa";
            Error = AnOrder.Valid(StockID, ItemQuantity, TotalPrice, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string TotalPrice = "aaaaaaaaa";
            Error = AnOrder.Valid(StockID, ItemQuantity, TotalPrice, OrderDate);
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void TotalPriceMaxPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string TotalPrice = "aaaaaaaaaa";
            Error = AnOrder.Valid(StockID, ItemQuantity, TotalPrice, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TotalPriceMid()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string TotalPrice = "aaaa";
            Error = AnOrder.Valid(StockID, ItemQuantity, TotalPrice, OrderDate);
            Assert.AreEqual(Error, "");
        } 
    }
}
