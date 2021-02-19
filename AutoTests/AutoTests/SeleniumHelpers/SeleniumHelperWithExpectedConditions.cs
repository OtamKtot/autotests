using System;
using OpenQA.Selenium;
using WebDriverWait = OpenQA.Selenium.Support.UI.WebDriverWait;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;
using AutoTests.Utilies;
using OpenQA.Selenium.Interactions;
using System.Collections.ObjectModel;

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
                new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.ElementToBeClickable(by));
                _driver.FindElement(by).Clear();
                _driver.FindElement(by).SendKeys(valueToType);
            }
            catch (StaleElementReferenceException)
            {
                new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.ElementToBeClickable(by));
                _driver.FindElement(by).Clear();
                _driver.FindElement(by).SendKeys(valueToType);
            }
            catch (Exception ex) when (ex is NoSuchElementException || ex is WebDriverTimeoutException)
            {
                Assert.Fail($"Exception occurred in SeleniumHelper.SendKeys(): element located by {by.ToString()} could not be located within {ConfigurationHelper.Get<int>("ChromeWaitConfig")} seconds.");
            }
        }
        public void Click(By by)
        {
            try
            {
                new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.ElementToBeClickable(by));
                _driver.FindElement(by).Click();
            }
            catch (StaleElementReferenceException)
            {
                new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.ElementToBeClickable(by));
                _driver.FindElement(by).Click();
            }
            catch (ElementClickInterceptedException)
            {
                try
                {
                    new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.InvisibilityOfElementLocated((By.XPath("//*[@class='loader']"))));
                }
                catch
                {
                    Assert.Fail($"Loader did not disappear after {ConfigurationHelper.Get<int>("ChromeWaitConfig")} seconds.");
                }
            }
            catch (Exception ex) when (ex is WebDriverTimeoutException || ex is NoSuchElementException)
            {
                Assert.Fail($"Exception occurred in SeleniumHelper.Click(): element located by {by.ToString()} could not be located within {ConfigurationHelper.Get<int>("ChromeWaitConfig")} seconds.");
            }
        }
        public bool CheckElementIsVisible(By by)
        {
            try
            {
                new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.ElementIsVisible((by)));
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
                new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.ElementIsVisible(by));
                returnValue = _driver.FindElement(by).Text;
            }
            catch (Exception ex) when (ex is NoSuchElementException || ex is WebDriverTimeoutException)
            {
                Assert.Fail($"Exception occurred in SeleniumHelper.GetElementText(): element located by {by.ToString()} could not be located within {ConfigurationHelper.Get<int>("ChromeWaitConfig")} seconds.");
            }
            return returnValue;
        }
        public bool CheckElementIsUnVisible(By by)
        {
            try
            {
                var a = new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.InvisibilityOfElementLocated((by)));
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
                new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.ElementToBeClickable(by));
                Actions act = new Actions(_driver);
                IWebElement webElement = _driver.FindElement(by);
                act.DoubleClick(webElement);
            }
            catch (StaleElementReferenceException)
            {
                new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.ElementToBeClickable(by));
                Actions act1 = new Actions(_driver);
                act1.DoubleClick(_driver.FindElement(by));
            }
            catch (Exception ex) when (ex is WebDriverTimeoutException || ex is NoSuchElementException)
            {
                Assert.Fail($"Exception occurred in SeleniumHelper.Click(): element located by {by.ToString()} could not be located within {ConfigurationHelper.Get<int>("ChromeWaitConfig")} seconds.");
            }
        }
        public void HasElementInList(By by, string disabledName)
        {
            ReadOnlyCollection<IWebElement> webElements = _driver.FindElements(by);
            int count = 0;
            for (int i = 0; i < webElements.Count; i = i + 1)
            {
                if (webElements[i].Text == disabledName && webElements[i].Displayed)
                {
                    count = 1;
                    break;

                }
            }
            if (count == 0)
            {
                Assert.Fail($"Exception occurred in SeleniumHelper.HasElementInList(): element located by {by.ToString()} could not be located within {ConfigurationHelper.Get<int>("ChromeWaitConfig")} seconds.");
            }
        }
    }
}
