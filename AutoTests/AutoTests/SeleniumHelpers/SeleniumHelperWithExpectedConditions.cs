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
        private Actions act;
        private IWebElement webElement;
        public SeleniumHelperWithExpectedConditions(IWebDriver driver)
        {
            _driver = driver;
            act = new Actions(_driver);
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
                new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.InvisibilityOfElementLocated((by)));
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
                //act = new Actions(_driver);
                webElement = _driver.FindElement(by);
                //webElement.Click();
                act.DoubleClick(webElement).Build().Perform();
            }
            catch (StaleElementReferenceException)
            {
                new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.ElementToBeClickable(by));
                webElement = _driver.FindElement(by);
                //webElement.Click();
                act.DoubleClick(webElement).Build().Perform();
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
        public void DragAndDrop(By by)
        {
            try
            {
                //TODO load Form and Attribute
                //new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.ElementToBeClickable(by));
                IJavaScriptExecutor ex = (IJavaScriptExecutor)_driver;
                ex.ExecuteScript("var oEvent = new DragEvent('dragover');" +
                    "document.querySelector('.ld-view__canvas .region').dispatchEvent(oEvent); ");
                ex.ExecuteScript("var sEvent = new DragEvent('dragstart', { dataTransfer: new DataTransfer() });" +
                    "document.querySelector('.ld-list-item[draggable=\"true\"]').dispatchEvent(sEvent); ");
                ex.ExecuteScript("var dEvent = new DragEvent('drag', { dataTransfer: new DataTransfer(), clientX: 900, clientY: 500  });" +
                    "document.querySelector('.ld-list-item[draggable=\"true\"]').dispatchEvent(dEvent); ");
                ex.ExecuteScript("var eEvent = new DragEvent('dragend', { dataTransfer: new DataTransfer() });" +
                    "document.querySelector('.ld-list-item[draggable=\"true\"]').dispatchEvent(eEvent); ");
            }
            catch (Exception ex) when (ex is WebDriverTimeoutException || ex is NoSuchElementException)
            {
                Assert.Fail($"Exception occurred in SeleniumHelper.Click(): element located by {by.ToString()} could not be located within {ConfigurationHelper.Get<int>("ChromeWaitConfig")} seconds.");
            }
        }
    }
}
