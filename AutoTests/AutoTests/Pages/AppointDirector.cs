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
    class AppointDirector : PageObject
    {
        private readonly IWebDriver _driver;
        private readonly string _numberProject;
        private readonly string MakeAppointDirectorXpath = ConfigurationHelper.Get<string>("MakeAppointDirectorXpath");
        private readonly string AddNewRecordOnCollectionXpath = ConfigurationHelper.Get<string>("AddNewRecordOnCollectionXpath");
        private readonly string CollectionFieldXpath = ConfigurationHelper.Get<string>("CollectionFieldXpath");
        private readonly string DropDownXpath = ConfigurationHelper.Get<string>("DropDownXpath");
        private readonly string FirstListCheckBoxXpath = ConfigurationHelper.Get<string>("FirstListCheckBoxXpath");
        private readonly string ButtonOnToolbarXpath = ConfigurationHelper.Get<string>("ButtonOnToolbarXpath");
        private readonly string ButtonCompleteXpath = ConfigurationHelper.Get<string>("ButtonCompleteXpath");
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath");
        public AppointDirector(IWebDriver driver, string numberProject) : base(driver)
        {
            _driver = driver;
            _numberProject = numberProject;
        }
        public IWebElement MakeAppointDirector { get { return _driver.FindElement(By.XPath("" + MakeAppointDirectorXpath + " ("+ _numberProject + " - TestName)']")); } }
        public IWebElement AddNewRecordOnCollection { get { return _driver.FindElement(By.XPath("" + AddNewRecordOnCollectionXpath + "")); } }
        public IWebElement CollectionField { get { return _driver.FindElement(By.XPath("" + CollectionFieldXpath + "[3]")); } }
        public IWebElement UserSendKeys { get { return _driver.FindElement(By.XPath("(" + DropDownXpath + ")[4]")); } }
        public IWebElement FirstListCheckBox { get { return _driver.FindElement(By.XPath("" + FirstListCheckBoxXpath + "")); } }
        public IWebElement CompleteTaskButton { get { return _driver.FindElement(By.XPath("" + ButtonCompleteXpath + "")); } }
        public IWebElement Loader { get { return _driver.FindElement(By.XPath("" + LoaderXpath + "")); } }

        public void CompleteTask()
        {
            //Thread.Sleep(15000);
            SeleniumHelper.waitUntilElementVisibile(MakeAppointDirector, 20000);
            SeleniumHelper.waitUntilElementInvisibile(Loader, 50000);
            Thread.Sleep(2000);
            Actions act = new Actions(_driver);
            act.DoubleClick(MakeAppointDirector).Perform();
            Thread.Sleep(2000);
            AddNewRecordOnCollection.Click();
            Thread.Sleep(2000);
            CollectionField.Click();
            UserSendKeys.SendKeys("Rukovoditel");
            Thread.Sleep(2000);
            FirstListCheckBox.Click();
            Thread.Sleep(5000);
            CompleteTaskButton.Click();
            SeleniumHelper.waitUntilElementInvisibile(Loader, 10000);
            //Thread.Sleep(10000);
        }
    }
}
