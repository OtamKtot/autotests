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
    class CreateWorkPlanStep
    {
        private readonly WorkPlan _pageWorkPlan;
        private readonly MyTasks _pageMyTasks;
        public CreateWorkPlanStep(IWebDriver driver)
        {
            _pageWorkPlan = new WorkPlan(driver);
            _pageMyTasks = new MyTasks(driver);
        }
        [When(@"I create WorkPlan")]
        public void WhenICreateWorkPlan()
        {
            _pageMyTasks.GoToMyWorkPlanList();
            _pageWorkPlan.CreateWorkPlan();
        }
        [Then(@"I should see that WorkPlank is created")]
        public void ThenIShouldSeeThatWorkPlankIsCreated()
        {
            _pageMyTasks.Logo.Displayed.Should().BeTrue();
        }
    }
}
