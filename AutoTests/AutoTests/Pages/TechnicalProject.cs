﻿using AutoTests.SeleniumHelpers;
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
    class TechnicalProject : PageObject
    {
        private readonly IWebDriver _driver;
        private readonly string _numberProject;
        private readonly SeleniumHelperWithExpectedConditions selenium;
        private readonly string TechnicalProjectXpath = ConfigurationHelper.Get<string>("TechnicalProjectXpath");
        private readonly string CheckBoxCollectionXpath = ConfigurationHelper.Get<string>("CheckBoxCollectionXpath");
        private readonly string DateTimeXpath = ConfigurationHelper.Get<string>("DateTimeXpath");
        private readonly string DayOldXpath = ConfigurationHelper.Get<string>("DayOldXpath");
        private readonly string DayNewXpath = ConfigurationHelper.Get<string>("DayNewXpath");
        private readonly string AddNewRecordOnCollectionXpath = ConfigurationHelper.Get<string>("AddNewRecordOnCollectionXpath");
        private readonly string CollectionFieldXpath = ConfigurationHelper.Get<string>("CollectionFieldXpath");
        private readonly string DropDownXpath = ConfigurationHelper.Get<string>("DropDownXpath");
        private readonly string FirstListCheckBoxXpath = ConfigurationHelper.Get<string>("FirstListCheckBoxXpath");
        private readonly string ButtonOnStartFormXpath = ConfigurationHelper.Get<string>("ButtonOnStartFormXpath");
        private readonly string TextFieldXpath = ConfigurationHelper.Get<string>("TextFieldXpath"); 
        private readonly string StatusPlannedXpath = ConfigurationHelper.Get<string>("StatusPlannedXpath");
        private readonly string CompletePhaseXpath = ConfigurationHelper.Get<string>("CompletePhaseXpath");
        private readonly string ButtonCompleteXpath = ConfigurationHelper.Get<string>("ButtonCompleteXpath");
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath");
        private readonly string LoaderOnUserFieldOnCollectionXpath = ConfigurationHelper.Get<string>("LoaderOnUserFieldOnCollectionXpath");
        public TechnicalProject(IWebDriver driver, string numberProject) : base(driver)
        {
            _driver = driver;
            _numberProject = numberProject;
            selenium = new SeleniumHelperWithExpectedConditions(_driver);
        }
        public IWebElement MakeTechnicalProject { get { return _driver.FindElement(By.XPath("" + TechnicalProjectXpath + " (" + _numberProject + " - TestName)']")); } }
        public IWebElement AllCheckBoxCollection { get { return _driver.FindElement(By.XPath("" + CheckBoxCollectionXpath + "")); } }
        public IWebElement DateTime { get { return _driver.FindElement(By.XPath("" + DateTimeXpath + "")); } }
        public IWebElement FirstStartDateSendKeys { get { return _driver.FindElement(By.XPath("(" + DayOldXpath + ")[1]")); } }
        public IWebElement FirstEndDateSendKeys { get { return _driver.FindElement(By.XPath("" + DayNewXpath + "")); } }
        public IWebElement AddNewRecordOnCollection { get { return _driver.FindElement(By.XPath("" + AddNewRecordOnCollectionXpath + "")); } }
        public IWebElement DeleteRecordOnCollection { get { return _driver.FindElement(By.XPath("(" + AddNewRecordOnCollectionXpath + ")[3]")); } }
        public IWebElement NameClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[5]")); } }
        public IWebElement NameSendKeys { get { return _driver.FindElement(By.XPath("(" + TextFieldXpath + ")[7]")); } }
        public IWebElement FirstStartDateClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[6]")); } }
        public IWebElement FirstEndDateClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[7]")); } }
        public IWebElement FirstResponsibleClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[8]")); } }
        public IWebElement UserSendKeys { get { return _driver.FindElement(By.XPath("(" + DropDownXpath + ")[5]")); } }
        public IWebElement FirstListCheckBox { get { return _driver.FindElement(By.XPath("" + FirstListCheckBoxXpath + "")); } }
        public IWebElement FirstAssigneeClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[9]")); } }
        public IWebElement DeleteRecord { get { return _driver.FindElement(By.XPath("" + ButtonOnStartFormXpath + "")); } }
        public IWebElement StatusComplete { get { return _driver.FindElement(By.XPath("(" + StatusPlannedXpath + ")[3]")); } }
        public IWebElement ButtonOnStartForm { get { return _driver.FindElement(By.XPath("" + ButtonOnStartFormXpath + "")); } }
        public IWebElement CompletePhase { get { return _driver.FindElement(By.XPath("" + CompletePhaseXpath + "")); } }
        public IWebElement Loader { get { return _driver.FindElement(By.XPath("" + LoaderXpath + "")); } }
        public void OpenTask()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.CheckElementIsVisible(By.XPath("" + TechnicalProjectXpath + " (" + _numberProject + " - TestName)']"));

            Actions act = new Actions(_driver);
            act.DoubleClick(MakeTechnicalProject).Perform();

            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void DeleteRecordsOnCollection()
        {
            selenium.Click(By.XPath(DateTimeXpath));
            selenium.Click(By.XPath("(" + DayOldXpath + ")[1]"));
            selenium.Click(By.XPath(DateTimeXpath));
            selenium.Click(By.XPath(DayNewXpath));

            //selenium.Click(By.XPath(CheckBoxCollectionXpath));
            //element is not visible
            AllCheckBoxCollection.Click();

            selenium.Click(By.XPath("(" + AddNewRecordOnCollectionXpath + ")[3]"));
            selenium.Click(By.XPath(ButtonOnStartFormXpath));
            selenium.Click(By.XPath(ButtonOnStartFormXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void AddRecordOnCollection()
        {
            selenium.Click(By.XPath(AddNewRecordOnCollectionXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[5]"));
            selenium.SendKeys(By.XPath("(" + TextFieldXpath + ")[7]"),"TestName");
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[6]"));
            selenium.Click(By.XPath("(" + DayOldXpath + ")[1]"));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[7]"));
            selenium.Click(By.XPath(DayNewXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[8]"));
            Thread.Sleep(2000);
            selenium.SendKeys(By.XPath("(" + DropDownXpath + ")[5]"), "Rukovoditel");
            selenium.CheckElementIsUnVisible(By.XPath(LoaderOnUserFieldOnCollectionXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            Thread.Sleep(2000);
            selenium.Click(By.XPath(FirstListCheckBoxXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[9]"));
            Thread.Sleep(2000);
            selenium.SendKeys(By.XPath("(" + DropDownXpath + ")[5]"), "Ispolnitel");
            selenium.CheckElementIsUnVisible(By.XPath(LoaderOnUserFieldOnCollectionXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            Thread.Sleep(2000);
            selenium.Click(By.XPath(FirstListCheckBoxXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void PlannedTask()
        {
            selenium.Click(By.XPath(CheckBoxCollectionXpath));
            selenium.Click(By.XPath("(" + StatusPlannedXpath + ")[3]"));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            Thread.Sleep(10000);
            selenium.Click(By.XPath(ButtonOnStartFormXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CompleteTask()
        { 
            selenium.Click(By.XPath(CompletePhaseXpath));
            Thread.Sleep(5000);
            selenium.Click(By.XPath(ButtonOnStartFormXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CompleteTaskTest()
        {
            //Thread.Sleep(15000);
            SeleniumHelper.waitUntilElementVisibile(MakeTechnicalProject, 30000);
            Actions act = new Actions(_driver);
            act.DoubleClick(MakeTechnicalProject).Perform();
            Thread.Sleep(2000);
            DateTime.Click();
            //wait.Until(_driver => DayOld.Enabled);
            Thread.Sleep(2000);
            FirstStartDateSendKeys.Click();
            DateTime.Click();
            // wait.Until(_driver => DayNew.Enabled);
            Thread.Sleep(2000);
            FirstEndDateSendKeys.Click();
            AllCheckBoxCollection.Click();
            Thread.Sleep(2000);
            DeleteRecordOnCollection.Click();
            Thread.Sleep(2000);
            DeleteRecord.Click();
            Thread.Sleep(2000);
            DeleteRecord.Click();
            Thread.Sleep(2000);
            AddNewRecordOnCollection.Click();
            Thread.Sleep(2000);
            NameClick.Click();
            NameSendKeys.SendKeys("TestName");

            FirstStartDateClick.Click();
            Thread.Sleep(2000);
            FirstStartDateSendKeys.Click();
            Thread.Sleep(2000);
            FirstEndDateClick.Click();
            Thread.Sleep(2000);
            FirstEndDateSendKeys.Click();
            Thread.Sleep(2000);
            FirstResponsibleClick.Click();
            Thread.Sleep(2000);
            UserSendKeys.SendKeys("Rukovoditel");
            Thread.Sleep(2000);
            FirstListCheckBox.Click();
            FirstAssigneeClick.Click();
            Thread.Sleep(2000);
            UserSendKeys.SendKeys("Ispolnitel");
            Thread.Sleep(2000);
            FirstListCheckBox.Click();

            UserSendKeys.SendKeys("Rukovoditel");
            Thread.Sleep(2000);
            FirstListCheckBox.Click();
            Thread.Sleep(2000);
            AllCheckBoxCollection.Click();
            StatusComplete.Click();
            Thread.Sleep(10000);
            ButtonOnStartForm.Click();
            Thread.Sleep(5000);
            Thread.Sleep(2000);
            CompletePhase.Click();
            Thread.Sleep(10000);
            ButtonOnStartForm.Click();
            SeleniumHelper.waitUntilElementInvisibile(Loader, 10000);
            //Thread.Sleep(10000);
        }
    }
}
