using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace EvenFibonacciNumbers.Test
{
    [TestFixture]
    class EvenFibonacciNumbersTest
    {
        FibonacciNumbers fn = new FibonacciNumbers();

        [Test]
        public void TestFibonacciSum()
        {
            Assert.AreEqual(231, fn.FinonacciSum(10));
        }
    }
}
