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
        private readonly SeleniumHelperWithExpectedConditions selenium;
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
        private readonly string VerticalLayoutXpath = ConfigurationHelper.Get<string>("VerticalLayoutXpath");
        public AcceptPhaseOPE(IWebDriver driver):base(driver)
        {
            _driver = driver;
            selenium = new SeleniumHelperWithExpectedConditions(_driver);
        }
        public void CompleteTask()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.CheckElementIsVisible(By.XPath(AcceptPhaseOPEXpath));

            //Actions act = new Actions(_driver);
            //act.DoubleClick(AcceptPhase).Perform();
            selenium.DoubleClick(By.XPath(AcceptPhaseOPEXpath));

            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(AcceptPhaseTabXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + AddNewRecordOnCollectionXpath + ")[3]"));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[139]"));
            selenium.Click(By.XPath("(" + DropDownXpath + ")[9]"));
            selenium.Click(By.XPath(PhaseOPEAktOPEAcceptXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[140]"));
            selenium.Click(By.XPath("(" + AcceptStatusXpath + ")[5]"));
            selenium.Click(By.XPath(AcceptPhaseTabXpath));
            Thread.Sleep(2000);
            selenium.Click(By.XPath("(" + AddNewRecordOnCollectionXpath + ")[3]"));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[144]"));
            selenium.Click(By.XPath("(" + DropDownXpath + ")[9]"));
            selenium.Click(By.XPath(PhaseOPEAktPEAcceptXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[145]"));
            selenium.Click(By.XPath("(" + AcceptStatusXpath + ")[6]"));
            selenium.Click(By.XPath(AcceptPhaseTabXpath));
            Thread.Sleep(2000);
            selenium.Click(By.XPath(ButtonCompleteXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
    }
}
