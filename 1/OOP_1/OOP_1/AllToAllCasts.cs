using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1_AllToAllCasts
{
    internal class AllToAllCasts
    {
        /*
         
        Написать программу, в которой реализуется явное и неявное преобразование любого типа в любой.
        Для выбора вариантов можно ограничиться типами:
        
        ===== char, string, byte, int, float, double, decimal, bool, object =====
    
        Указание - использовать тип dynamic с динамической типизацией.

         */
    }

    internal class MyString
    {
        public string s;

        public static implicit operator MyString(MyObject myObject)
        {
            return new MyString() { s = myObject.ToString() };
        }
    }

    internal class MyChar
    {
        public char c;
    }

    internal class MyByte
    {
        public byte b;
    }

    internal class MyInt
    {
        public int a;
    }

    internal class MyFloat
    {
        public float f;
    }

    internal class MyDouble
    {
        public double d;
    }

    internal class MyDecimal
    {
        public decimal dec;
    }

    internal class MyBool
    {
        public bool bl;
    }

    internal class MyObject
    {
        public object o;

        public static implicit operator MyObject(MyString myString)
        {
            return new MyObject() { o = myString.s };
        }

        public static implicit operator MyObject(MyChar myChar)
        {
            return new MyObject() { o = myChar.c };
        }

        public static implicit operator MyObject(MyByte myByte)
        {
            return new MyObject() { o = myByte.b };
        }

        public static implicit operator MyObject(MyInt myInt)
        {
            return new MyObject() { o = myInt.a };
        }

        public static implicit operator MyObject(MyFloat myFloat)
        {
            return new MyObject() { o = myFloat.f };
        }

        public static implicit operator MyObject(MyDouble myDouble)
        {
            return new MyObject() { o = myDouble.d };
        }

        public static implicit operator MyObject(MyDecimal myDecimal)
        {
            return new MyObject() { o = myDecimal.dec };
        }

        public static implicit operator MyObject(MyBool myBool)
        {
            return new MyObject() { o = myBool.bl };
        }

        public static explicit operator MyString(MyObject obj)
        {
            return (MyString)obj.o;
        }

        public static explicit operator MyChar(MyObject obj)
        {
            return (MyChar)obj;
        }
    }
}
