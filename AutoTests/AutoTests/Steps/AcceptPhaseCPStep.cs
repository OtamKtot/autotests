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
    class AcceptPhaseCPStep
    {
        private readonly AcceptPhaseCP _pageAcceptPhaseCP;
        private readonly MyTasks _pageMyTasks;
        public AcceptPhaseCPStep(IWebDriver driver)
        {
            _pageAcceptPhaseCP = new AcceptPhaseCP(driver);
            _pageMyTasks = new MyTasks(driver);
        }
        [When(@"I complete AcceptPhaseCP")]
        public void WhenICompleteAcceptPhaseCP()
        {
            _pageAcceptPhaseCP.CompleteTask();
        }
        [Then(@"I should see that AcceptPhaseCP is complete")]
        public void ThenIShouldSeeThatAcceptPhaseCPIsComplete()
        {
            _pageMyTasks.Logo.Displayed.Should().BeTrue();
        }
    }
}
