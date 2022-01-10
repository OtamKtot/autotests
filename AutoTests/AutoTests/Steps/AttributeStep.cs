using AutoTests.Globals;
using AutoTests.Pages;
using AutoTests.SeleniumHelpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace AutoTests.Steps
{
    [Binding]
    class AttributeFeatureSteps
    {
        private AttributePage _pageAttribute;

        public AttributeFeatureSteps(IWebDriver driver)
        {
            _pageAttribute = new AttributePage(driver);
        }
        [When(@"I create attribute")]
        public void ThenICreateAttribute(Table table)
        {
            var attribute = table.CreateInstance<Attribute>();
            _pageAttribute.CreateAttribute(attribute.Name, attribute.Alias);
        }
        [When(@"I create attribute Text type")]
    public void WhenICreateAttributeTextType()
        {
            var attribute = new Attribute
            {
                Name = Constants.TextAttribute1
            };
            _pageAttribute.CreateTextAttribute(attribute.Name);
        }
        [When(@"I create attribute Logic type")]
        public void WhenICreateAttributeLogicType()
        {
            var attribute = new Attribute
            {
                Name = Constants.LogicAttribute1
            };
            _pageAttribute.CreateLogicAttribute(attribute.Name);
        }
        [When(@"I create attribute Date and time type")]
        public void WhenICreateDateAndTimeAttribute()
        {
            var attribute = new Attribute
            {
                Name = Constants.DateAndTimeAttribute1
            };
            _pageAttribute.CreateDateAndTimeAttribute(attribute.Name);
        }
        [When(@"I create attribute Duration type")]
        public void WhenICreateAttributeDurationType()
        {
            var attrbute = new Attribute
            {
                Name = Constants.DurationAttribute1
            };
            _pageAttribute.CreateDurationAttribute(attrbute.Name);
        }
        [When(@"I create attribute Number type")]
        public void WhenICreateNumberAttribute()
        {
            var attribute = new Attribute
            {
                Name = Constants.NumberAttribute1
            };
            _pageAttribute.CreateNumberAttribute(attribute.Name);
        }
        [When(@"I create attribute User type")]
        public void WhenICreateAttributeUserType()
        {
            var attribute = new Attribute
            {
                Name = Constants.UserAttribute1
            };
            _pageAttribute.CreateUserAttribute(attribute.Name);
        }
        [When(@"I create attribute Document type")]
        public void WhenICreateAttributeDocumentType()
        {
            var attribure = new Attribute
            {
                Name = Constants.DocumentAttribute1
            };
            _pageAttribute.CreateDocumentAttribute(attribure.Name);
        }
        [When(@"I create attribute Link type")]
        public void WhenICreateAttributeLinkType()
        {
            var attribute = new Attribute
            {
                Name = Constants.LinkAttribute1
            };
            _pageAttribute.CreateLinkAttribute(attribute.Name);
        }
        [When(@"I create attribute Collection type")]
        public void WhenICreateAttributeCollectionType()
        {
            var attribute = new Attribute
            {
                Name = Constants.CollectionAttribute1
            };
            _pageAttribute.CreateCollectionAttribute(attribute.Name);
        }
        [When(@"I create attribute URI type")]
        public void WhenICreateURIAttributeURIType()
        {
            var attribute = new Attribute
            {
                Name = Constants.URIAttribute1
            };
            _pageAttribute.CreateURIAttribute(attribute.Name);
        }
        [When(@"I create attribute Image type")]
        public void WhenICreateAttributeImageType()
        {
            var attribute = new Attribute
            {
                Name = Constants.ImageAttribute1
            };
            _pageAttribute.CreateImageAttribute(attribute.Name);
        }
        [Then(@"I should see All attributes in list attributes")]
        public void ThenIShouldSeeNameAttributeInListAttributes()
        {
            SeleniumHelper.HasElementInList(_pageAttribute.Attributes, Constants.TextAttribute1);
            SeleniumHelper.HasElementInList(_pageAttribute.Attributes, Constants.LogicAttribute1);
            SeleniumHelper.HasElementInList(_pageAttribute.Attributes, Constants.DateAndTimeAttribute1);
            SeleniumHelper.HasElementInList(_pageAttribute.Attributes, Constants.DurationAttribute1);
            SeleniumHelper.HasElementInList(_pageAttribute.Attributes, Constants.NumberAttribute1);
            SeleniumHelper.HasElementInList(_pageAttribute.Attributes, Constants.UserAttribute1);
            SeleniumHelper.HasElementInList(_pageAttribute.Attributes, Constants.DocumentAttribute1);
            SeleniumHelper.HasElementInList(_pageAttribute.Attributes, Constants.LinkAttribute1);
            //SeleniumHelper.HasElementInList(_pageAttribute.Attributes, Constants.CollectionAttribute1);
            SeleniumHelper.HasElementInList(_pageAttribute.Attributes, Constants.ImageAttribute1);
            SeleniumHelper.HasElementInList(_pageAttribute.Attributes, Constants.URIAttribute1);   
        }
        [When(@"I create attribute Text type for collection")]
        public void WhenICreateAttributeTextTypeColl()
        {
            var attribute = new Attribute
            {
                Name = Constants.TextAttribute2
            };
            _pageAttribute.CreateTextAttribute(attribute.Name);
        }
        [When(@"I create attribute Logic type for collection")]
        public void WhenICreateAttributeLogicTypeColl()
        {
            var attribute = new Attribute
            {
                Name = Constants.LogicAttribute2
            };
            _pageAttribute.CreateLogicAttribute(attribute.Name);
        }
        [When(@"I create attribute Date and time type for collection")]
        public void WhenICreateDateAndTimeAttributeColl()
        {
            var attribute = new Attribute
            {
                Name = Constants.DateAndTimeAttribute2
            };
            _pageAttribute.CreateDateAndTimeAttribute(attribute.Name);
        }
        [When(@"I create attribute Duration type for collection")]
        public void WhenICreateAttributeDurationTypeColl()
        {
            var attrbute = new Attribute
            {
                Name = Constants.DurationAttribute2
            };
            _pageAttribute.CreateDurationAttribute(attrbute.Name);
        }
        [When(@"I create attribute Number type for collection")]
        public void WhenICreateNumberAttributeColl()
        {
            var attribute = new Attribute
            {
                Name = Constants.NumberAttribute2
            };
            _pageAttribute.CreateNumberAttribute(attribute.Name);
        }
        [When(@"I create attribute User type for collection")]
        public void WhenICreateAttributeUserTypeColl()
        {
            var attribute = new Attribute
            {
                Name = Constants.UserAttribute2
            };
            _pageAttribute.CreateUserAttribute(attribute.Name);
        }
        [When(@"I create attribute Document type for collection")]
        public void WhenICreateAttributeDocumentTypeColl()
        {
            var attribure = new Attribute
            {
                Name = Constants.DocumentAttribute2
            };
            _pageAttribute.CreateDocumentAttribute(attribure.Name);
        }
        [When(@"I create attribute URI type for collection")]
        public void WhenICreateURIAttributeURITypeColl()
        {
            var attribute = new Attribute
            {
                Name = Constants.URIAttribute2
            };
            _pageAttribute.CreateURIAttribute(attribute.Name);
        }
        [When(@"I create attribute Image type for collection")]
        public void WhenICreateAttributeImageTypeColl()
        {
            var attribute = new Attribute
            {
                Name = Constants.ImageAttribute2
            };
            _pageAttribute.CreateImageAttribute(attribute.Name);
        }
        [Then(@"I should see All attributes in list attributes for collection")]
        public void ThenIShouldSeeNameAttributeInListAttributesColl()
        {
            SeleniumHelper.HasElementInList(_pageAttribute.Attributes, Constants.TextAttribute2);
            SeleniumHelper.HasElementInList(_pageAttribute.Attributes, Constants.LogicAttribute2);
            SeleniumHelper.HasElementInList(_pageAttribute.Attributes, Constants.DateAndTimeAttribute2);
            SeleniumHelper.HasElementInList(_pageAttribute.Attributes, Constants.DurationAttribute2);
            SeleniumHelper.HasElementInList(_pageAttribute.Attributes, Constants.NumberAttribute2);
            SeleniumHelper.HasElementInList(_pageAttribute.Attributes, Constants.UserAttribute2);
            SeleniumHelper.HasElementInList(_pageAttribute.Attributes, Constants.DocumentAttribute2);
            SeleniumHelper.HasElementInList(_pageAttribute.Attributes, Constants.ImageAttribute2);
            SeleniumHelper.HasElementInList(_pageAttribute.Attributes, Constants.URIAttribute2);
        }
    }
}
