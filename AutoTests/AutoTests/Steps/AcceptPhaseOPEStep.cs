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
    class AcceptPhaseOPEStep
    {
        private readonly AcceptPhaseOPE _pageAcceptPhaseOPE;
        private readonly MyTasks _pageMyTasks;
        public AcceptPhaseOPEStep(IWebDriver driver)
        {
            _pageAcceptPhaseOPE = new AcceptPhaseOPE(driver);
            _pageMyTasks = new MyTasks(driver);
        }
        [When(@"I complete AcceptPhaseOPE")]
        public void WhenICompleteAcceptPhaseOPE()
        {
            _pageAcceptPhaseOPE.CompleteTask();
        }
        [Then(@"I should see that AcceptPhaseOPE is complete")]
        public void ThenIShouldSeeThatAcceptPhaseOPEIsComplete()
        {
            _pageMyTasks.Logo.Displayed.Should().BeTrue();
        }
    }
}
