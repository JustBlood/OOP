using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecondPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondPractice.Tests
{
    [TestClass()]
    public class GCDTests
    {
        [TestMethod()]
        public void EuclidTest2()
        {
            var result = GCD.GetByEuclid(1, 2);
            Assert.AreEqual(1, result);
        }

        [TestMethod()]
        public void EuclidTest3()
        {
            var result = GCD.GetByEuclid(12, 36, 96);
            Assert.AreEqual(12, result);
        }

        [TestMethod()]
        public void EuclidTest4()
        {
            var result = GCD.GetByEuclid(99, 999, 9999, 99999999);
            Assert.AreEqual(9, result);
        }

        [TestMethod()]
        public void GetBySteinTest2()
        {
            var result = GCD.GetByStein(1, 2);
            Assert.AreEqual(1, result);
        }

        [TestMethod()]
        public void GetBySteinTest3()
        {
            var result = GCD.GetByStein(3, 6, 9);
            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void GetBySteinTest4()
        {
            var result = GCD.GetByStein(12, 18, 24);
            Assert.AreEqual(6, result);
        }
    }
}