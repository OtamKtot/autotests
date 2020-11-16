using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Reflection;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
//using AventStack.ExtentReports;
//using AventStack.ExtentReports.Reporter;
//using AventStack.ExtentReports.Gherkin.Model;
using System;
using System.Text;
using OpenQA.Selenium.Support.Extensions;
using System.IO;
using AutoTests.SeleniumHelpers;
using AutoTests.Utilies;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Gherkin.Model;
using NUnit.Framework;

namespace AutoTests.Hooks
{
    //[TestFixture(typeof(FirefoxDriver))]
    //[TestFixture(typeof(ChromeDriver))]
    [Binding]
    public class Hooks
    {
        //Global Variable for Extend report
        //private static ExtentTest featureName;
        //private static ExtentTest scenario;
        //private static ExtentReports extent;
        private static ExtentKlovReporter klov;
        [ThreadStatic] private static ExtentTest featureName;
        [ThreadStatic] private static ExtentTest scenario;
        private static ExtentReports extent;
        public static string ReportPath;
        public static string iWorkDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        public static string BuildNumber = ConfigurationHelper.Get<string>("BuildNumber");
        public static string DriverToUse = ConfigurationHelper.Get<string>("DriverToUse");

        private readonly IObjectContainer _objectContainer;
        private readonly FeatureContext featureContext;
        private readonly ScenarioContext scenarioContext;
        //private RemoteWebDriver _driver;

        private IWebDriver _driver;
        private StringBuilder _verificationErrors;
        private string _baseUrl;
        private static DriverFactory _driverFactory;

        public Hooks(IObjectContainer objectContainer, FeatureContext featureContext, ScenarioContext scenarioContext)
        {
            this._objectContainer = objectContainer;
            this.featureContext = featureContext;
            this.scenarioContext = scenarioContext;
        }

        [BeforeTestRun]
        public static void InitializeReport()
        {
            _driverFactory = new DriverFactory();
            Directory.CreateDirectory(Path.Combine("..", "..", "TestResults"));
            string path1 = @"\\storage\Tmp\QA\Results";
            string path = path1 + "Report\\index.html";
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(path);
            htmlReporter.Config.DocumentTitle = BuildNumber+" "+ DriverToUse;
            htmlReporter.Config.ReportName = "BuildNumber:" +BuildNumber + " Browser:" + DriverToUse;
            //htmlReporter.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
            extent = new ExtentReports();
            extent.AddSystemInfo("Browser", "Chrome");
            extent.AttachReporter(htmlReporter);
        }
        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            featureName = extent.CreateTest<Feature>(featureContext.FeatureInfo.Title);
            Console.WriteLine("BeforeFeature");
        }
        [BeforeScenario]
        public void Initialize(ScenarioContext scenarioContext)
        {
            _driver = _driverFactory.Create();
            _objectContainer.RegisterInstanceAs(_driver);
            _baseUrl = ConfigurationHelper.Get<string>("TargetUrl");
            _verificationErrors = new StringBuilder();
            Console.WriteLine("BeforeScenario");
            scenario = featureName.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
        }

        [AfterStep]
        public void InsertReportingSteps(ScenarioContext scenarioContext)
        {
            var stepType = scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
            if (scenarioContext.TestError == null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(scenarioContext.StepContext.StepInfo.Text);
            }
            else if (scenarioContext.TestError != null)
            {
                if (stepType == "Given")
                {
                    scenario.CreateNode<Given>(scenarioContext.StepContext.StepInfo.Text).Fail(scenarioContext.TestError.Message);

                }
                else if (stepType == "When")
                {
                    scenario.CreateNode<When>(scenarioContext.StepContext.StepInfo.Text).Fail(scenarioContext.TestError.Message);
                    //string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", ""), $"{scenarioContext.ScenarioInfo.Title}.png");
                    string path = Path.Combine(@"\\storage\Tmp\QA\Results", $"{scenarioContext.ScenarioInfo.Title}.png");
                    _driver.TakeScreenshot().SaveAsFile(Path.Combine(@"\\storage\Tmp\QA\Results", $"{scenarioContext.ScenarioInfo.Title}.png"), ScreenshotImageFormat.Png);
                    scenario.AddScreenCaptureFromPath(path);

                }
                else if (stepType == "Then")
                {
                    scenario.CreateNode<Then>(scenarioContext.StepContext.StepInfo.Text).Fail(scenarioContext.TestError.Message);
                    string path = Path.Combine(@"\\storage\Tmp\QA\Results", $"{scenarioContext.ScenarioInfo.Title}.png");
                    _driver.TakeScreenshot().SaveAsFile(Path.Combine(@"\\storage\Tmp\QA\Results", $"{scenarioContext.ScenarioInfo.Title}.png"), ScreenshotImageFormat.Png);
                    scenario.AddScreenCaptureFromPath(path);

                }
                else if (stepType == "And")
                {
                    scenario.CreateNode<And>(scenarioContext.StepContext.StepInfo.Text).Fail(scenarioContext.TestError.Message);

                }
            }
        }

        [AfterScenario]
        public void AfterScenario(ScenarioContext scenarioContext)
        {
            Console.WriteLine("AfterScenario");
            if (scenarioContext.TestError != null)
            {
                _driver.TakeScreenshot().SaveAsFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", ""), $"{scenarioContext.ScenarioInfo.Title}.png"), ScreenshotImageFormat.Png);
            }
            _driver?.Dispose();
            _driver?.Quit();
        }
        [AfterTestRun]
        public static void AfterTestRun()
        {
            extent.Flush();
        }
    }
}