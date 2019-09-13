﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TddCalApp.library;

namespace TddCalApp.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldReturnPositiveonPassingTwoPositiveNumbers()
        {
            Calculator testCalculator = new Calculator();
            int num1 = 3;
            int num2 = 2;
            int result;
            result = testCalculator.Add(num1, num2);
            Assert.AreEqual(5, result,"Testing two integers 3 and 2");
        }
    }
}
