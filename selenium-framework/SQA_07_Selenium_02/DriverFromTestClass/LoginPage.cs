using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.Policy;

namespace SQA_097_Selenium_02
{
    public class LoginPage
    {
        public void Login(IWebDriver driver, string url, string user, string pass)
        {
            driver.Url = url;
            driver.FindElement(By.Id("username")).SendKeys(user);
            driver.FindElement(By.Id("password")).SendKeys(pass);
            driver.FindElement(By.Id("login")).Click();

        }
    }
}
