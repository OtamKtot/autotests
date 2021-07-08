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
            _pageAttribute.CreateAttribute(attribute.Name,attribute.Alias);
        }
        [Then(@"I should see (.*) attribute in list attributes")]
        public void ThenIShouldSeeNameAttributeInListAttributes(string nameAttribute)
        {
            SeleniumHelper.HasElementInList(_pageAttribute.Attributes, nameAttribute);
        }
        [When(@"I create attribute Text type")]
        public void WhenICreateAttributeTextType()
        {
            var attribute = new Attribute
            {
                Name = Constants.BusinessApp
            };
            _pageAttribute.CreateTextAttribute(attribute.Name);
        }

    }
}
