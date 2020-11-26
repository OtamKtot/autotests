using AutoTests.SeleniumHelpers;
using AutoTests.Utilies;
using NUnit.Framework;
using OpenQA.Selenium;
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
    class MyTasks : PageObject
    {
        private readonly IWebDriver _driver;
        private readonly SeleniumHelperWithExpectedConditions selenium;
        private readonly int ExplicityWait = ConfigurationHelper.Get<int>("ExplicityWait");
        private readonly string MyTaskXpath = ConfigurationHelper.Get<string>("MyTaskXpath");
        private readonly string RecordOnProjectXpath = ConfigurationHelper.Get<string>("RecordOnProjectXpath");
        private readonly string CreateRecordOnProjectXpath = ConfigurationHelper.Get<string>("CreateRecordOnProjectXpath");
        private readonly string TextFieldXpath = ConfigurationHelper.Get<string>("TextFieldXpath");
        private readonly string DropDownXpath = ConfigurationHelper.Get<string>("DropDownXpath"); 
        private readonly string FirstElementFromListXpath = ConfigurationHelper.Get<string>("FirstElementFromListXpath");
        private readonly string DateTimeNullXpath = ConfigurationHelper.Get<string>("DateTimeNullXpath");
        private readonly string DayOldXpath = ConfigurationHelper.Get<string>("DayOldXpath");
        private readonly string DayNewXpath = ConfigurationHelper.Get<string>("DayNewXpath");
        private readonly string ButtonOnStartFormXpath = ConfigurationHelper.Get<string>("ButtonOnStartFormXpath");
        private readonly string LogoXpath = ConfigurationHelper.Get<string>("LogoXpath");
        private readonly string LogOutClickXpath = ConfigurationHelper.Get<string>("LogOutClickXpath");
        private readonly string WorkPlanGroupXpath = ConfigurationHelper.Get<string>("WorkPlanGroupXpath");
        private readonly string MyWorkPlanXpath = ConfigurationHelper.Get<string>("MyWorkPlanXpath");
        private readonly string ProjectGroupXpath = ConfigurationHelper.Get<string>("ProjectGroupXpath");
        private readonly string MyProjectXpath = ConfigurationHelper.Get<string>("MyProjectXpath");
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath"); 
        private readonly string CreateTicketXpath = ConfigurationHelper.Get<string>("CreateTicketXpath");
        private readonly string GlobalConfigurationXpath = ConfigurationHelper.Get<string>("GlobalConfigurationXpath");
        public MyTasks(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            selenium = new SeleniumHelperWithExpectedConditions(_driver);
        }
        public IWebElement MyTask { get { return _driver.FindElement(By.XPath("" + MyTaskXpath + "")); } }
        public IWebElement RecordOnProject { get { return _driver.FindElement(By.XPath("" + RecordOnProjectXpath + "")); } }
        public IWebElement CreateRecordOnProject { get { return _driver.FindElement(By.XPath("" + CreateRecordOnProjectXpath + "")); } }
        public IWebElement Name { get { return _driver.FindElement(By.XPath("" + TextFieldXpath + "")); } }
        public IWebElement NapravlenieDeyatelnosti { get { return _driver.FindElement(By.XPath("" + DropDownXpath + "")); } }
        public IWebElement FirstElementFromList { get { return _driver.FindElement(By.XPath("" + FirstElementFromListXpath + "")); } }
        public IWebElement Zakazchik { get { return _driver.FindElement(By.XPath("(" + DropDownXpath + ")[2]")); } }
        public IWebElement DateTimeNull { get { return _driver.FindElement(By.XPath("" + DateTimeNullXpath + "")); } }
        public IWebElement DayOld { get { return _driver.FindElement(By.XPath("" + DayOldXpath + "")); } }
        public IWebElement DayNew { get { return _driver.FindElement(By.XPath("(" + DayNewXpath + ")[2]")); } }
        public IWebElement Create { get { return _driver.FindElement(By.XPath("" + ButtonOnStartFormXpath + "")); } }
        public IWebElement Exit { get { return _driver.FindElement(By.XPath("" + ButtonOnStartFormXpath + "")); } }
        public IWebElement Logo { get { return _driver.FindElement(By.XPath("" + LogoXpath + "")); } }
        public IWebElement LogOutClick { get { return _driver.FindElement(By.XPath("" + LogOutClickXpath + "")); } }
        public IWebElement WorkPlanGroup { get { return _driver.FindElement(By.XPath("" + WorkPlanGroupXpath + "")); } }
        public IWebElement MyWorkPlan { get { return _driver.FindElement(By.XPath("" + MyWorkPlanXpath + "")); } }
        public IWebElement ProjectGroup { get { return _driver.FindElement(By.XPath("" + ProjectGroupXpath + "")); } }
        public IWebElement MyProject { get { return _driver.FindElement(By.XPath("" + MyProjectXpath + "")); } }
        public IWebElement Loader { get { return _driver.FindElement(By.XPath("" + LoaderXpath + "")); } }
        public IWebElement CreateTicketButton { get { return _driver.FindElement(By.XPath("(" + CreateTicketXpath + ")[2]")); } }
        public IWebElement GlobalConfiguration { get { return _driver.FindElement(By.XPath("(" + GlobalConfigurationXpath + ")[3]")); } }
        public void GoToMyTasks()
        {
            Thread.Sleep(5000);
            MyTask.Click();
            SeleniumHelper.waitUntilElementInvisibile(Loader, 30000);
            //Thread.Sleep(20000);
        }
        public void GoToMyTasksWithExit()
        {
            MyTask.Click();
            Thread.Sleep(2000);
            Exit.Click();
            Thread.Sleep(12000);
        }
        public void GoToMyWorkPlanList()
        {
            //Thread.Sleep(2000);
            WorkPlanGroup.Click();
            //Thread.Sleep(1000);
            MyWorkPlan.Click();
        }
        public void GoToMyProjectList()
        {
            //Thread.Sleep(2000);
            ProjectGroup.Click();
            //Thread.Sleep(1000);
            MyProject.Click();
            SeleniumHelper.waitUntilElementInvisibile(Loader, 30000);
            Thread.Sleep(2000);
        }
        public void LogOut()
        {
            Assert.IsTrue(SeleniumHelper.WaitForToBeNotVisibleAndPresent(_driver, LoaderXpath, 5));
            //SeleniumHelper.waitUntilElementInvisibile(Loader, 30000);
            //Thread.Sleep(2000);
            //WebDriverWait iWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10)); 
            //iWait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@class='js - content - loading - region l - loader visible - loader']")));
            IJavaScriptExecutor ex = (IJavaScriptExecutor)_driver;
            ex.ExecuteScript("arguments[0].click();", Logo);
            //wait = new WebDriverWait(_driver, TimeSpan.FromMinutes(ExplicityWait));
            //wait.Until(ExpectedConditions.StalenessOf(Logo));
            // Thread.Sleep(12000);
            // Logo.Click();
            // Thread.Sleep(2000);
            // wait.Until(_driver => LogOutClick);
            //IJavaScriptExecutor ex = (IJavaScriptExecutor)_driver;
            ex.ExecuteScript("arguments[0].click();", LogOutClick);
            // LogOutClick.Click();
            //Assert.IsTrue(SeleniumHelper.WaitForToBeNotVisibleAndPresent(_driver, LoaderXpath, 5));
            Thread.Sleep(12000);
        }
        public void CreateTicket()
        {
            selenium.Click(By.XPath(RecordOnProjectXpath));
            selenium.Click(By.XPath(CreateRecordOnProjectXpath));
            selenium.SendKeys(By.XPath(TextFieldXpath), "TestName");
            selenium.Click(By.XPath(DropDownXpath));
            selenium.Click(By.XPath(FirstElementFromListXpath));
            selenium.Click(By.XPath("(" + DropDownXpath + ")[2]"));
            selenium.Click(By.XPath(FirstElementFromListXpath));
            selenium.Click(By.XPath(DateTimeNullXpath));
            selenium.Click(By.XPath(DayOldXpath));
            selenium.Click(By.XPath(DateTimeNullXpath));
            selenium.Click(By.XPath("(" + DayNewXpath + ")[2]"));
            selenium.Click(By.XPath("(" + CreateTicketXpath + ")[2]"));
            Assert.IsTrue(SeleniumHelper.WaitForToBeNotVisibleAndPresent(_driver, LoaderXpath, 30));
        }
        public void CreateTicketTest()
        {
            RecordOnProject.Click();
            CreateRecordOnProject.Click();
            Name.SendKeys("TestName");
            NapravlenieDeyatelnosti.Click();
            // wait = new WebDriverWait(_driver, TimeSpan.FromMinutes(ExplicityWait));
            //wait.Until(_driver => FirstElementFromList.Enabled);
            //Thread.Sleep(2000);
            Assert.IsTrue(SeleniumHelper.WaitForToBeDisplayed(_driver, FirstElementFromListXpath, 2));
            //SeleniumHelper.waitUntilElementVisibile(FirstElementFromList, 2000);
            //Thread.Sleep(2000);
            FirstElementFromList.Click();
            //wait.Until(_driver => Zakazchik.Enabled);
            Zakazchik.Click();
            //wait.Until(_driver => FirstElementFromList.Enabled);
            Assert.IsTrue(SeleniumHelper.WaitForToBeDisplayed(_driver, FirstElementFromListXpath, 2));
            //SeleniumHelper.waitUntilElementVisibile(FirstElementFromList, 2000);
            //Thread.Sleep(2000);
            FirstElementFromList.Click();
            DateTimeNull.Click();
            //wait.Until(_driver => DayOld.Enabled);
            //Thread.Sleep(2000);
            Assert.IsTrue(SeleniumHelper.WaitForToBeDisplayed(_driver, DayOldXpath, 2));
            //SeleniumHelper.waitUntilElementVisibile(DayOld, 2000);
            DayOld.Click();
            DateTimeNull.Click();
            // wait.Until(_driver => DayNew.Enabled);
            Assert.IsTrue(SeleniumHelper.WaitForToBeDisplayed(_driver, "(" + DayNewXpath + ")[2]", 2));
            //Thread.Sleep(2000);
            //SeleniumHelper.waitUntilElementVisibile(DayNew, 2000);
            DayNew.Click();
            CreateTicketButton.Click();
            Assert.IsTrue(SeleniumHelper.WaitForToBeNotVisibleAndPresent(_driver, LoaderXpath, 30));
            //SeleniumHelper.waitUntilElementInvisibile(Loader, 30000);
        }
    }
}
