using AutoTests.Pages;
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
    class TechnicalProjectStep
    {
        private readonly TechnicalProject _pageTechnicalProject;
        private readonly MyTasks _pageMyTasks;
        private readonly string code = "11";
        public TechnicalProjectStep(IWebDriver driver)
        {
            _pageTechnicalProject = new TechnicalProject(driver, code);
            _pageMyTasks = new MyTasks(driver);
        }
        [When(@"I complete TechnicalProject")]
        public void WhenICompleteTechnicalProject()
        {
            _pageTechnicalProject.CompleteTask();
        }
        [Then(@"I should see that TechnicalProject is completed")]
        public void ThenIShouldSeeThatTechnicalProjectIsCompleted()
        {
            _pageMyTasks.Logo.Displayed.Should().BeTrue();
        }
    }
}
