using System;
using OpenQA.Selenium;
using WebDriverWait = OpenQA.Selenium.Support.UI.WebDriverWait;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;
using AutoTests.Utilies;
using OpenQA.Selenium.Interactions;

namespace AutoTests.SeleniumHelpers
{
    public class SeleniumHelperWithExpectedConditions
    {
        private IWebDriver _driver;
        public SeleniumHelperWithExpectedConditions(IWebDriver driver)
        {
            _driver = driver;
        }
        public void SendKeys(By by, string valueToType)
        {
            try
            {
                new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ImplicitlyWait"))).Until(ExpectedConditions.ElementToBeClickable(by));
                _driver.FindElement(by).Clear();
                _driver.FindElement(by).SendKeys(valueToType);
            }
            catch (StaleElementReferenceException)
            {
                new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ImplicitlyWait"))).Until(ExpectedConditions.ElementToBeClickable(by));
                _driver.FindElement(by).Clear();
                _driver.FindElement(by).SendKeys(valueToType);
            }
            catch (Exception ex) when (ex is NoSuchElementException || ex is WebDriverTimeoutException)
            {
                Assert.Fail($"Exception occurred in SeleniumHelper.SendKeys(): element located by {by.ToString()} could not be located within {ConfigurationHelper.Get<int>("ImplicitlyWait")} seconds.");
            }
        }
        public void Click(By by)
        {
            try
            {
                new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ImplicitlyWait"))).Until(ExpectedConditions.ElementToBeClickable(by));
                _driver.FindElement(by).Click();
            }
            catch (StaleElementReferenceException)
            {
                new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ImplicitlyWait"))).Until(ExpectedConditions.ElementToBeClickable(by));
                _driver.FindElement(by).Click();
            }
            catch (Exception ex) when (ex is WebDriverTimeoutException || ex is NoSuchElementException)  
            {
                Assert.Fail($"Exception occurred in SeleniumHelper.Click(): element located by {by.ToString()} could not be located within {ConfigurationHelper.Get<int>("ImplicitlyWait")} seconds.");
            }
        }
        public bool CheckElementIsVisible(By by)
        {
            try
            {
                new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ImplicitlyWait"))).Until(ExpectedConditions.ElementIsVisible((by)));
            }
            catch (Exception ex) when (ex is NoSuchElementException || ex is WebDriverTimeoutException)
            {
                return false;
            }
            return true;
        }
        public string GetElementText(By by)
        {
            string returnValue = "";
            try
            {
                new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ImplicitlyWait"))).Until(ExpectedConditions.ElementIsVisible(by));
                returnValue = _driver.FindElement(by).Text;
            }
            catch (Exception ex) when (ex is NoSuchElementException || ex is WebDriverTimeoutException)
            {
                Assert.Fail($"Exception occurred in SeleniumHelper.GetElementText(): element located by {by.ToString()} could not be located within {ConfigurationHelper.Get<int>("ImplicitlyWait")} seconds.");
            }
            return returnValue;
        }
        public bool CheckElementIsUnVisible(By by)
        {
            try
            {
                new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ImplicitlyWait"))).Until(ExpectedConditions.InvisibilityOfElementLocated((by)));
            }
            catch (Exception ex) when (ex is NoSuchElementException || ex is WebDriverTimeoutException)
            {
                return false;
            }
            return true;
        }
        public void DoubleClick(By by)
        {
            try
            {
                new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ImplicitlyWait"))).Until(ExpectedConditions.ElementToBeClickable(by));
                Actions act = new Actions(_driver);
                IWebElement webElement = _driver.FindElement(by);
                act.DoubleClick(webElement);
            }
            catch (StaleElementReferenceException)
            {
                new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ImplicitlyWait"))).Until(ExpectedConditions.ElementToBeClickable(by));
                Actions act1 = new Actions(_driver);
                act1.DoubleClick(_driver.FindElement(by));
            }
            catch (Exception ex) when (ex is WebDriverTimeoutException || ex is NoSuchElementException)
            {
                Assert.Fail($"Exception occurred in SeleniumHelper.Click(): element located by {by.ToString()} could not be located within {ConfigurationHelper.Get<int>("ImplicitlyWait")} seconds.");
            }
        }
    }
}
