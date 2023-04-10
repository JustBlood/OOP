using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_1
{
    /// <summary>
    /// First exercise - using casts
    /// Validate form to enter correct double number
    /// </summary>
    public partial class FirstExercise : Form
    {
        public FirstExercise()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validate entered text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBoxValidate.ValidateDoubleNumber(textBox1);
        }

        /// <summary>
        /// Create new form for second exercise
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToSecondExerciseButton_Click(object sender, EventArgs e)
        {
            new SecondExercise().ShowDialog();
        }

        /// <summary>
        /// Create new form for third exercise
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            new ThirdExercise().ShowDialog();
        }

        private void ToFirstExtraTaskButton_Click(object sender, EventArgs e)
        {
            new FirstAdditionalTask().ShowDialog();
        }
    }
}
