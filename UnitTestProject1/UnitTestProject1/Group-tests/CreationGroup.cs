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
    public class CreationGroupTests : BaseTest
    {
        [Test]
        public void CreationGroup()
        {
            navigator.GoToHome();
            loginHelper.Login(new AccountData("admin", "secret"));
            navigator.GoToGroups();
            groupHelper.CreationNewGroup(new GroupData("A", "B", "C"));
            groupHelper.ReturnToGroups();
            navigator.Logout();
        }
    }
}
