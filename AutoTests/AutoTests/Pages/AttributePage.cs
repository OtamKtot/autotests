using AutoTests.Utilies;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTests.Pages
{
    class AttributePage : PageObject
    {
        private readonly IWebDriver _driver;
        private readonly string AddXpath = ConfigurationHelper.Get<string>("AddXpath");
        private readonly string TextFieldXpath = ConfigurationHelper.Get<string>("TextFieldXpath");
        private readonly string ButtonOnStartFormXpath = ConfigurationHelper.Get<string>("ButtonOnStartFormXpath");
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath");
        public AttributePage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }
        public IWebElement Add { get { return _driver.FindElement(By.XPath("" + AddXpath + "")); } }
        public IWebElement Name { get { return _driver.FindElement(By.XPath("" + TextFieldXpath + "")); } }
        public IWebElement Alias { get { return _driver.FindElement(By.XPath("(" + TextFieldXpath + ")[2]")); } }
        public IWebElement Save { get { return _driver.FindElement(By.XPath("" + ButtonOnStartFormXpath + "")); } }
        public IWebElement Loader { get { return _driver.FindElement(By.XPath("" + LoaderXpath + "")); } }
    }
}
