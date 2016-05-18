using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopAtHomeAutomation;

namespace ShopAtHomeAutomation
{
    [TestClass]
    public class LoginTests
    {
        //Initialize the session
        [TestInitialize]
        public void Ini()
        {
            Driver.Initialize();
        }

        //Method to test that user can login
        [TestMethod]
        public void User_Can_Login()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("testaccounttest1234@hotmail.com").WithPassword("TestAccount*").Login();

            //Search for a user name in the dashboard, if login action wasn't successfull failed message gets displayed
            Assert.IsTrue(DashboardPage.IsAt, "Failed to login");
        }


        //Close the browser
        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
