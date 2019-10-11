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
    public class CreationContacts
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/addressbook/";
            verificationErrors = new StringBuilder();
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

        [Test]
        public void CreationContact()
        {
            GoToHome();
            Login(new AccountData("admin","secret"));
            GoToCreationContact();
            ContactData contact = new ContactData("test");
            contact.Lastname = "testov";
            contact.Mobile = "11111111111";
            contact.Email = "q@q.q";
            contact.Address = "Qwerty 1";
            SubmitContactCreation();
            ReturnToContacts();
        }
            

        private void ReturnToContacts()
        {
            driver.FindElement(By.LinkText("home page")).Click();
        }

          private void SubmitContactCreation()
        { 
            driver.FindElement(By.XPath("(//input[@name='submit'])[2]")).Click();
        }
        private void FillContactForm(ContactData contact)
        {
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contact.Firstname);
            //driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contact.Lastname);
            driver.FindElement(By.Name("mobile")).Clear();
            driver.FindElement(By.Name("mobile")).SendKeys(contact.Mobile);
            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys(contact.Email);
            driver.FindElement(By.Name("address2")).Clear();
            driver.FindElement(By.Name("address2")).SendKeys(contact.Address);
        }
       
          private void GoToCreationContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }
        private void Login(AccountData account)
        {
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys(account.username);
            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys(account.password);
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }

        private void GoToHome()
        {
            driver.Navigate().GoToUrl("http://localhost/addressbook/");
        }

    }
}
