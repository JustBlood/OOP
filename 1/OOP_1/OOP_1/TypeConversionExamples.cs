using System;
using System.Linq.Expressions;

namespace OOP_1
{
    /// <summary>
    /// Класс демонстрирует возможности кастов(преобразований типов) в языке C#
    /// </summary>
    internal static class TypeConversionExamples
    {

        /// <summary>
        /// 1 Задание. 1 пункт.
        /// </summary>
        public static void ImplicitConversions()
        {

            /*
            
            Таблица безопасных неявных преобразований - т.е. расширяющих

            byte - short, ushort, int, uint, long, ulong, float, double, decimal
            sbyte - short, int, long, float, double, decimal
            short - int, long, float, double, decimal
            ushort - int, uint, long, ulong, float, double, decimal
            int - long, float, double, decimal
            uint - long, ulong, float, double, decimal
            long - float, double, decimal
            ulong - float, double, decimal
            float - double
            char - ushort, int, uint, long, ulong, float, double, decimal
            
            дополнительно:
            single - double
            (В тип single без потери данных можно преобразовать типы:
            Byte, SByte, Int16, UInt16, Char)
             */


            var a = 1; // Int32
            var b = 1L; // Int64
            b = a; // success
            //var fl = 99999999999999f;
            long i = long.MaxValue;
            double fl = i;


            var a1 = 1.1; // double
            var b1 = 1.2f; // single
            a1 = b1; // success

            /*
             Для классов всё просто - неявно кастятся производные классы к базовым.
             */
            var boo = new Boo();
            var foo = new Foo();
            foo = boo; // foo - базовый класс для boo, неявное преобразование возможно.

        }

        /// <summary>
        /// 1 Задание. 2 пункт.
        /// </summary>
        /// <exception cref="OverflowException"></exception>
        public static void ExplicitConversations()
        {
            /*
             
            Таблица явных преобразований
            
            Byte	- SByte
            SByte	- Byte, UInt16, UInt32, UInt64
            Int16	- Byte, SByte, UInt16
            UInt16	- Byte, SByte, Int16
            Int32	- Byte, SByte, Int16, UInt16,UInt32
            UInt32	- Byte, SByte, Int16, UInt16, Int32
            Int64	- Byte, SByte, Int16, UInt16, Int32,UInt32,UInt64
            UInt64	- Byte, SByte, Int16, UInt16, Int32, UInt32, Int64
            Decimal	- Byte, SByte, Int16, UInt16, Int32, UInt32, Int64, UInt64
            Single	- Byte, SByte, Int16, UInt16, Int32, UInt32, Int64, UInt64
            Double	- Byte, SByte, Int16, UInt16, Int32, UInt32, Int64, UInt64

             */

            try
            {
                // Типы-значения
                var a = 1.1;
                //int b = a; - нельзя
                int b = (int)a; // success

                // Ссылочные типы. Можно явно преобразовывать только к базовым типам и обратно к изначальным
                var boo = new Boo();
                var foo = new Foo();
                //boo = (Boo)foo; // нельзя
                var newBoo = (Foo)boo;
                var backToBoo = (Boo)newBoo; // success
            }
            catch
            {
                throw new OverflowException("Преобразование недопустимо");
            }
        }

        /// <summary>
        /// 1 задание. 3 пункт.
        /// Метод показывает, что приведение базового типа к производному невозможно.
        /// А производный к базовому - возможно
        /// </summary>
        public static void ThirdTask()
        {
            // Boo - производный класс
            // Foo - базовый
            Foo a = new Foo();
            Boo b = new Boo();
            try
            {
                b = (Boo)a; // выдаст InvalidCastException, т.к. пытаемся привести базовый класс к производному
            }
            catch
            {
                b = new Boo();
                try
                {
                    a = (Foo)b; // correct
                    a = b; // correct
                }
                catch
                {
                    // никогда не отработает.
                }
            }
        }

        /// <summary>
        /// 1 задание. 4 пункт.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static void AsIsOperators()
        {
            Foo a = new Foo();
            object b = new Boo();
            //b = b as Foo;
            if (b is Foo)
                b = b as Foo;
            else
            {
                throw new Exception("b is not Foo convertable");
            }
            // потом работаем с b, как с объектом Foo и делаем необходимое
        }

        /// <summary>
        /// 1 Задание. 5 пункт.
        /// </summary>
        public static void ImplicitExplicitExamples()
        {
            StringExample myString = "Hello world!"; // implicit cast
            var a = "Bye world!";
            myString = a; // implicit cast
            a = "Hello again!";
            var b = myString.Field; // "Bye world!"
            var b1 = (string)myString; // "Bye world!" - explicit cast
        }

        /// <summary>
        /// 1 Задание. 6 пункт.
        /// Convert, Parse, TryParse.
        /// </summary>
        public static void ConvertDemonstration()
        {
            var a = Convert.ToSingle(1); // 1
            var b = Convert.ToSingle(double.MaxValue); // inf
            var c = Convert.ToSingle("1.1"); // 1.1
            var d = Single.Parse("1.1"); // 1.1

            int num;
            string someNumber = "12312";
            if (int.TryParse(someNumber, out num)) // TryParse - возвращает true, если операция каста удалась, присваивает значение в переменную по ссылке (out)
                num += 1;
            else
                num = 0;
        }

        /// <summary>
        /// Вспомогательный метод
        /// Преобразует любой тип в любой другой, если это возможно.
        /// </summary>
        /// <typeparam name="T">Тип, в который необходимо преобразовать</typeparam>
        /// <param name="someObject">Преобразуемый тип</param>
        /// <returns></returns>
        public static T GetConvertCast<T>(dynamic someObject)
        {
            return (T)Convert.ChangeType(someObject, typeof(T));
        }

        public static T GetImplicitCast<T>(dynamic someObject)
        {
            return someObject;
        }

        public static T GetExplicitCast<T>(dynamic someObject)
        {
            return (T)someObject;
        }

    }

    /// <summary>
    /// Вспомогательный класс строки
    /// </summary>
    class StringExample
    {
        public string Field { private set; get; }

        public static implicit operator StringExample(string s)
        {
            return new StringExample() { Field = s.Substring(0) };
        }

        public static explicit operator string(StringExample ex)
        {
            return ex.Field.Substring(0);
        }
    }

    /// <summary>
    /// Вспомогательный класс для демонстрации каста классов
    /// </summary>
    class Foo
    {

    }

    /// <summary>
    /// Вспомогательный класс для демонстрации каста классов
    /// Производный от: Foo
    /// </summary>
    class Boo : Foo
    {

    }

    /// <summary>
    /// Вспомогательный класс для демонстрации каста классов
    /// Производый от: Foo, Boo
    /// </summary>
    class Coo : Foo
    {

    }
}
