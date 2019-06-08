using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Zad2.Membership.Tests
{
    [TestClass()]
    public class DiscreteFunctionTests
    {
        [TestMethod()]
        public void GetMembershipTest()
        {
            IMembershipFunction function = new DiscreteFunction();
            function.Parameters = new List<double> { 0.0, 1.0, 0.5, 0.2, 0.0 };
            Assert.AreEqual(0.0, function.GetMembership(0.0));
            Assert.AreEqual(0.5, function.GetMembership(2.0));
            Assert.AreEqual(0.2, function.GetMembership(3.0));
        }
    }
}