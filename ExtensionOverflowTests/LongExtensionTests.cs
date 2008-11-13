using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtensionOverflow;

namespace ExtensionOverflowTests
{
	/// <summary>
	/// Summary description for LongExtensionTests
	/// </summary>
	[TestClass]
	public class LongExtensionTests
	{
		public LongExtensionTests()
		{
			//
			// TODO: Add constructor logic here
			//
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
		public void PercentageOfLongInt()
		{
			Assert.AreEqual(33.0M, ((long)100).PercentageOf((int)33));
		}

		[TestMethod]
		public void PercentOfLongInt()
		{
			Assert.AreEqual(33.0M, ((long)33).PercentOf((int)100));
		}

		[TestMethod]
		public void PercentageOfLongFloat()
		{
			Assert.AreEqual(33.0M, ((long)100).PercentageOf((float)33.0F));
		}

		[TestMethod]
		public void PercentOfLongFloat()
		{
			Assert.AreEqual(33.0M, ((long)33).PercentOf((float)100.0F));
		}

		[TestMethod]
		public void PercentageOfLongDouble()
		{
			Assert.AreEqual(33.0M, ((long)100).PercentageOf((double)33.0F));
		}

		[TestMethod]
		public void PercentOfLongDouble()
		{
			Assert.AreEqual(33.0M, ((long)33).PercentOf((double)100.0F));
		}

		[TestMethod]
		public void PercentageOfLongDecimal()
		{
			Assert.AreEqual(33.0M, ((long)100).PercentageOf((decimal)33.0M));
		}

		[TestMethod]
		public void PercentOfLongDecimal()
		{
			Assert.AreEqual(33.0M, ((long)33).PercentOf((decimal)100.0M));
		}

		[TestMethod]
		public void PercentageOfLongLong()
		{
			Assert.AreEqual(33.0M, ((long)100).PercentageOf((long)33));
		}

		[TestMethod]
		public void PercentOfLongLong()
		{
			Assert.AreEqual(33.0M, ((long)33).PercentOf((long)100));
		}
	}
}
