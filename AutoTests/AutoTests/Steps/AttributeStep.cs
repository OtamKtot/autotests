using AutoTests.Globals;
using AutoTests.Pages;
using AutoTests.SeleniumHelpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace AutoTests.Steps
{
    [Binding]
    class AttributeFeatureSteps
    {
        private AttributePage _pageAttribute;

        public AttributeFeatureSteps(IWebDriver driver)
        {
            _pageAttribute = new AttributePage(driver);
        }
        [When(@"I create attribute")]
        public void ThenICreateAttribute(Table table)
        {
            var attribute = table.CreateInstance<Attribute>();
            _pageAttribute.CreateAttribute(attribute.Name, attribute.Alias);
        }
        [Then(@"I should see Text attribute in list attributes")]
        public void ThenIShouldSeeNameAttributeInListAttributes()
        {
            SeleniumHelper.HasElementInList(_pageAttribute.Attributes, Constants.TextAttribute1);
        }
        [When(@"I create attribute Image type")]
        public void WhenICreateAttributeImageType()
        {
            var attribute = new Attribute
            {
                Name = Constants.ImageAttribute1
            };
            _pageAttribute.CreateImageAttribute(attribute.Name);
        }
        [When(@"I create attribute Document type")]
        public void WhenICreateAttributeDocumentType()
        {
            var attribure = new Attribute
            {
                Name = Constants.DocumentAttribute1
            };
            _pageAttribute.CreateDocumentAttribute(attribure.Name);
        }
        [When(@"I create attribute User type")]
        public void WhenICreateAttributeUserType()
        {
            var attribute = new Attribute
            {
                Name = Constants.UserAttribute1
            };
            _pageAttribute.CreateUserAttribute(attribute.Name);
        }
        [When(@"I create attribute Duration type")]
        public void WhenICreateAttributeDurationType()
        {
            var attrbute = new Attribute
            {
                Name = Constants.DurationAttribute1
            };
            _pageAttribute.CreateDurationAttribute(attrbute.Name);
        }
        [When(@"I create attribute Logic type")]
        public void WhenICreateAttributeLogicType()
        {
            var attribute = new Attribute
            {
                Name = Constants.LogicAttribute1
            };
            _pageAttribute.CreateLogicAttribute(attribute.Name);
        }
        [When(@"I create attribute Text type")]
    public void WhenICreateAttributeTextType()
        {
            var attribute = new Attribute
            {
                Name = Constants.TextAttribute1
            };
            _pageAttribute.CreateTextAttribute(attribute.Name);
        }
        [When(@"I create attribute Number type")]
        public void WhenICreateNumberAttribute()
        {
            var attribute = new Attribute
            {
                Name = Constants.NumberAttribute1
            };
            _pageAttribute.CreateNumberAttribute(attribute.Name);
        }
        [When(@"I create attribute Date and time type")]
        public void WhenICreateDateAndTimeAttribute()
        {
            var attribute = new Attribute
            {
                Name = Constants.DateAndTimeAttribute1
            };
            _pageAttribute.CreateDateAndTimeAttribute(attribute.Name);
        }
    }
}
