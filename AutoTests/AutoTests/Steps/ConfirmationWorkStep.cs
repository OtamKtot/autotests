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
    class ConfirmationWorkStep
    {
        private readonly ConfirmationWork _pageConfirmationWork;
        private readonly MyTasks _pageMyTasks;
        private readonly string code = "11";
        public ConfirmationWorkStep(IWebDriver driver)
        {
            _pageConfirmationWork = new ConfirmationWork(driver, code);
            _pageMyTasks = new MyTasks(driver);
        }
        [When(@"I confirmation all tasks of Work")]
        public void WhenIConfirmationAllTasksOfWork()
        {
            _pageConfirmationWork.CompleteTaskOfBuisnessResearch();
            _pageMyTasks.GoToMyTasks();
            _pageConfirmationWork.CompleteTaskOfDevelopScheme();
            _pageMyTasks.GoToMyTasks();
            _pageConfirmationWork.CompleteTaskOfNewRecord();
            _pageMyTasks.GoToMyTasks();
            _pageConfirmationWork.CompleteTaskOfNewRecord2();
            _pageMyTasks.GoToMyTasks();
            _pageConfirmationWork.CompleteTaskOfNewRecord3();
            _pageMyTasks.GoToMyTasks();
            _pageConfirmationWork.CompleteTaskDevelopTask();
            _pageMyTasks.GoToMyTasks();
            _pageConfirmationWork.CompleteTaskOfDevelopTicket();
            _pageMyTasks.GoToMyTasks();
        }
        [Then(@"I should see that all tasks of Work is confirmation")]
        public void ThenIShouldSeeThatAllTasksOfWorkIsConfirmation()
        {
            _pageMyTasks.Logo.Displayed.Should().BeTrue();
        }
    }
}
