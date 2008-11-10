using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtensionOverflow;

namespace ExtensionOverflow.Tests
{
	/// <summary>
	/// Summary description for StringExtensionTests
	/// </summary>
	[TestClass]
	public class StringExtensionTests
	{
		public StringExtensionTests()
		{
		}

		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		internal class Dummy
		{
			public Dummy()
			{

			}

			public string Name
			{
				get;
				set;
			}

			public override string ToString()
			{
				return Name;
			}
		}

		[TestMethod]
		public void FormatWithStringOneArgument()
		{
			string sut = "string with literal {0}";
			Assert.AreEqual("string with literal test", sut.FormatWith("test"));
		}

		[TestMethod]
		public void FormatWithCustomClassOneArgument()
		{
			Dummy dummy = new Dummy();
			dummy.Name = "Dummy";

			string sut = "string with literal {0}";
			Assert.AreEqual("string with literal Dummy", sut.FormatWith(dummy));
		}
	}
}
