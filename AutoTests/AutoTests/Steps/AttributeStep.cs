using AutoTests.Pages;
using AutoTests.SeleniumHelpers;
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
    class AttributeFeatureSteps
    {
        private AttributePage _pageAttribute;

        public AttributeFeatureSteps(IWebDriver driver)
        {
            _pageAttribute = new AttributePage(driver);
        }
        [When(@"I create attribute")]
        public void ThenICreateAttribute()
        {
            SeleniumHelper.waitUntilElementInvisibile(_pageAttribute.Loader, 5000);
            SeleniumHelper.waitUntilElementVisibile(_pageAttribute.Add , 2000);
            _pageAttribute.Add.Click();
            _pageAttribute.Name.SendKeys("Name");
            _pageAttribute.Alias.SendKeys("Alias");
            _pageAttribute.Save.Click();
        }
        [Then(@"I should see Name(.*) attribute in list attributes")]
        public void ThenIShouldSeeNameAttributeInListAttributes(string nameAttribute)
        {
            SeleniumHelper.HasElementInList(_pageAttribute.Attributes, nameAttribute);
        }

    }
}
