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
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
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
    }
}
