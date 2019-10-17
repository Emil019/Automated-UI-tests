using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{

    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string baseURL;


        protected HelperLogin loginHelper;
        protected HelperNavigation navigator;
        protected HelperGroup groupHelper;
        protected HelperContact contactHelper;

        public ApplicationManager()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/addressbook/";
            

            loginHelper = new HelperLogin(driver);
            navigator = new HelperNavigation(driver, baseURL);
            groupHelper = new HelperGroup(driver);
            contactHelper = new HelperContact(driver);
        }

        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
           
        }

        public HelperLogin Auth
        {
            get
            {
                return loginHelper;

            }

        }

        public HelperNavigation Navigator
        {
            get
            {
                return navigator;

            }
        }

        public HelperGroup GroupHelper
        {
            get
            {
                return groupHelper;

            }
        }

        public HelperContact ContactHelper
        {
            get
            {
                return contactHelper;

            }
        }
    }
}
