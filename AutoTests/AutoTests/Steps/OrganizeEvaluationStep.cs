using AutoTests.Pages;
using FluentAssertions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AutoTests.Steps
{
    [Binding]
    class OrganizeEvaluationStep
    {
        private readonly OrganizeEvaluation _pageOrganizeEvaluation;
        private readonly MyTasks _pageMyTasks;
        public OrganizeEvaluationStep(IWebDriver driver)
        {
            _pageOrganizeEvaluation = new OrganizeEvaluation(driver);
            _pageMyTasks = new MyTasks(driver);
        }
        [When(@"I complete OrganizeEvaluation")]
        public void WhenICompleteOrganizeEvaluation()
        {
            _pageMyTasks.GoToMyTasks();
            _pageOrganizeEvaluation.CompleteTask();
            Thread.Sleep(2000);
        }
        [Then(@"I should see that OrganizeEvaluation is completed")]
        public void ThenIShouldSeeThatOrganizeEvaluationIsCompleted()
        {
            _pageMyTasks.Logo.Displayed.Should().BeTrue();
        }
    }
}
