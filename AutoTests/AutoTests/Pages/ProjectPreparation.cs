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
    class ProjectPreparation : PageObject
    {
        private readonly IWebDriver _driver;
        private readonly string _numberProject;
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
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath");
        public ProjectPreparation(IWebDriver driver, string numberProject) : base(driver)
        {
            _driver = driver;
            _numberProject = numberProject;
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

        public void CompleteTask()
        {
            //Thread.Sleep(15000);
            SeleniumHelper.waitUntilElementVisibile(MakeProjectPrepare, 30000);
            Actions act = new Actions(_driver);
            act.DoubleClick(MakeProjectPrepare).Perform();
            SeleniumHelper.waitUntilElementInvisibile(Loader, 10000);
            Thread.Sleep(2000);
            AddNewRecordOnCollection.Click();
            //Thread.Sleep(15000);
            Thread.Sleep(2000);
            RoleClick.Click();
            Thread.Sleep(2000);
            FirstElementFromList.Click();
            UserClick.Click();
            Thread.Sleep(2000);
            UserSendKeys.SendKeys("Ispolnitel");
            Thread.Sleep(2000);
            FirstListCheckBox.Click();
            //Thread.Sleep(2000);
            PhaseKP.Click();
            PhaseTP.Click();
            PhaseOPE.Click();
            CreatePhase.Click();
            Thread.Sleep(5000);
            AcceptExecute.Click();
            SeleniumHelper.waitUntilElementInvisibile(Loader, 10000);
            Thread.Sleep(2000);
            DocumentsTab.Click();
            Thread.Sleep(2000);
            AddDocumentOnCollection.Click();
            Thread.Sleep(2000);
            VidDocClick.Click();
            Thread.Sleep(2000);
            FirstElementFromList.Click();
            AttributeDoc.SendKeys("Test");
            String filePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)+ @"\Report.pdf";
            //String filePath = "C:/Users/aantipov/Documents/Report.pdf";
            AddDocument.SendKeys(filePath);
            CreatePopUp.Click();
            SeleniumHelper.waitUntilElementInvisibile(Loader, 10000);
            Thread.Sleep(5000);
            CompleteTaskButton.Click();
            SeleniumHelper.waitUntilElementInvisibile(Loader, 10000);
            //Thread.Sleep(2000);
        }
    }
}

