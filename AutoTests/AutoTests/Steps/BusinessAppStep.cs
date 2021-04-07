using AutoTests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AutoTests.Steps
{
    [Binding]
    class BusinessAppStep
    {
        private BusinessAppPage _pageBusinessApp;
        private Actions act;

        public BusinessAppStep(IWebDriver driver)
        {
            _pageBusinessApp = new BusinessAppPage(driver);
            act = new Actions(driver);
        }
        [Given(@"I select system BusinessApp")]
        public void GivenISelectSystemBusinessApp()
        {
            var nameBuisnessApp = "systemSolution";
            foreach (var element in _pageBusinessApp.BuisnessApp)
            {
                if (element.Text == nameBuisnessApp)
                {
                    act.DoubleClick(element).Perform();
                    break;
                }
            }
        }

    }
}
