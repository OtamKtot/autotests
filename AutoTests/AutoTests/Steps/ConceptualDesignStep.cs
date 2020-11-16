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
    class ConceptualDesignStep
    {
        private readonly ConceptualDesign _pageConceptualDesign;
        private readonly MyTasks _pageMyTasks;
        private readonly string code = "11";
        public ConceptualDesignStep(IWebDriver driver)
        {
            _pageConceptualDesign = new ConceptualDesign(driver, code);
            _pageMyTasks = new MyTasks(driver);
        }
        [When(@"I edit ConceptualDesign")]
        public void WhenIEditConceptualDesign()
        {
            _pageConceptualDesign.EditTask();
            Thread.Sleep(2000);
        }
        [Then(@"I should see that ConceptualDesign is edit")]
        public void ThenIShouldSeeThatConceptualDesignIsEdit()
        {
            _pageMyTasks.Logo.Displayed.Should().BeTrue();
        }
        [When(@"I create version of ConceptualDesign")]
        public void WhenICreateVersionOfConceptualDesign()
        {
            _pageConceptualDesign.CreateVersionTask();
        }
        [Then(@"I should see that version of ConceptualDesign is create")]
        public void ThenIShouldSeeThatVersionOfConceptualDesignIsCreate()
        {
            _pageMyTasks.Logo.Displayed.Should().BeTrue();
        }
        [When(@"I complete ConceptualDesign")]
        public void WhenICompleteConceptualDesign()
        {
            _pageConceptualDesign.CompleteTask();
        }
        [Then(@"I should see that ConceptualDesign is complete")]
        public void ThenIShouldSeeThatConceptualDesignIsComplete()
        {
            _pageMyTasks.Logo.Displayed.Should().BeTrue();
        }
    }
}
