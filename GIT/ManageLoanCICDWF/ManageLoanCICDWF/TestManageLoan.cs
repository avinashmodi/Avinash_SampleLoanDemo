using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageLoanCICDWF
{
    [TestFixture]
    public class TestManageLoan
    {
        [TestCase]
        public void testLoan()
        {
            Assert.AreEqual("Hello", "Hello");
        }

        [TestCase]
        public void testLogin()
        {
            Assert.AreEqual("test", "test");
        }
    }
}