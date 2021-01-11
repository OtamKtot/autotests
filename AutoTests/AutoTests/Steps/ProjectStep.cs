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
    class ProjectStep
    {
        private readonly Project _pageProject;
        private readonly MyTasks _pageMyTasks;
        private readonly string code = "11";
        public ProjectStep(IWebDriver driver)
        {
            _pageProject = new Project(driver, code);
            _pageMyTasks = new MyTasks(driver);
        }
        [When(@"I open taskform on Project")]
        public void WhenIOpenTaskformOnProject()
        {
            _pageMyTasks.GoToMyProjectList();
            _pageProject.CompleteTask();
            Thread.Sleep(2000);
        }
        [Then(@"I should see that taskform on Project is opened")]
        public void ThenIShouldSeeThatTaskformOnProjectIsOpened()
        {
            _pageMyTasks.Logo.Displayed.Should().BeTrue();
        }
    }
}
