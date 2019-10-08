using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{

    public class HelperNavigation : BaseHelper
    {

        private string baseURL;

        public HelperNavigation(IWebDriver driver, string baseURL)
            : base(driver)
        {
            this.baseURL = baseURL;
        }


        public void GoToHome()
        {
            driver.Navigate().GoToUrl(baseURL);
            // driver.Navigate().GoToUrl(baseURL + "http://localhost/addressbook/");
        }

        public void GoToGroups()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }

        public void Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }
    }
}

