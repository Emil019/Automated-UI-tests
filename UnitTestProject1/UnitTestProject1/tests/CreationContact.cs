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
    public class CreationContacts : BaseTest
    {
        [Test]
        public void CreationContact()
        {
            app.Navigator.GoToHome();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToCreationContact();
            app.ContactHelper.CreationNewContact();
        }
    }
}



            


       
            
            
            
        



       
        

     


      
























           
            
           

