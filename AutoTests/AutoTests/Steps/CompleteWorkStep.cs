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
    class CompleteWorkStep
    {
        private readonly CompleteWork _pageCompleteWork;
        private readonly MyTasks _pageMyTasks;
        private readonly string code = "11";
        public CompleteWorkStep(IWebDriver driver)
        {
            _pageCompleteWork = new CompleteWork(driver, code);
            _pageMyTasks = new MyTasks(driver);
        }
        [When(@"I complete all tasks of Work")]
        public void WhenICompleteAllTasksOfWork()
        {
            _pageCompleteWork.CompleteTaskOfBuisnessResearch();
            _pageMyTasks.GoToMyTasks();
            _pageCompleteWork.CompleteTaskOfDevelopScheme();
            _pageMyTasks.GoToMyTasks();
            _pageCompleteWork.CompleteTaskOfNewRecord();
            _pageMyTasks.GoToMyTasks();
            _pageCompleteWork.CompleteTaskOfNewRecord2();
            _pageMyTasks.GoToMyTasks();
            _pageCompleteWork.CompleteTaskOfNewRecord3();
            _pageMyTasks.GoToMyTasks();
            _pageCompleteWork.CompleteTaskDevelopTask();
            _pageMyTasks.GoToMyTasks();
            _pageCompleteWork.CompleteTaskOfDevelopTicket();
            _pageMyTasks.GoToMyTasks();
        }
        [Then(@"I should see that all tasks of Work is completed")]
        public void ThenIShouldSeeThatAllTasksOfWorkIsCompleted()
        {
            _pageMyTasks.Logo.Displayed.Should().BeTrue();
        }
    }
}
