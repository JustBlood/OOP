using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatrixMultiplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;

namespace MatrixMultiplication.Tests
{
    [TestClass()]
    public class MainWindowTests
    {
        [TestMethod()]
        public void GetMultiplyMatricesTest()
        {
            var first = new double[2, 3] { { 1, 2, 3 }, { 1, 0, 1 } };
            var second = new double[3, 3] { { 3, 4, 5 }, { 6, 0, 2 }, { 7, 1, 8 } };
            var result = MatrixOperations.MultiplyMatrices(first, second);
            var expected = new double[2, 3] { { 36, 7, 33 }, { 10, 5, 13 } };
            Assert.AreEqual(expected.GetLength(0), result.GetLength(0));
            Assert.AreEqual(expected.GetLength(1), result.GetLength(1));
            for (int i = 0; i < expected.GetLength(0); i++)
            {
                for (int j = 0; j < expected.GetLength(1); j++)
                {
                    Assert.AreEqual(expected[i, j], result[i, j]);
                }
            }
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEqualCols1AndRows2Tests()
        {
            var first = new double[1, 2]
            {
                { 1, 2 }
            };
            var second = new double[3, 4]
            {
                {1, 1, 1, 1},
                {1, 1, 1, 1},
                {1, 1, 1, 1},
            };
            var result = MatrixOperations.MultiplyMatrices(first, second);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeMatrixElementTest()
        {
            var first = new double[1, 2]
            {
                { 1, -2 }
            };
            var second = new double[3, 4]
            {
                {1, 1, 1, 1},
                {1, 1, 1, 1},
                {1, 1, 1, 1},
            };
            var result = MatrixOperations.MultiplyMatrices(first, second);
        }
    }
}