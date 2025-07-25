using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Windows;

namespace SQA_097_Selenium_02
{
    [TestClass]
    public class LoginExecution
    {
        public IWebDriver driver;

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
            driver = new ChromeDriver();
        }

        [TestCleanup]
        public void TestClean()
        {
            driver.Close();
        }

        #endregion

        [TestMethod]
        public void TestCase_001()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Login(driver, "https://adactinhotelapp.com/", "AmirImam","AmirImam");
        }

        [TestMethod]
        public void TestCase_002()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Login(driver, "https://adactinhotelapp.com/", "12312", "12132");
        }
    }
}
