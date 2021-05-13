﻿using AutoTests.Pages;
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
    class ProjectOnTicketStep
    {
        private readonly ProjectOnTicket _pageProjectOnTicket;
        private readonly MyTasks _pageMyTasks;
        public ProjectOnTicketStep(IWebDriver driver)
        {
            _pageProjectOnTicket = new ProjectOnTicket(driver);
            _pageMyTasks = new MyTasks(driver);
        }
        [When(@"I complete ProjectOnTicket")]
        public void WhenICompleteProjectOnTicket()
        {
            _pageProjectOnTicket.CompleteTask();
            Thread.Sleep(2000);
        }
        [Then(@"I should see that ProjectOnTicket is completed")]
        public void ThenIShouldSeeThatProjectOnTicketIsCompleted()
        {
            _pageMyTasks.Logo.Displayed.Should().BeTrue();
        }
        [Given(@"I open task and add record in collection")]
        public void GivenIOpenTaskAndAddRecordInCollection()
        {
            _pageMyTasks.RefreshMyList();
            _pageProjectOnTicket.OpenTask();
            _pageProjectOnTicket.AddRecordInCollection();
        }

    }
}
