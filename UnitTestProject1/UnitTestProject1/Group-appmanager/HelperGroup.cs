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


        public HelperGroup(IWebDriver driver)
            : base(driver)
        {

        }
        public void CreationNewGroup(GroupData group)
        {
            driver.FindElement(By.Name("new")).Click();

            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);

            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);

            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);

            driver.FindElement(By.Name("submit")).Click();
        }
        public void ReturnToGroups()
        {
            driver.FindElement(By.LinkText("group page")).Click();

        }
        public void SelectGroup()
        {
            driver.FindElement(By.Name("selected[]")).Click();
        }
        public void RemoveGroup()
        {
            driver.FindElement(By.XPath("(//input[@name='delete'])")).Click();
        }
    }
}
