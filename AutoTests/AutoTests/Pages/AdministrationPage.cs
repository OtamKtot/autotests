using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoTests.SeleniumHelpers;
using AutoTests.Utilies;
using OpenQA.Selenium;

namespace AutoTests.Pages
{
    class AdministrationPage : PageObject
    {
        private readonly IWebDriver _driver;
        private readonly string TemplateTextXpath = ConfigurationHelper.Get<string>("TemplateTextXpath");
        private readonly SeleniumHelperWithExpectedConditions selenium;
        public AdministrationPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            selenium = new SeleniumHelperWithExpectedConditions(_driver);
        }
        public IWebElement TemplateText { get { return _driver.FindElement(By.XPath("" + TemplateTextXpath + "")); } }
        public void NavigateIntoTemplates()
        {
            selenium.Click(By.XPath(TemplateTextXpath));
        }
    }
}
