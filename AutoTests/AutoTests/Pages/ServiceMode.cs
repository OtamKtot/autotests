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
    class ServiceMode : PageObject
    {
        private readonly IWebDriver _driver;
        private readonly SeleniumHelperWithExpectedConditions selenium;
        private readonly string LoaderXpath = ConfigurationHelper.Get<string>("LoaderXpath");
        public ServiceMode(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            selenium = new SeleniumHelperWithExpectedConditions(_driver);
        }
        public void GoServiceMode()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.Click(By.XPath("//*[@class='login__link']"));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.SendKeys(By.Id("username"), "admin");
            selenium.SendKeys(By.Id("password"), "admin123");
            selenium.Click(By.Id("LoginButton"));
            selenium.Click(By.XPath("//*[@class='configure__skip-button']"));
            selenium.Click(By.XPath("//*[@class='configure__submit']"));
            //To upgrade 3.5 to 3.6
            //selenium.SendKeys(By.Id("Uri"), "http://autoqa:9200/");
            //selenium.Click(By.XPath("//*[@class='configure__submit configure__submit_elastic']"));
            //selenium.Click(By.XPath("(//*[@class='configure__submit configure__submit_elastic-btn'])[2]"));
            //selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
        public void ILoginInSystem()
        {
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
            selenium.CheckElementIsVisible(By.XPath("//*[@class='js-link-button left-menu-i']"));
            selenium.CheckElementIsUnVisible(By.XPath(LoaderXpath));
        }
    }
}
