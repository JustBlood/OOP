using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IntegerOverflow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            operationComboBox.ItemsSource = new[] { '+', '-', '*', '/' };
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            int num1, num2;
            if (!int.TryParse(firstNumber.Text, out num1)
                || !int.TryParse(secondNumber.Text, out num2))
            {
                MessageBox.Show("Enter valid INT values. Denied.");
                return;
            }
            if (operationComboBox.SelectedItem == null)
            {
                MessageBox.Show("Select a operation. Denied.");
                return;
            }
            try
            {
                resultString.Content = "= " + CheckedIntegerOperations.GetOperationResult(num1, num2, (char)operationComboBox.SelectedItem);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Overflow exception was occured!\n{ex.Message}");
            }
        }
    }
}
