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
