
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.Policy;

namespace SQA_097_Selenium_02
{
    public class BasePage
    {
        public static IWebDriver driver;

        public static void SeleniumInitialization()
        {
            driver = new ChromeDriver();
        }
    }
}
