using AutoTests.SeleniumHelpers;
using AutoTests.Utilies;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using Tests.SeleniumHelperss;

namespace AutoTests.Pages
{
    class LoginPage : PageObject
    {
        private readonly IWebDriver _driver;
        private readonly SeleniumHelperWithExpectedConditions selenium;
        private readonly int ExplicityWait = ConfigurationHelper.Get<int>("ExplicityWait");
        private readonly string UserNameXpath = ConfigurationHelper.Get<string>("UserNameXpath");
        private readonly string PasswordXpath = ConfigurationHelper.Get<string>("PasswordXpath");
        private readonly string LoginButtonXpath = ConfigurationHelper.Get<string>("LoginButtonXpath");
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath");
        // private WebDriverWait wait;

        public LoginPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            selenium = new SeleniumHelperWithExpectedConditions(_driver);
        }
        public IWebElement UserName { get { return _driver.FindElement(By.XPath("" + UserNameXpath + "")); } }
        public IWebElement Password { get { return _driver.FindElement(By.XPath("" + PasswordXpath + "")); } }
        public IWebElement Submit { get { return _driver.FindElement(By.XPath("" + LoginButtonXpath + "")); } }
        public IWebElement Loader { get { return _driver.FindElement(By.XPath("" + LoaderXpath + "")); } }
        public void Login(Account acc)
        {
            UserName.SendKeys(@"" + acc.Username);
            Password.SendKeys(@"" + acc.Password);
        }
    }
}
