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
            app.Auth.Login(new AccountData("admin", "secret"));

            GroupData group = new GroupData("aaa");
            group.Header = "bbb";
            group.Footer = "ccc";


            app.GroupHelper
                .InitGroupCreation()
                .FillGroupForm(group)
                .SubmitGroupCreation()
                .ReturnToGroups();
            app.Navigator.Logout();
        }
    }
}
             

           



