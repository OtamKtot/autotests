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
        [Then(@"I should see that ConceptualDesign is edited")]
        public void ThenIShouldSeeThatConceptualDesignIsEdited()
        {
            _pageMyTasks.Logo.Displayed.Should().BeTrue();
        }
        [When(@"I create version of ConceptualDesign")]
        public void WhenICreateVersionOfConceptualDesign()
        {
            _pageConceptualDesign.OpenTask();
            _pageConceptualDesign.CreateVersionTask();
        }
        [Then(@"I should see that version of ConceptualDesign is created")]
        public void ThenIShouldSeeThatVersionOfConceptualDesignIsCreated()
        {
            _pageMyTasks.Logo.Displayed.Should().BeTrue();
        }
        [When(@"I complete ConceptualDesign")]
        public void WhenICompleteConceptualDesign()
        {
            _pageConceptualDesign.CompleteTask();
        }
        [Then(@"I should see that ConceptualDesign is completed")]
        public void ThenIShouldSeeThatConceptualDesignIsCompleted()
        {
            _pageMyTasks.Logo.Displayed.Should().BeTrue();
        }
        [Given(@"I open task and add edit four record in collection")]
        public void GivenIOpenTaskAndAddEditFourRecordInCollection()
        {
            _pageConceptualDesign.OpenTask();
            _pageConceptualDesign.EditFourCollectionRecord();
        }
        [Given(@"I add three childs for three variants")]
        public void GivenIAddThreeChildsForThreeVariants()
        {
            _pageConceptualDesign.CreateThreeVariantsChilds();
        }
        [When(@"I planned Work in ConceptualDesign")]
        public void WhenIPlannedWorkInConceptualDesign()
        {
            _pageConceptualDesign.PlannedTask();
        }

    }
}
