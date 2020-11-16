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
        private readonly string MakeTurnProjectXpath = ConfigurationHelper.Get<string>("MakeTurnProjectXpath");
        private readonly string ButtonOnToolbarXpath = ConfigurationHelper.Get<string>("ButtonOnToolbarXpath");
        private readonly string RadioButtonXpath = ConfigurationHelper.Get<string>("RadioButtonXpath");
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath");
        private WebDriverWait wait;
        public TurnProject(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
        }
        public IWebElement MakeTurnProject { get { return _driver.FindElement(By.XPath("" + MakeTurnProjectXpath + "")); } }
        public IWebElement RadioButton { get { return _driver.FindElement(By.XPath("" + RadioButtonXpath + "")); } }
        public IWebElement CompleteTaskButton { get { return _driver.FindElement(By.XPath("" + ButtonOnToolbarXpath + "")); } }
        public IWebElement Loader { get { return _driver.FindElement(By.XPath("" + LoaderXpath + "")); } }
        public void CompleteTask()
        {
            SeleniumHelper.waitUntilElementVisibile(MakeTurnProject, 20000);
            Actions act = new Actions(_driver);
            act.DoubleClick(MakeTurnProject).Perform();
            SeleniumHelper.waitUntilElementInvisibile(Loader, 10000);
            //Thread.Sleep(2000);
            RadioButton.Click();
            CompleteTaskButton.Click();
            SeleniumHelper.waitUntilElementInvisibile(Loader, 10000);
            //Thread.Sleep(5000);
        }
    }
}
