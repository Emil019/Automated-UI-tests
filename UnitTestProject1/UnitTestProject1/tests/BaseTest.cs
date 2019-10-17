using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests
{
       [TestFixture]
    public class BaseTest
    {
        protected ApplicationManager app; //здесь ошибка
       
       [SetUp]
        public void SetupTest()
        {
            app = new ApplicationManager();

            app.Navigator.GoToHome();
            app.Navigator.GoToGroups();  

        }

        [TearDown]
        public void TeardownTest()  
        {
            app.Stop();
        }
    }
}











       
      


     


