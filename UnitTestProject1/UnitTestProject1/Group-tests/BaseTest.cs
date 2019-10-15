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

        public HelperContact contactHelper;
     
     


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




        protected void GoToHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);


        }
      


        protected void CreationNewContact()
        {
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys("q");
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys("q");
            driver.FindElement(By.Name("company")).Clear();
            driver.FindElement(By.Name("company")).SendKeys("Qwerty");
            driver.FindElement(By.Name("mobile")).Clear();
            driver.FindElement(By.Name("mobile")).SendKeys("1111111111");
            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys("q@q.q");
            driver.FindElement(By.Name("address2")).Clear();
            driver.FindElement(By.Name("address2")).SendKeys("Qqqq 1");
            driver.FindElement(By.XPath("(//input[@name='submit'])[2]")).Click();
        }



    }
}








