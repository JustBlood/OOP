using System;
using System.Windows.Forms;
using OOP_1_AllToAllCasts;

namespace OOP_1
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //TypeConversionExamples.GetCast<char>("23");
            TypeConversionExamples.ConvertDemonstration();
            TypeConversionExamples.ImplicitExplicitExamples();
            TypeConversionExamples.ThirdTask();
            TypeConversionExamples.ExplicitConversations();
            TypeConversionExamples.ImplicitConversions();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FirstExercise());
        }
    }
}
