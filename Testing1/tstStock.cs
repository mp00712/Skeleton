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
            string TestData = "Hand Sanitizer";
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
        public void StockIDFindMethodOK()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Int32 StockID = 2;
            Found = AnStock.Find(StockID);
            Assert.IsTrue(Found);


        }

        [TestMethod]
        public void TestItemQuantityFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemQuantity = 2;
            //invoke the method
            Found = AnStock.Find(ItemQuantity);
            //check the address no
            if (AnStock.ItemQuantity != 50)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockNameFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockName = 21;
            //invoke the method
            Found = AnStock.Find(StockName);
            //check the property
            if (AnStock.StockName != "Hand Sanitizer")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestTotalPriceFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 TotalPrice = 21;
            //invoke the method
            Found = AnStock.Find(TotalPrice);
            //check the property
            if (AnStock.TotalPrice != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestRestockDateFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 RestockDate = 21;
            //invoke the method
            Found = AnStock.Find(RestockDate);
            //check the property
            if (AnStock.RestockDate != Convert.ToDateTime("02/02/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}


