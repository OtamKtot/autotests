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
//            Assert.IsTrue(SeleniumHelper.wa)
            SeleniumHelper.waitUntilElementInvisibile(_pageTemplates.Loader, 10000);
            var template = table.CreateInstance<Template>();
            _pageTemplates.Add.Click();
            _pageTemplates.Name.SendKeys(template.Name);
            _pageTemplates.Alias.SendKeys(template.Alias);
            _pageTemplates.Solution.Click();
            SeleniumHelper.waitUntilElementVisibile(_pageTemplates.SolutionSystem, 2000);
            _pageTemplates.SolutionSystem.Click();
            _pageTemplates.Create.Click();
        }
        [Then(@"I should see RecordTemplate in list Templates")]
        public void ThenIShouldSeeRecordTemplateInListTemplates()
        {
            SeleniumHelper.HasElementInList(_pageTemplates.Templates, "Name");
            //ScenarioContext.Current.Pending();
        }
        [Then(@"I should see (.*) RecordTemplate in list Templates")]
        public void ThenIShouldSeeRecordTemplateInListTemplates(string nameTemplate)
        {
            SeleniumHelper.HasElementInList(_pageTemplates.Templates, nameTemplate);
            //ScenarioContext.Current.Pending();
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

    }
}
