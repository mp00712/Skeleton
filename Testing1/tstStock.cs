using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock AnStock = new clsStock();
            Assert.IsNotNull(AnStock);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsStock AnStock = new clsStock();
            Boolean TestData = true;
            AnStock.Active = TestData;
            Assert.AreEqual(AnStock.Active, TestData);
        }
        
        [TestMethod]
            public void DateAddedPropertyOK()
            {
                //create an instance of the class we want to create
                clsStock AnStock = new clsStock();
                //create some test data to assign to the property
                DateTime TestData = DateTime.Now.Date;
                //assign the data to the property
                AnStock.DateAdded = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnStock.DateAdded, TestData);
            }


            [TestMethod]
            public void StockNoPropertyOK()
            {
                //create an instance of the class we want to create
                clsStock AnStock = new clsStock();
                //create some test data to assign to the property
                Int32 TestData = 1;
                //assign the data to the property
                AnStock.StockNo = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnStock.StockNo, TestData);
            }

            [TestMethod]
            public void CountyNoPropertyOK()
            {
                //create an instance of the class we want to create
                clsStock AnStock = new clsStock();
                //create some test data to assign to the property
                Int32 TestData = 1;
                //assign the data to the property
                AnStock.CountyNo = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnStock.CountyNo, TestData);
            }

            [TestMethod]
            public void HouseNoPropertyOK()
            {
                //create an instance of the class we want to create
                clsStock AnStock = new clsStock();
                //create some test data to assign to the property
                string TestData = "21b";
                //assign the data to the property
                AnStock.HouseNo = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnStock.HouseNo, TestData);
            }

            [TestMethod]
            public void PostCodePropertyOK()
            {
                //create an instance of the class we want to create
                clsStock AnStock = new clsStock();
                //create some test data to assign to the property
                string TestData = "LE1 4AB";
                //assign the data to the property
                AnStock.PostCode = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnStock.PostCode, TestData);
            }

            [TestMethod]
            public void StreetPropertyOK()
            {
                //create an instance of the class we want to create
                clsStock AnStock = new clsStock();
                //create some test data to assign to the property
                string TestData = "Some Street";
                //assign the data to the property
                AnStock.Street = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnStock.Street, TestData);
            }

            [TestMethod]
            public void TownPropertyOK()
            {
                //create an instance of the class we want to create
                clsStock AnStock = new clsStock();
                //create some test data to assign to the property
                string TestData = "Leicester";
                //assign the data to the property
                AnStock.Town = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnStock.Town, TestData);
            }
        }

    internal class clsStock
    {
        public bool Active { get; internal set; }
        public DateTime DateAdded { get; internal set; }
        public int CountyNo { get; internal set; }
        public string HouseNo { get; internal set; }
        public string PostCode { get; internal set; }
        public string Town { get; internal set; }
        public int StockNo { get; internal set; }
        public string Street { get; internal set; }
    }
}

