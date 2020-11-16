﻿using AutoTests.Pages;
using AutoTests.SeleniumHelpers;
using AutoTests.Utilies;
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
    class LoginPageStep
    {
        private readonly LoginPage _pageLogin;
        private readonly MyTasks _pageMyTasks;
        private readonly string baseUrl = ConfigurationHelper.Get<string>("TargetUrl");
        public LoginPageStep(IWebDriver driver)
        {
            _pageLogin = new LoginPage(driver);
            _pageMyTasks = new MyTasks(driver);

        }
        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            _pageLogin.Navigate(baseUrl);
        }
        [When(@"I enter username and password")]
        public void WhenIEnterUsernameAndPassword(Table table)
        {
            var account = table.CreateInstance<Account>();
            _pageLogin.Login(account);
        }
        [When(@"I click login")]
        public void WhenIClickLogin()
        {
            _pageLogin.Submit.Click();
            SeleniumHelper.waitUntilElementInvisibile(_pageLogin.Loader, 5000);
        }
    }
}
