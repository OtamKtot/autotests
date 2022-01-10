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
        private readonly SeleniumHelperWithExpectedConditions selenium;
        private readonly string MakeRateUrgencyXpath = ConfigurationHelper.Get<string>("MakeRateUrgencyXpath");
        private readonly string RadioButtonXpath = ConfigurationHelper.Get<string>("RadioButtonXpath");
        private readonly string ButtonOnToolbarXpath = ConfigurationHelper.Get<string>("ButtonOnToolbarXpath");
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath");
        public RateUrgency(IWebDriver driver) : base (driver)
        {
            _driver = driver;
            selenium = new SeleniumHelperWithExpectedConditions(_driver);
        }
        public void CompleteTask()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));

            //Actions act = new Actions(_driver);
            //act.DoubleClick(MakeRateUrgency).Perform();
            selenium.DoubleClick(By.XPath(MakeRateUrgencyXpath));

            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(RadioButtonXpath));
            selenium.Click(By.XPath(ButtonOnToolbarXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
    }
}
