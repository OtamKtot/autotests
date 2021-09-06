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
    class ProjectPreparation : PageObject
    {
        private readonly IWebDriver _driver;
        private readonly string _numberProject;
        private readonly SeleniumHelperWithExpectedConditions selenium;
        private readonly string MakeProjectPrepareXpath = ConfigurationHelper.Get<string>("MakeProjectPrepareXpath");
        private readonly string RadioButtonXpath = ConfigurationHelper.Get<string>("RadioButtonXpath");
        private readonly string CreatePhaseXpath = ConfigurationHelper.Get<string>("CreatePhaseXpath");
        private readonly string AddNewRecordOnCollectionXpath = ConfigurationHelper.Get<string>("AddNewRecordOnCollectionXpath");
        private readonly string CollectionFieldXpath = ConfigurationHelper.Get<string>("CollectionFieldXpath");
        private readonly string FirstElementFromListXpath = ConfigurationHelper.Get<string>("FirstElementFromListXpath");
        private readonly string DropDownXpath = ConfigurationHelper.Get<string>("DropDownXpath");
        private readonly string FirstListCheckBoxXpath = ConfigurationHelper.Get<string>("FirstListCheckBoxXpath");
        private readonly string DocumentsTabXpath = ConfigurationHelper.Get<string>("DocumentsTabXpath");
        private readonly string TextFieldXpath = ConfigurationHelper.Get<string>("TextFieldXpath");
        private readonly string AddDocumentXpath = ConfigurationHelper.Get<string>("AddDocumentXpath");
        private readonly string CreatePopUpXpath = ConfigurationHelper.Get<string>("ButtonOnStartFormXpath");
        private readonly string ButtonCompleteXpath = ConfigurationHelper.Get<string>("ButtonCompleteXpath");
        private readonly string VerticalLayoutXpath = ConfigurationHelper.Get<string>("VerticalLayoutXpath");
        private readonly string LoaderOnUserFieldOnCollectionXpath = ConfigurationHelper.Get<string>("LoaderOnUserFieldOnCollectionXpath");
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath"); 
        private readonly string LoaderCollectionXpath = ConfigurationHelper.Get<string>("LoaderCollectionXpath");
        public ProjectPreparation(IWebDriver driver, string numberProject) : base(driver)
        {
            _driver = driver;
            _numberProject = numberProject;
            selenium = new SeleniumHelperWithExpectedConditions(_driver);
        }
        public IWebElement MakeProjectPrepare { get { return _driver.FindElement(By.XPath("" + MakeProjectPrepareXpath + " (" + _numberProject + " - TestName)']")); } }
       // public IWebElement MakeProjectPrepare { get { return _driver.FindElement(By.XPath("" + MakeProjectPrepareXpath + " (1q2w3e1 - 1pr)']")); } }
        public IWebElement PhaseKP { get { return _driver.FindElement(By.XPath("" + RadioButtonXpath + "")); } }
        public IWebElement PhaseTP { get { return _driver.FindElement(By.XPath("(" + RadioButtonXpath + ")[2]")); } }
        public IWebElement PhaseOPE { get { return _driver.FindElement(By.XPath("(" + RadioButtonXpath + ")[3]")); } }
        public IWebElement CreatePhase { get { return _driver.FindElement(By.XPath("" + CreatePhaseXpath + "")); } }
        public IWebElement AcceptExecute { get { return _driver.FindElement(By.XPath("" + CreatePopUpXpath + "")); } }
        public IWebElement AddNewRecordOnCollection { get { return _driver.FindElement(By.XPath("" + AddNewRecordOnCollectionXpath + "")); } }
        public IWebElement RoleClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[8]")); } }
        public IWebElement FirstElementFromList { get { return _driver.FindElement(By.XPath("" + FirstElementFromListXpath + "")); } }
        public IWebElement UserClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + ")[9]")); } }
        public IWebElement UserSendKeys { get { return _driver.FindElement(By.XPath("(" + DropDownXpath + ")[5]")); } }
        public IWebElement FirstListCheckBox { get { return _driver.FindElement(By.XPath("" + FirstListCheckBoxXpath + "")); } }
        public IWebElement DocumentsTab { get { return _driver.FindElement(By.XPath("(" + DocumentsTabXpath + ")[2]")); } }
        public IWebElement AddDocumentOnCollection { get { return _driver.FindElement(By.XPath("(" + AddNewRecordOnCollectionXpath + ")[4]")); } }
        public IWebElement VidDocClick { get { return _driver.FindElement(By.XPath("(" + DropDownXpath + ")[5]")); } }
        public IWebElement AttributeDoc { get { return _driver.FindElement(By.XPath("(" + TextFieldXpath + ")[6]")); } }
        public IWebElement AddDocument { get { return _driver.FindElement(By.XPath("" + AddDocumentXpath + "")); } }
        public IWebElement CreatePopUp { get { return _driver.FindElement(By.XPath("" + CreatePopUpXpath + "")); } }
        public IWebElement CompleteTaskButton { get { return _driver.FindElement(By.XPath("" + ButtonCompleteXpath + "")); } }
        public IWebElement Loader { get { return _driver.FindElement(By.XPath("" + LoaderXpath + "")); } }
        public void OpenTask()
        {
            Assert.IsTrue(selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath)));
            selenium.CheckElementIsVisible(By.XPath("" + MakeProjectPrepareXpath + " (" + _numberProject + " - TestName)']"));

            //Actions act = new Actions(_driver);
            //act.DoubleClick(MakeProjectPrepare).Perform();
            selenium.DoubleClick(By.XPath("" + MakeProjectPrepareXpath + " (" + _numberProject + " - TestName)']"));

            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void AddIspolnitelInCollectionAndCreatePhase()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderCollectionXpath));
            //Thread.Sleep(2000);
            selenium.Click(By.XPath("("+AddNewRecordOnCollectionXpath+")[3]"));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[8]"));
            selenium.Click(By.XPath(FirstElementFromListXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + ")[9]"));
            Thread.Sleep(2000);
            selenium.SendKeys(By.XPath("(" + DropDownXpath + ")[5]"), "Ispolnitel");
            selenium.CheckElementIsUnVisible(By.XPath(LoaderOnUserFieldOnCollectionXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            Thread.Sleep(2000);
            selenium.Click(By.XPath(FirstListCheckBoxXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(VerticalLayoutXpath));
            selenium.Click(By.XPath(RadioButtonXpath));
            selenium.Click(By.XPath("(" + RadioButtonXpath + ")[2]"));
            selenium.Click(By.XPath("(" + RadioButtonXpath + ")[3]"));
            selenium.Click(By.XPath(CreatePhaseXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("("+CreatePhaseXpath+")[2]"));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void AddDocumentOnFormCollection()
        {
            selenium.Click(By.XPath("(" + DocumentsTabXpath + ")[2]"));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + AddNewRecordOnCollectionXpath + ")[4]"));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + DropDownXpath + ")[5]"));
            selenium.Click(By.XPath(FirstElementFromListXpath));
            selenium.SendKeys(By.XPath("(" + TextFieldXpath + ")[6]"), "Test");
            String filePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Report.pdf";

            AddDocument.SendKeys(filePath);

            //selenium.SendKeys(By.XPath(AddDocumentXpath), filePath);
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(CreatePopUpXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            Thread.Sleep(5000);
        }
        public void CompleteTask()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(ButtonCompleteXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
    }
}

