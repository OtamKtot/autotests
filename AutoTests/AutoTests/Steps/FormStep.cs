using AutoTests.Globals;
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
        private string name = "Text";
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
           // _pageForm.NavigateIntoFirstForm();
            _pageForm.DragAndDropFirstAttribute();
        }
        [When(@"I drag and drop (.*) Attribute (.*) into Form")]
        public void WhenIDragAndDropNameAttributeNameIntoForm(string Name, string Alias)
        {
            _pageForm.DragAndDropAttribute(Name, Alias);
        }
        [Given(@"I create all type attributes")]
        public void GivenICreateAllTypeAttributes()
        {
            _pageForm.HoverOverAttributes();
            _pageForm.CreateAttribute(name);
        }
        [When(@"I drag and drop Attributes into Form")]
        public void WhenIDragAndDropAttributesIntoForm()
        {
            _pageForm.DragAndDropAttribute(Constants.TextAttribute1, "");
            _pageForm.DragAndDropAttribute(Constants.DateAndTimeAttribute1, "");
            //_pageForm.DragAndDropAttribute(Constants.UserAttribute1, "");
            _pageForm.DragAndDropAttribute(Constants.NumberAttribute1, "");
            _pageForm.DragAndDropAttribute(Constants.DurationAttribute1, "");
            _pageForm.DragAndDropAttribute(Constants.DocumentAttribute1, "");
            _pageForm.DragAndDropAttribute(Constants.LogicAttribute1, "");
            _pageForm.DragAndDropAttribute(Constants.ImageAttribute1, "");
            _pageForm.DragAndDropAttribute(Constants.URIAttribute1, "");
            _pageForm.DragAndDropAttribute(Constants.CollectionAttribute1, "");
        }
        [When(@"I save form")]
        public void SaveButton()
        {
            _pageForm.SaveButton();
        }
        [Then(@"I should see attributes in Form")]
        public void ThenIShouldSeeAttributesInForm()
        {
            _pageMyTasks.Logo.Displayed.Should().BeTrue();
        }

    }
}
