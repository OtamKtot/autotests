using AutoTests.SeleniumHelpers;
using AutoTests.Utilies;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoTests.Pages
{
    class TurnProject : PageObject
    {
        private readonly IWebDriver _driver;
        private readonly SeleniumHelperWithExpectedConditions selenium;
        private readonly string MakeTurnProjectXpath = ConfigurationHelper.Get<string>("MakeTurnProjectXpath");
        private readonly string ButtonOnToolbarXpath = ConfigurationHelper.Get<string>("ButtonOnToolbarXpath");
        private readonly string RadioButtonXpath = ConfigurationHelper.Get<string>("RadioButtonXpath");
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath");
        public TurnProject(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            selenium = new SeleniumHelperWithExpectedConditions(_driver);
        }
        public IWebElement MakeTurnProject { get { return _driver.FindElement(By.XPath("" + MakeTurnProjectXpath + "")); } }
        public IWebElement RadioButton { get { return _driver.FindElement(By.XPath("" + RadioButtonXpath + "")); } }
        public IWebElement CompleteTaskButton { get { return _driver.FindElement(By.XPath("" + ButtonOnToolbarXpath + "")); } }
        public IWebElement Loader { get { return _driver.FindElement(By.XPath("" + LoaderXpath + "")); } }
        public void CompleteTask()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.CheckElementIsVisible(By.XPath(MakeTurnProjectXpath));

            //Actions act = new Actions(_driver);
            //act.DoubleClick(MakeTurnProject).Perform();
            selenium.DoubleClick(By.XPath(MakeTurnProjectXpath));

            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(RadioButtonXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(ButtonOnToolbarXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            //Thread.Sleep(5000);
        }
    }
}
