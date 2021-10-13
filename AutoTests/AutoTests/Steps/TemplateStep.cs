using AutoTests.Globals;
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
        private FormPage _pageForms;
        private Actions act;

        public TemplateFeatureSteps(IWebDriver driver)
        {
            _pageTemplates = new TemplatesPage(driver);
            _pageForms = new FormPage(driver);
            act = new Actions(driver);
        }
        [Given(@"I navigate into template")]
        public void GivenINavigateIntoTemplate()
        {
            _pageTemplates.NavigateIntoTemplate();
        }

        [Given(@"I add RecordTemplate")]
        public void GivenIAddRecordTemplate(Table table)
        {
            var template = table.CreateInstance<Template>();
            _pageTemplates.AddRecordTemplate(template.Name, template.Alias);
            _pageTemplates.AlertIsTrue();
        }
        [Then(@"I should see (.*) RecordTemplate in list Templates")]
        public void ThenIShouldSeeRecordTemplateInListTemplates(string nameTemplate)
        {
            //TODO search in list
           // _pageTemplates.HasElementInList(nameTemplate);
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
        [Given(@"I select Test Record Template")]
        public void GivenISelectTemplate()
        {
            var RecordTemplate = new Template
            {
                Name = Constants.RecordTemplate1
            };
            _pageTemplates.NavigateIntoNameTemplate(RecordTemplate.Name);
        }

        [Given(@"I navigate into Attribute")]
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
            _pageForms.NavigateIntoFirstForm();
        }
        [Then(@"I should see RecordTemplate in list Templates")]
        public void ThenIShouldSeeRecordTemplateInListTemplates()
        {
            //TODO:Search
            //ScenarioContext.Current.Pending();
        }
        [Given(@"I add three RecordTemplate")]
        public void GivenIAddThreeRecordTemplate()
        {
            var Template1 = new Template
            {
                Name = Constants.RecordTemplate1
            };
            var Template2 = new Template
            {
                Name = Constants.RecordTemplate2
            };
            var Template3 = new Template
            {
                Name = Constants.RecordTemplate3
            };
            _pageTemplates.AddThreeRecordTemplate(Template1.Name, Template2.Name, Template3.Name);
        }
        [Given(@"I select Test Record Template3")]
        public void GivenISelectTestRecordTemplate3()
        {
            var RecordTemplate = new Template
            {
                Name = Constants.RecordTemplate3
            };
            _pageTemplates.NavigateIntoNameTemplate(RecordTemplate.Name);
        }
    }
}
