using System;
using System.Globalization;
using System.Windows.Forms;

namespace OOP_1
{
    internal static class TextBoxValidate
    {
        public static void ValidateIntNumber(TextBox box)
        {
            int num;
            try
            {
                num = int.Parse(box.Text);
            }
            catch (Exception ex)
            {
                if (box.TextLength > 1)
                    box.Text = box.Text.Substring(0, box.TextLength - 1);
                else
                    box.Text = "";
                if (ex is OverflowException)
                    MessageBox.Show("Это число слишком большое для int.");
                else if (ex is FormatException)
                    MessageBox.Show("Неверный формат числа. Введите целочисленное int число.");
            }
        }

        public static void ValidateDoubleNumber(TextBox box)
        {
            double? num;
            try
            {
                var format = new NumberFormatInfo();
                format.NumberDecimalSeparator = ".";
                format.NumberGroupSeparator = "_";
                var toValidate = box.Text;
                if (box.Text[0] == '-')
                {
                    if (box.Text.Length == 1)
                        return;
                    toValidate = toValidate.Substring(1);
                }
                num = Convert.ToDouble(toValidate, format);
            }
            catch (Exception ex)
            {
                if (box.TextLength == 0)
                    box.Text = "";
                else
                    box.Text = box.Text.Substring(0, box.TextLength - 1);

                if (ex is OverflowException)
                    MessageBox.Show("Вы ввели неправильное значение! Оно не является вещественным числом двойной точности. (Выход за пределы)");
                else if (ex is FormatException)
                    MessageBox.Show("Формат ввода значения неправильный! Дробная часть отделяется ТОЧКОЙ.");
            }
        }

        public static void ValidateNegativeNumber(TextBox box)
        {
            double num;
            try
            {
                num = Convert.ToDouble(box.Text);
                if (num < 0)
                {
                    MessageBox.Show("Введите положительное число!");
                    box.Text = "";
                }

            }
            catch
            {
                MessageBox.Show("Неверный ввод.");
            }
        }

    }
}
