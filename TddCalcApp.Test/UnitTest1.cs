using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TddCalcApp.library;

namespace TddCalcApp.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldReturnPositiveonPassingTwoPositiveNumbers()
        {
            Calculator Testcalculator = new Calculator();
            int num1 = 1;
            int num2 = 2;
            int result = Testcalculator.Add(num1, num2);
            Assert.AreEqual(3, result, "Testing two Integer 3 and 2");

        }
        [TestMethod]

        public void ShouldReturnZeroOnPassingPairOfPositiveandNegatieNumbers()
        {
            Calculator Testcalculator = new Calculator();
            int num1 = 3;
            int num2 = -3;
            int result = Testcalculator.Add(num1, num2);
            Assert.AreEqual(0, result, "Testing pair of positive and negative integers to return 0");
            
        }
    }
}
