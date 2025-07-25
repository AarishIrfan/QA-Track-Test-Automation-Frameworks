using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using System.Windows;

namespace SQA_097_Selenium_02
{
    [TestClass]
    public class UnitTest4
    {
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

      
        [TestMethod]
        public void TestCase_001()
        {
            Thread.Sleep(3000);
        
        }

        [TestMethod]
        public void TestCase_002()
        {
            Thread.Sleep(3000);
        }

        [TestMethod]
        public void TestCase_003()
        {
            Thread.Sleep(3000);
        }
    }

}
