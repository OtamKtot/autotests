using AutoTests.Globals;
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
    class ButtonPage : PageObject
    {
        private readonly IWebDriver _driver;
        private readonly SeleniumHelperWithExpectedConditions selenium;
        private readonly string AddXpath = ConfigurationHelper.Get<string>("AddXpath");
        private readonly string TextFieldXpath = ConfigurationHelper.Get<string>("TextFieldXpath");
        private readonly string ButtonOnStartFormXpath = ConfigurationHelper.Get<string>("ButtonOnStartFormXpath");
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath");
        private readonly string ColumnsOfListXpath = ConfigurationHelper.Get<string>("ColumnsOfListXpath");
        private readonly string ListTypeAttributeXpath = ConfigurationHelper.Get<string>("ListTypeAttributeXpath");
        private readonly string ListElementsCss = ConfigurationHelper.Get<string>("ListElementsCss");
        private readonly string DropDownXpath = ConfigurationHelper.Get<string>("DropDownXpath");
        private readonly string ListTypeURIXpath = ConfigurationHelper.Get<string>("ListTypeURIXpath");
        private readonly string SaveButtonXpath = ConfigurationHelper.Get<string>("SaveButtonXpath");

        public ButtonPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            selenium = new SeleniumHelperWithExpectedConditions(_driver);
        }
        public void CreateButton(string Name)
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(AddXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.SendKeys(By.XPath(TextFieldXpath), Name);
            selenium.Click(By.XPath(DropDownXpath));
            selenium.Click(By.CssSelector(selenium.SearchByTittleCss(ListElementsCss, "Запись")));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("("+DropDownXpath+")[2]"));
            selenium.Click(By.CssSelector(selenium.SearchByTittleCss(ListElementsCss, "Создать")));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + DropDownXpath + ")[3]"));
            selenium.Click(By.CssSelector(selenium.SearchByTittleCss(ListElementsCss, "Обновить данные")));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("(" + DropDownXpath + ")[5]"));
            selenium.Click(By.CssSelector(selenium.SearchByTittleCss(ListElementsCss, Constants.RecordTemplate1)));
            selenium.Click(By.XPath(SaveButtonXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
    }
}
