using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP_1
{
    /// <summary>
    /// Задание 2: Вычислить квадратный корень с контролем точности
    /// </summary>
    public partial class SecondExercise : Form
    {

        decimal prevResultForNewton = 1;
        IEnumerator<decimal> newtoneIterations;
        bool isFirstIteration = true;
        decimal newtoneResult;
        public SecondExercise()
        {
            InitializeComponent();
        }

        private void valueTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxValidate.ValidateDoubleNumber(valueTextBox);
        }

        /// <summary>
        /// Validate entered number
        /// Calculate sqrt by 2 methods using SqrtCalculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void сalculateButton_Click(object sender, EventArgs e)
        {
            var format = new NumberFormatInfo();
            format.NumberDecimalSeparator = ".";
            format.NumberGroupSeparator = "_";

            double value;
            decimal valueDecimal;
            if (!double.TryParse(valueTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out value)
                || !decimal.TryParse(valueTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out valueDecimal))
            {
                MessageBox.Show("Введите число типа Decimal.");
                return;
            }
            if (value < 0)
            {
                MessageBox.Show("Введите неотрицательное число.");
                return;
            }
            var calculator = new SqrtCalculator();
            var dotNetSqrt = calculator.GetMathRealization(value);
            var newtoneSqrt = 0m;
            foreach(var iteration in calculator.GetNewtoneRealization(valueDecimal))
            {
                newtoneSqrt = iteration;
            }
            newtoneLabel.Text = newtoneSqrt.ToString() + " (Using Newtone method)"; 
            dotNetLabel.Text = dotNetSqrt.ToString() + " (Using .NET Framework)";
            var decimalDotNetSqrt = Convert.ToDecimal(dotNetSqrt);
            inaccuracyLabel.Text = inaccuracyLabel.Text.Split(':')[0].ToString() + ": " + (decimalDotNetSqrt - newtoneSqrt).ToString("e0");
        }

        private void getNextIteration_Click(object sender, EventArgs e)
        {
            decimal valueDecimal;
            if (!decimal.TryParse(valueTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out valueDecimal))
            {
                MessageBox.Show("Введите число типа Decimal.");
                return;
            }
            if (valueDecimal < 0)
            {
                MessageBox.Show("Введите неотрицательное число.");
                return;
            }

            if (isFirstIteration)
            {
                newtoneResult = new SqrtCalculator().GetNewtoneRealization(valueDecimal).Last();
                newtoneIterations = new SqrtCalculator().GetNewtoneRealization(valueDecimal).GetEnumerator();
                isFirstIteration = false;
                newtoneIterations.MoveNext();
            }
            var nextValue = newtoneIterations.Current;
            newtoneIterations.MoveNext();
            var inaccurancy = Math.Abs(nextValue - prevResultForNewton);
            prevResultForNewton = nextValue;
            iterationsValue.Text = iterationsValue.Text.Split(':')[0] + ": " + nextValue;
            inaccurancyIterations.Text = inaccurancyIterations.Text.Split(':')[0] + ": " + inaccurancy;
            resultInaccurancy.Text = resultInaccurancy.Text.Split(':')[0] + ": " + (nextValue - newtoneResult).ToString(); 
        }

        /// <summary>
        /// Iteration button logic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iterationButton_Click(object sender, EventArgs e)
        {
            isFirstIteration = true;
            iterationsValue.Text = iterationsValue.Text.Split(':')[0] + ": " + 0;
            inaccurancyIterations.Text = inaccurancyIterations.Text.Split(':')[0] + ": " + 0;
        }
    }
}
