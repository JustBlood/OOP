using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    public struct complex
    {
        public double RealPart { get; set; }
        public double ImaginaryPart { get; set; }
        public readonly double Mod
        {
            get
            {
                return Math.Sqrt(Math.Pow(RealPart, 2) + Math.Pow(ImaginaryPart, 2));
            }
        }
        /// <summary>
        /// To create complex number, enter real and imaginary part
        /// for example, number = a + bi:
        /// a - real, b - imaginary
        /// </summary>
        /// <param name="real"></param>
        /// <param name="imaginary"></param>
        public complex(double real, double imaginary)
        {
            RealPart = real;
            ImaginaryPart = imaginary;
        }

        public static complex operator+ (complex complex1, complex complex2)
        {
            return new complex(complex1.RealPart + complex2.RealPart, complex1.ImaginaryPart + complex2.ImaginaryPart);
        }
        public static complex operator- (complex complex1, complex complex2)
        {
            return new complex(complex1.RealPart - complex2.RealPart, complex1.ImaginaryPart - complex2.ImaginaryPart);
        }
        public static complex operator* (complex complex1, complex complex2)
        {
            var realPart = complex1.RealPart * complex2.RealPart - complex1.ImaginaryPart * complex2.ImaginaryPart;
            var imaginaryPart = complex1.RealPart * complex2.ImaginaryPart + complex1.ImaginaryPart * complex2.RealPart;
            return new complex(realPart, imaginaryPart);
        }


        public static bool operator== (complex complex1, complex complex2)
        {
            return Equals(complex1, complex2);
        }
        public static bool operator!= (complex complex1, complex complex2)
        {
            return !Equals(complex1, complex2);
        }
        public override string ToString()
        {
            var imaginaryMark = ImaginaryPart > 0 ? '+' : '-';
            return $"{RealPart} {imaginaryMark} {Math.Abs(ImaginaryPart)}i";
        }

        public static implicit operator complex(string complex)
        {
            double realPart;
            double imaginaryPart;
            if (!double.TryParse(complex.Split()[0], out realPart)
                || !double.TryParse(complex.Split()[2].Trim('i'), out imaginaryPart))
                throw new FormatException("Incorrect string format. String should be: -a - bi");
            if (complex.Split()[1] == "-")
                imaginaryPart *= -1;
            return new complex(realPart, imaginaryPart);
        }
    }
}
