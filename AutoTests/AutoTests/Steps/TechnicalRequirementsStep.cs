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
    class TechnicalRequirementsStep
    {
        private readonly TechnicalRequirements _pageTechnicalRequirements;
        private readonly MyTasks _pageMyTasks;
        public TechnicalRequirementsStep(IWebDriver driver)
        {
            _pageTechnicalRequirements = new TechnicalRequirements(driver);
            _pageMyTasks = new MyTasks(driver);
        }
        [When(@"I complete TechnicalRequirements")]
        public void WhenICompleteTechnicalRequirements()
        {
            _pageMyTasks.RefreshMyList();
            _pageTechnicalRequirements.CompleteTask();
            Thread.Sleep(2000);
        }
        [Then(@"I should see that TechnicalRequirements is completed")]
        public void ThenIShouldSeeThatTechnicalRequirementsIsCompleted()
        {
            _pageMyTasks.Logo.Displayed.Should().BeTrue();
        }

    }
}
