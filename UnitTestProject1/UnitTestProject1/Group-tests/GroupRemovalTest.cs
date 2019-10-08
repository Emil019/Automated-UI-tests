using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : BaseTest
    {
        [Test]
        public void GroupRemovalTest()
        {
            navigator.GoToHome();
            loginHelper.Login(new AccountData("admin", "secret"));
            navigator.GoToGroups();
            groupHelper.SelectGroup();
            groupHelper.RemoveGroup();
            groupHelper.ReturnToGroups();
            //  Logout();
        }
    }
}



