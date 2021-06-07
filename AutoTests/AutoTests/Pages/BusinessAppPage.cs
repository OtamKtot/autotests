using AutoTests.SeleniumHelpers;
using AutoTests.Utilies;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTests.Pages
{
    class BusinessAppPage : PageObject
    {
        private readonly IWebDriver _driver;
        private readonly SeleniumHelperWithExpectedConditions selenium;
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath"); 
        private readonly string ColumnsOfListXpath = ConfigurationHelper.Get<string>("ColumnsOfListXpath"); 
        private readonly string AddXpath = ConfigurationHelper.Get<string>("AddXpath"); 
        private readonly string TextFieldXpath = ConfigurationHelper.Get<string>("TextFieldXpath");
        private readonly string ButtonOnStartFormXpath = ConfigurationHelper.Get<string>("ButtonOnStartFormXpath");
        private readonly string AlertBodyXpath = ConfigurationHelper.Get<string>("AlertBodyXpath");
        public BusinessAppPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            selenium = new SeleniumHelperWithExpectedConditions(_driver);
        }
        public IWebElement Loader { get { return _driver.FindElement(By.XPath("" + LoaderXpath + "")); } }
        public ReadOnlyCollection<IWebElement> BuisnessApp { get { return _driver.FindElements(By.XPath("" + ColumnsOfListXpath + "")); } }
        public void NavigateIntoSystemBusinessApp(string Name)
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.HasElementInList(By.XPath(ColumnsOfListXpath),Name);
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void SelectFromListSystemBusinessApp(string Name)
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            foreach (var element in BuisnessApp)
            {
                if (element.Text == Name)
                {
                    selenium.DoubleClick(element);
                    break;
                }
            }
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void AddBusinessApp(string Name)
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(AddXpath));
            selenium.SendKeys(By.XPath(TextFieldXpath), Name);
            selenium.Click(By.XPath(ButtonOnStartFormXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void AlertIsTrue()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            Assert.AreEqual(selenium.GetElementText(By.XPath(AlertBodyXpath)), "Приложение создано");
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void NavigateIntoTestBusinessApp(string Name)
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.DoubleClick(By.XPath(selenium.SearchByTittle(ColumnsOfListXpath, Name)));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
    }
}
