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
    class ProjectPreparationStep
    {
        private readonly ProjectPreparation _pageProjectPreparation;
        private readonly MyTasks _pageMyTasks;
        private readonly string code = "11";
        public ProjectPreparationStep(IWebDriver driver)
        {
            _pageProjectPreparation = new ProjectPreparation(driver, code);
            _pageMyTasks = new MyTasks(driver);
        }
        [When(@"I complete ProjectPreparation")]
        public void WhenICompleteProjectPreparation()
        {
            _pageProjectPreparation.CompleteTask();
            Thread.Sleep(5000);
        }
        [Then(@"I should see that ProjectPreparation is complete")]
        public void ThenIShouldSeeThatProjectPreparationIsComplete()
        {
            _pageMyTasks.Logo.Displayed.Should().BeTrue();
        }
        [When(@"I open task and add Ispolnitel in collection and create phase")]
        public void WhenIOpenTaskAndAddIspolnitelInCollectionAndCreatePhase()
        {
            _pageProjectPreparation.OpenTask();
            _pageProjectPreparation.AddIspolnitelInCollectionAndCreatePhase();
        }
        [When(@"I add document in collection")]
        public void WhenIAddDocumentInCollection()
        {
            _pageProjectPreparation.AddDocumentOnFormCollection();
        }

    }
}
