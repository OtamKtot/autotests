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
    [Binding]
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
        [Then(@"I should see (.*) attribute in Form")]
        public void ThenIShouldSeeAttributeInForm(string p0)
        {
            _pageMyTasks.Logo.Displayed.Should().BeTrue();
        }
        [When(@"I drag and drop Attribute into Form")]
        public void WhenIDragAndDropAttributeIntoForm()
        {
            string Name = "Name";
            string Alias = "NameAlias";
            var cssSelector = _pageForm.SearchByTittle(Name,Alias);
            _pageForm.DragAndDropAttribute(Name, Alias);
        }
        [When(@"I drag and drop '(.*)' Attribute '(.*)' into Form")]
        public void WhenIDragAndDropNameAttributeNameIntoForm(string Name, string Alias)
        {
            _pageForm.DragAndDropAttribute(Name, Alias);
        }

    }
}
