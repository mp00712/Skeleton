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
        public void TestMethod()
        {
        }

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


    }
}
