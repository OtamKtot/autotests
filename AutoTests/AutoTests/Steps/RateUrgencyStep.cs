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
    class RateUrgencyStep
    {
        private readonly RateUrgency _pageRateUrgency;
        private readonly MyTasks _pageMyTasks;
        public RateUrgencyStep(IWebDriver driver)
        {
            _pageRateUrgency = new RateUrgency(driver);
            _pageMyTasks = new MyTasks(driver);
        }
        [When(@"I complete RateUrgency")]
        public void WhenICompleteRateUrgency()
        {
            _pageMyTasks.RefreshMyList();
            _pageRateUrgency.CompleteTask();
            Thread.Sleep(2000);
        }
        [Then(@"I should see that RateUrgency is completed")]
        public void ThenIShouldSeeThatRateUrgencyIsCompleted()
        {
            _pageMyTasks.Logo.Displayed.Should().BeTrue();
        }

    }
}
