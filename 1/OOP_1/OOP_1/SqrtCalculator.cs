using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class SqrtCalculator
    {

        public double GetMathRealization(double num, double eps = 1e-15)
        {
            return Math.Sqrt(num);
        }

        public IEnumerable<decimal> GetNewtoneRealization(decimal num, decimal eps = 1e-28m)
        {
            decimal result = 1;
            var iters = 0;
            while (true)
            {
                result = (result + num / result) / 2;
                yield return result;
                if (Math.Abs(result * result - num) <= eps
                    || iters++ > 1e6)
                    yield break;
            }
        }
    }
}
