using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerOverflow
{
    internal static class CheckedIntegerOperations
    {
        private static readonly Dictionary<char, Func<int, int, int>> _table;
        
        static CheckedIntegerOperations()
        {
            _table = new Dictionary<char, Func<int, int, int>>()
            {
                { '+', CheckedSum },
                { '-', CheckedDifference },
                { '*', CheckedProduct },
                { '/', CheckedDivision },
            };
        }
        public static int GetOperationResult(int number1, int number2, char operation)
        {
            return _table[operation](number1, number2);
        }

        private static int CheckedSum(int n1, int n2)
        {
            return checked(n1 + n2);
        }
        private static int CheckedDifference(int n1, int n2)
        {
            return checked(n1 - n2);
        }
        private static int CheckedProduct(int n1, int n2)
        {
            return checked(n1 * n2);
        }
        private static int CheckedDivision(int n1, int n2)
        {
            return checked(n1 / n2);
        }
    }
}
