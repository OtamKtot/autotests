using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoTests.Utilies;
using OpenQA.Selenium;

namespace AutoTests.Pages
{
    class AdministrationPage : PageObject
    {
        private readonly IWebDriver _driver;
        private readonly string TemplateTextXpath = ConfigurationHelper.Get<string>("TemplateTextXpath");
        public AdministrationPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }
        public IWebElement TemplateText { get { return _driver.FindElement(By.XPath("" + TemplateTextXpath + "")); } }
    }
}
