using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace MatrixMultiplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double[,]? matrix1;
        double[,]? matrix2;
        double[,] resultMatrix;

        public bool ReadyToCalculate {
            get
            {
                return matrix1 != null && matrix2 != null;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void matrixDimensions_TextChanged(object sender, TextChangedEventArgs e)
        {
            var firstRows = firstMatrixRows.Text;
            var firstColumns = firstMatrixColumns.Text;
            var secondRows = secondMatrixRows.Text;
            var secondColumns = secondMatrixColumns.Text;
            if (!CanConvertStringsToInts(firstRows, firstColumns, secondRows, secondColumns))
            {
                if (!IsSomeoneNullOrEmpty(firstRows, firstColumns, secondRows, secondColumns))
                {
                    var textBox = (TextBox)sender;
                    textBox.Text = new string(textBox.Text
                        .Take(textBox.Text.Length - 1)
                        .ToArray());
                    MessageBox.Show("Enter a valid int numbers in matrices dimensions." +
                        "\nIncorrect!");
                }
                matrix1 = null;
                matrix2 = null;
                return;
                
            }
            matrix1 = new double[int.Parse(firstRows), int.Parse(firstColumns)];
            matrix2 = new double[int.Parse(secondRows), int.Parse(secondColumns)];
            resultMatrix = new double[int.Parse(firstRows), int.Parse(secondColumns)];

            InitializeGrid(firstGrid, matrix1);
            InitializeGrid(secondGrid, matrix2);
        }

        private bool CanConvertStringsToInts(params string[] entered)
        {
            foreach (var str in entered)
            {
                if (!int.TryParse(str, out int value))
                    return false;
            }
            return true;
        }

        private bool IsSomeoneNullOrEmpty(params string[] entered)
        {
            foreach (var str in entered)
            {
                if (string.IsNullOrEmpty(str))
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Fill first and second matricies random values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fillMatrices_Click(object sender, RoutedEventArgs e)
        {
            if (matrix1 == null
                || matrix2 == null)
            {
                MessageBox.Show("Enter matrices dimensions firstly!\nRejected!");
                return;
            }
            var matrices = new[] { (matrix1, firstGrid), (matrix2, secondGrid) };
            for (int k = 0; k < matrices.Length; k++)
            {
                for (int i = 0; i < matrices[k].Item1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrices[k].Item1.GetLength(1); j++)
                    {
                        matrices[k].Item1[i, j] = Math.Round(new Random().NextDouble() * 10, 2);
                    }
                    InitializeGrid(matrices[k].Item2, matrices[k].Item1);
                }
            }
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (!ReadyToCalculate)
            {
                MessageBox.Show("Please, enter dimensions of tables and values!");
                return;
            }
            var firstMatrix = GetValuesFromGrid(firstGrid, matrix1);
            var secondMatrix = GetValuesFromGrid(secondGrid, matrix2);

            try
            {
                resultMatrix = MatrixOperations.MultiplyMatrices(firstMatrix, secondMatrix);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            //var a = (Button)sender;

            InitializeGrid(resultGrid, resultMatrix);
            //a.Visibility = Visibility.Visible;
        }

        private double[,] GetValuesFromGrid(Grid grid, double[,] matrix)
        {
            var result = new double[matrix.GetLength(0), matrix.GetLength(1)];
            int columns = grid.ColumnDefinitions.Count;
            int rows = grid.RowDefinitions.Count;
            // Iterate over cells in Grid, copying to matrix array
            for (int c = 0; c < grid.Children.Count; c++)
            {
                TextBox t = (TextBox)grid.Children[c];
                int row = Grid.GetRow(t);
                int column = Grid.GetColumn(t);
                result[row, column] = double.Parse(t.Text);
            }
            return result;
        }

        private void InitializeGrid(Grid grid, double[,] matrix)
        {
            if (grid != null)
            {
                // Reset the grid before doing anything
                grid.Children.Clear();
                grid.ColumnDefinitions.Clear();
                grid.RowDefinitions.Clear();
                // Get the dimensions
                int rows = matrix.GetLength(0);
                int columns = matrix.GetLength(1);
                // Add the correct number of coumns to the grid
                for (int x = 0; x < columns; x++)
                {
                    grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star), });
                }
                for (int y = 0; y < rows; y++)
                {
                    // GridUnitType.Star - The value is expressed as a weighted proportion of available space
                    grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star), });
                }
                // Fill each cell of the grid with an editable TextBox containing the value from the matrix 
                for (int x = 0; x < rows; x++)
                {
                    for (int y = 0; y < columns; y++)
                    {
                        double cell = Math.Round(matrix[x, y], 2);
                        TextBox t = new TextBox();
                        t.Text = cell.ToString();
                        t.VerticalAlignment = System.Windows.VerticalAlignment.Center;
                        t.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
                        t.Margin = new Thickness(10);
                        //t.AutoWordSelection = true;
                        t.SetValue(Grid.RowProperty, x);
                        t.SetValue(Grid.ColumnProperty, y);
                        grid.Children.Add(t);
                    }
                }
            }
        }

    }
}
