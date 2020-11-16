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
    class TurnProjectStep
    {
        private readonly TurnProject _pageTurnProject;
        private readonly MyTasks _pageMyTasks;
        public TurnProjectStep(IWebDriver driver)
        {
            _pageTurnProject = new TurnProject(driver);
            _pageMyTasks = new MyTasks(driver);
        }
        [When(@"I complete TurnProject")]
        public void WhenICompleteTurnProject()
        {
            _pageMyTasks.GoToMyTasks();
            _pageTurnProject.CompleteTask();
            Thread.Sleep(2000);
        }
        [Then(@"I should see that TurnProject is complete")]
        public void ThenIShouldSeeThatTurnProjectIsComplete()
        {
            _pageMyTasks.Logo.Displayed.Should().BeTrue();
        }
    }
}
