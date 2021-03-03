using AutoTests.Pages;
using AutoTests.SeleniumHelpers;
using FluentAssertions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AutoTests.Steps
{
    class FormStep
    {
        private readonly FormPage _pageForm;
        private readonly MyTasks _pageMyTasks;
        private readonly SeleniumHelperWithExpectedConditions selenium;
        public FormStep(IWebDriver _driver)
        {
            _pageForm = new FormPage(_driver);
            selenium = new SeleniumHelperWithExpectedConditions(_driver);
            _pageMyTasks = new MyTasks(_driver);
        }
        [Then(@"I should see Name(.*) attribute in Form")]
        public void ThenIShouldSeeNameAttributeInForm(int p0)
        {
            _pageMyTasks.Logo.Displayed.Should().BeTrue();
        }
        [When(@"I drag and drop Attribute into Form")]
        public void WhenIDragAndDropAttributeIntoForm()
        {
            _pageForm.DragAndDropFirstAttribute();
        }

    }
}
