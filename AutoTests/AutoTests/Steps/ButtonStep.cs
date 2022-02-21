using AutoTests.Globals;
using AutoTests.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AutoTests.Steps
{
    [Binding]
    class ButtonStep
    {
        private TemplatesPage _templatesPage;
        private ButtonPage _buttonPage;
        public ButtonStep(IWebDriver driver)
        {
            _templatesPage = new TemplatesPage(driver);
            _buttonPage = new ButtonPage(driver);
        }
        [Given(@"I select Button Area")]
        public void GivenISelectButtonArea()
        {
            _templatesPage.NavigateIntoButton();
        }
        [When(@"I Create Button")]
        public void WhenICreateButton()
        {
            var button = new Button
            {
                Name = Constants.Button1
            };
            _buttonPage.CreateButton(button.Name);
        }
        [Then(@"I should see Button in Template")]
        public void ThenIShouldSeeButtonInTemplate()
        {
            //TODO:Search ScenarioContext.Current.Pending();
        }

    }
}
