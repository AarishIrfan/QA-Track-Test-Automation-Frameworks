using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Windows;

namespace SQA_097_Selenium_02
{
    [TestClass]
    public class TCExec
    {
       

        #region TEST INIT AND CLEANUP

        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }
        [TestInitialize]
        public void TestInit()
        {
           BasePage.SeleniumInitialization();
        }

        [TestCleanup]
        public void TestClean()
        {
            BasePage.driver.Close();
        }

        #endregion

        [TestMethod]
        public void TestCase_001()
        {
            LoginPageTC loginPage = new LoginPageTC();
            loginPage.Login("https://adactinhotelapp.com/", "AmirImam","AmirImam");
        }

        [TestMethod]
        public void TestCase_002_SeachHotel()
        {
            LoginPageTC loginPage = new LoginPageTC();
            SearchPage searchPage = new SearchPage();

            loginPage.Login("https://adactinhotelapp.com/", "AmirImam", "AmirImam");
            searchPage.Search("Sydney");
        }
    }
}
