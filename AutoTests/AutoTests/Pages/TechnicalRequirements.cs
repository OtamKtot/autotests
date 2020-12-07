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
    class TechnicalRequirements : PageObject
    {
        private readonly IWebDriver _driver;
        private readonly SeleniumHelperWithExpectedConditions selenium;
        private readonly string MakeTechnicalRequirementXpath = ConfigurationHelper.Get<string>("MakeTechnicalRequirementXpath");
        private readonly string TextFieldOnGroupXpath = ConfigurationHelper.Get<string>("TextFieldOnGroupXpath");
        private readonly string AddRecordToCollectionXpath = ConfigurationHelper.Get<string>("AddRecordToCollectionXpath");
        private readonly string FirstElementFromListXpath = ConfigurationHelper.Get<string>("FirstElementFromListXpath");
        private readonly string ButtonOnToolbarXpath = ConfigurationHelper.Get<string>("ButtonOnToolbarXpath");
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath"); 
        private readonly string LoaderVisibleXpath = ConfigurationHelper.Get<string>("LoaderVisibleXpath");
        public TechnicalRequirements(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            selenium = new SeleniumHelperWithExpectedConditions(_driver);
        }
        public IWebElement MakeTechnicalRequirement { get { return _driver.FindElement(By.XPath("" + MakeTechnicalRequirementXpath + "")); } }
        public IWebElement Goal { get { return _driver.FindElement(By.XPath("" + TextFieldOnGroupXpath + "")); } }
        public IWebElement Effect { get { return _driver.FindElement(By.XPath("(" + TextFieldOnGroupXpath + ")[2]")); } }
        public IWebElement AddRecordToCollection { get { return _driver.FindElement(By.XPath("" + AddRecordToCollectionXpath + "")); } }
        public IWebElement FirstElementList { get { return _driver.FindElement(By.XPath("" + FirstElementFromListXpath + "")); } }
        public IWebElement CompleteTaskButton { get { return _driver.FindElement(By.XPath("" + ButtonOnToolbarXpath + "")); } }
        public IWebElement Loader { get { return _driver.FindElement(By.XPath("" + LoaderXpath + "")); } }        
        public IWebElement LoaderVisible { get { return _driver.FindElement(By.XPath("" + LoaderVisibleXpath + "")); } }
        public void CompleteTask()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(MakeTechnicalRequirementXpath));

            Actions act = new Actions(_driver);
            act.DoubleClick(MakeTechnicalRequirement).Perform();

            selenium.SendKeys(By.XPath(TextFieldOnGroupXpath),"TestName");
            selenium.SendKeys(By.XPath("(" + TextFieldOnGroupXpath + ")[2]"), "TestName");
            selenium.Click(By.XPath(AddRecordToCollectionXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(FirstElementFromListXpath));
            selenium.Click(By.XPath(ButtonOnToolbarXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CompleteTaskTest()
        {
            //SeleniumHelper.waitUntilElementInvisibile(Loader, 10000);
            //Thread.Sleep(8000);
            Assert.IsTrue(SeleniumHelper.WaitForToBeNotVisibleAndPresent(_driver, LoaderXpath, 30));
            MakeTechnicalRequirement.Click();
            Actions act = new Actions(_driver);
            act.DoubleClick(MakeTechnicalRequirement).Perform();
            Goal.SendKeys("TestName");
            Effect.SendKeys("TestName");
            AddRecordToCollection.Click();
            Assert.IsTrue(SeleniumHelper.WaitForToBeNotVisibleAndPresent(_driver, LoaderXpath, 30));
            //SeleniumHelper.waitUntilElementInvisibile(Loader, 10000);
            //Thread.Sleep(2000);
            Assert.IsTrue(SeleniumHelper.WaitForToBeDisplayed(_driver, FirstElementFromListXpath, 2));
            FirstElementList.Click();
            //Thread.Sleep(2000);
            CompleteTaskButton.Click();
            Assert.IsTrue(SeleniumHelper.WaitForToBeNotVisibleAndPresent(_driver, LoaderXpath, 30));
            //SeleniumHelper.waitUntilElementInvisibile(Loader, 10000);
            //Thread.Sleep(8000);
        }
    }
}
