using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Windows;

namespace SQA_097_Selenium_02
{
    [TestClass]
    public class UnitTest3
    {
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        #region CLASS INIT AND CLEANUP

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            MessageBox.Show("ClassInit");

        }

        [ClassCleanup]
        public static void ClassCleanUp()
        {
            MessageBox.Show("ClassCleanUp");
        }

        #endregion

        #region TEST INIT AND CLEANUP
        [TestInitialize]
        public void TestInit()
        {
            MessageBox.Show("TestInit");
        }

        [TestCleanup]
        public void TestClean()
        {
            MessageBox.Show("TestClean");
        }

        #endregion

        [TestMethod]
        public void TestCase_001()
        {
            MessageBox.Show("TestCase_001");
        
        }

        [TestMethod]
        public void TestCase_002()
        {
            MessageBox.Show("TestCase_002");

        }
    }

}
