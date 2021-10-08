using System;
using OpenQA.Selenium;
using WebDriverWait = OpenQA.Selenium.Support.UI.WebDriverWait;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;
using AutoTests.Utilies;
using OpenQA.Selenium.Interactions;
using System.Collections.ObjectModel;
using System.Threading;

namespace AutoTests.SeleniumHelpers
{
    public class SeleniumHelperWithExpectedConditions
    {
        private IWebDriver _driver;
        //private Actions act;
        //private Actions act2;
        private IWebElement webElement;
        private IWebElement webElement2;
        public SeleniumHelperWithExpectedConditions(IWebDriver driver)
        {
            _driver = driver;
            //act = new Actions(_driver);
            //act2 = new Actions(_driver);
        }
        public void SendKeysWithoutClear(By by, string valueToType)
        {
            try
            {
                new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.ElementToBeClickable(by));
                _driver.FindElement(by).SendKeys(valueToType);
            }
            catch (StaleElementReferenceException)
            {
                new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.ElementToBeClickable(by));
                _driver.FindElement(by).SendKeys(valueToType);
            }
            catch (Exception ex) when (ex is NoSuchElementException || ex is WebDriverTimeoutException)
            {
                Assert.Fail($"Exception occurred in SeleniumHelper.SendKeys(): element located by {by.ToString()} could not be located within {ConfigurationHelper.Get<int>("ChromeWaitConfig")} seconds.");
            }
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
                    _driver.FindElement(by).Click();
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
                Thread.Sleep(500);
                new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.InvisibilityOfElementLocated((by)));
                Thread.Sleep(500);
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
                new Actions(_driver).DoubleClick(webElement).Perform();
            }
            catch (StaleElementReferenceException)
            {
                Thread.Sleep(2000);
                new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.ElementToBeClickable(by));
                webElement2 = _driver.FindElement(by);
                //webElement.Click();
                new Actions(_driver).DoubleClick(webElement2).Perform();
            }
            catch (Exception ex) when (ex is WebDriverTimeoutException || ex is NoSuchElementException)
            {
                Assert.Fail($"Exception occurred in SeleniumHelper.Click(): element located by {by.ToString()} could not be located within {ConfigurationHelper.Get<int>("ChromeWaitConfig")} seconds.");
            }
        }
        public void DoubleClick(IWebElement webElement)
        {
            try
            {
                new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.ElementToBeClickable(webElement));
                new Actions(_driver).DoubleClick(webElement).Perform();
            }
            catch (StaleElementReferenceException)
            {
                Thread.Sleep(2000);
                new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.ElementToBeClickable(webElement));
                new Actions(_driver).DoubleClick(webElement).Perform();
            }
            catch (Exception ex) when (ex is WebDriverTimeoutException || ex is NoSuchElementException)
            {
                Assert.Fail($"Exception occurred in SeleniumHelper.Click(): element located by {webElement.ToString()} could not be located within {ConfigurationHelper.Get<int>("ChromeWaitConfig")} seconds.");
            }
        }
        public void HasElementInList(By by, string disabledName)
        {
            new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(by)); 
            new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.ElementToBeClickable(by));
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
            Thread.Sleep(1000);
            string cssSelector = ".js-context-ld-list-item.ld-list-item-block";
            //String xpath = css2xpath.Transform(cssSelector);
            try
            {
                //TODO load Form and Attribute
                //new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.ElementToBeClickable(by));
                //".ld-list-item" for 3.5
                //".ld-list-item__link" for 3.6
                IJavaScriptExecutor ex = (IJavaScriptExecutor)_driver;
                ex.ExecuteScript("var oEvent = new DragEvent('dragover');" +
                    "document.querySelector('.ld-view__canvas .region').dispatchEvent(oEvent); ");
                ex.ExecuteScript("var sEvent = new DragEvent('dragstart', { dataTransfer: new DataTransfer() });" +
                    "document.querySelector('"+ cssSelector+"[draggable=\"true\"]').dispatchEvent(sEvent); ");
                ex.ExecuteScript("var dEvent = new DragEvent('drag', { dataTransfer: new DataTransfer(), clientX: 900, clientY: 500  });" +
                    "document.querySelector('" + cssSelector + "[draggable=\"true\"]').dispatchEvent(dEvent); ");
                ex.ExecuteScript("var eEvent = new DragEvent('dragend', { dataTransfer: new DataTransfer() });" +
                    "document.querySelector('" + cssSelector + "[draggable=\"true\"]').dispatchEvent(eEvent); ");
            }
            catch (Exception ex) when (ex is WebDriverTimeoutException || ex is NoSuchElementException)
            {
                Assert.Fail($"Exception occurred in SeleniumHelper.DragAndDrop(): element located by {cssSelector} could not be located within {ConfigurationHelper.Get<int>("ChromeWaitConfig")} seconds.");
            }
        }
        public void DragAndDrop(string cssSelector)
        {
            //string cssSelector = ".ld-list-item:nth-child(5)";
            //String xpath = css2xpath.Transform(cssSelector);
            try
            {
                //TODO load Form and Attribute
                //new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.ElementToBeClickable(by));
                //".ld-list-item" for 3.5
                //".ld-list-item__link" for 3.6
                IJavaScriptExecutor ex = (IJavaScriptExecutor)_driver;
                ex.ExecuteScript("var oEvent = new DragEvent('dragover');" +
                    "document.querySelector('.ld-view__canvas .region').dispatchEvent(oEvent); ");
                ex.ExecuteScript("var sEvent = new DragEvent('dragstart', { dataTransfer: new DataTransfer() });" +
                    "document.querySelector('" + cssSelector + "[draggable=\"true\"]').dispatchEvent(sEvent); ");
                ex.ExecuteScript("var dEvent = new DragEvent('drag', { dataTransfer: new DataTransfer(), clientX: 900, clientY: 500  });" +
                    "document.querySelector('" + cssSelector + "[draggable=\"true\"]').dispatchEvent(dEvent); ");
                ex.ExecuteScript("var eEvent = new DragEvent('dragend', { dataTransfer: new DataTransfer() });" +
                    "document.querySelector('" + cssSelector + "[draggable=\"true\"]').dispatchEvent(eEvent); ");
            }
            catch (Exception ex) when (ex is WebDriverTimeoutException || ex is NoSuchElementException)
            {
                Assert.Fail($"Exception occurred in SeleniumHelper.DragAndDrop(): element located by {cssSelector} could not be located within {ConfigurationHelper.Get<int>("ChromeWaitConfig")} seconds.");
            }
        }
        public string SearchByTittle(string cssSelector, string Name, string Alias)
        {
            new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(cssSelector)));
            new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(cssSelector)));
            var count = _driver.FindElements(By.CssSelector(cssSelector)).Count;
            for (int i=1; i<count; i++)
            {
                string NameAlias = Name + "\r\n" + Name + Alias;
                cssSelector = cssSelector + ":nth-child(" + i + ")";
                new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(cssSelector)));
                webElement = _driver.FindElement(By.CssSelector(cssSelector));
                var a = webElement.GetAttribute("title");
                if (webElement.Text == NameAlias)
                {
                    return cssSelector;
                }
                cssSelector = cssSelector.Replace(":nth-child(" + i + ")", "");
            }
            Assert.Fail($"Exception occurred in SeleniumHelper.SearchByTittle(): element located by {Name} could not be located within {ConfigurationHelper.Get<int>("ChromeWaitConfig")} seconds.");
            return "false"; 
        }
        public string SearchByTittle(string Xpath, string Name)
        {
            new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.ElementToBeClickable(By.XPath(Xpath)));
            new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.ElementToBeClickable(By.XPath(Xpath)));
            var count = _driver.FindElements(By.XPath(Xpath)).Count;
            Xpath = "(" + Xpath;
            for (int i = 1; i < count; i++)
            {
                Xpath = Xpath + ")[" + i + "]";
                new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.ElementToBeClickable(By.XPath(Xpath)));
                webElement = _driver.FindElement(By.XPath(Xpath));
                var a = webElement.GetAttribute("title");
                if (webElement.Text == Name)
                {
                    return Xpath;
                }
                Xpath = Xpath.Replace(")[" + i + "]", "");
            }
            Assert.Fail($"Exception occurred in SeleniumHelper.SearchByTittle(): element located by {Name} could not be located within {ConfigurationHelper.Get<int>("ChromeWaitConfig")} seconds.");
            return "false";
        }
        public void MoveToElement(By by)
        {
            try
            {
                new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.ElementToBeClickable(by));
                //act = new Actions(_driver);
                webElement = _driver.FindElement(by);
                //webElement.Click();
                new Actions(_driver).MoveToElement(webElement).Perform();
            }
            catch (StaleElementReferenceException)
            {
                Thread.Sleep(2000);
                new WebDriverWait(_driver, TimeSpan.FromSeconds(ConfigurationHelper.Get<int>("ChromeWaitConfig"))).Until(ExpectedConditions.ElementToBeClickable(by));
                webElement2 = _driver.FindElement(by);
                //webElement.Click();
                new Actions(_driver).MoveToElement(webElement2).Perform();
            }
            catch (Exception ex) when (ex is WebDriverTimeoutException || ex is NoSuchElementException)
            {
                Assert.Fail($"Exception occurred in SeleniumHelper.Click(): element located by {by.ToString()} could not be located within {ConfigurationHelper.Get<int>("ChromeWaitConfig")} seconds.");
            }
        }
        public void ScrollTo(int xPosition = 0, int yPosition = 0)
        {
            var js = String.Format("window.scrollTo({0}, {1})", xPosition, yPosition);
            IJavaScriptExecutor ex = (IJavaScriptExecutor)_driver;
            ex.ExecuteScript(js);
        }

        //public IWebElement ScrollToView(string Xpath)
        //{
         //   webElement = _driver.FindElement(By.XPath(Xpath));
         //   ScrollToView(element);
         //   return element;
       // }

        public void ScrollToView(string Xpath)
        {
            webElement = _driver.FindElement(By.XPath(Xpath));
            if (webElement.Location.Y > 200)
            {
                ScrollTo(0, webElement.Location.Y - 100); // Make sure element is in the view but below the top navigation pane
            }

        }
    }
}
