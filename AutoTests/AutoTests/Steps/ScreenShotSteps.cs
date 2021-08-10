using AutoTests.SeleniumHelpers;
using Microsoft.Test.VisualVerification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AutoTests.Steps
{
    [Binding]
    class ScreenShotSteps
    {
        [Given(@"two ScreenShot")]
        public void GivenTwoScreenShot()
        {
            Snapshot a = Snapshot.FromFile(@"\\storage\Tmp\QA\Results\Add Text Attribute.png");
            Snapshot b = Snapshot.FromFile(@"\\storage\Tmp\QA\Results\Add Text Attribute.png");
            ScreenShotMaker.ScreenShotCompare(a,b);
        }
        [Then(@"Screenshot is Approve")]
        public void ThenScreenshotIsApprove()
        {
            //ScenarioContext.Current.Pending();
        }

    }
}
