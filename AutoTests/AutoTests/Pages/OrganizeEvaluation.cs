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
    class OrganizeEvaluation : PageObject
    {
        private readonly IWebDriver _driver;
        private readonly string MakeOrganizeEvaluationXpath = ConfigurationHelper.Get<string>("MakeOrganizeEvaluationXpath");
        private readonly string ButtonOnToolbarXpath = ConfigurationHelper.Get<string>("ButtonOnToolbarXpath");
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath");
        public OrganizeEvaluation(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }
        public IWebElement MakeOrganizeEvaluation { get { return _driver.FindElement(By.XPath("" + MakeOrganizeEvaluationXpath + "")); } }
        public IWebElement CompleteTaskButton { get { return _driver.FindElement(By.XPath("" + ButtonOnToolbarXpath + "")); } }
        public IWebElement Loader { get { return _driver.FindElement(By.XPath("" + LoaderXpath + "")); } }
        public void CompleteTask()
        {
            SeleniumHelper.waitUntilElementVisibile(MakeOrganizeEvaluation, 20000);
            SeleniumHelper.waitUntilElementInvisibile(Loader, 10000);
            Actions act = new Actions(_driver);
            act.DoubleClick(MakeOrganizeEvaluation).Perform();
            SeleniumHelper.waitUntilElementInvisibile(Loader, 10000);
            Thread.Sleep(1000);
            CompleteTaskButton.Click();
            SeleniumHelper.waitUntilElementInvisibile(Loader, 10000);
            //Thread.Sleep(2000);
        }
    }
}
