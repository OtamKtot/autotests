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
    class ProjectOnTicket : PageObject
    {
        private readonly IWebDriver _driver;
        private readonly SeleniumHelperWithExpectedConditions selenium;
        private readonly string MakeProjectXpath = ConfigurationHelper.Get<string>("MakeProjectXpath");
        private readonly string AddNewRecordOnCollectionXpath = ConfigurationHelper.Get<string>("AddNewRecordOnCollectionXpath");
        private readonly string CollectionFieldXpath = ConfigurationHelper.Get<string>("CollectionFieldXpath");
        private readonly string TextFieldXpath = ConfigurationHelper.Get<string>("TextFieldXpath");
        private readonly string DayOldXpath = ConfigurationHelper.Get<string>("DayOldXpath");
        private readonly string DayNewXpath = ConfigurationHelper.Get<string>("DayNewXpath");
        private readonly string DropDownXpath = ConfigurationHelper.Get<string>("DropDownXpath");
        private readonly string FirstListCheckBoxXpath = ConfigurationHelper.Get<string>("FirstListCheckBoxXpath");
        private readonly string FirstElementFromListXpath = ConfigurationHelper.Get<string>("FirstElementFromListXpath");
        private readonly string ButtonOnToolbarXpath = ConfigurationHelper.Get<string>("ButtonOnToolbarXpath");
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath"); 
        private readonly string LoaderOnUserFieldOnCollectionXpath = ConfigurationHelper.Get<string>("LoaderOnUserFieldOnCollectionXpath");
        private readonly string VerticalLayoutXpath = ConfigurationHelper.Get<string>("VerticalLayoutXpath");
        public ProjectOnTicket(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            selenium = new SeleniumHelperWithExpectedConditions(_driver);
        }
        public IWebElement MakeProject { get { return _driver.FindElement(By.XPath("" + MakeProjectXpath + "")); } }
        public IWebElement AddNewRecordOnCollection { get { return _driver.FindElement(By.XPath("(" + AddNewRecordOnCollectionXpath + ")[3]")); } }
        public IWebElement CodeClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + "[2])[2]")); } }
        public IWebElement CodeSendKeys { get { return _driver.FindElement(By.XPath("(" + TextFieldXpath + ")[7]")); } }
        public IWebElement NameClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + "[3])[2]")); } }
        public IWebElement NameSendKeys { get { return _driver.FindElement(By.XPath("(" + TextFieldXpath + ")[7]")); } }
        public IWebElement StartDateClick { get { return _driver.FindElement(By.XPath("" + CollectionFieldXpath + "[5]")); } }
        public IWebElement StartDateSendKeys { get { return _driver.FindElement(By.XPath("(" + DayOldXpath + ")[1]")); } }
        public IWebElement EndDateClick { get { return _driver.FindElement(By.XPath("" + CollectionFieldXpath + "[6]")); } }
        public IWebElement EndDateSendKeys { get { return _driver.FindElement(By.XPath("(" + DayNewXpath + ")[2]")); } }
        public IWebElement UserClick { get { return _driver.FindElement(By.XPath("(" + CollectionFieldXpath + "[4])[2]")); } }
        public IWebElement UserSendKeys { get { return _driver.FindElement(By.XPath("(" + DropDownXpath + ")[2]")); } }
        public IWebElement FirstListCheckBox { get { return _driver.FindElement(By.XPath("" + FirstListCheckBoxXpath + "")); } }
        public IWebElement Status { get { return _driver.FindElement(By.XPath("" + CollectionFieldXpath + "[8]")); } }
        public IWebElement FirstListElement { get { return _driver.FindElement(By.XPath("" + FirstElementFromListXpath + "")); } }
        public IWebElement USEED { get { return _driver.FindElement(By.XPath("" + CollectionFieldXpath + "[7]")); } }
        public IWebElement CompleteTaskButton { get { return _driver.FindElement(By.XPath("" + ButtonOnToolbarXpath + "")); } }
        public IWebElement Loader { get { return _driver.FindElement(By.XPath("" + LoaderXpath + "")); } }
        public IWebElement LoaderOnUserFieldOnCollection { get { return _driver.FindElement(By.XPath("" + LoaderOnUserFieldOnCollectionXpath + "")); } }
        public void OpenTask()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.CheckElementIsVisible(By.XPath(MakeProjectXpath));

            Actions act = new Actions(_driver);
            act.DoubleClick(MakeProject).Perform();

            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void AddRecordInCollection()
        {
            string code = "11";
            selenium.Click(By.XPath("(" + AddNewRecordOnCollectionXpath + ")[3]"));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + "[2])[2]"));
            selenium.SendKeys(By.XPath("(" + TextFieldXpath + ")[7]"), code);
            selenium.Click(By.XPath(VerticalLayoutXpath));
            Assert.AreEqual(selenium.GetElementText(By.XPath("(" + CollectionFieldXpath + "[2])[2]")), code);
            selenium.Click(By.XPath("(" + CollectionFieldXpath + "[3])[2]"));
            selenium.SendKeys(By.XPath("(" + TextFieldXpath + ")[7]"), "TestName");
            selenium.Click(By.XPath(VerticalLayoutXpath));
            Assert.AreEqual(selenium.GetElementText(By.XPath("(" + CollectionFieldXpath + "[3])[2]")), "TestName");
            selenium.Click(By.XPath("" + CollectionFieldXpath + "[5]"));
            selenium.Click(By.XPath("(" + DayOldXpath + ")[1]"));
            selenium.Click(By.XPath("" + CollectionFieldXpath + "[6]"));
            selenium.Click(By.XPath("(" + DayNewXpath + ")[2]"));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + "[4])[2]"));
            Thread.Sleep(2000);
            selenium.SendKeys(By.XPath("(" + DropDownXpath + ")[2]"), "Director");
            selenium.CheckElementIsUnVisible(By.XPath(LoaderOnUserFieldOnCollectionXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            Thread.Sleep(2000);
            selenium.Click(By.XPath(FirstListCheckBoxXpath));
            selenium.Click(By.XPath("" + CollectionFieldXpath + "[8]"));
            selenium.Click(By.XPath(FirstElementFromListXpath));
            selenium.Click(By.XPath("" + CollectionFieldXpath + "[7]"));
            selenium.Click(By.XPath(VerticalLayoutXpath));
        }
        public void CompleteTask()
        {
            selenium.Click(By.XPath(ButtonOnToolbarXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }

        public string CompleteTaskOLD()
        {
            //Random rnd = new Random();
            //string code = rnd.Next().ToString();
            string code = "11";
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.CheckElementIsVisible(By.XPath(MakeProjectXpath));

            Actions act = new Actions(_driver);
            act.DoubleClick(MakeProject).Perform();

            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + AddNewRecordOnCollectionXpath + ")[3]"));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + "[2])[2]"));
            selenium.SendKeys(By.XPath("(" + TextFieldXpath + ")[7]"), code);
            selenium.Click(By.XPath(VerticalLayoutXpath));
            Assert.AreEqual(selenium.GetElementText(By.XPath("(" + CollectionFieldXpath + "[2])[2]")),code);
            selenium.Click(By.XPath("(" + CollectionFieldXpath + "[3])[2]"));
            selenium.SendKeys(By.XPath("(" + TextFieldXpath + ")[7]"), "TestName");
            selenium.Click(By.XPath(VerticalLayoutXpath));
            Assert.AreEqual(selenium.GetElementText(By.XPath("(" + CollectionFieldXpath + "[3])[2]")), "TestName");
            selenium.Click(By.XPath("" + CollectionFieldXpath + "[5]"));
            selenium.Click(By.XPath("(" + DayOldXpath + ")[1]"));
            selenium.Click(By.XPath("" + CollectionFieldXpath + "[6]"));
            selenium.Click(By.XPath("(" + DayNewXpath + ")[2]"));
            selenium.Click(By.XPath("(" + CollectionFieldXpath + "[4])[2]"));
            Thread.Sleep(2000);
            selenium.SendKeys(By.XPath("(" + DropDownXpath + ")[2]"), "Director");
            selenium.CheckElementIsUnVisible(By.XPath(LoaderOnUserFieldOnCollectionXpath));
            Thread.Sleep(2000);
            selenium.Click(By.XPath(FirstListCheckBoxXpath));
            selenium.Click(By.XPath("" + CollectionFieldXpath + "[8]"));
            selenium.Click(By.XPath(FirstElementFromListXpath));
            selenium.Click(By.XPath("" + CollectionFieldXpath + "[7]"));
            selenium.Click(By.XPath(ButtonOnToolbarXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            return code;
        }
    }
}