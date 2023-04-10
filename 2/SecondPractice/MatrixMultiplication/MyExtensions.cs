using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplication
{
    public static class MyDoubleMatrixExtensions
    {
        public static double[,] Transpone(this double[,] matrix)
        {
            var transponedMatrix = new double[matrix.GetLength(1), matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    transponedMatrix[j, i] = matrix[i, j];
                }
            }
            return transponedMatrix;
        }
    }
}
