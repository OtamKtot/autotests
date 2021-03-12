using AutoTests.Pages;
using AutoTests.SeleniumHelpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace AutoTests.Steps
{
    [Binding]
    public class TemplateFeatureSteps
    {
        private TemplatesPage _pageTemplates;
        private Actions act;

        public TemplateFeatureSteps(IWebDriver driver)
        {
            _pageTemplates = new TemplatesPage(driver);
            act = new Actions(driver);
        }
        [Given(@"I add RecordTemplate")]
        public void GivenIAddRecordTemplate(Table table)
        {
            var template = table.CreateInstance<Template>();
            _pageTemplates.AddRecordTemplate(template.Name, template.Alias);
        }
        [Then(@"I should see (.*) RecordTemplate in list Templates")]
        public void ThenIShouldSeeRecordTemplateInListTemplates(string nameTemplate)
        {
            _pageTemplates.HasElementInList(nameTemplate);
        }
        [When(@"I navigate into (.*) RecordTemplate")]
        public void ThenINavigateIntoNameRecordTemplate(string nameTemplate)
        {
            SeleniumHelper.waitUntilElementInvisibile(_pageTemplates.Loader, 10000);
            foreach (var element in _pageTemplates.Templates)
            {
                if (element.Text == nameTemplate)
                {                   
                    act.DoubleClick(element).Perform();
                    break;
                }
            }
        }
        [Given(@"I navigate into (.*) RecordTemplate")]
        public void GivenINavigateIntoRecordTemplate(string nameTemplate)
        {
            //SeleniumHelper.waitUntilElementInvisibile(_pageTemplates.Loader, 10000);
            foreach (var element in _pageTemplates.Templates)
            {
                if (element.Text == nameTemplate)
                {
                    act.DoubleClick(element).Perform();
                    break;
                }
            }
        }
        [When(@"I navigate into Attribute")]
        public void ThenINavigateIntoAttribute()
        {
            _pageTemplates.AttributeText.Click();
            //ScenarioContext.Current.Pending();
        }
        [When(@"I navigate into Forms")]
        public void WhenINavigateIntoForms()
        {
            _pageTemplates.FormText.Click();
        }
        [Given(@"I navigate into Form")]
        public void GivenINavigateIntoForm()
        {
            _pageTemplates.NavigateIntoForm();
        }

    }
}
