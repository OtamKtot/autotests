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
        public void ThenISelectTemplate()
        {
            _pageAdministration.TemplateText.Click();
            //ScenarioContext.Current.Pending();
        }
    }
}
