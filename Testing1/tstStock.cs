using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing6
{
    [TestClass]
    public class tstStock
    {
        string StockID = "2";
        string StockName = "Hand Sanitizer";
        string ItemQuantity = "50";
        string TotalPrice = "3";
        string RestockDate = DateTime.Now.Date.ToString();
        
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
        public void FindMethodOK()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Int32 StockID = 2;
            Found = AnStock.Find(StockID);
            Assert.IsTrue(Found);


        }

        public void TestStockIDFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 2;
            //invoke the method
            Found = AnStock.Find(StockID);
            //check the Stock no
            if (AnStock.StockID != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
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
            //check the Stock no
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
            Int32 StockName = 2;
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
            Int32 TotalPrice = 2;
            //invoke the method
            Found = AnStock.Find(TotalPrice);
            //check the property
            if (AnStock.TotalPrice != 3)
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
            Int32 RestockDate = 1;
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

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockIDMinLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string StockID = "";
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockIDMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockID = "a"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockID = "aa"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockID = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockIDMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockID = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockIDMid()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockID = "aaa"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockID = "aaaaaaaa"; 
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockIDExtremeMax()
        {
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockID = "";
            StockID = StockID.PadRight(500, 'a');
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void RestockDateExtremeMin()
        {
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string RestockDate = TestDate.ToString();
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RestockDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddYears(-1);
            //convert the date variable to a string variable
            string RestockDate = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RestockDateMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string RestockDate = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RestockDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string RestockDate = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RestockDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string RestockDate = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RestockDateInvalidDate()
        {
            clsStock AnStock = new clsStock();
            String Error;
            string RestockDate = "this is not a date!";
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StockName = "";
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockName = "a";
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockName = "aa";
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockName = "";
            StockName = StockName.PadRight(49, 'a');
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockName = "";
            StockName = StockName.PadRight(50, 'a');
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StockName = "";
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMid()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockName = "";
            StockName = StockName.PadRight(25, 'a');
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string TotalPrice = "";
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string TotalPrice = "a";
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string TotalPrice = "aa";
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string TotalPrice = "aaaaaaaa";
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string TotalPrice = "aaaaaaaaa";
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string TotalPrice = "aaaaaaaaaa";
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMid()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string TotalPrice = "aaaa";
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ItemQuantity = "";
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ItemQuantity = "a";
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ItemQuantity = "aa";
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ItemQuantityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ItemQuantity = "";
            ItemQuantity = ItemQuantity.PadRight(49, 'a');
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ItemQuantity = "";
            ItemQuantity = ItemQuantity.PadRight(50, 'a');
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string ItemQuantity = "";
            ItemQuantity = ItemQuantity.PadRight(51, 'a');
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void ItemQuantityMid()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ItemQuantity = "";
            ItemQuantity = ItemQuantity.PadRight(25, 'a');
            //invoke the method
            Error = AnStock.Valid(StockID, StockName, ItemQuantity, TotalPrice, RestockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


    }
}


