using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing6
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AnStock);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStock.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.Active, TestData);
        }

        [TestMethod]
        public void RestockDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStock.RestockDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.RestockDate, TestData);
        }


        [TestMethod]
        public void StockIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStock.StockID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.StockID, TestData);
        }

        [TestMethod]
        public void TotalPricePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStock.TotalPrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.TotalPrice, TestData);
        }

        [TestMethod]
        public void ItemQuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStock.ItemQuantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ItemQuantity, TestData);
        }

        [TestMethod]
        public void StockNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Test";
            //assign the data to the property
            AnStock.StockName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.StockName, TestData);
        }

        [TestMethod]
        public void StockAvailabilityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStock.StockAvailability = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.StockAvailability, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Int32 StockID = 1;
            Found = AnStock.Find(StockID);
            Assert.IsTrue(Found);


        }

        [TestMethod]
        public void TestStockIDFound()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockID = 2;
            Found = AnStock.Find(StockID);
            if (AnStock.StockID != 2)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


    }


   

    internal class clsStock
    {
        public clsStock()
        {
        }



        public Boolean Active { get; internal set; }
        public DateTime RestockDate { get; internal set; }
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
        public Int32 ItemQuantity { get; internal set; }
        public global::System.String StockName { get; internal set; }
        public global::System.Object StockAvailability { get; internal set; }
        public int TotalPrice { get; internal set; }


        public bool Find(int StockID)
        {
            return true;
        }

    }

}

