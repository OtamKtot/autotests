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
    class PreparationOPE : PageObject
    {
        private readonly IWebDriver _driver;
        private readonly string _numberProject;
        private readonly SeleniumHelperWithExpectedConditions selenium;
        private readonly string PreparationOPEXpath = ConfigurationHelper.Get<string>("PreparationOPEXpath");
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
        private readonly string FirstElementFromListXpath = ConfigurationHelper.Get<string>("FirstElementFromListXpath");
        private readonly string LoaderOnUserFieldOnCollectionXpath = ConfigurationHelper.Get<string>("LoaderOnUserFieldOnCollectionXpath");
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath");
        private readonly string AcceptPlannedXpath = ConfigurationHelper.Get<string>("AcceptPlannedXpath");
        public PreparationOPE(IWebDriver driver, string numberProject) : base(driver)
        {
            _driver = driver;
            _numberProject = numberProject;
            selenium = new SeleniumHelperWithExpectedConditions(_driver);
        }
        public IWebElement AllCheckBoxCollection { get { return _driver.FindElement(By.XPath("" + CheckBoxCollectionXpath + "")); } }
        public void OpenTask()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.CheckElementIsVisible(By.XPath("" + PreparationOPEXpath + " (" + _numberProject + " - TestName)']"));

            //Actions act = new Actions(_driver);
            //act.DoubleClick(MakePreparationOPE).Perform();
            selenium.DoubleClick(By.XPath("" + PreparationOPEXpath + " (" + _numberProject + " - TestName)']"));

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
            Thread.Sleep(5000);
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            AllCheckBoxCollection.Click();
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));

            selenium.Click(By.XPath("(" + AddNewRecordOnCollectionXpath + ")[4]"));
            //selenium.Click(By.XPath(ButtonOnStartFormXpath));
            //selenium.Click(By.XPath(ButtonOnStartFormXpath));
            Thread.Sleep(20000);
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void AddRecordOnCollection()
        {
            selenium.Click(By.XPath("("+AddNewRecordOnCollectionXpath+")[2]"));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[5]"));
            selenium.SendKeys(By.XPath("(" + TextFieldXpath + ")[7]"), "TestName");
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
            selenium.Click(By.XPath(FirstElementFromListXpath));
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
            selenium.Click(By.XPath(AcceptPlannedXpath));
            Thread.Sleep(60000);
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CompleteTask()
        {
            selenium.Click(By.XPath(CompletePhaseXpath));
            Thread.Sleep(50000);
            selenium.Click(By.XPath("(" + CompletePhaseXpath + ")[2]"));
            Thread.Sleep(30000);
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
    }
}
