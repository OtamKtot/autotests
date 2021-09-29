using AutoTests.Pages;
using AutoTests.Utilies;
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
    class ServiceModeStep
    {
        private readonly ServiceMode _pageServiceMode;
        private readonly string baseUrl = ConfigurationHelper.Get<string>("TargetUrl");
        public ServiceModeStep(IWebDriver driver)
        {
            _pageServiceMode = new ServiceMode(driver);
        }
        [Given(@"go service mode")]
        public void GivenGoServiceMode()
        {
            _pageServiceMode.Navigate(baseUrl);
            _pageServiceMode.GoServiceMode();
        }
        [Then(@"I login in system")]
        public void ThenILoginInSystem()
        {
            _pageServiceMode.ILoginInSystem();
        }
    }
}
