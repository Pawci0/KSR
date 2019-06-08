using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Zad2.Membership.Tests
{
    [TestClass()]
    public class TriangularFunctionTests
    {
        [TestMethod()]
        public void GetMembershipTest()
        {
            IMembershipFunction function = new TriangularFunction();
            function.Parameters = new List<double> { 1, 2, 3 };
            Assert.AreEqual(1.0, function.GetMembership(2));
            Assert.AreEqual(0.0, function.GetMembership(0.5));
            Assert.AreEqual(0.0, function.GetMembership(3.1));
            Assert.AreEqual(0.5, function.GetMembership(1.5));
        }
    }
}