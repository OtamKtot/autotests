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
        private readonly string FirstListCheckBoxXpath = ConfigurationHelper.Get<string>("FirstListCheckBoxXpath");
        private readonly string ButtonOnToolbarXpath = ConfigurationHelper.Get<string>("ButtonOnToolbarXpath");
        private readonly string DropDownXpath = ConfigurationHelper.Get<string>("DropDownXpath"); 
        private readonly string ButtonOnAddFormXpath = ConfigurationHelper.Get<string>("ButtonOnAddFormXpath");
        private readonly string PopupHeaderXpath = ConfigurationHelper.Get<string>("PopupHeaderXpath"); 
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath"); 
        private readonly string LoaderVisibleXpath = ConfigurationHelper.Get<string>("LoaderVisibleXpath");
        public TechnicalRequirements(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            selenium = new SeleniumHelperWithExpectedConditions(_driver);
        }
        public void CompleteTask()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(MakeTechnicalRequirementXpath));

            //Actions act = new Actions(_driver);
            //act.DoubleClick(MakeTechnicalRequirement).Perform();
            selenium.DoubleClick(By.XPath(MakeTechnicalRequirementXpath));

            selenium.SendKeys(By.XPath(TextFieldOnGroupXpath),"TestName");
            selenium.SendKeys(By.XPath("(" + TextFieldOnGroupXpath + ")[2]"), "TestName");
            selenium.Click(By.XPath("("+AddRecordToCollectionXpath+")[4]"));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("("+DropDownXpath+")[2]"));
            selenium.Click(By.XPath(FirstListCheckBoxXpath));
            Thread.Sleep(1000);
            selenium.Click(By.XPath(PopupHeaderXpath));
            Thread.Sleep(1000);
            selenium.Click(By.XPath("(" + ButtonOnAddFormXpath + ")[2]"));
            selenium.Click(By.XPath(ButtonOnToolbarXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
    }
}
