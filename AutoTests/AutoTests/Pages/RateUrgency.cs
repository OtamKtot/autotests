using AutoTests.SeleniumHelpers;
using AutoTests.Utilies;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoTests.Pages
{
    class RateUrgency : PageObject
    {
        private readonly IWebDriver _driver;
        private readonly string MakeRateUrgencyXpath = ConfigurationHelper.Get<string>("MakeRateUrgencyXpath");
        private readonly string RadioButtonXpath = ConfigurationHelper.Get<string>("RadioButtonXpath");
        private readonly string ButtonOnToolbarXpath = ConfigurationHelper.Get<string>("ButtonOnToolbarXpath");
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath");
        public RateUrgency(IWebDriver driver) : base (driver)
        {
            _driver = driver;
        }
        public IWebElement MakeRateUrgency { get { return _driver.FindElement(By.XPath("" + MakeRateUrgencyXpath + "")); } }
        public IWebElement RadioButton { get { return _driver.FindElement(By.XPath("" + RadioButtonXpath + "")); } }
        public IWebElement CompleteTaskButton { get { return _driver.FindElement(By.XPath("" + ButtonOnToolbarXpath + "")); } }
        public IWebElement Loader { get { return _driver.FindElement(By.XPath("" + LoaderXpath + "")); } }
        public void CompleteTask()
        {
            Assert.IsTrue(SeleniumHelper.WaitForToBeNotVisibleAndPresent(_driver, LoaderXpath, 30));
            //SeleniumHelper.waitUntilElementVisibile(MakeRateUrgency, 20000);
            Actions act = new Actions(_driver);
            act.DoubleClick(MakeRateUrgency).Perform();
            Assert.IsTrue(SeleniumHelper.WaitForToBeNotVisibleAndPresent(_driver, LoaderXpath, 30));
            //SeleniumHelper.waitUntilElementInvisibile(Loader, 10000);
            RadioButton.Click();
            //Thread.Sleep(2000);
            CompleteTaskButton.Click();
            Assert.IsTrue(SeleniumHelper.WaitForToBeNotVisibleAndPresent(_driver, LoaderXpath, 30));
            //SeleniumHelper.waitUntilElementInvisibile(Loader, 10000);
            //Thread.Sleep(2000);
        }
    }
}
