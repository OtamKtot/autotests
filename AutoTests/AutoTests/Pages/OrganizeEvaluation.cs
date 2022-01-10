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
        private readonly SeleniumHelperWithExpectedConditions selenium;
        private readonly string MakeOrganizeEvaluationXpath = ConfigurationHelper.Get<string>("MakeOrganizeEvaluationXpath");
        private readonly string ButtonOnToolbarXpath = ConfigurationHelper.Get<string>("ButtonOnToolbarXpath");
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath");
        public OrganizeEvaluation(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            selenium = new SeleniumHelperWithExpectedConditions(_driver);
        }
        public void CompleteTask()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.CheckElementIsVisible(By.XPath(MakeOrganizeEvaluationXpath));

            //Actions act = new Actions(_driver);
            //act.DoubleClick(MakeOrganizeEvaluation).Perform();
            selenium.DoubleClick(By.XPath(MakeOrganizeEvaluationXpath));

            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(ButtonOnToolbarXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
    }
}
