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
    class CompleteWork : PageObject
    {
        private readonly IWebDriver _driver;
        private readonly string _numberProject;
        private readonly SeleniumHelperWithExpectedConditions selenium;
        private readonly string BuissnessResearchXpath = ConfigurationHelper.Get<string>("BuissnessResearchXpath");
        private readonly string EditorPopoutXpath = ConfigurationHelper.Get<string>("EditorPopoutXpath");
        private readonly string ExecuteStatusXpath = ConfigurationHelper.Get<string>("ExecuteStatusXpath");
        private readonly string DevelopShemeXpath = ConfigurationHelper.Get<string>("DevelopShemeXpath");
        private readonly string DevelopTicketXpath = ConfigurationHelper.Get<string>("DevelopTicketXpath");
        private readonly string DevelopTaskXpath = ConfigurationHelper.Get<string>("DevelopTaskXpath");
        private readonly string TitleXpath = ConfigurationHelper.Get<string>("TitleXpath"); 
        private readonly string ButtonOnToolbarXpath = ConfigurationHelper.Get<string>("ButtonOnToolbarXpath");
        private readonly string DropDownXpath = ConfigurationHelper.Get<string>("DropDownXpath");
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath");
        public CompleteWork(IWebDriver driver, string numberProject) : base(driver)
        {
            _driver = driver;
            _numberProject = numberProject;
            selenium = new SeleniumHelperWithExpectedConditions(_driver);
        }
        public IWebElement BuissnessResearch { get { return _driver.FindElement(By.XPath("" + BuissnessResearchXpath + " (Проект – " + _numberProject + ")']")); } }
        //public IWebElement BuissnessResearch { get { return _driver.FindElement(By.XPath("" + BuissnessResearchXpath + " (Проект – 1902270605)']")); } }
        public IWebElement DevelopScheme { get { return _driver.FindElement(By.XPath("" + DevelopShemeXpath + " (Проект – " + _numberProject + ")']")); } }
        //public IWebElement DevelopScheme { get { return _driver.FindElement(By.XPath("" + DevelopShemeXpath + " (Проект – 1902270605)']")); } }
        public IWebElement DevelopTicket { get { return _driver.FindElement(By.XPath("" + DevelopTicketXpath + " (Проект – " + _numberProject + ")']")); } }
        //public IWebElement DevelopTicket { get { return _driver.FindElement(By.XPath("" + DevelopTicketXpath + " (Проект – 1902270605)']")); } }
        public IWebElement TaskNewRecord { get { return _driver.FindElement(By.XPath("" + TitleXpath + "TestName (Проект – " + _numberProject + ")']")); } }
        //public IWebElement TaskNewRecord { get { return _driver.FindElement(By.XPath("" + TitleXpath + "TestName (Проект – 1310600719)']")); } }
        public IWebElement DevelopTask { get { return _driver.FindElement(By.XPath("" + DevelopTaskXpath + " (Проект – " + _numberProject + ")']")); } }
        //public IWebElement DevelopTask { get { return _driver.FindElement(By.XPath("" + DevelopTaskXpath + " (Проект – 600457694)']")); } }
        public IWebElement TaskNewRecord2 { get { return _driver.FindElement(By.XPath("(" + TitleXpath + "TestName (Проект – " + _numberProject + ")'])[2]")); } }
        //public IWebElement TaskNewRecord { get { return _driver.FindElement(By.XPath("" + TitleXpath + "TestName (Проект – 1902270605)']")); } }
        public IWebElement TaskNewRecord3 { get { return _driver.FindElement(By.XPath("(" + TitleXpath + "TestName (Проект – " + _numberProject + ")'])[3]")); } }
        //public IWebElement TaskNewRecord { get { return _driver.FindElement(By.XPath("" + TitleXpath + "TestName (Проект – 1902270605)']")); } }
        public IWebElement EditorPopout { get { return _driver.FindElement(By.XPath("(" + EditorPopoutXpath + ")[2]")); } }
        public IWebElement ExecuteStatus { get { return _driver.FindElement(By.XPath("" + ExecuteStatusXpath + "")); } }
        public IWebElement ExecuteStatusForDevelopTask { get { return _driver.FindElement(By.XPath("(" + ExecuteStatusXpath + ")[4]")); } }
        public IWebElement CompleteTaskButton { get { return _driver.FindElement(By.XPath("" + ButtonOnToolbarXpath + "")); } }
        public IWebElement DropDown { get { return _driver.FindElement(By.XPath("(" + DropDownXpath + ")[2]")); } }
        public IWebElement Loader { get { return _driver.FindElement(By.XPath("" + LoaderXpath + "")); } }
        public void CompleteTaskOfBuisnessResearch()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.CheckElementIsVisible(By.XPath("" + BuissnessResearchXpath + " (Проект – " + _numberProject + ")']"));

            Actions act = new Actions(_driver);
            act.DoubleClick(BuissnessResearch).Perform();

            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + EditorPopoutXpath + ")[2]"));
            selenium.Click(By.XPath("(" + DropDownXpath + ")[2]"));
            selenium.Click(By.XPath(ExecuteStatusXpath));
            selenium.Click(By.XPath(ButtonOnToolbarXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CompleteTaskOfDevelopScheme()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.CheckElementIsVisible(By.XPath("" + DevelopShemeXpath + " (Проект – " + _numberProject + ")']"));

            Actions act = new Actions(_driver);
            act.DoubleClick(DevelopScheme).Perform();

            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + EditorPopoutXpath + ")[2]"));
            selenium.Click(By.XPath("(" + DropDownXpath + ")[2]"));
            selenium.Click(By.XPath(ExecuteStatusXpath));
            selenium.Click(By.XPath(ButtonOnToolbarXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CompleteTaskOfDevelopTicket()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.CheckElementIsVisible(By.XPath("" + DevelopTicketXpath + " (Проект – " + _numberProject + ")']"));

            Actions act = new Actions(_driver);
            act.DoubleClick(DevelopTicket).Perform();

            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + EditorPopoutXpath + ")[2]"));
            selenium.Click(By.XPath("(" + DropDownXpath + ")[2]"));
            selenium.Click(By.XPath(ExecuteStatusXpath));
            selenium.Click(By.XPath(ButtonOnToolbarXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CompleteTaskOfNewRecord()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.CheckElementIsVisible(By.XPath("" + TitleXpath + "TestName (Проект – " + _numberProject + ")']"));

            Actions act = new Actions(_driver);
            act.DoubleClick(TaskNewRecord).Perform();

            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + EditorPopoutXpath + ")[2]"));
            selenium.Click(By.XPath("(" + DropDownXpath + ")[2]"));
            selenium.Click(By.XPath(ExecuteStatusXpath));
            selenium.Click(By.XPath(ButtonOnToolbarXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CompleteTaskOfNewRecord2()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.CheckElementIsVisible(By.XPath("(" + TitleXpath + "TestName (Проект – " + _numberProject + ")'])[2]"));

            Actions act = new Actions(_driver);
            act.DoubleClick(TaskNewRecord2).Perform();

            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + EditorPopoutXpath + ")[2]"));
            selenium.Click(By.XPath("(" + DropDownXpath + ")[2]"));
            selenium.Click(By.XPath(ExecuteStatusXpath));
            selenium.Click(By.XPath(ButtonOnToolbarXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CompleteTaskOfNewRecord3()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.CheckElementIsVisible(By.XPath("(" + TitleXpath + "TestName (Проект – " + _numberProject + ")'])[3]"));

            Actions act = new Actions(_driver);
            act.DoubleClick(TaskNewRecord3).Perform();

            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + EditorPopoutXpath + ")[2]"));
            selenium.Click(By.XPath("(" + DropDownXpath + ")[2]"));
            selenium.Click(By.XPath(ExecuteStatusXpath));
            selenium.Click(By.XPath(ButtonOnToolbarXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CompleteTaskDevelopTask()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.CheckElementIsVisible(By.XPath("" + DevelopTaskXpath + " (Проект – " + _numberProject + ")']"));

            Actions act = new Actions(_driver);
            act.DoubleClick(DevelopTask).Perform();

            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + EditorPopoutXpath + ")[2]"));
            selenium.Click(By.XPath("(" + DropDownXpath + ")[2]"));
            selenium.Click(By.XPath(ExecuteStatusXpath));
            selenium.Click(By.XPath(ButtonOnToolbarXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
    }
}
