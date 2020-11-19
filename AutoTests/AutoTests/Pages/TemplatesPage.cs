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

    }
}
