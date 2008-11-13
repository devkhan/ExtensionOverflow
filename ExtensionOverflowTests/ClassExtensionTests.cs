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

    /// <summary>
    /// Dummy class for testing purposes with circular references thrown into the mix.
    /// </summary>
    public class DummyCircularClass : DummyClass
    {
        public DummyCircularClass another;

        public DummyCircularClass() : base()
        {
            // create 2 more childrens to link in a circle
            var d1 = new DummyCircularClass(true);
            var d2 = new DummyCircularClass(true);

            // create circular references
            d1.another = this;
            this.another = d2;
            d2.another = this;
        }

        private DummyCircularClass(bool placeholder) : base()
        {
            /* does nothing */
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
