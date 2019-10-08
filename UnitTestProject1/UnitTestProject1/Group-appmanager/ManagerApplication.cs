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
    class ApplicationManager
    {
        protected IWebDriver driver;
        public StringBuilder verificationErrors;
        public HelperLogin loginHelper;

        protected HelperLogin loginHelper;
        protected HelperNavigation navigator;
        protected HelperGroup groupHelper;

        public ApplicationManager()
        {
            loginHelper = new HelperLogin(driver);
            navigator = new HelperNavigation(driver, baseURL);
            groupHelper = new HelperGroup(driver);
        }
    }
}
