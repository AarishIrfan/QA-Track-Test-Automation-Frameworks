using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.Policy;

namespace SQA_097_Selenium_02
{
    public class SearchPage : BasePage
    {
        public void Search(string location)
        {
            driver.FindElement(By.Id("location")).SendKeys(location);
            driver.FindElement(By.Id("Submit")).Click();
        }
    }
}
