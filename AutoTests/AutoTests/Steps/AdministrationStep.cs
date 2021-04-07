using AutoTests.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace AutoTests.Steps
{
    [Binding]
    public class AdministrationFeatureSteps
    {
        private AdministrationPage _pageAdministration;

        public AdministrationFeatureSteps(IWebDriver driver)
        {
            _pageAdministration = new AdministrationPage(driver);
        }
        [When(@"I select Template")]
        public void WhenISelectTemplate()
        {
            _pageAdministration.NavigateIntoTemplates();
        }
        [Given(@"I select Template")]
        public void GivenISelectTemplate()
        {
            _pageAdministration.NavigateIntoTemplates();
        }
        [Given(@"I select BusinessApp")]
        public void GivenISelectBusinessApp()
        {
            _pageAdministration.NavigateIntoBusinessApp();
        }
    }
}
