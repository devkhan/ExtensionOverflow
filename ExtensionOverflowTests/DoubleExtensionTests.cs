using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtensionOverflow;

namespace ExtensionOverflowTests
{
	/// <summary>
	/// Summary description for DoubleExtensionTests
	/// </summary>
	[TestClass]
	public class DoubleExtensionTests
	{
		public DoubleExtensionTests()
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
		public void PercentageOfDoubleInt()
		{
			Assert.AreEqual(33.0M, ((double)100.0F).PercentageOf((int)33));
		}

		[TestMethod]
		public void PercentOfDoubleInt()
		{
			Assert.AreEqual(33.0M, ((double)33.0F).PercentOf((int)100));
		}

		[TestMethod]
		public void PercentageOfDoubleFloat()
		{
			Assert.AreEqual(33.0M, ((double)100.0F).PercentageOf((float)33.0F));
		}

		[TestMethod]
		public void PercentOfDoubleFloat()
		{
			Assert.AreEqual(33.0M, ((double)33.0F).PercentOf((float)100.0F));
		}

		[TestMethod]
		public void PercentageOfDoubleDouble()
		{
			Assert.AreEqual(33.0M, ((double)100.0F).PercentageOf((double)33.0F));
		}

		[TestMethod]
		public void PercentOfDoubleDouble()
		{
			Assert.AreEqual(33.0M, ((double)33.0F).PercentOf((double)100.0F));
		}

		[TestMethod]
		public void PercentageOfDoubleLong()
		{
			Assert.AreEqual(33.0M, ((double)100.0F).PercentageOf((long)33));
		}

		[TestMethod]
		public void PercentOfDoubleLong()
		{
			Assert.AreEqual(33.0M, ((double)33.0F).PercentOf((long)100));
		}
	}
}
