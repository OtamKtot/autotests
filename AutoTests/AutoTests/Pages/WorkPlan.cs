using AutoTests.SeleniumHelpers;
using AutoTests.Utilies;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoTests.Pages
{
    class WorkPlan : PageObject
    {
        private readonly IWebDriver _driver;
        private readonly SeleniumHelperWithExpectedConditions selenium;
        private readonly string CreateWorkPlanXpath = ConfigurationHelper.Get<string>("CreateWorkPlanXpath");
        private readonly string TextFieldXpath = ConfigurationHelper.Get<string>("TextFieldXpath");
        private readonly string DropDownXpath = ConfigurationHelper.Get<string>("DropDownXpath");
        private readonly string FirstElementFromListXpath = ConfigurationHelper.Get<string>("FirstElementFromListXpath");
        private readonly string FirstListCheckBoxXpath = ConfigurationHelper.Get<string>("FirstListCheckBoxXpath");
        private readonly string SaveButtonXpath = ConfigurationHelper.Get<string>("SaveButtonXpath");
        private readonly string TabWorkGroupXpath = ConfigurationHelper.Get<string>("TabWorkGroupXpath");
        private readonly string AddNewRecordOnCollectionXpath = ConfigurationHelper.Get<string>("AddNewRecordOnCollectionXpath");
        private readonly string CollectionFieldXpath = ConfigurationHelper.Get<string>("CollectionFieldXpath");
        private readonly string RukovoditelXpath = ConfigurationHelper.Get<string>("RukovoditelXpath");
        private readonly string LoaderOnUserFieldOnCollectionXpath = ConfigurationHelper.Get<string>("LoaderOnUserFieldOnCollectionXpath");
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath");
        public WorkPlan(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            selenium = new SeleniumHelperWithExpectedConditions(_driver);
        }
        public IWebElement CreateWorkPlanButton { get { return _driver.FindElement(By.XPath("" + CreateWorkPlanXpath + "")); } }
        public IWebElement NameWorkPlan { get { return _driver.FindElement(By.XPath("" + TextFieldXpath + "")); } }
        public IWebElement ShortNameWorkPlan { get { return _driver.FindElement(By.XPath("(" + TextFieldXpath + ")[2]")); } }
        public IWebElement Status { get { return _driver.FindElement(By.XPath("" + DropDownXpath + "")); } }
        public IWebElement FirstElementFromList { get { return _driver.FindElement(By.XPath("" + FirstElementFromListXpath + "")); } }
        public IWebElement Customer { get { return _driver.FindElement(By.XPath("(" + DropDownXpath + ")[2]")); } }
        public IWebElement Supervisor { get { return _driver.FindElement(By.XPath("(" + DropDownXpath + ")[3]")); } }
        public IWebElement FirstListCheckBox { get { return _driver.FindElement(By.XPath("" + FirstListCheckBoxXpath + "")); } }
        public IWebElement SaveButton { get { return _driver.FindElement(By.XPath("" + SaveButtonXpath + "")); } }
        public IWebElement TabWorkGroup { get { return _driver.FindElement(By.XPath("" + TabWorkGroupXpath + "")); } }
        public IWebElement AddNewRecordOnCollectionWorkGroup { get { return _driver.FindElement(By.XPath("(" + AddNewRecordOnCollectionXpath + ")[5]")); } }
        public IWebElement RoleClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[4]")); } }
        public IWebElement RukovoditelClick { get { return _driver.FindElement(By.XPath("" + RukovoditelXpath + "")); } }
        public IWebElement FIOClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[5]")); } }
        public IWebElement UserSendKeys { get { return _driver.FindElement(By.XPath("(" + DropDownXpath + ")[4]")); } }
        public IWebElement Loader { get { return _driver.FindElement(By.XPath("" + LoaderXpath + "")); } }
        public void CreateWorkPlan()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(CreateWorkPlanXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.SendKeys(By.XPath(TextFieldXpath), "WorkPlan");
            selenium.SendKeys(By.XPath("(" + TextFieldXpath + ")[2]"), "WP");
            selenium.Click(By.XPath(DropDownXpath));
            selenium.Click(By.XPath(FirstElementFromListXpath));
            selenium.Click(By.XPath("(" + DropDownXpath + ")[2]"));
            selenium.Click(By.XPath(FirstElementFromListXpath));
            selenium.Click(By.XPath("(" + DropDownXpath + ")[3]"));
            selenium.SendKeys(By.XPath("(" + DropDownXpath + ")[3]"), "Rukovoditel");
            selenium.Click(By.XPath(FirstListCheckBoxXpath));
            selenium.Click(By.XPath(TabWorkGroupXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + AddNewRecordOnCollectionXpath + ")[5]"));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[4]"));
            selenium.Click(By.XPath(RukovoditelXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[5]"));
            Thread.Sleep(2000);
            selenium.SendKeys(By.XPath("(" + DropDownXpath + ")[4]"), "Rukovoditel");
            selenium.CheckElementIsUnVisible(By.XPath(LoaderOnUserFieldOnCollectionXpath));
            Thread.Sleep(2000);
            selenium.Click(By.XPath(FirstListCheckBoxXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(SaveButtonXpath));
        }
        public void CreateWorkPlanTest()
        {
            //MyWorkPlan.Click();
            CreateWorkPlanButton.Click();
            Thread.Sleep(2000);
            NameWorkPlan.SendKeys("WorkPlan");
            ShortNameWorkPlan.SendKeys("WP");
            Status.Click();
            Thread.Sleep(2000);
            FirstElementFromList.Click();
            Customer.Click();
            Thread.Sleep(2000);
            FirstElementFromList.Click();
            Supervisor.Click();
            Thread.Sleep(2000);
            Supervisor.SendKeys("Rukovoditel");
            Thread.Sleep(2000);
            FirstListCheckBox.Click();
            TabWorkGroup.Click();
            Thread.Sleep(2000);
            AddNewRecordOnCollectionWorkGroup.Click();
            Thread.Sleep(2000);
            RoleClick.Click();
            Thread.Sleep(2000);
            RukovoditelClick.Click();
            FIOClick.Click();
            Thread.Sleep(2000);
            UserSendKeys.SendKeys("Rukovoditel");
            Thread.Sleep(2000);
            FirstListCheckBox.Click();
            SaveButton.Click();
            SeleniumHelper.waitUntilElementInvisibile(Loader, 10000);
            //Thread.Sleep(2000);
        }
    }
}
