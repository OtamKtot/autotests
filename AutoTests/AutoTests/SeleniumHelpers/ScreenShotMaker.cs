using Microsoft.Test.VisualVerification;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTests.SeleniumHelpers
{
    class ScreenShotMaker
    {
        public static string ScreenShotCompare(Snapshot actual, Snapshot expected)
        {
            // 1. Capture the actual pixels from a given window
            Snapshot actual1 = Snapshot.FromFile(@"\\storage\Tmp\QA\Results\I open taskform on Project.png");

            // 2. Load the reference/master data from a previously saved file
            Snapshot expected1 = Snapshot.FromFile(@"\\storage\Tmp\QA\Results\I open taskform on Project.png");

            // 3. Compare the actual image with the master image
            //    This operation creates a difference image. Any regions which are identical in 
            //    the actual and master images appear as black. Areas with significant 
            //    differences are shown in other colors.
            Snapshot difference = actual1.CompareTo(expected1);

            // 4. Configure the snapshot verifier - It expects a black image with zero tolerances
            SnapshotVerifier v = new SnapshotColorVerifier(Color.Black, new ColorDifference());

            // 5. Evaluate the difference image
            if (v.Verify(difference) == VerificationResult.Fail)
            {
                // Log failure, and save the diff file for investigation
                actual.ToFile(@"\\storage\Tmp\QA\Results\Actual.png", ImageFormat.Png);
                difference.ToFile(@"\\storage\Tmp\QA\Results\Difference.png", ImageFormat.Png);
                return "Fail";
            }
            return "Cool";
        }
    }
}


