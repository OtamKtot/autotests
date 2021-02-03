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
        private readonly string RadioButtonXpath = ConfigurationHelper.Get<string>("RadioButtonXpath");
        private readonly string CompletePhaseXpath = ConfigurationHelper.Get<string>("CompletePhaseXpath");
        private readonly string LoaderOnUserFieldOnCollectionXpath = ConfigurationHelper.Get<string>("LoaderOnUserFieldOnCollectionXpath");
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath");
        public ConceptualDesign(IWebDriver driver, string numberProject) : base(driver)
        {
            _driver = driver;
            _numberProject = numberProject;
            selenium = new SeleniumHelperWithExpectedConditions(_driver);
        }
        public IWebElement EditConceptualDesign { get { return _driver.FindElement(By.XPath("" + ConceptualDesignXpath + " (" + _numberProject + " - TestName)']")); } }
        //public IWebElement EditConceptualDesign { get { return _driver.FindElement(By.XPath("" + ConceptualDesignXpath + " (1389858753 - TestName)']")); } }
        public IWebElement DateTime { get { return _driver.FindElement(By.XPath("" + DateTimeXpath + "")); } }
        public IWebElement AddNewRecordOnCollection { get { return _driver.FindElement(By.XPath("" + AddNewRecordOnCollectionXpath + "")); } }
        public IWebElement AddNewRecordDetailCollection { get { return _driver.FindElement(By.XPath("(" + AddNewRecordOnCollectionXpath + ")[5]")); } }
        public IWebElement ButtonOnStartForm { get { return _driver.FindElement(By.XPath("" + ButtonOnStartFormXpath + "")); } }
        public IWebElement FirstCollectionFieldClick { get { return _driver.FindElement(By.XPath("(" + FirstCollectionXpath + ")[5]")); } }
        public IWebElement FirstStartDateClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[6]")); } }
        public IWebElement FirstStartDateSendKeys { get { return _driver.FindElement(By.XPath("(" + DayOldXpath + ")[1]")); } }
        public IWebElement FirstEndDateClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[7]")); } }
        public IWebElement FirstEndDateSendKeys { get { return _driver.FindElement(By.XPath("" + DayNewXpath + "")); } }
        public IWebElement FirstResponsibleClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[8]")); } }
        public IWebElement UserSendKeys { get { return _driver.FindElement(By.XPath("(" + DropDownXpath + ")[5]")); } }
        public IWebElement FirstListCheckBox { get { return _driver.FindElement(By.XPath("" + FirstListCheckBoxXpath + "")); } }
        public IWebElement FirstAssigneeClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[9]")); } }
        public IWebElement SecondStartDateClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[23]")); } }
        public IWebElement SecondStartDateSendKeys { get { return _driver.FindElement(By.XPath("(" + DayOldXpath + ")[1]")); } }
        public IWebElement SecondEndDateClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[24]")); } }
        public IWebElement SecondEndDateSendKeys { get { return _driver.FindElement(By.XPath("" + DayNewXpath + "")); } }
        public IWebElement SecondResponsibleClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[25]")); } }
        public IWebElement SecondAssigneeClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[26]")); } }
        public IWebElement ThirdStartDateClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[40]")); } }
        public IWebElement ThirdStartDateSendKeys { get { return _driver.FindElement(By.XPath("(" + DayOldXpath + ")[1]")); } }
        public IWebElement ThirdEndDateClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[41]")); } }
        public IWebElement ThirdEndDateSendKeys { get { return _driver.FindElement(By.XPath("" + DayNewXpath + "")); } }
        public IWebElement ThirdResponsibleClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[42]")); } }
        public IWebElement ThirdAssigneeClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[43]")); } }
        public IWebElement FourthStartDateClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[57]")); } }
        public IWebElement FourthStartDateSendKeys { get { return _driver.FindElement(By.XPath("(" + DayOldXpath + ")[1]")); } }
        public IWebElement FourthEndDateClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[58]")); } }
        public IWebElement FourthEndDateSendKeys { get { return _driver.FindElement(By.XPath("" + DayNewXpath + "")); } }
        public IWebElement FourthResponsibleClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[59]")); } }
        public IWebElement FourthAssigneeClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[60]")); } }
        public IWebElement FifthStartDateClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[74]")); } }
        public IWebElement FifthStartDateSendKeys { get { return _driver.FindElement(By.XPath("(" + DayOldXpath + ")[1]")); } }
        public IWebElement FifthEndDateClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[75]")); } }
        public IWebElement FifthEndDateSendKeys { get { return _driver.FindElement(By.XPath("" + DayNewXpath + "")); } }
        public IWebElement FifthResponsibleClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[76]")); } }
        public IWebElement FifthAssigneeClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[77]")); } }
        public IWebElement UserOnFormSendKeys { get { return _driver.FindElement(By.XPath("(" + DropDownXpath + ")[10]")); } }
        public IWebElement FirstCheckBoxCollection { get { return _driver.FindElement(By.XPath("(" + CheckBoxCollectionXpath + ")[2]")); } }
        public IWebElement CreateRecordInCollectionClick { get { return _driver.FindElement(By.XPath("(" + CreateTittleXpath + ")[3]")); } }
        public IWebElement FirstName { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[22]")); } }
        public IWebElement SecondName { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[39]")); } }
        public IWebElement ThirdName { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[56]")); } }
        public IWebElement NameSendKeys { get { return _driver.FindElement(By.XPath("(" + TextFieldXpath + ")[7]")); } }
        public IWebElement SixthAssigneeClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[43]")); } }
        public IWebElement SeventhAssigneeClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[60]")); } }
        public IWebElement AllCheckBoxCollection { get { return _driver.FindElement(By.XPath("" + CheckBoxCollectionXpath + "")); } }
        public IWebElement StatusPlannedButton { get { return _driver.FindElement(By.XPath("" + StatusPlannedXpath + "")); } }
        public IWebElement SaveTaskButton { get { return _driver.FindElement(By.XPath("" + ButtonSaveXpath + "")); } }

        public IWebElement VersionsTab { get { return _driver.FindElement(By.XPath("" + VersionsTabXpath + "")); } }
        public IWebElement CreateVersion { get { return _driver.FindElement(By.XPath("(" + StatusPlannedXpath + ")[5]")); } }
        public IWebElement CopyPhaseKP { get { return _driver.FindElement(By.XPath("(" + CheckBoxXpath + ")[4]")); } }
        public IWebElement CopyPhaseTP { get { return _driver.FindElement(By.XPath("(" + CheckBoxXpath + ")[5]")); } }
        public IWebElement CopyPhaseOPE { get { return _driver.FindElement(By.XPath("(" + CheckBoxXpath + ")[6]")); } }
        public IWebElement NoDocEnter { get { return _driver.FindElement(By.XPath("(" + RadioButtonXpath + ")[2]")); } }
        public IWebElement Comment { get { return _driver.FindElement(By.XPath("(" + TextFieldXpath + ")[8]")); } }
        public IWebElement Accept { get { return _driver.FindElement(By.XPath("(" + ButtonOnStartFormXpath + ")[3]")); } }
        public IWebElement CompletePhase { get { return _driver.FindElement(By.XPath("" + CompletePhaseXpath + "")); } }
        public IWebElement Loader { get { return _driver.FindElement(By.XPath("" + LoaderXpath + "")); } }
        public IWebElement DeleteRecordOnCollection { get { return _driver.FindElement(By.XPath("(" + AddNewRecordOnCollectionXpath + ")[3]")); } }
        public IWebElement DeleteRecord { get { return _driver.FindElement(By.XPath("" + ButtonOnStartFormXpath + "")); } }
        public IWebElement StatusComplete { get { return _driver.FindElement(By.XPath("(" + StatusPlannedXpath + ")[3]")); } }
        public void CreateVersionTask()
        {
            selenium.Click(By.XPath(VersionsTabXpath));
            selenium.Click(By.XPath("(" + StatusPlannedXpath + ")[5]"));
            Thread.Sleep(10000);
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + CheckBoxXpath + ")[4]"));
            selenium.Click(By.XPath("(" + CheckBoxXpath + ")[5]"));
            selenium.Click(By.XPath("(" + CheckBoxXpath + ")[6]"));
            selenium.Click(By.XPath("(" + RadioButtonXpath + ")[2]"));
            selenium.SendKeys(By.XPath("(" + TextFieldXpath + ")[8]"), "Test");
            selenium.Click(By.XPath(ButtonOnStartFormXpath));
            Thread.Sleep(8000);
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + ButtonOnStartFormXpath + ")[3]"));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CreateVersionTaskTest()
        {
            // Thread.Sleep(15000);
            SeleniumHelper.waitUntilElementVisibile(EditConceptualDesign, 20000);
            Actions act = new Actions(_driver);
            act.DoubleClick(EditConceptualDesign).Perform();
            Thread.Sleep(2000);
            VersionsTab.Click();
            Thread.Sleep(2000);
            CreateVersion.Click();
            Thread.Sleep(10000);
            CopyPhaseKP.Click();
            CopyPhaseOPE.Click();
            CopyPhaseTP.Click();
            NoDocEnter.Click();
            Comment.SendKeys("Test");
            ButtonOnStartForm.Click();
            Thread.Sleep(8000);
            Accept.Click();
            SeleniumHelper.waitUntilElementInvisibile(Loader, 10000);
            //Thread.Sleep(8000);
        }
        public void OpenTask()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.CheckElementIsVisible(By.XPath("" + ConceptualDesignXpath + " (" + _numberProject + " - TestName)']"));

            Actions act = new Actions(_driver);
            act.DoubleClick(EditConceptualDesign).Perform();

            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void EditFourCollectionRecord()
        {
            selenium.Click(By.XPath(DateTimeXpath));
            selenium.Click(By.XPath(DayOldXpath));
            selenium.Click(By.XPath(DateTimeXpath));
            selenium.Click(By.XPath(DayNewXpath));

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
            selenium.Click(By.XPath(FirstListCheckBoxXpath));
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
            selenium.Click(By.XPath(FirstListCheckBoxXpath));
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
            selenium.Click(By.XPath(FirstListCheckBoxXpath));
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
            selenium.Click(By.XPath(FirstListCheckBoxXpath));
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

            selenium.Click(By.XPath("(" + AddNewRecordOnCollectionXpath + ")[5]"));
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
            selenium.Click(By.XPath(FirstListCheckBoxXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[77]"));
            Thread.Sleep(2000);
            selenium.SendKeys(By.XPath("(" + DropDownXpath + ")[10]"), "Ispolnitel");
            selenium.CheckElementIsUnVisible(By.XPath(LoaderOnUserFieldOnCollectionXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            Thread.Sleep(2000);
            selenium.Click(By.XPath(FirstListCheckBoxXpath));
            selenium.Click(By.XPath(ButtonOnStartFormXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            Thread.Sleep(20000);

            Actions act1 = new Actions(_driver);
            act1.ContextClick(FirstCollectionFieldClick).Perform();
            selenium.Click(By.XPath("(" + CreateTittleXpath + ")[3]"));
            Thread.Sleep(5000);
            selenium.Click(By.XPath("(" + CheckBoxCollectionXpath + ")[2]"));
            selenium.Click(By.XPath(AddNewRecordOnCollectionXpath));
            Thread.Sleep(5000);
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[22]"));
            selenium.SendKeys(By.XPath("(" + TextFieldXpath + ")[7]"), "TestName");
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[39]"));
            selenium.SendKeys(By.XPath("(" + TextFieldXpath + ")[7]"), "TestName");
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[56]"));
            selenium.SendKeys(By.XPath("(" + TextFieldXpath + ")[7]"), "TestName");


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
            selenium.Click(By.XPath(ButtonOnStartFormXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }

        public void EditTask()
        {
            SeleniumHelper.waitUntilElementInvisibile(Loader, 10000);
            //Thread.Sleep(15000);
            Thread.Sleep(2000);
            Actions act = new Actions(_driver);
            act.DoubleClick(EditConceptualDesign).Perform();
            Thread.Sleep(2000);
            //AddNewRecordOnCollection.Click();
            //Thread.Sleep(15000);            

            DateTime.Click();
            //wait.Until(_driver => DayOld.Enabled);
            Thread.Sleep(2000);
            FirstStartDateSendKeys.Click();
            DateTime.Click();
            // wait.Until(_driver => DayNew.Enabled);
            Thread.Sleep(2000);
            FirstEndDateSendKeys.Click();

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

            SecondStartDateClick.Click();
            Thread.Sleep(2000);
            SecondStartDateSendKeys.Click();
            Thread.Sleep(2000);
            SecondEndDateClick.Click();
            Thread.Sleep(2000);
            SecondEndDateSendKeys.Click();
            //Thread.Sleep(2000);
            SecondResponsibleClick.Click();
            Thread.Sleep(2000);
            UserSendKeys.SendKeys("Rukovoditel");
            Thread.Sleep(2000);
            FirstListCheckBox.Click();
            SecondAssigneeClick.Click();
            Thread.Sleep(2000);
            UserSendKeys.SendKeys("Ispolnitel");
            Thread.Sleep(2000);
            FirstListCheckBox.Click();

            ThirdStartDateClick.Click();
            Thread.Sleep(2000);
            ThirdStartDateSendKeys.Click();
            Thread.Sleep(2000);
            ThirdEndDateClick.Click();
            Thread.Sleep(2000);
            ThirdEndDateSendKeys.Click();
            Thread.Sleep(2000);
            ThirdResponsibleClick.Click();
            Thread.Sleep(2000);
            UserSendKeys.SendKeys("Rukovoditel");
            Thread.Sleep(2000);
            FirstListCheckBox.Click();
            ThirdAssigneeClick.Click();
            Thread.Sleep(2000);
            UserSendKeys.SendKeys("Ispolnitel");
            Thread.Sleep(2000);
            FirstListCheckBox.Click();

            FourthStartDateClick.Click();
            Thread.Sleep(2000);
            FourthStartDateSendKeys.Click();
            Thread.Sleep(2000);
            FourthEndDateClick.Click();
            Thread.Sleep(2000);
            FourthEndDateSendKeys.Click();
            Thread.Sleep(2000);
            FourthResponsibleClick.Click();
            Thread.Sleep(2000);
            UserSendKeys.SendKeys("Rukovoditel");
            Thread.Sleep(2000);
            FirstListCheckBox.Click();
            FourthAssigneeClick.Click();
            Thread.Sleep(2000);
            UserSendKeys.SendKeys("Ispolnitel");
            Thread.Sleep(2000);
            FirstListCheckBox.Click();

            FirstCollectionFieldClick.Click();
            Actions act2 = new Actions(_driver);
            act2.DoubleClick(FirstCollectionFieldClick).Perform();
            Thread.Sleep(5000);
            AddNewRecordDetailCollection.Click();
            Thread.Sleep(5000);
            FifthStartDateClick.Click();
            Thread.Sleep(2000);
            FifthStartDateSendKeys.Click();
            Thread.Sleep(2000);
            FifthEndDateClick.Click();
            Thread.Sleep(2000);
            FifthEndDateSendKeys.Click();
            Thread.Sleep(2000);
            FifthResponsibleClick.Click();
            Thread.Sleep(2000);
            UserOnFormSendKeys.SendKeys("Rukovoditel");
            Thread.Sleep(2000);
            FirstListCheckBox.Click();
            FifthAssigneeClick.Click();
            Thread.Sleep(2000);
            UserOnFormSendKeys.SendKeys("Ispolnitel");
            Thread.Sleep(2000);
            FirstListCheckBox.Click();
            Thread.Sleep(2000);
            ButtonOnStartForm.Click();
            Thread.Sleep(15000);
            //FirstCollectionFieldClick.Click();
            Actions act1 = new Actions(_driver);
            act1.ContextClick(FirstCollectionFieldClick).Perform();
            CreateRecordInCollectionClick.Click();
            Thread.Sleep(2000);
            FirstCheckBoxCollection.Click();
            Thread.Sleep(5000);
            AddNewRecordOnCollection.Click();
            Thread.Sleep(5000);
            FirstName.Click();
            NameSendKeys.SendKeys("TestName");
            SecondName.Click();
            NameSendKeys.SendKeys("TestName");
            ThirdName.Click();
            NameSendKeys.SendKeys("TestName");

            SixthAssigneeClick.Click();
            Thread.Sleep(2000);
            UserSendKeys.SendKeys("Ispolnitel");
            Thread.Sleep(2000);
            FirstListCheckBox.Click();
            Thread.Sleep(2000);
            ThirdName.Click();
            SeventhAssigneeClick.Click();
            Thread.Sleep(2000);
            UserSendKeys.SendKeys("Ispolnitel");
            Thread.Sleep(2000);
            FirstListCheckBox.Click();
            Thread.Sleep(2000);
            AllCheckBoxCollection.Click();
            StatusPlannedButton.Click();
            Thread.Sleep(10000);
            ButtonOnStartForm.Click();
            SeleniumHelper.waitUntilElementInvisibile(Loader, 10000);
            //Thread.Sleep(10000);
            //SaveTaskButton.Click();
        }
        public void EditTaskTest()
        {
            SeleniumHelper.waitUntilElementInvisibile(Loader, 10000);
            //Thread.Sleep(15000);
            Thread.Sleep(2000);
            Actions act = new Actions(_driver);
            act.DoubleClick(EditConceptualDesign).Perform();
            Thread.Sleep(2000);
            //AddNewRecordOnCollection.Click();
            //Thread.Sleep(15000);            

            DateTime.Click();
            //wait.Until(_driver => DayOld.Enabled);
            Thread.Sleep(2000);
            FirstStartDateSendKeys.Click();
            DateTime.Click();
            // wait.Until(_driver => DayNew.Enabled);
            Thread.Sleep(2000);
            FirstEndDateSendKeys.Click();

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

            SecondStartDateClick.Click();
            Thread.Sleep(2000);
            SecondStartDateSendKeys.Click();
            Thread.Sleep(2000);
            SecondEndDateClick.Click();
            Thread.Sleep(2000);
            SecondEndDateSendKeys.Click();
            //Thread.Sleep(2000);
            SecondResponsibleClick.Click();
            Thread.Sleep(2000);
            UserSendKeys.SendKeys("Rukovoditel");
            Thread.Sleep(2000);
            FirstListCheckBox.Click();
            SecondAssigneeClick.Click();
            Thread.Sleep(2000);
            UserSendKeys.SendKeys("Ispolnitel");
            Thread.Sleep(2000);
            FirstListCheckBox.Click();

            ThirdStartDateClick.Click();
            Thread.Sleep(2000);
            ThirdStartDateSendKeys.Click();
            Thread.Sleep(2000);
            ThirdEndDateClick.Click();
            Thread.Sleep(2000);
            ThirdEndDateSendKeys.Click();
            Thread.Sleep(2000);
            ThirdResponsibleClick.Click();
            Thread.Sleep(2000);
            UserSendKeys.SendKeys("Rukovoditel");
            Thread.Sleep(2000);
            FirstListCheckBox.Click();
            ThirdAssigneeClick.Click();
            Thread.Sleep(2000);
            UserSendKeys.SendKeys("Ispolnitel");
            Thread.Sleep(2000);
            FirstListCheckBox.Click();

            FourthStartDateClick.Click();
            Thread.Sleep(2000);
            FourthStartDateSendKeys.Click();
            Thread.Sleep(2000);
            FourthEndDateClick.Click();
            Thread.Sleep(2000);
            FourthEndDateSendKeys.Click();
            Thread.Sleep(2000);
            FourthResponsibleClick.Click();
            Thread.Sleep(2000);
            UserSendKeys.SendKeys("Rukovoditel");
            Thread.Sleep(2000);
            FirstListCheckBox.Click();
            FourthAssigneeClick.Click();
            Thread.Sleep(2000);
            UserSendKeys.SendKeys("Ispolnitel");
            Thread.Sleep(2000);
            FirstListCheckBox.Click();

            FirstCollectionFieldClick.Click();
            Actions act2 = new Actions(_driver);
            act2.DoubleClick(FirstCollectionFieldClick).Perform();
            Thread.Sleep(5000);
            AddNewRecordDetailCollection.Click();
            Thread.Sleep(5000);
            FifthStartDateClick.Click();
            Thread.Sleep(2000);
            FifthStartDateSendKeys.Click();
            Thread.Sleep(2000);
            FifthEndDateClick.Click();
            Thread.Sleep(2000);
            FifthEndDateSendKeys.Click();
            Thread.Sleep(2000);
            FifthResponsibleClick.Click();
            Thread.Sleep(2000);
            UserOnFormSendKeys.SendKeys("Rukovoditel");
            Thread.Sleep(2000);
            FirstListCheckBox.Click();
            FifthAssigneeClick.Click();
            Thread.Sleep(2000);
            UserOnFormSendKeys.SendKeys("Ispolnitel");
            Thread.Sleep(2000);
            FirstListCheckBox.Click();
            Thread.Sleep(2000);
            ButtonOnStartForm.Click();
            Thread.Sleep(15000);
            //FirstCollectionFieldClick.Click();
            Actions act1 = new Actions(_driver);
            act1.ContextClick(FirstCollectionFieldClick).Perform();
            CreateRecordInCollectionClick.Click();
            Thread.Sleep(2000);
            FirstCheckBoxCollection.Click();
            Thread.Sleep(5000);
            AddNewRecordOnCollection.Click();
            Thread.Sleep(5000);
            FirstName.Click();
            NameSendKeys.SendKeys("TestName");
            SecondName.Click();
            NameSendKeys.SendKeys("TestName");
            ThirdName.Click();
            NameSendKeys.SendKeys("TestName");

            SixthAssigneeClick.Click();
            Thread.Sleep(2000);
            UserSendKeys.SendKeys("Ispolnitel");
            Thread.Sleep(2000);
            FirstListCheckBox.Click();
            Thread.Sleep(2000);
            ThirdName.Click();
            SeventhAssigneeClick.Click();
            Thread.Sleep(2000);
            UserSendKeys.SendKeys("Ispolnitel");
            Thread.Sleep(2000);
            FirstListCheckBox.Click();
            Thread.Sleep(2000);
            AllCheckBoxCollection.Click();
            StatusPlannedButton.Click();
            Thread.Sleep(10000);
            ButtonOnStartForm.Click();
            SeleniumHelper.waitUntilElementInvisibile(Loader, 10000);
            //Thread.Sleep(10000);
            //SaveTaskButton.Click();
        }
        public void CompleteTask()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.CheckElementIsVisible(By.XPath("" + ConceptualDesignXpath + " (" + _numberProject + " - TestName)']"));

            Actions act = new Actions(_driver);
            act.DoubleClick(EditConceptualDesign).Perform();

            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(CompletePhaseXpath));
            Thread.Sleep(5000);
            selenium.Click(By.XPath(ButtonOnStartFormXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CompleteTaskTest()
        {
            // Thread.Sleep(15000);
            SeleniumHelper.waitUntilElementInvisibile(Loader, 10000);
            Actions act = new Actions(_driver);
            act.DoubleClick(EditConceptualDesign).Perform();
            Thread.Sleep(2000);
            CompletePhase.Click();
            Thread.Sleep(10000);
            ButtonOnStartForm.Click();
            SeleniumHelper.waitUntilElementInvisibile(Loader, 10000);
            //Thread.Sleep(8000);
        }
        public void QuickEditTask()
        {
            //Thread.Sleep(15000);
            SeleniumHelper.waitUntilElementVisibile(EditConceptualDesign, 30000);
            Actions act = new Actions(_driver);
            act.DoubleClick(EditConceptualDesign).Perform();
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
            Thread.Sleep(2000);
            FirstCollectionFieldClick.Click();
            NameSendKeys.SendKeys("TestName");
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
        }
    }
}
