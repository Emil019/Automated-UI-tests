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
    [TestFixture]
    public class BaseTest
    {
        protected IWebDriver driver;
        public StringBuilder verificationErrors;
        protected string baseURL;

        public HelperLogin loginHelper;
        public HelperNavigation navigator;
        public HelperGroup groupHelper;

        //protected ApplicationManager app;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/addressbook/";
            verificationErrors = new StringBuilder();

            loginHelper = new HelperLogin(driver);
            navigator = new HelperNavigation(driver, baseURL);
            groupHelper = new HelperGroup(driver);
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }








    }
}
