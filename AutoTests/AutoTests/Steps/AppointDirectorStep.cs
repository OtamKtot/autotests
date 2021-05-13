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
    class AppointDirectorStep
    {
        private readonly AppointDirector _pageAppointDirector;
        private readonly MyTasks _pageMyTasks;
        private readonly string code = "11";
        public AppointDirectorStep(IWebDriver driver)
        {
            _pageAppointDirector = new AppointDirector(driver, code);
            _pageMyTasks = new MyTasks(driver);
        }
        [When(@"I complete AppointDirector")]
        public void WhenICompleteAppointDirector()
        {           
            _pageAppointDirector.CompleteTask();
            Thread.Sleep(2000);
        }
        [Then(@"I should see that AppointDirector is completed")]
        public void ThenIShouldSeeThatAppointDirectorIsCompleted()
        {
            _pageMyTasks.Logo.Displayed.Should().BeTrue();
        }
        [Given(@"I open task and add Rukovoditel in collection")]
        public void GivenIOpenTaskAndAddRukovoditelInCollection()
        {
            Thread.Sleep(400000);
            _pageMyTasks.RefreshMyList();
            _pageAppointDirector.OpenTask();
            _pageAppointDirector.AddRukovoditelInCollection();
        }

    }
}
