using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_1
{
    public partial class FirstAdditionalTask : Form
    {
        public FirstAdditionalTask()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Валидация данных в форме
        /// Вычисление и отображение результата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void convertButton_Click(object sender, EventArgs e)
        {
            var stringToTypes = StringTypesAccordance.stringToType;
            var fromType = stringToTypes[convertFromChoice.Text];
            var toType = stringToTypes[convertToChoice.Text];
            if (!StringTypesAccordance.CanChangeType(convertFromTextBox.Text, fromType))
                return;
            dynamic fromValue = Convert.ChangeType(convertFromTextBox.Text, fromType);
            if (!StringTypesAccordance.CanUseConvert(fromValue, toType))
            {
                MessageBox.Show("Преобразование невозможно.");
                return;
            }
            var toValue = Convert.ChangeType(fromValue, toType);
            resultTypeLabel.Text = toValue.GetType().ToString();
            resultValueLabel.Text = toValue.ToString();
        }
    }

    public static class StringTypesAccordance
    {
        public static Dictionary<string, Type> stringToType = new Dictionary<string, Type>()
        {
            { "char", typeof(char) },
            { "string", typeof(string) },
            { "byte", typeof(byte) },
            { "int", typeof(int) },
            { "float", typeof(float) },
            { "double", typeof(double) },
            { "decimal", typeof(decimal) },
            { "bool", typeof(bool) },
            { "object", typeof(object) },

        };

        public static bool CanChangeType(string from, Type to)
        {
            try
            {
                Convert.ChangeType(from, to);
            }
            catch (Exception ex)
            {
                if (ex is InvalidCastException)
                {
                    MessageBox.Show("Вы некорректно ввели значения указаных вами типов." +
                    "\nПерепроверьте введенные вами переменные на соответствие выбранных типов");
                }
                else if (ex is OverflowException)
                {
                    MessageBox.Show($"Введенное значение нужного типа, однако, слишком большое для выбранного типа данных." +
                    $"\nВыберите больший тип данных или уменьшите значение");
                }
                else if (ex is FormatException)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                else
                {
                    MessageBox.Show($"Неизвестная ошибка: {ex}");
                }
                return false;
            }
            return true;
        }

        public static bool CanUseConvert(dynamic obj, Type type)
        {
            try
            {
                Convert.ChangeType(unchecked(obj), type);
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    MessageBox.Show("Неверный формат ввода значения. Нужный формат:" +
                        "\nРазделитель вещественных чисел - ЗАПЯТАЯ = ','" +
                        "\nРазделитель может быть только 1" +
                        "\nПеревести из string в char можно только если длина строки = 1");
                }
                return false;
            }
            return true;
        }
    }
}
