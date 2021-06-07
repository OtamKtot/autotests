using AutoTests.Globals;
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
            _pageBusinessApp.SelectFromListSystemBusinessApp(nameBuisnessApp);
        }
        [When(@"I add BusinessApp")]
        public void WhenIAddBusinessApp()
        {
            var businessApp = new BusinessApp
            {
                Name = Constants.BusinessApp
            };
            _pageBusinessApp.AddBusinessApp(businessApp.Name);
        }
        [Then(@"I should see BusinessApp is created")]
        public void ThenIShouldSeeBusinessAppIsCreated()
        {
            _pageBusinessApp.AlertIsTrue();
        }
        [Given(@"I select Test BusinessApp")]
        public void GivenISelectTestBusinessApp()
        {
            var businessApp = new BusinessApp
            {
                Name = Constants.BusinessApp
            };
            _pageBusinessApp.NavigateIntoTestBusinessApp(businessApp.Name);
        }
    }
}
