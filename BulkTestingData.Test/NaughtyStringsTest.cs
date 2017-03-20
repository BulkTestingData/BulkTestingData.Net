using System;
using System.Linq;
using ApprovalTests;
using ApprovalTests.Reporters;
using ApprovalUtilities.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BulkTestingData.Test
{
    [TestClass]
    [UseReporter(typeof(DiffReporter), typeof(ClipboardReporter))]
    public class NaughtyStringsTest
    {
        [TestMethod]
        public void TestAll()
        {
            Approvals.VerifyAll("length", NaughtyStrings.AllExceptNull(), s => "{0} => {1}".FormatWith(s, s.Length));
        }

        [TestMethod]
        public void TestAllAndNull()
        {
            Approvals.VerifyAll("length", NaughtyStrings.All().Take(5), s => "{0} => {1}".FormatWith(s, String.IsNullOrEmpty(s)));
        }

    }
}
