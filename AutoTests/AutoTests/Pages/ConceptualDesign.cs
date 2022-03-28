using AutoTests.SeleniumHelpers;
using AutoTests.Utilies;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoTests.Pages
{
    class ConceptualDesign : PageObject
    {
        private readonly IWebDriver _driver;
        private readonly string _numberProject;
        private readonly SeleniumHelperWithExpectedConditions selenium;
        private readonly string ConceptualDesignXpath = ConfigurationHelper.Get<string>("ConceptualDesignXpath");
        private readonly string DateTimeXpath = ConfigurationHelper.Get<string>("DateTimeXpath");
        private readonly string AddNewRecordOnCollectionXpath = ConfigurationHelper.Get<string>("AddNewRecordOnCollectionXpath");
        private readonly string CollectionFieldXpath = ConfigurationHelper.Get<string>("CollectionFieldXpath");
        private readonly string TextFieldXpath = ConfigurationHelper.Get<string>("TextFieldXpath");
        private readonly string DayOldXpath = ConfigurationHelper.Get<string>("DayOldXpath");
        private readonly string DayNewXpath = ConfigurationHelper.Get<string>("DayNewXpath");
        private readonly string DropDownXpath = ConfigurationHelper.Get<string>("DropDownXpath");
        private readonly string FirstListCheckBoxXpath = ConfigurationHelper.Get<string>("FirstListCheckBoxXpath");
        private readonly string FirstElementFromListXpath = ConfigurationHelper.Get<string>("FirstElementFromListXpath");
        private readonly string CheckBoxCollectionXpath = ConfigurationHelper.Get<string>("CheckBoxCollectionXpath");
        private readonly string FirstCollectionXpath = ConfigurationHelper.Get<string>("FirstCollectionXpath");
        private readonly string CreateTittleXpath = ConfigurationHelper.Get<string>("CreateTittleXpath");
        private readonly string ButtonOnStartFormXpath = ConfigurationHelper.Get<string>("ButtonOnStartFormXpath");
        private readonly string StatusPlannedXpath = ConfigurationHelper.Get<string>("StatusPlannedXpath");
        private readonly string ButtonSaveXpath = ConfigurationHelper.Get<string>("ButtonSaveXpath"); 
        private readonly string VersionsTabXpath = ConfigurationHelper.Get<string>("VersionsTabXpath");
        private readonly string CheckBoxXpath = ConfigurationHelper.Get<string>("CheckBoxXpath"); 
        private readonly string AcceptPlannedXpath = ConfigurationHelper.Get<string>("AcceptPlannedXpath");
        private readonly string MainDataXpath = ConfigurationHelper.Get<string>("MainDataXpath");
        private readonly string ButtonOnFormCollectionXpath = ConfigurationHelper.Get<string>("ButtonOnFormCollectionXpath");       
        private readonly string RadioButtonXpath = ConfigurationHelper.Get<string>("RadioButtonXpath");
        private readonly string CompletePhaseXpath = ConfigurationHelper.Get<string>("CompletePhaseXpath");
        private readonly string VerticalLayoutXpath = ConfigurationHelper.Get<string>("VerticalLayoutXpath");
        private readonly string LoaderOnUserFieldOnCollectionXpath = ConfigurationHelper.Get<string>("LoaderOnUserFieldOnCollectionXpath");
        private readonly string LeftNavigationRollXpath = ConfigurationHelper.Get<string>("LeftNavigationRollXpath"); 
        private readonly string CreateVersionXpath = ConfigurationHelper.Get<string>("CreateVersionXpath"); 
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath");
        private readonly string AlertBodyXpath = ConfigurationHelper.Get<string>("AlertBodyXpath");
        private readonly string ManageProjectXpath = ConfigurationHelper.Get<string>("ManageProjectXpath");
        public ConceptualDesign(IWebDriver driver, string numberProject) : base(driver)
        {
            _driver = driver;
            _numberProject = numberProject;
            selenium = new SeleniumHelperWithExpectedConditions(_driver);
        }
        public IWebElement FirstCollectionFieldClick { get { return _driver.FindElement(By.XPath("(" + FirstCollectionXpath + ")[5]")); } }
        public void CreateVersionTask()
        {            
            selenium.Click(By.XPath(LeftNavigationRollXpath));
            selenium.Click(By.XPath(VersionsTabXpath));
            selenium.Click(By.XPath("(" + StatusPlannedXpath + ")[5]"));
            Thread.Sleep(10000);
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + CheckBoxXpath + ")[4]"));
            selenium.Click(By.XPath("(" + CheckBoxXpath + ")[5]"));
            selenium.Click(By.XPath("(" + CheckBoxXpath + ")[6]"));
            selenium.Click(By.XPath("(" + RadioButtonXpath + ")[2]"));
            selenium.SendKeys(By.XPath("(" + TextFieldXpath + ")[8]"), "Test");
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(CreateVersionXpath));
            Thread.Sleep(10000);
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void OpenTask()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.CheckElementIsVisible(By.XPath("" + ConceptualDesignXpath + " (" + _numberProject + " - TestName)']"));

            //Actions act = new Actions(_driver);
            //act.DoubleClick(EditConceptualDesign).Perform();
            selenium.DoubleClick(By.XPath("" + ConceptualDesignXpath + " (" + _numberProject + " - TestName)']"));

            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void EditFourCollectionRecord()
        {
            selenium.Click(By.XPath(DateTimeXpath));
            selenium.Click(By.XPath(DayOldXpath));
            selenium.Click(By.XPath(DateTimeXpath));
            selenium.Click(By.XPath(DayNewXpath));
            Thread.Sleep(5000);
            selenium.Click(By.XPath(ManageProjectXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[6]"));
            selenium.Click(By.XPath(DayOldXpath));
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

            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[23]"));
            selenium.Click(By.XPath(DayOldXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[24]"));
            selenium.Click(By.XPath(DayNewXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[25]"));
            Thread.Sleep(2000);
            selenium.SendKeys(By.XPath("(" + DropDownXpath + ")[5]"), "Rukovoditel");
            selenium.CheckElementIsUnVisible(By.XPath(LoaderOnUserFieldOnCollectionXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            Thread.Sleep(2000);
            selenium.Click(By.XPath(FirstElementFromListXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[26]"));
            Thread.Sleep(2000);
            selenium.SendKeys(By.XPath("(" + DropDownXpath + ")[5]"), "Ispolnitel");
            selenium.CheckElementIsUnVisible(By.XPath(LoaderOnUserFieldOnCollectionXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            Thread.Sleep(2000);
            selenium.Click(By.XPath(FirstListCheckBoxXpath));

            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[40]"));
            selenium.Click(By.XPath(DayOldXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[41]"));
            selenium.Click(By.XPath(DayNewXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[42]"));
            Thread.Sleep(2000);
            selenium.SendKeys(By.XPath("(" + DropDownXpath + ")[5]"), "Rukovoditel");
            selenium.CheckElementIsUnVisible(By.XPath(LoaderOnUserFieldOnCollectionXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            Thread.Sleep(2000);
            selenium.Click(By.XPath(FirstElementFromListXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[43]"));
            Thread.Sleep(2000);
            selenium.SendKeys(By.XPath("(" + DropDownXpath + ")[5]"), "Ispolnitel");
            selenium.CheckElementIsUnVisible(By.XPath(LoaderOnUserFieldOnCollectionXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            Thread.Sleep(2000);
            selenium.Click(By.XPath(FirstListCheckBoxXpath));

            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[57]"));
            selenium.Click(By.XPath(DayOldXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[58]"));
            selenium.Click(By.XPath(DayNewXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[59]"));
            Thread.Sleep(2000);
            selenium.SendKeys(By.XPath("(" + DropDownXpath + ")[5]"), "Rukovoditel");
            selenium.CheckElementIsUnVisible(By.XPath(LoaderOnUserFieldOnCollectionXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            Thread.Sleep(2000);
            selenium.Click(By.XPath(FirstElementFromListXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[60]"));
            Thread.Sleep(2000);
            selenium.SendKeys(By.XPath("(" + DropDownXpath + ")[5]"), "Ispolnitel");
            selenium.CheckElementIsUnVisible(By.XPath(LoaderOnUserFieldOnCollectionXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            Thread.Sleep(2000);
            selenium.Click(By.XPath(FirstListCheckBoxXpath));
        }
        public void CreateThreeVariantsChilds()
        {
            selenium.Click(By.XPath("(" + FirstCollectionXpath + ")[5]"));
            Actions act2 = new Actions(_driver);
            act2.DoubleClick(FirstCollectionFieldClick).Perform();
            Thread.Sleep(2000);
            selenium.Click(By.XPath(MainDataXpath));
            selenium.PageDown();
            selenium.Click(By.XPath("(" + AddNewRecordOnCollectionXpath + ")[4]"));
            //Thread.Sleep(2000);
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[74]"));
            selenium.Click(By.XPath(DayOldXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[75]"));
            selenium.Click(By.XPath(DayNewXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[76]"));
            Thread.Sleep(2000);
            selenium.SendKeys(By.XPath("(" + DropDownXpath + ")[10]"), "Rukovoditel");
            selenium.CheckElementIsUnVisible(By.XPath(LoaderOnUserFieldOnCollectionXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            Thread.Sleep(2000);
            selenium.Click(By.XPath(FirstElementFromListXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[77]"));
            Thread.Sleep(2000);
            selenium.SendKeys(By.XPath("(" + DropDownXpath + ")[10]"), "Ispolnitel");
            selenium.CheckElementIsUnVisible(By.XPath(LoaderOnUserFieldOnCollectionXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            Thread.Sleep(2000);
            selenium.Click(By.XPath(FirstListCheckBoxXpath));
            Thread.Sleep(2000);
            selenium.Click(By.XPath(ButtonOnFormCollectionXpath));
            Thread.Sleep(30000);
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.PageDown();
            Thread.Sleep(5000);

            Actions act1 = new Actions(_driver);
            act1.ContextClick(FirstCollectionFieldClick).Perform();
            Thread.Sleep(5000);
            selenium.Click(By.XPath("(" + CreateTittleXpath + ")[3]"));
            Thread.Sleep(5000);
            //selenium.Click(By.XPath("(" + CheckBoxCollectionXpath + ")[2]"));
            selenium.Click(By.XPath("("+AddNewRecordOnCollectionXpath+")[2]"));
            Thread.Sleep(5000);
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[22]"));
            selenium.SendKeys(By.XPath("(" + TextFieldXpath + ")[7]"), "TestName");
            selenium.Click(By.XPath(ManageProjectXpath));
            Thread.Sleep(2000);
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[39]"));
            selenium.SendKeys(By.XPath("(" + TextFieldXpath + ")[7]"), "TestName");
            selenium.Click(By.XPath(ManageProjectXpath));
            Thread.Sleep(2000);
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[56]"));
            selenium.SendKeys(By.XPath("(" + TextFieldXpath + ")[7]"), "TestName");
            selenium.Click(By.XPath(ManageProjectXpath));
            Thread.Sleep(2000);


            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[43]"));
            Thread.Sleep(2000);
            selenium.SendKeys(By.XPath("(" + DropDownXpath + ")[5]"), "Ispolnitel");
            selenium.CheckElementIsUnVisible(By.XPath(LoaderOnUserFieldOnCollectionXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            Thread.Sleep(2000);
            selenium.Click(By.XPath(FirstListCheckBoxXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[56]"));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[60]"));
            Thread.Sleep(2000);
            selenium.SendKeys(By.XPath("(" + DropDownXpath + ")[5]"), "Ispolnitel");
            selenium.CheckElementIsUnVisible(By.XPath(LoaderOnUserFieldOnCollectionXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            Thread.Sleep(2000);
            selenium.Click(By.XPath(FirstListCheckBoxXpath));
        }
        public void PlannedTask()
        {
            selenium.Click(By.XPath(CheckBoxCollectionXpath));
            selenium.Click(By.XPath(StatusPlannedXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            Thread.Sleep(10000);
            selenium.Click(By.XPath(AcceptPlannedXpath));
            Thread.Sleep(60000);
            //selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            //Assert.AreEqual(selenium.GetElementText(By.XPath(AlertBodyXpath)), "Операция выполнена");
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CompleteTask()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.CheckElementIsVisible(By.XPath("" + ConceptualDesignXpath + " (" + _numberProject + " - TestName)']"));

            //Actions act = new Actions(_driver);
            //act.DoubleClick(EditConceptualDesign).Perform();
            selenium.DoubleClick(By.XPath("" + ConceptualDesignXpath + " (" + _numberProject + " - TestName)']"));

            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            //Thread.Sleep(10000);
            selenium.Click(By.XPath(CompletePhaseXpath));
            Thread.Sleep(50000);
            selenium.Click(By.XPath("("+CompletePhaseXpath+")[2]"));
            Thread.Sleep(30000);
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
    }
}
