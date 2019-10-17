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
            app.Navigator.GoToHome();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToGroups();
            app.GroupHelper.SelectGroup()
                           .RemoveGroup()
                           .ReturnToGroups();
           
        }
    }
}



