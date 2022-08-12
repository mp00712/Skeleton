using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
        
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AnStaff);
        }

        [TestMethod]
        public void StaffIDStaffOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the staffid
            Int32 TestData = 1;
            //assign the data to the staffi
            AnStaff.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffID, TestData);
        }

        [TestMethod]
        public void StaffEmailStaffOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "George@gmail.com";
            //assign the data to the property
            AnStaff.StaffEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffEmail, TestData);
        }

        [TestMethod]
        public void StaffNameStaffOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "George Smith";
            //assign the data to the property
            AnStaff.StaffName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffName, TestData);
        }

        [TestMethod]
        public void IsAdminStaffOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStaff.IsAdmin = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.IsAdmin, TestData);
        }

        [TestMethod]
        public void DateCreatedStaffOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStaff.DateCreated = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.DateCreated, TestData);
        }

        [TestMethod]
        public void SalaryStaffOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 35000;
            //assign the data to the property
            AnStaff.Salary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Salary, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {

        
            clsStaff AnStaff = new clsStaff();
            bool Found = false;
            Int32 StaffID = 2;
            Found = AnStaff.Find(StaffID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStaffIDFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 2;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the staff ID
            if (AnStaff.StaffID != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 2;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the property
            if (AnStaff.StaffName != "Tommy Smith")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestIsAdminFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 2;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the property
            if (AnStaff.IsAdmin != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void TestDateCreatedFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 2;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the property
            if (AnStaff.DateCreated != Convert.ToDateTime("18/02/2013"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSalaryFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 2;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the property
            if (AnStaff.Salary != 24000)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffEmailFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 2;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the property
            if (AnStaff.StaffEmail != "Tommy@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }



}

