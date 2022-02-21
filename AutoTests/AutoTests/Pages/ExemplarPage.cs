using AutoTests.SeleniumHelpers;
using AutoTests.Utilies;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTests.Pages
{
    class ExemplarPage : PageObject
    {
        private readonly IWebDriver _driver;
        private readonly SeleniumHelperWithExpectedConditions selenium;
        private readonly string AddXpath = ConfigurationHelper.Get<string>("AddXpath");
        private readonly string TextFieldXpath = ConfigurationHelper.Get<string>("TextFieldXpath");
        private readonly string ButtonOnStartFormXpath = ConfigurationHelper.Get<string>("ButtonOnStartFormXpath");
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath");
        private readonly string ColumnsOfListXpath = ConfigurationHelper.Get<string>("ColumnsOfListXpath");
        private readonly string ListTypeAttributeXpath = ConfigurationHelper.Get<string>("ListTypeAttributeXpath");
        private readonly string ListDataXpath = ConfigurationHelper.Get<string>("ListDataXpath");
        private readonly string DropDownXpath = ConfigurationHelper.Get<string>("DropDownXpath");
        private readonly string ListTypeURIXpath = ConfigurationHelper.Get<string>("ListTypeURIXpath");
        private readonly string LinkTemplate = ConfigurationHelper.Get<string>("LinkTemplate");

        public ExemplarPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            selenium = new SeleniumHelperWithExpectedConditions(_driver);
        }
    }
}
