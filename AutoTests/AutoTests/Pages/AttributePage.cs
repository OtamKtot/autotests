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
    class AttributePage : PageObject
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

        public AttributePage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            selenium = new SeleniumHelperWithExpectedConditions(_driver);
        }
        public IWebElement Add { get { return _driver.FindElement(By.XPath("" + AddXpath + "")); } }
        public IWebElement Name { get { return _driver.FindElement(By.XPath("" + TextFieldXpath + "")); } }
        public IWebElement Alias { get { return _driver.FindElement(By.XPath("(" + TextFieldXpath + ")[2]")); } }
        public IWebElement Save { get { return _driver.FindElement(By.XPath("" + ButtonOnStartFormXpath + "")); } }
        public IWebElement Loader { get { return _driver.FindElement(By.XPath("" + LoaderXpath + "")); } }
        public ReadOnlyCollection<IWebElement> Attributes { get { return _driver.FindElements(By.XPath("" + ColumnsOfListXpath + "")); } }
        public void CreateAttribute(string Name, string Alias)
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(AddXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.SendKeys(By.XPath(TextFieldXpath), Name);
            selenium.SendKeys(By.XPath("(" + TextFieldXpath + ")[2]"), Alias);
            selenium.Click(By.XPath(ButtonOnStartFormXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CreateTextAttribute(string Name)
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(AddXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.SendKeys(By.XPath(TextFieldXpath), Name);
            selenium.Click(By.XPath(ButtonOnStartFormXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CreateNumberAttribute(string Name)
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(AddXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(ListTypeAttributeXpath));
            selenium.Click(By.XPath(selenium.SearchByTittle(ListDataXpath, "Число")));
            selenium.SendKeys(By.XPath(TextFieldXpath), Name);
            selenium.Click(By.XPath(ButtonOnStartFormXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CreateDateAndTimeAttribute(string Name)
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(AddXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(ListTypeAttributeXpath));
            selenium.Click(By.XPath(selenium.SearchByTittle(ListDataXpath, "Дата / Время")));
            selenium.SendKeys(By.XPath(TextFieldXpath), Name);
            selenium.Click(By.XPath(ButtonOnStartFormXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CreateDurationAttribute(string Name)
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(AddXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(ListTypeAttributeXpath));
            selenium.Click(By.XPath(selenium.SearchByTittle(ListDataXpath, "Длительность")));
            selenium.SendKeys(By.XPath(TextFieldXpath), Name);
            selenium.Click(By.XPath(ButtonOnStartFormXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CreateLogicAttribute(string Name)
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(AddXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(ListTypeAttributeXpath));
            selenium.Click(By.XPath(selenium.SearchByTittle(ListDataXpath, "Логический")));
            selenium.SendKeys(By.XPath(TextFieldXpath), Name);
            selenium.Click(By.XPath(ButtonOnStartFormXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CreateUserAttribute(string Name)
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(AddXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(ListTypeAttributeXpath));
            selenium.Click(By.XPath(selenium.SearchByTittle(ListDataXpath, "Пользователь")));
            selenium.SendKeys(By.XPath(TextFieldXpath), Name);
            selenium.Click(By.XPath(ButtonOnStartFormXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CreateDocumentAttribute(string Name)
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(AddXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(ListTypeAttributeXpath));
            selenium.Click(By.XPath(selenium.SearchByTittle(ListDataXpath, "Документ")));
            selenium.SendKeys(By.XPath(TextFieldXpath), Name);
            selenium.Click(By.XPath(ButtonOnStartFormXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CreateImageAttribute(string Name)
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(AddXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(ListTypeAttributeXpath));
            selenium.Click(By.XPath(selenium.SearchByTittle(ListDataXpath, "Изображение")));
            selenium.SendKeys(By.XPath(TextFieldXpath), Name);
            selenium.Click(By.XPath(ButtonOnStartFormXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CreateURIAttribute(string Name)
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(AddXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(ListTypeAttributeXpath));
            selenium.Click(By.XPath(selenium.SearchByTittle(ListDataXpath, "Гиперссылка")));
            selenium.SendKeys(By.XPath(TextFieldXpath), Name);
            selenium.Click(By.XPath("(" + DropDownXpath + ")[7]"));
            selenium.Click(By.XPath(selenium.SearchByTittle(ListTypeURIXpath, "HTTP")));
            selenium.Click(By.XPath(selenium.SearchByTittle(ListTypeURIXpath, "Https")));
            selenium.Click(By.XPath(selenium.SearchByTittle(ListTypeURIXpath, "Telegram")));
            selenium.Click(By.XPath(selenium.SearchByTittle(ListTypeURIXpath, "Git")));
            selenium.Click(By.XPath(TextFieldXpath));
            selenium.Click(By.XPath(ButtonOnStartFormXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CreateLinkAttribute(string Name)
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(AddXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(ListTypeAttributeXpath));
            selenium.SendKeysWithoutClear(By.XPath(DropDownXpath), "Ссылка");
            selenium.Click(By.XPath(selenium.SearchByTittle(LinkTemplate, "Ссылка")));
            selenium.SendKeys(By.XPath(TextFieldXpath), Name);
            selenium.Click(By.XPath("(" + DropDownXpath + ")[5]"));
            selenium.Click(By.XPath(selenium.SearchByTittle(LinkTemplate, "RecordTemplate2")));
            selenium.Click(By.XPath(ButtonOnStartFormXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void CreateCollectionAttribute(string Name)
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(AddXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath(ListTypeAttributeXpath));
            selenium.SendKeysWithoutClear(By.XPath(DropDownXpath), "К");
            selenium.Click(By.XPath(selenium.SearchByTittle(LinkTemplate, "Коллекция")));
            selenium.SendKeys(By.XPath(TextFieldXpath), Name);
            selenium.Click(By.XPath("(" + DropDownXpath + ")[5]"));
            selenium.Click(By.XPath(selenium.SearchByTittle(LinkTemplate, "RecordTemplate3")));
            selenium.SendKeys(By.XPath("(" + TextFieldXpath + ")[5]"), "CollLink1");
            selenium.Click(By.XPath(ButtonOnStartFormXpath));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }


    } 
}
