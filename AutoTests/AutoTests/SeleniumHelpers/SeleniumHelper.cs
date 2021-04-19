using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoTests.SeleniumHelpers
{
    class SeleniumHelper
    {

        public static bool WaitForToBeNotVisibleAndPresent(IWebDriver _driver, string locator, int timeout = 10, int end = 10)
        {
            var errors = new StringBuilder();
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeout));

            try
            {
                //wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException), typeof(NoSuchElementException));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.XPath(locator)));
                
                return true;
            }
            catch (StaleElementReferenceException)
            {
               // if (end == 0) { return false; }
               // return WaitForToBeNotVisibleAndPresent(_driver, locator, timeout, end - 1);
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.StalenessOf(_driver.FindElement(By.XPath(locator))));
                return true;
            }
            catch (Exception ex)
            {
                errors.AppendLine(ex.Message);
                //Logger.Info($"[Element] Element located by [ {locator} ] is VISIBLE or present in DOM after { timeout } second(s) expectation.");
                //Logger.Debug(e.Message);
                return false;
            }
        }
        public static bool WaitForToBeDisplayed(IWebDriver _driver, string locator, int timeout = 10, int end = 10)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeout));
            var errors = new StringBuilder();
            try
            {
                //wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException), typeof(NoSuchElementException));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(locator)));

                return true;
            }
            catch (StaleElementReferenceException)
            {
                //if (end == 0) { return false; }
                //return WaitForToBeDisplayed(_driver, locator, timeout, end - 1);
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.StalenessOf(_driver.FindElement(By.XPath(locator))));
                return true;
            }
            catch (Exception ex)
            {
                errors.AppendLine(ex.Message);
                //Logger.Info($"[Element] Element located by [ {locator} ] is NOT displayed after {timeout} second(s) expectation.");
                //Logger.Debug(e.Message);
                return false;
            }
        }
        public static bool WaitForToBePresent(IWebDriver _driver, string locator, int timeout = 10, int end = 10)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeout));
            var errors = new StringBuilder();
            try
            {
                wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException), typeof(NoSuchElementException));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(locator)));

                return true;
            }
            catch (StaleElementReferenceException)
            {
                //if (end == 0) { return false; }
                //return WaitForToBePresent(_driver, locator, timeout, end - 1);
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.StalenessOf(_driver.FindElement(By.XPath(locator))));
                return true;
            }
            catch (Exception ex)
            {
                errors.AppendLine(ex.Message);
                //Logger.Info("[Element] Element located by [" + locator + "] is NOT present in DOM after " + timeout + " second(s) expectation.");
                //Logger.Debug(e.Message);
                return false;
            }
        }
        //ожидаем исчезновение элемента
        public static void waitUntilElementInvisibile(IWebElement webelement, double periodElementWait)
        {
            var errors = new StringBuilder();
            double counter = 0;
            try
            {
                while (webelement.Displayed && webelement.Enabled)
                {
                    int second = 300;
                    Thread.Sleep(second);
                    counter += second;


                    if (counter > periodElementWait)
                    {
                        //throw new Exception("Элемент не исчез спустя (sec): " + periodElementWait);
                        Assert.Fail("Элемент не исчез спустя (sec): " + periodElementWait);

                    }

                }
            }
            catch (AssertionException ex)
            {
                errors.AppendLine(ex.Message);
                //Thread.CurrentThread.Abort();
            }
        }
        public static void waitUntilElementVisibile(IWebElement webelement, double periodElementWait)
        {
            var errors = new StringBuilder();
            double counter = 0;
            try
            {
                while (!webelement.Displayed && !webelement.Enabled)
                {
                    int second = 300;
                    Thread.Sleep(second);
                    counter += second;


                    if (counter > periodElementWait)
                    {
                        //throw new Exception("Элемент не исчез спустя (sec): " + periodElementWait);
                        Assert.Fail("Элемент не появился спустя (sec): " + periodElementWait);

                    }

                }
            }
            catch (Exception ex)
            {
                errors.AppendLine(ex.Message);
                //Thread.CurrentThread.Abort();
            }
        }
        public static void HasElementInList(ReadOnlyCollection<IWebElement> webelements, string disabledName)
        {
            int count = 0;
            for (int i = 0; i < webelements.Count; i = i + 1)
            {
                if (webelements[i].Text == disabledName && webelements[i].Displayed)
                {
                    count = 1;
                    break;
                    
                }
            }
            if (count == 0)
            {
                Assert.That(true, Is.False);
            }
        }
    }
}
