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
    public class HelperContact : BaseHelper
    {


        public HelperContact(IWebDriver driver)
            : base(driver)
        {

        }
        public void SubmitContactCreation()
        //public void CreationNewGroup(ContactData group)
        {
            driver.FindElement(By.XPath("(//input[@name='submit'])[2]")).Click();
        }
        //public void FillContactForm(ContactData contact)
        //{
        //    driver.FindElement(By.Name("firstname")).Clear();
        //    driver.FindElement(By.Name("firstname")).SendKeys(contact.Firstname);
        //    driver.FindElement(By.Name("lastname")).Clear();
        //    driver.FindElement(By.Name("lastname")).SendKeys(contact.Lastname);
        //    driver.FindElement(By.Name("mobile")).Clear();
        //    driver.FindElement(By.Name("mobile")).SendKeys(contact.Mobile);
        //    driver.FindElement(By.Name("email")).Clear();
        //    driver.FindElement(By.Name("email")).SendKeys(contact.Email);
        //    driver.FindElement(By.Name("address2")).Clear();
        //    driver.FindElement(By.Name("address2")).SendKeys(contact.Address);
        //}

    }
}