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
    public class CreationContacts :BaseTest
    {

        [Test]
        public void CreationContact()
        {
            navigator.GoToHome();
            loginHelper.Login(new AccountData("admin", "secret"));
            navigator.GoToCreationContact();

            //contactHelper.FillContactForm(new ContactData("test", "testov", "11111111111", "q@q.q", "Qwerty 1"));  //!!!!

            FillContactForm(); //(string Firstname, string Lastname, string Mobile, string Email, string Address)
           

            //contactHelper.SubmitContactCreation();
            navigator.ReturnToContacts();
            navigator.Logout();
        }
        private void FillContactForm() //(string Firstname, string Lastname, string Mobile, string Email, string Address)
        {
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys("qwer");
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys("qwer");
            driver.FindElement(By.Name("mobile")).Clear();
            driver.FindElement(By.Name("mobile")).SendKeys("qwer");
            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys("qwer");
            driver.FindElement(By.Name("address2")).Clear();
            driver.FindElement(By.Name("address2")).SendKeys("qwer");
        }
    }
}





