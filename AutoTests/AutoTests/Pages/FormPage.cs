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
    class FormPage : PageObject
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
        private readonly string FormAttributeCss = ConfigurationHelper.Get<string>("FormAttributeCss");
        public FormPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            selenium = new SeleniumHelperWithExpectedConditions(_driver);
        }
        public void NavigateIntoFirstForm()
        {
            selenium.DoubleClick(By.XPath(ColumnsOfListXpath));
        }
        //public void DragAndDropFirstAttribute()
        //{
         //   selenium.DragAndDrop(By.CssSelector(LoaderXpath));
        //}
        public string SearchByTittle(string Name, string Alias)
        {
            return selenium.SearchByTittle(FormAttributeCss, Name, Alias);
        }
        public void DragAndDropAttribute(string Name, string Alias)
        {
            selenium.DragAndDrop(SearchByTittle(Name, Alias));
        }
        public void DragAndDropFirstAttribute()
        {
            selenium.DragAndDrop(By.CssSelector(LoaderXpath));
        }
    }
}
