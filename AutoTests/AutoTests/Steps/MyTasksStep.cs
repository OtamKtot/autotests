using AutoTests.Pages;
using AutoTests.SeleniumHelpers;
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
    class MyTasksStep
    {
        private readonly MyTasks _pageMyTasks;
        private readonly SeleniumHelperWithExpectedConditions selenium;
        public MyTasksStep(IWebDriver _driver)
        {
            _pageMyTasks = new MyTasks(_driver);
            selenium = new SeleniumHelperWithExpectedConditions(_driver);
        }
        [Then(@"I should see user logged in to the application")]
        public void ThenIShouldSeeUserLoggedInToTheApplication()
        {
            _pageMyTasks.Logo.Displayed.Should().BeTrue();
        }
        [When(@"I Create Ticket")]
        public void WhenICreateTicket()
        {
            _pageMyTasks.CreateTicket();
            Thread.Sleep(2000);
        }
        [Then(@"I should see that Ticket is created")]
        public void ThenIShouldSeeThatTicketIsCreated()
        {
            _pageMyTasks.Logo.Displayed.Should().BeTrue();
        }
        [Given(@"I click logout")]
        public void GivenIClickLogout()
        {
            _pageMyTasks.LogOut();
        }
        [Given(@"I navigate to global configuration")]
        public void GivenINavigateToGlobalConfiguration()
        {
            _pageMyTasks.GoToAdministration();
        }
    }
}
