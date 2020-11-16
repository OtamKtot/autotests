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
    class AcceptPhaseTPStep
    {
        private readonly AcceptPhaseTP _pageAcceptPhaseTP;
        private readonly MyTasks _pageMyTasks;
        public AcceptPhaseTPStep(IWebDriver driver)
        {
            _pageAcceptPhaseTP = new AcceptPhaseTP(driver);
            _pageMyTasks = new MyTasks(driver);
        }
        [When(@"I complete AcceptPhaseTP")]
        public void WhenICompleteAcceptPhaseTP()
        {
            _pageAcceptPhaseTP.CompleteTask();
        }
        [Then(@"I should see that AcceptPhaseTP is complete")]
        public void ThenIShouldSeeThatAcceptPhaseTPIsComplete()
        {
            _pageMyTasks.Logo.Displayed.Should().BeTrue();
        }
    }
}
