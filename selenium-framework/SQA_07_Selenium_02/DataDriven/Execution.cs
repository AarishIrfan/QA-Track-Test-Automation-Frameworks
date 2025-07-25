using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace SQA_097_Selenium_02
{
    [TestClass]
    public class Execution
    {
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "Data.csv", "data#csv", DataAccessMethod.Sequential)]
        public void TestCase_001()
        {
            string url = TestContext.DataRow["url"].ToString();
            string user = TestContext.DataRow["username"].ToString();
            string pass = TestContext.DataRow["password"].ToString();

            IWebDriver driver = new ChromeDriver();
           
            driver.Url = url;
            driver.FindElement(By.Id("username")).SendKeys(user);
            driver.FindElement(By.Id("password")).SendKeys(pass);
            driver.FindElement(By.Id("login")).Click();
            driver.Close();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "Data.csv", "data#csv", DataAccessMethod.Sequential)]
        public void TestCase_002()
        {
            string url = TestContext.DataRow["url"].ToString();
            string user = TestContext.DataRow["username"].ToString();
            string pass = TestContext.DataRow["password"].ToString();

            Console.WriteLine(url +"   "+  user +"   "+  pass);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "TestCase_DataDriven_XML_001", DataAccessMethod.Sequential)]
        public void TestCase_DataDriven_XML_001()
        {
            string url = TestContext.DataRow["url"].ToString();
            string user = TestContext.DataRow["username"].ToString();
            string pass = TestContext.DataRow["password"].ToString();

            IWebDriver driver = new ChromeDriver();

            driver.Url = url;
            driver.FindElement(By.Id("username")).SendKeys(user);
            driver.FindElement(By.Id("password")).SendKeys(pass);
            driver.FindElement(By.Id("login")).Click();
            driver.Close();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "Login", DataAccessMethod.Sequential)]
        public void Login()
        {
            string url = TestContext.DataRow["url"].ToString();
            string user = TestContext.DataRow["username"].ToString();
            string pass = TestContext.DataRow["password"].ToString();

            
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("-start-maximized");
           // options.AddArguments("headless");
            options.AddArguments("incognito");

            IWebDriver driver = new ChromeDriver(options);

            driver.Url = url;
            driver.FindElement(By.Id("username")).SendKeys(user);
            driver.FindElement(By.Id("password")).SendKeys(pass);
            driver.FindElement(By.Id("login")).Click();
            driver.Close();
        }
    }

}
