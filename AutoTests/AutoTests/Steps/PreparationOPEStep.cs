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
    class PreparationOPEStep
    {
        private readonly PreparationOPE _pagePreparationOPE;
        private readonly MyTasks _pageMyTasks;
        private readonly string code = "11";
        public PreparationOPEStep(IWebDriver driver)
        {
            _pagePreparationOPE = new PreparationOPE(driver, code);
            _pageMyTasks = new MyTasks(driver);
        }
        [Given(@"I complete PreparationOPE")]
        public void GivenICompletePreparationOPE()
        {
            _pagePreparationOPE.OpenTask();
            _pagePreparationOPE.DeleteRecordsOnCollection();
            _pagePreparationOPE.AddRecordOnCollection();
            _pagePreparationOPE.PlannedTask();
            _pagePreparationOPE.CompleteTask();
        }
        [Then(@"I should see that PreparationOPE is completed")]
        public void ThenIShouldSeeThatPreparationOPEIsCompleted()
        {
            _pageMyTasks.Logo.Displayed.Should().BeTrue();
        }
    }
}
