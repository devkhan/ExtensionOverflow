using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtensionOverflow;

namespace ExtensionOverflowTests
{
	/// <summary>
	/// Test System.DateTime extension methods.
	/// </summary>
	[TestClass]
	public class DateTimeExtensionTests
	{
        /// <summary>
        /// Provide information about current testing context.
        /// Required by MSTests.
        /// </summary>
        public TestContext TestContext { get; set; }

		[TestMethod]
		public void Elapset15min()
		{
            DateTime datetime = DateTime.Now.AddMinutes(-15);
			Assert.AreEqual(15, datetime.Elapsed().Minutes);
		}

        [TestMethod]
        public void Elapset15sec()
        {
            Assert.AreEqual(15, DateTime.Now.AddSeconds(-15).Elapsed().Seconds);
        }

        [TestMethod]
        public void ElapsetMinus15sec()
        {
            Assert.AreEqual(-15, DateTime.Now.AddSeconds(15).Elapsed().Seconds);
        }
	}
}
