using System;
using System.Collections.Generic;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstStockCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            clsStockcollection AllStock = new clsStockcollection();
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            clsStockcollection AllStock = new clsStockcollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.Active = true;
            TestItem.StockID = 2;
            TestItem.StockName = "Hand Sanitizer";
            TestItem.ItemQuantity = 50;
            TestItem.TotalPrice = 3;
            TestItem.RestockDate = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.StockList, TestList);
        }

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockcollection AllStock = new clsStockcollection();
            clsStock TestStock = new clsStock();

            TestStock.Active = true;
            TestStock.StockID = 2;
            TestStock.StockName = "Hand Sanitizer";
            TestStock.ItemQuantity = 50;
            TestStock.TotalPrice = 3;
            TestStock.RestockDate = DateTime.Now.Date;

            AllStock.ThisStock = TestStock;
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }


        [TestMethod]
        public void ListandCountOK()
        {
            clsStockcollection AllStock = new clsStockcollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.Active = true;
            TestItem.StockID = 2;
            TestItem.StockName = "Hand Sanitizer";
            TestItem.ItemQuantity = 50;
            TestItem.TotalPrice = 3;
            TestItem.RestockDate = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

        [TestMethod]

        public void AddMethodOK()
        {
            clsStockcollection AllStock = new clsStockcollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.StockAvailability = true;
            TestItem.StockID = 2;
            TestItem.StockName = "Hand Sanitizer";
            TestItem.ItemQuantity = 50;
            TestItem.TotalPrice = 3;
            TestItem.RestockDate = DateTime.Now.Date;

            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.StockID = PrimaryKey;
            AllStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void UpdateMethod()
        {
            clsStockcollection AllStock = new clsStockcollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.StockAvailability = true;
            TestItem.StockID = 2;
            TestItem.StockName = "Hand Sanitizer";
            TestItem.ItemQuantity = 50;
            TestItem.TotalPrice = 3;
            TestItem.RestockDate = DateTime.Now.Date;

            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.StockID = PrimaryKey;

            TestItem.StockAvailability = false;
            TestItem.StockID = 3;
            TestItem.StockName = "Covid Hand Sanitizer";
            TestItem.ItemQuantity = 100;
            TestItem.TotalPrice = 5;
            TestItem.RestockDate = DateTime.Now.Date;

            AllStock.ThisStock = TestItem;
            AllStock.Update();
            AllStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStockcollection AllStock = new clsStockcollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.StockAvailability = true;
            TestItem.StockID = 2;
            TestItem.StockName = "Hand Sanitizer";
            TestItem.ItemQuantity = 50;
            TestItem.TotalPrice = 3;
            TestItem.RestockDate = DateTime.Now.Date;

            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.StockID = PrimaryKey;

            AllStock.ThisStock.Find(PrimaryKey);
            AllStock.Delete();
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void ReportbyStockNameMethodOK()
        {
            clsStockcollection AllStock = new clsStockcollection();
            clsStockcollection FilteredStock = new clsStockcollection();
            FilteredStock.ReportbyStockName("");
            Assert.AreEqual(AllStock.Count, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportbyStockNameNoneFound()
        {
            clsStockcollection FilteredStock = new clsStockcollection();
            FilteredStock.ReportbyStockName("xxxxx xxxxxxx");
            Assert.AreEqual(0, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportbyStockNameDataFound()
        {
            clsStockcollection FilteredStock = new clsStockcollection();
            Boolean OK = true;
            FilteredStock.ReportbyStockName("Covid Faceshield");
            if (FilteredStock.Count == 2)
            {
                if (FilteredStock.StockList[1].StockName != "Covid Mask")
                {
                    OK = false;
                }

                if (FilteredStock.StockList[2].StockName !="Hand Sanitizer")
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
