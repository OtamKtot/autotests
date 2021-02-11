using AutoTests.Pages;
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
        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            var account = table.CreateInstance<Account>();
            _pageLogin.Login(account);
        }
        [When(@"I click login")]
        public void WhenIClickLogin()
        {
            _pageLogin.Submit.Click();
            SeleniumHelper.waitUntilElementInvisibile(_pageLogin.Loader, 5000);
            //_pageMyTasks.DragAndDrop();
        }
        [Given(@"I navigate to application and login as Project")]
        public void GivenINavigateToApplicationAndLoginAsProject()
        {
            var account = new Account
            {
                Username = "Project",
                Password = "1"
            };
            _pageLogin.Navigate(baseUrl);
            _pageLogin.Login(account);
            _pageLogin.Submit.Click();
            SeleniumHelper.waitUntilElementInvisibile(_pageLogin.Loader, 5000);
        }
        [Given(@"I navigate to application and login as Director")]
        public void GivenINavigateToApplicationAndLoginAsDirector()
        {
            var account = new Account
            {
                Username = "Director",
                Password = "1"
            };
            _pageLogin.Navigate(baseUrl);
            _pageLogin.Login(account);
            _pageLogin.Submit.Click();
            SeleniumHelper.waitUntilElementInvisibile(_pageLogin.Loader, 5000);
        }
        [Given(@"I navigate to application and login as Rukovoditel")]
        public void GivenINavigateToApplicationAndLoginAsRukovoditel()
        {
            var account = new Account
            {
                Username = "Rukovoditel",
                Password = "1"
            };
            _pageLogin.Navigate(baseUrl);
            _pageLogin.Login(account);
            _pageLogin.Submit.Click();
            SeleniumHelper.waitUntilElementInvisibile(_pageLogin.Loader, 5000);
        }
        [Given(@"I navigate to application and login as Ispolnitel")]
        public void GivenINavigateToApplicationAndLoginAsIspolnitel()
        {
            var account = new Account
            {
                Username = "Ispolnitel",
                Password = "1"
            };
            _pageLogin.Navigate(baseUrl);
            _pageLogin.Login(account);
            _pageLogin.Submit.Click();
            SeleniumHelper.waitUntilElementInvisibile(_pageLogin.Loader, 5000);
        }
        [Given(@"I navigate to application and login as Admin")]
        public void GivenINavigateToApplicationAndLoginAsAdmin()
        {
            var account = new Account
            {
                Username = "Admin",
                Password = "admin123"
            };
            _pageLogin.Navigate(baseUrl);
            _pageLogin.Login(account);
            _pageLogin.Submit.Click();
            SeleniumHelper.waitUntilElementInvisibile(_pageLogin.Loader, 5000);

        }

    }
}
