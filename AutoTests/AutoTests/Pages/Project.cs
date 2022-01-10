using AutoTests.SeleniumHelpers;
using AutoTests.Utilies;
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
    class Project : PageObject
    {
        private readonly IWebDriver _driver;
        private readonly string _numberProject;
        private readonly SeleniumHelperWithExpectedConditions selenium;
        private readonly string TitleXpath = ConfigurationHelper.Get<string>("TitleXpath");
        private readonly string GoToTaskXpath = ConfigurationHelper.Get<string>("GoToTaskXpath");
        private readonly string ColumnsOfListXpath = ConfigurationHelper.Get<string>("ColumnsOfListXpath");
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath");
        public Project(IWebDriver driver, string numberProject) : base(driver)
        {
            _driver = driver;
            _numberProject = numberProject;
            selenium = new SeleniumHelperWithExpectedConditions(_driver);
        }
        public void CompleteTask()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("("+ ColumnsOfListXpath+")[3]"));
            selenium.PageDown();
            selenium.CheckElementIsVisible(By.XPath("" + TitleXpath + _numberProject + "']"));

            //Actions act = new Actions(_driver);
            //act.DoubleClick(ProjectClick).Perform();
            selenium.DoubleClick(By.XPath("" + TitleXpath + _numberProject + "']"));

            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(GoToTaskXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
    }
}