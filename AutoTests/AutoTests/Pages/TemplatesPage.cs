using AutoTests.SeleniumHelpers;
using AutoTests.Utilies;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTests.Pages
{
    class TemplatesPage : PageObject
    {
        private readonly IWebDriver _driver;
        private readonly SeleniumHelperWithExpectedConditions selenium;
        private readonly string AddXpath = ConfigurationHelper.Get<string>("AddXpath");
        private readonly string TextFieldXpath = ConfigurationHelper.Get<string>("TextFieldXpath");
        private readonly string DropDownXpath = ConfigurationHelper.Get<string>("DropDownXpath");
        private readonly string SelectedListXpath = ConfigurationHelper.Get<string>("SelectedListXpath");
        private readonly string ButtonOnStartFormXpath = ConfigurationHelper.Get<string>("ButtonOnStartFormXpath");
        private readonly string ColumnsOfListXpath = ConfigurationHelper.Get<string>("ColumnsOfListXpath");
        private readonly string AttributeTextXpath = ConfigurationHelper.Get<string>("AttributeTextXpath");
        private readonly string FormTextXpath = ConfigurationHelper.Get<string>("FormTextXpath");
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath");
        public TemplatesPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            selenium = new SeleniumHelperWithExpectedConditions(_driver);
        }
        public IWebElement Add { get { return _driver.FindElement(By.XPath("" + AddXpath + "")); } }
        public IWebElement Name { get { return _driver.FindElement(By.XPath("" + TextFieldXpath + "")); } }
        public IWebElement Alias { get { return _driver.FindElement(By.XPath("(" + TextFieldXpath + ")[2]")); } }
        public IWebElement Solution { get { return _driver.FindElement(By.XPath("(" + DropDownXpath + ")[2]")); } }
        public IWebElement SolutionSystem { get { return _driver.FindElement(By.XPath("" + SelectedListXpath + "")); } }
        public IWebElement Create { get { return _driver.FindElement(By.XPath("" + ButtonOnStartFormXpath + "")); } }
        public ReadOnlyCollection<IWebElement> Templates { get { return _driver.FindElements(By.XPath("" + ColumnsOfListXpath + "")); } }
        public IWebElement AttributeText { get { return _driver.FindElement(By.XPath("" + AttributeTextXpath + "")); } }
        public IWebElement FormText { get { return _driver.FindElement(By.XPath("" + FormTextXpath + "")); } }
        public IWebElement Loader { get { return _driver.FindElement(By.XPath("" + LoaderXpath + "")); } }

        public void NavigateIntoTemplate()
        {
            selenium.DoubleClick(By.XPath(ColumnsOfListXpath));
        }
        public void AddRecordTemplate(string Name, string Alias)
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(AddXpath));
            selenium.SendKeys(By.XPath(TextFieldXpath), Name);
            selenium.SendKeys(By.XPath("(" + TextFieldXpath + ")[2]"), Alias);
            selenium.Click(By.XPath("(" + DropDownXpath + ")[2]"));
            selenium.Click(By.XPath(SelectedListXpath));
            selenium.Click(By.XPath(ButtonOnStartFormXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void HasElementInList(string Name)
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.HasElementInList(By.XPath(ColumnsOfListXpath),Name);
        }
        public void NavigateIntoForm()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(FormTextXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
    }
}
