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
using AutoTests.SeleniumHelpers;
using NUnit.Framework;

namespace AutoTests.Pages
{
    class AcceptPhaseCP : PageObject
    {
        private readonly IWebDriver _driver;
        private readonly SeleniumHelperWithExpectedConditions selenium;
        private readonly string AcceptPhaseCPXpath = ConfigurationHelper.Get<string>("AcceptPhaseCPXpath");
        private readonly string AcceptPhaseTabXpath = ConfigurationHelper.Get<string>("AcceptPhaseTabXpath");
        private readonly string AddNewRecordOnCollectionXpath = ConfigurationHelper.Get<string>("AddNewRecordOnCollectionXpath");
        private readonly string CollectionFieldXpath = ConfigurationHelper.Get<string>("CollectionFieldXpath");
        private readonly string DropDownXpath = ConfigurationHelper.Get<string>("DropDownXpath");
        private readonly string PhaseCPTaskAcceptXpath = ConfigurationHelper.Get<string>("PhaseCPTaskAcceptXpath");
        private readonly string PhaseCPTicketAcceptXpath = ConfigurationHelper.Get<string>("PhaseCPTicketAcceptXpath");
        private readonly string AcceptStatusXpath = ConfigurationHelper.Get<string>("AcceptStatusXpath");
        private readonly string ButtonCompleteXpath = ConfigurationHelper.Get<string>("ButtonCompleteXpath");
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath");
        private readonly string VerticalLayoutXpath = ConfigurationHelper.Get<string>("VerticalLayoutXpath");
        public AcceptPhaseCP(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            selenium = new SeleniumHelperWithExpectedConditions(_driver);
        }
        public IWebElement AcceptPhase { get { return _driver.FindElement(By.XPath("" + AcceptPhaseCPXpath + "")); } }
        public IWebElement AddNewRecordOnCollection { get { return _driver.FindElement(By.XPath("(" + AddNewRecordOnCollectionXpath + ")[4]")); } }
        public IWebElement AcceptPhaseTab { get { return _driver.FindElement(By.XPath("" + AcceptPhaseTabXpath + "")); } }
        public IWebElement NameClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[236]")); } }
        public IWebElement NameSendKeys { get { return _driver.FindElement(By.XPath("(" + DropDownXpath + ")[9]")); } }
        public IWebElement PhaseCPTaskAccept { get { return _driver.FindElement(By.XPath("" + PhaseCPTaskAcceptXpath + "")); } }
        public IWebElement StatusClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[237]")); } }
        public IWebElement StatusSendKeys { get { return _driver.FindElement(By.XPath("(" + DropDownXpath + ")[9]")); } }
        public IWebElement AcceptStatus { get { return _driver.FindElement(By.XPath("" + AcceptStatusXpath + "")); } }
        public IWebElement Name2Click { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[241]")); } }
        public IWebElement Status2Click { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[242]")); } }
        public IWebElement PhaseCPTicketAccept { get { return _driver.FindElement(By.XPath("" + PhaseCPTicketAcceptXpath + "")); } }
        public IWebElement AcceptStatus2 { get { return _driver.FindElement(By.XPath("(" + AcceptStatusXpath + ")[2]")); } }
        public IWebElement CompleteTaskButton { get { return _driver.FindElement(By.XPath("" + ButtonCompleteXpath + "")); } }
        public IWebElement Loader { get { return _driver.FindElement(By.XPath("" + LoaderXpath + "")); } }

        public void CompleteTask()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.CheckElementIsVisible(By.XPath(AcceptPhaseCPXpath));

            //Actions act = new Actions(_driver);
            //act.DoubleClick(AcceptPhase).Perform();
            selenium.DoubleClick(By.XPath(AcceptPhaseCPXpath));

            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(AcceptPhaseTabXpath));
            selenium.Click(By.XPath("(" + AddNewRecordOnCollectionXpath + ")[3]"));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[236]"));
            selenium.Click(By.XPath("(" + DropDownXpath + ")[9]"));
            selenium.Click(By.XPath(PhaseCPTaskAcceptXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[237]"));
            selenium.Click(By.XPath(AcceptStatusXpath));
            selenium.Click(By.XPath(VerticalLayoutXpath));
            Thread.Sleep(2000);
            selenium.Click(By.XPath("(" + AddNewRecordOnCollectionXpath + ")[3]"));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[241]"));
            selenium.Click(By.XPath("(" + DropDownXpath + ")[9]"));
            selenium.Click(By.XPath(PhaseCPTicketAcceptXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[242]"));
            selenium.Click(By.XPath("(" + AcceptStatusXpath + ")[2]"));
            selenium.Click(By.XPath(VerticalLayoutXpath));
            Thread.Sleep(2000);
            selenium.Click(By.XPath(ButtonCompleteXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
    }
}
