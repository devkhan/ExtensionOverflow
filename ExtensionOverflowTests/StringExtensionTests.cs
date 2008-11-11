using System;
using System.Threading;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtensionOverflow;
using System.Globalization;

namespace ExtensionOverflow.Tests
{
    /// <summary>
    /// Summary description for StringExtensionTests
    /// </summary>
    [TestClass]
    public class StringExtensionTests
    {
        /// <summary>
        /// Provide information about current testing context.
        /// Required by MSTests
        /// </summary>
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void FormatWithStringOneArgument()
        {
            string s = "{0} ought to be enough for everybody.";
            string param0 = "64K";

            string expected = "64K ought to be enough for everybody.";

            Assert.AreEqual(expected, s.FormatWith(param0),
                "1-argument string.FormatWith is not formatting string properly.");
        }

        [TestMethod]
        public void FormatWithStringTwoArguments()
        {
            string s = "{0} ought to be enough for {1}.";
            string param0 = "64K";
            string param1 = "everybody";

            string expected = "64K ought to be enough for everybody.";

            Assert.AreEqual(expected, s.FormatWith(param0, param1),
                "2-arguments string.FormatWith is not formatting string properly.");
        }

        [TestMethod]
        public void FormatWithStringThreeArguments()
        {
            string s = "{0} ought to be {1} for {2}.";
            string param0 = "64K";
            string param1 = "enough";
            string param2 = "everybody";

            string expected = "64K ought to be enough for everybody.";

            Assert.AreEqual(expected, s.FormatWith(param0, param1, param2),
                "3-arguments string.FormatWith is not formatting string properly.");
        }

        [TestMethod]
        public void FormatWithStringMultipleArguments()
        {
            string s = "{0} {1} to be {2} for {3}.";
            string param0 = "64K";
            string param1 = "ought";
            string param2 = "enough";
            string param3 = "everybody";

            string expected = "64K ought to be enough for everybody.";

            Assert.AreEqual(expected, s.FormatWith(param0, param1, param2, param3),
                "4-arguments string.FormatWith is not formatting string properly.");
        }

        [TestMethod]
        public void FormatWithStringObeyThreadCulture()
        {
            string s = "{0} is used as the decimal separator in French, as in {1:#,##0.00}";
            string param0 = "Comma";
            float param1 = 123.45F;

            var expected = "Comma is used as the decimal separator in French, as in 123,45";

            // save current culture for later restore and switch to fr-FR culture
            var currentCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");

            Assert.AreEqual(expected, s.FormatWith(param0, param1),
                "2-arguments string.FormatWith does not obey the current thread culture.");

            // restore culture
            Thread.CurrentThread.CurrentCulture = currentCulture;

        }
    }
}
