using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MatrixMultiplication
{
    public static class MatrixOperations
    {
        public static double[,] MultiplyMatrices(double[,] first, double[,] second)
        {
            if (first.GetLength(1).CompareTo(second.GetLength(0)) != 0)
                    throw new ArgumentException("Matrix 1 columns not equal to Matrix 2 rows. Incorrect Operation.");
            foreach (var el in first)
            {
                if (el < 0)
                    throw new ArgumentException("Matrix 1 contains less zero element. Incorrect Operation.");
            }
            foreach (var el in second)
            {
                if (el < 0)
                    throw new ArgumentException("Matrix 2 contains less zero element. Incorrect Operation.");
            }
            var result = new double[first.GetLength(0), second.GetLength(1)];
            var transponedSecond = second.Transpone();
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    var elementsCount = first.GetLength(1);
                    while (elementsCount-- > 0)
                    {
                        result[i, j] += first[i, elementsCount] * transponedSecond[j, elementsCount];
                    }
                }
            }
            return result;
        }
    }
}
