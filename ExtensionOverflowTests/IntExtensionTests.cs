using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtensionOverflow;

namespace ExtensionOverflowTests
{
	/// <summary>
	/// Summary description for IntExtensionTests
	/// </summary>
	[TestClass]
	public class IntExtensionTests
	{
		public IntExtensionTests()
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

		#region Additional test attributes
		//
		// You can use the following additional attributes as you write your tests:
		//
		// Use ClassInitialize to run code before running the first test in the class
		// [ClassInitialize()]
		// public static void MyClassInitialize(TestContext testContext) { }
		//
		// Use ClassCleanup to run code after all tests in a class have run
		// [ClassCleanup()]
		// public static void MyClassCleanup() { }
		//
		// Use TestInitialize to run code before running each test 
		// [TestInitialize()]
		// public void MyTestInitialize() { }
		//
		// Use TestCleanup to run code after each test has run
		// [TestCleanup()]
		// public void MyTestCleanup() { }
		//
		#endregion

		[TestMethod]
		public void PercentageOfIntInt()
		{
			Assert.AreEqual(33.0M, 100.PercentageOf(33));
		}

		[TestMethod]
		public void PercentOfIntInt()
		{
			Assert.AreEqual(33.0M, 33.PercentOf(100));
		}

		[TestMethod]
		public void PercentageOfIntFloat()
		{
			Assert.AreEqual(33.0M, 100.PercentageOf((float)33.0F));
		}

		[TestMethod]
		public void PercentOfIntFloat()
		{
			Assert.AreEqual(33.0M, 33.PercentOf((float)100.0F));
		}

		[TestMethod]
		public void PercentageOfIntDouble()
		{
			Assert.AreEqual(33.0M, 100.PercentageOf((double)33.0F));
		}

		[TestMethod]
		public void PercentOfIntDouble()
		{
			Assert.AreEqual(33.0M, 33.PercentOf((double)100.0F));
		}

		[TestMethod]
		public void PercentageOfIntDecimal()
		{
			Assert.AreEqual(33.0M, 100.PercentageOf((decimal)33.0M));
		}

		[TestMethod]
		public void PercentOfIntDecimal()
		{
			Assert.AreEqual(33.0M, 33.PercentOf((decimal)100.0M));
		}

		[TestMethod]
		public void PercentageOfIntLong()
		{
			Assert.AreEqual(33.0M, 100.PercentageOf((long)33));
		}

		[TestMethod]
		public void PercentOfIntLong()
		{
			Assert.AreEqual(33.0M, 33.PercentOf((long)100));
		}
	}
}
