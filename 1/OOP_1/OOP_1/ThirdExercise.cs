using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_1
{
    /// <summary>
    /// Class for third exercise
    /// Задание 3: Конвертация целочисленных данных в бинарные
    /// </summary>
    public partial class ThirdExercise : Form
    {
        public ThirdExercise()
        {
            InitializeComponent();
        }

        private void toBinaryTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxValidate.ValidateIntNumber(toBinaryTextBox);
        }

        public Stack<int> GetInNumberSystem(int value, int system)
        {
            if (system > 36)
                return new Stack<int>();
            var result = new Stack<int>();
            while (value > 0)
            {
                result.Push(value % system);
                value /= system;
            }
            return result;
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            int boxValue;
            var newValue = new StringBuilder();
            if (!int.TryParse(toBinaryTextBox.Text, out boxValue))
            {
                MessageBox.Show("Невозможно преобразовать.");
                return;
            }
            var system = int.Parse(systemToConvert.Text);
            var stack = GetInNumberSystem(boxValue, system);
            while (stack.Count > 0)
            {
                var element = stack.Pop();
                if (element > 9)
                    newValue.Append((char)(element + 55));
                else
                    newValue.Append(element);
            }
            convertedValueLabel.Text = newValue.ToString();
        }
    }
}
