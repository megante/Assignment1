using System;
using Assignment1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 obj = new Class1();

            double expected1 = 85.0485693;
            double real1 = obj.ConvertToGrams(3);
            double delta1 = 0.0005693;

            Assert.AreEqual(expected1, real1, delta1);


            double expected2 = 0.1058218857;
            double real2 = obj.ConvertToOunces(3);
            double delta2 = 0.0000218857;

            Assert.AreEqual(expected2, real2, delta2);
        }
    }
}
