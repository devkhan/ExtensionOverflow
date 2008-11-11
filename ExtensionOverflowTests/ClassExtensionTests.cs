///----------------------------------------------------------------------------
///
/// ClassExtensionTests.cs - Extension Methods to be used on Classes.
///
/// Copyright (c) 2008 Extension Overflow
///
///----------------------------------------------------------------------------
///
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtensionOverflow;

namespace ExtensionOverflow.Tests
{
	public class DummyClass
	{
		public DummyClass()
		{

		}

		public string Name
		{
			get;
			set;
		}
	}

	[TestClass]
	public class ClassExtensionTests
	{
		public ClassExtensionTests()
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

		[TestMethod, ExpectedException(typeof(ArgumentNullException))]
		public void ThrowIfArgumentIsNullOnDummyClass()
		{
			DummyClass sut = null;

			sut.ThrowIfArgumentIsNull("DummyClass");			
		}

		[TestMethod]
		public void ThrowIfArgumentIsNotNullOnDummyClass()
		{
			DummyClass sut = new DummyClass();

			sut.ThrowIfArgumentIsNull("DummyClass");
		}

		[TestMethod, ExpectedException(typeof(ArgumentNullException))]
		public void ThrowIfArgumentIsNullOnString()
		{
			string sut = null;

			sut.ThrowIfArgumentIsNull("string");
		}

		[TestMethod]
		public void ThrowIfArgumentIsNotNullOnString()
		{
			string sut = "not null";

			sut.ThrowIfArgumentIsNull("string");
		}
	}
}
