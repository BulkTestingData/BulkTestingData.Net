using System;
using ApprovalTests;
using ApprovalTests.Reporters;
using ApprovalUtilities.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BulkTestingData
{
    [TestClass]
    [UseReporter(typeof(DiffReporter))]
    public class NaughtyStringsTest
    {
        [TestMethod]
        public void TestAll()
        {
           Approvals.VerifyAll("length", NaughtyStrings.All12(), s => "{0} => {1}".FormatWith(s, s.Length));
        }
    }
}
