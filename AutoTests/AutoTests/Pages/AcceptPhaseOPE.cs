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
    class AcceptPhaseOPE : PageObject
    {
        private readonly IWebDriver _driver;
        private readonly string AcceptPhaseOPEXpath = ConfigurationHelper.Get<string>("AcceptPhaseOPEXpath");
        private readonly string AcceptPhaseTabXpath = ConfigurationHelper.Get<string>("AcceptPhaseTabXpath");
        private readonly string AddNewRecordOnCollectionXpath = ConfigurationHelper.Get<string>("AddNewRecordOnCollectionXpath");
        private readonly string CollectionFieldXpath = ConfigurationHelper.Get<string>("CollectionFieldXpath");
        private readonly string DropDownXpath = ConfigurationHelper.Get<string>("DropDownXpath");
        private readonly string PhaseOPEAktOPEAcceptXpath = ConfigurationHelper.Get<string>("PhaseOPEAktOPEAcceptXpath");
        private readonly string PhaseOPEAktPEAcceptXpath = ConfigurationHelper.Get<string>("PhaseOPEAktPEAcceptXpath");
        private readonly string AcceptStatusXpath = ConfigurationHelper.Get<string>("AcceptStatusXpath");
        private readonly string ButtonCompleteXpath = ConfigurationHelper.Get<string>("ButtonCompleteXpath");
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath");
        public AcceptPhaseOPE(IWebDriver driver):base(driver)
        {
            _driver = driver;
        }
        public IWebElement AcceptPhase { get { return _driver.FindElement(By.XPath("" + AcceptPhaseOPEXpath + "")); } }
        public IWebElement AddNewRecordOnCollection { get { return _driver.FindElement(By.XPath("(" + AddNewRecordOnCollectionXpath + ")[4]")); } }
        public IWebElement AcceptPhaseTab { get { return _driver.FindElement(By.XPath("" + AcceptPhaseTabXpath + "")); } }
        public IWebElement NameClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[139]")); } }
        public IWebElement NameSendKeys { get { return _driver.FindElement(By.XPath("(" + DropDownXpath + ")[9]")); } }
        public IWebElement PhaseOPEAktOPEAccept { get { return _driver.FindElement(By.XPath("" + PhaseOPEAktOPEAcceptXpath + "")); } }
        public IWebElement StatusClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[140]")); } }
        public IWebElement StatusSendKeys { get { return _driver.FindElement(By.XPath("(" + DropDownXpath + ")[9]")); } }
        public IWebElement AcceptStatus { get { return _driver.FindElement(By.XPath("(" + AcceptStatusXpath + ")[5]")); } }
        public IWebElement Name2Click { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[144]")); } }
        public IWebElement Status2Click { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[145]")); } }
        public IWebElement PhaseOPEAktPEAccept { get { return _driver.FindElement(By.XPath("" + PhaseOPEAktPEAcceptXpath + "")); } }
        public IWebElement AcceptStatus2 { get { return _driver.FindElement(By.XPath("(" + AcceptStatusXpath + ")[6]")); } }
        public IWebElement CompleteTaskButton { get { return _driver.FindElement(By.XPath("" + ButtonCompleteXpath + "")); } }
        public IWebElement Loader { get { return _driver.FindElement(By.XPath("" + LoaderXpath + "")); } }

        public void CompleteTask()
        {
            //Thread.Sleep(5000);
            SeleniumHelper.waitUntilElementVisibile(AcceptPhase, 20000);
            Actions act = new Actions(_driver);
            act.DoubleClick(AcceptPhase).Perform();
            Thread.Sleep(2000);
            AcceptPhaseTab.Click();
            Thread.Sleep(2000);
            AddNewRecordOnCollection.Click();
            Thread.Sleep(2000);
            NameClick.Click();
            NameSendKeys.Click();
            Thread.Sleep(2000);
            PhaseOPEAktOPEAccept.Click();
            Thread.Sleep(2000);
            StatusClick.Click();
            //StatusSendKeys.Click();
            Thread.Sleep(2000);
            AcceptStatus.Click();
            Thread.Sleep(2000);
            AddNewRecordOnCollection.Click();
            Thread.Sleep(2000);
            Name2Click.Click();
            //NameSendKeys.Click();
            Thread.Sleep(2000);
            PhaseOPEAktPEAccept.Click();
            Thread.Sleep(2000);
            Status2Click.Click();
            //StatusSendKeys.Click();
            Thread.Sleep(2000);
            AcceptStatus2.Click();
            CompleteTaskButton.Click();
            SeleniumHelper.waitUntilElementInvisibile(Loader, 10000);
            //Thread.Sleep(10000);
        }
    }
}
