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
    class ConfirmationWork : PageObject
    {
        private readonly IWebDriver _driver;
        private readonly string _numberProject;
        private readonly SeleniumHelperWithExpectedConditions selenium;
        private readonly string AddedBuissnessResearchXpath = ConfigurationHelper.Get<string>("AddedBuissnessResearchXpath");
        private readonly string EditorPopoutXpath = ConfigurationHelper.Get<string>("EditorPopoutXpath");
        private readonly string CompleteStatusXpath = ConfigurationHelper.Get<string>("CompleteStatusXpath");
        private readonly string AddedDevelopShemeXpath = ConfigurationHelper.Get<string>("AddedDevelopShemeXpath");
        private readonly string AddedDevelopTicketXpath = ConfigurationHelper.Get<string>("AddedDevelopTicketXpath");
        private readonly string AddedDevelopTaskXpath = ConfigurationHelper.Get<string>("AddedDevelopTaskXpath");
        private readonly string TitleXpath = ConfigurationHelper.Get<string>("TitleXpath"); 
        private readonly string ButtonOnToolbarXpath = ConfigurationHelper.Get<string>("ButtonOnToolbarXpath");
        private readonly string DateTimeXpath = ConfigurationHelper.Get<string>("DateTimeXpath");
        private readonly string DayNewXpath = ConfigurationHelper.Get<string>("DayNewXpath");
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath");
        public ConfirmationWork(IWebDriver driver, string numberProject) : base(driver)
        {
            _driver = driver;
            _numberProject = numberProject;
            selenium = new SeleniumHelperWithExpectedConditions(_driver);
        }
        public IWebElement BuissnessResearch { get { return _driver.FindElement(By.XPath("" + TitleXpath + "Подтверждение работы - Обследование бизнес-процесса, выбор варианта реализации (Проект – " + _numberProject + ")']")); } }
        //public IWebElement BuissnessResearch { get { return _driver.FindElement(By.XPath("" + BuissnessResearchXpath + " (Проект – 1902270605)']")); } }
        public IWebElement DevelopScheme { get { return _driver.FindElement(By.XPath("" + TitleXpath + "Подтверждение работы - Разработка Схемы бизнес-процесса и направление на согласование (Проект – " + _numberProject + ")']")); } }
        //public IWebElement DevelopScheme { get { return _driver.FindElement(By.XPath("" + DevelopShemeXpath + " (Проект – 1902270605)']")); } }
        public IWebElement DevelopTicket { get { return _driver.FindElement(By.XPath("" + TitleXpath + "Подтверждение работы - Разработка Пояснительной записки и направление на согласование (Проект – " + _numberProject + ")']")); } }
        //public IWebElement DevelopTicket { get { return _driver.FindElement(By.XPath("" + DevelopTicketXpath + " (Проект – 1902270605)']")); } }
        public IWebElement TaskNewRecord { get { return _driver.FindElement(By.XPath("" + TitleXpath + "Подтверждение работы - TestName (Проект – " + _numberProject + ")']")); } }
        //public IWebElement TaskNewRecord { get { return _driver.FindElement(By.XPath("" + TitleXpath + "TestName (Проект – 1902270605)']")); } }
        public IWebElement DevelopTask { get { return _driver.FindElement(By.XPath("" + TitleXpath + "Подтверждение работы - Разработка Задания на проектирование и направление на согласование (Проект – " + _numberProject + ")']")); } }
        //public IWebElement TaskNewRecord { get { return _driver.FindElement(By.XPath("" + TitleXpath + "TestName (Проект – 1902270605)']")); } }
        public IWebElement TaskNewRecord2 { get { return _driver.FindElement(By.XPath("(" + TitleXpath + "Подтверждение работы - TestName (Проект – " + _numberProject + ")'])[2]")); } }
        //public IWebElement TaskNewRecord { get { return _driver.FindElement(By.XPath("" + TitleXpath + "TestName (Проект – 1902270605)']")); } }
        public IWebElement TaskNewRecord3 { get { return _driver.FindElement(By.XPath("(" + TitleXpath + "Подтверждение работы - TestName (Проект – " + _numberProject + ")'])[3]")); } }
        //public IWebElement TaskNewRecord { get { return _driver.FindElement(By.XPath("" + TitleXpath + "TestName (Проект – 1902270605)']")); } }
        public IWebElement EditorPopout { get { return _driver.FindElement(By.XPath("(" + EditorPopoutXpath + ")[2]")); } }
        public IWebElement CompleteStatus { get { return _driver.FindElement(By.XPath("" + CompleteStatusXpath + "")); } }
        public IWebElement CompleteStatusForDeveloperTask { get { return _driver.FindElement(By.XPath("(" + CompleteStatusXpath + ")[4]")); } }
        public IWebElement CompleteTaskButton { get { return _driver.FindElement(By.XPath("" + ButtonOnToolbarXpath + "")); } }
        public IWebElement DateTime { get { return _driver.FindElement(By.XPath("" + DateTimeXpath + "")); } }
        public IWebElement DayNew { get { return _driver.FindElement(By.XPath("" + DayNewXpath + "")); } }
        public IWebElement Loader { get { return _driver.FindElement(By.XPath("" + LoaderXpath + "")); } }
        public void CompleteTaskOfBuisnessResearch()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.CheckElementIsVisible(By.XPath("" + TitleXpath + "Подтверждение работы - Обследование бизнес-процесса, выбор варианта реализации (Проект – " + _numberProject + ")']"));

            //Actions act = new Actions(_driver);
            //act.DoubleClick(BuissnessResearch).Perform();
            selenium.DoubleClick(By.XPath("" + TitleXpath + "Подтверждение работы - Обследование бизнес-процесса, выбор варианта реализации (Проект – " + _numberProject + ")']"));

            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + EditorPopoutXpath + ")[2]"));
            selenium.Click(By.XPath(CompleteStatusXpath));
            selenium.Click(By.XPath(ButtonOnToolbarXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CompleteTaskOfDevelopScheme()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.CheckElementIsVisible(By.XPath("" + TitleXpath + "Подтверждение работы - Разработка Схемы бизнес-процесса и направление на согласование (Проект – " + _numberProject + ")']"));

            //Actions act = new Actions(_driver);
            //act.DoubleClick(DevelopScheme).Perform();
            selenium.DoubleClick(By.XPath("" + TitleXpath + "Подтверждение работы - Разработка Схемы бизнес-процесса и направление на согласование (Проект – " + _numberProject + ")']"));

            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + EditorPopoutXpath + ")[2]"));
            selenium.Click(By.XPath(CompleteStatusXpath));
            selenium.Click(By.XPath(ButtonOnToolbarXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CompleteTaskOfDevelopTicket()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.CheckElementIsVisible(By.XPath("" + TitleXpath + "Подтверждение работы - Разработка Пояснительной записки и направление на согласование (Проект – " + _numberProject + ")']"));

            ///Actions act = new Actions(_driver);
            //act.DoubleClick(DevelopTicket).Perform();
            selenium.DoubleClick(By.XPath("" + TitleXpath + "Подтверждение работы - Разработка Пояснительной записки и направление на согласование (Проект – " + _numberProject + ")']"));

            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + EditorPopoutXpath + ")[2]"));
            selenium.Click(By.XPath(CompleteStatusXpath));
            selenium.Click(By.XPath(ButtonOnToolbarXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CompleteTaskOfNewRecord()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.CheckElementIsVisible(By.XPath("" + TitleXpath + "Подтверждение работы - TestName (Проект – " + _numberProject + ")']"));

            //Actions act = new Actions(_driver);
            //act.DoubleClick(TaskNewRecord).Perform();
            selenium.DoubleClick(By.XPath("" + TitleXpath + "Подтверждение работы - TestName (Проект – " + _numberProject + ")']"));

            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + EditorPopoutXpath + ")[2]"));
            selenium.Click(By.XPath(CompleteStatusXpath));
            selenium.Click(By.XPath(ButtonOnToolbarXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CompleteTaskOfNewRecord2()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.CheckElementIsVisible(By.XPath("(" + TitleXpath + "Подтверждение работы - TestName (Проект – " + _numberProject + ")'])[2]"));

            //Actions act = new Actions(_driver);
            //act.DoubleClick(TaskNewRecord2).Perform();
            selenium.DoubleClick(By.XPath("(" + TitleXpath + "Подтверждение работы - TestName (Проект – " + _numberProject + ")'])[2]"));

            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + EditorPopoutXpath + ")[2]"));
            selenium.Click(By.XPath(CompleteStatusXpath));
            selenium.Click(By.XPath(ButtonOnToolbarXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CompleteTaskOfNewRecord3()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.CheckElementIsVisible(By.XPath("(" + TitleXpath + "Подтверждение работы - TestName (Проект – " + _numberProject + ")'])[1]"));

            //Actions act = new Actions(_driver);
            //act.DoubleClick(TaskNewRecord3).Perform();
            selenium.DoubleClick(By.XPath("(" + TitleXpath + "Подтверждение работы - TestName (Проект – " + _numberProject + ")'])[1]"));

            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + EditorPopoutXpath + ")[2]"));
            selenium.Click(By.XPath(CompleteStatusXpath));
            selenium.Click(By.XPath(ButtonOnToolbarXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CompleteTaskDevelopTask()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.CheckElementIsVisible(By.XPath("" + TitleXpath + "Подтверждение работы - Разработка Задания на проектирование и направление на согласование (Проект – " + _numberProject + ")']"));

            //Actions act = new Actions(_driver);
            //act.DoubleClick(DevelopTask).Perform();
            selenium.DoubleClick(By.XPath("" + TitleXpath + "Подтверждение работы - Разработка Задания на проектирование и направление на согласование (Проект – " + _numberProject + ")']"));

            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + EditorPopoutXpath + ")[2]"));
            selenium.Click(By.XPath(CompleteStatusXpath));
            selenium.Click(By.XPath(ButtonOnToolbarXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
    }
}
