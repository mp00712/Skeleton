using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Testing4;

namespace TestingOrders
{
    [TestClass]
    public class tstOrderCollection
    {


        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrdersListOK(List<clsOrders> TestList)
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrders> TestsList = new List<clsOrders>();
            clsOrders TestItem = new clsOrders();

            TestItem.Shipment = true;
            TestItem.OrderID = 1;
            TestItem.StockID = 1;
            TestItem.ItemQuantity = 2;
            TestItem.TotalPrice = 4;
            TestItem.OrderDate = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllOrders.OrdersList = TestList; 
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }


           [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            clsOrders TestOrder = new clsOrders();

            TestOrder.Shipment = true;
            TestOrder.OrderID = 1;
            TestOrder.StockID = 1;
            TestOrder.ItemQuantity = 2;
            TestOrder.TotalPrice = 4;
            TestOrder.OrderDate = DateTime.Now.Date;
            
            AllOrders.ThisOrder = TestOrder;

            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            List<clsOrders> TestList = new List<clsOrders>();

            clsOrders TestItem = new clsOrders();

            TestItem.Shipment = true;
            TestItem.OrderID = 1;
            TestItem.StockID = 1;
            TestItem.ItemQuantity = 2;
            TestItem.TotalPrice = 4;
            TestItem.OrderDate = DateTime.Now.Date;

            TestList.Add(TestItem);

            AllOrders.OrdersList = TestList;

            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            clsOrders TestOrder = new clsOrders();

            Int32 PrimaryKey = 0;

            TestOrder.Shipment = true;
            TestOrder.OrderID = 6;
            TestOrder.StockID = 2;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.ItemQuantity  = 2;
            TestOrder.TotalPrice = 30;
            

            AllOrders.ThisOrder = TestOrder;

            PrimaryKey = AllOrders.Add();

            TestOrder.OrderID = PrimaryKey;

            AllOrders.ThisOrder.Find(PrimaryKey);

            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            clsOrders TestOrder = new clsOrders();

            Int32 PrimaryKey = 0;

            TestOrder.Shipment = true;
            TestOrder.StockID = 2;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.ItemQuantity = 2;
            TestOrder.TotalPrice = 30;

            AllOrders.ThisOrder = TestOrder;

            PrimaryKey = AllOrders.Add();

            TestOrder.OrderID = PrimaryKey;

            TestOrder.Shipment = false;
            TestOrder.StockID = 3;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.ItemQuantity = 4;
            TestOrder.TotalPrice = 8;

            AllOrders.ThisOrder = TestOrder;

            AllOrders.Update();

            AllOrders.ThisOrder.Find(PrimaryKey);

            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            clsOrders TestOrder = new clsOrders();

            Int32 PrimaryKey = 0;

            TestOrder.Shipment = true;
            TestOrder.OrderID = 6;
            TestOrder.StockID = 2;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.ItemQuantity = 2;
            TestOrder.TotalPrice = 30;

            AllOrders.ThisOrder = TestOrder;

            PrimaryKey = AllOrders.Add();

            TestOrder.OrderID = PrimaryKey;

            AllOrders.ThisOrder.Find(PrimaryKey);

            AllOrders.Delete();

            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByStockIDOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            clsOrderCollection FilteredOrders = new clsOrderCollection();

            FilteredOrders.ReportByStockID("-1");

            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }
        [TestMethod]
        public void ReportByStockIDNoneFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();

            FilteredOrders.ReportByStockID("0");

            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ResportByCustomerIDTestDataFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();

            Boolean OK = true;

            FilteredOrders.ReportByStockID("1");

            if (FilteredOrders.Count == 2)
            {
                if (FilteredOrders.OrdersList[0].OrderID != 36)
                {
                    OK = false;
                }
                if (FilteredOrders.OrdersList[1].OrderID != 37)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

    }
}
