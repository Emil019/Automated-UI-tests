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
    public class HelperGroup : BaseHelper
    {


        public HelperGroup(IWebDriver driver) : base(driver)
        {
        }

        public HelperGroup InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }
        public HelperGroup FillGroupForm(GroupData group)
        {
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
            return this;
        }
        public HelperGroup SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }
        public HelperGroup ReturnToGroups()
        {
            driver.FindElement(By.LinkText("group page")).Click();
            return this;
        }
        public HelperGroup SelectGroup()
        {
            driver.FindElement(By.Name("selected[]")).Click();
            return this;
        }
        public HelperGroup RemoveGroup()
        {
            driver.FindElement(By.XPath("(//input[@name='delete'])")).Click();
            return this;
        }
    }
}


