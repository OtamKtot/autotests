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
        [When(@"I create attribute Text type")]
        public void WhenICreateAttributeTextType()
        {
            var attribute = new Attribute
            {
                Name = Constants.TextAttribute1
            };
            _pageAttribute.CreateTextAttribute(attribute.Name);
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
