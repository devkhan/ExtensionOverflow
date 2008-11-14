﻿using System;
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
    /// Test System.String extension methods.
    /// </summary>
    [TestClass]
    public class StringExtensionTests
    {
        /// <summary>
        /// Provide information about current testing context.
        /// Required by MSTests.
        /// </summary>
        public TestContext TestContext { get; set; }

		#region FormatWith

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
		public void FormatWithStringOneNullArgument()
		{
			string s = "{0} ought to be enough for everybody.";
			string param0 = null;

			string expected = " ought to be enough for everybody.";

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
		public void FormatWithStringTwoNullArguments()
		{
			string s = "{0} ought to be enough for {1}.";
			string param0 = null;
			string param1 = null;

			string expected = " ought to be enough for .";

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
		public void FormatWithStringThreeNullArguments()
		{
			string s = "{0} ought to be {1} for {2}.";
			string param0 = null;
			string param1 = null;
			string param2 = null;

			string expected = " ought to be  for .";

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
		public void FormatWithStringMultipleNullArguments()
		{
			string s = "{0} {1} to be {2} for {3}.";
			string param0 = null;
			string param1 = null;
			string param2 = null;
			string param3 = null;

			string expected = "  to be  for .";

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

			Assert.AreEqual(expected, s.FormatWith(Thread.CurrentThread.CurrentCulture, param0, param1),
                "2-arguments string.FormatWith does not obey the current thread culture.");

            // restore culture
            Thread.CurrentThread.CurrentCulture = currentCulture;
        }

		#endregion

        #region XmlSerialize / XmlDeserialize

        [TestMethod]
		public void XmlSerializeString()
		{
			DummyClass dummy = new DummyClass();
			dummy.Name = "xyz";

			string actual = dummy.XmlSerialize<DummyClass>();
			string expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><DummyClass xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"><Name>xyz</Name></DummyClass>";
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void XmlDeserializeString()
		{
			string teststring = "<?xml version=\"1.0\" encoding=\"utf-8\"?><DummyClass xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"><Name>xyz</Name></DummyClass>";
			DummyClass sut = teststring.XmlDeserialize<DummyClass>();
			Assert.AreEqual("xyz", sut.Name);
		}

        [TestMethod]
        public void XmlDeserializeShouldNotThrowException()
        {
            var invalidXml =
                "<?xml version=\"1.0\" encoding=\"utf-8\"?><DummyClass><invalid></markup></DummyClass>";

            // no exception should be thrown
            object result = invalidXml.XmlDeserialize<DummyClass>();

            Assert.IsNull(result);
        }

		#endregion
	}
}
