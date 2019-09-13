using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TddCalcApp.library;

namespace TddCalcApp.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculator Testcalculator = new Calculator();
            int num1 = 1;
            int num2 = 2;
            int result = Testcalculator.Add(num1, num2);
            Assert.AreEqual(3, result, "Testing two Integer 3 and 2");

        }
    }
}
