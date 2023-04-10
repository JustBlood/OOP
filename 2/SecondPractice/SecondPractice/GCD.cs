using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondPractice
{
    delegate int GCDMethod(params int[] values);

    public static class GCD
    {
        /// <summary>
        /// метод Евклида для вычисления НОД
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static int GetByEuclid(params int[] values)
        {
            int? prev = null;
            foreach (int? value in values)
            {
                if (prev == null)
                {
                    prev = value;
                    continue;
                }
                var second = value;
                if (prev == 0)
                {
                    prev = value;
                    continue;
                }
                while (second != 0)
                {
                    if (prev > second)
                    {
                        prev -= second;
                    }
                    else
                    {
                        second -= prev;
                    }
                }
            }
            return prev.Value;
        }

        public static int GetByStein(params int[] values)
        {
            int? u = null;
            foreach (var value in values)
            {
                var v = value;
                if (u == null)
                {
                    u = v;
                    continue;
                }

                int k;
                // Step 1.
                // gcd(0, v) = v, because everything divides zero, 
                // and v is the largest number that divides v. 
                // Similarly, gcd(u, 0) = u. gcd(0, 0) is not typically 
                // defined, but it is convenient to set gcd(0, 0) = 0.
                if (u == 0 || v == 0)
                {
                    u = u | v;
                    continue;
                }
                // Step 2.
                // if u and v are both even, then gcd(u, v) = 2•gcd(u/2, v/2), 
                // because 2 is a common divisor. 
                for (k = 0; ((u | v) & 1) == 0; ++k)
                {
                    u >>= 1;
                    v >>= 1;
                }
                // Step 3.
                // if u is even and v is odd, then gcd(u, v) = gcd(u/2, v), 
                // because 2 is not a common divisor. 
                // Similarly, if u is odd and v is even, 
                // then gcd(u, v) = gcd(u, v/2). 

                while ((u & 1) == 0)
                    u >>= 1;
                // Step 4.
                // if u and v are both odd, and u ≥ v, 
                // then gcd(u, v) = gcd((u − v)/2, v). 
                // If both are odd and u < v, then gcd(u, v) = gcd((v − u)/2, u). 
                // These are combinations of one step of the simple 
                // Euclidean algorithm, 
                // which uses subtraction at each step, and an application 
                // of step 3 above. 
                // The division by 2 results in an integer because the 
                // difference of two odd numbers is even.
                do
                {
                    while ((v & 1) == 0)  // Loop x
                        v >>= 1;
                    // Now u and v are both odd, so diff(u, v) is even.
                    //   Let u = min(u, v), v = diff(u, v)/2. 
                    if (u < v)
                    {
                        v -= u.Value;
                    }
                    else
                    {
                        int diff = u.Value - v;
                        u = v;
                        v = diff;
                    }
                    v >>= 1;
                    // Step 5.
                    // Repeat steps 3–4 until u = v, or (one more step) 
                    // until u = 0.
                    // In either case, the result is (2^k) * v, where k is 
                    // the number of common factors of 2 found in step 2. 
                } while (v != 0);
                u <<= k;
            }
            return u == null ? 0 : u.Value;
            
        }

    }
}
