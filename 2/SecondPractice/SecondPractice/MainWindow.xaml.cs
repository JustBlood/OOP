using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SecondPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void inputValues_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                inputValues.Text
                    .Split(' ')
                    .Where(x => !string.IsNullOrEmpty(x))
                    .Select(x => int.Parse(x))
                    .ToArray();
            }
            catch
            {
                inputValues.Text = new string(inputValues.Text.Take(inputValues.Text.Length - 1).ToArray());
                MessageBox.Show("Неправильный формат ввода! Введите числа типа INT через ПРОБЕЛ");
            }
        }

        private void findGCM_Click(object sender, RoutedEventArgs e)
        {
            var values = inputValues.Text
                .Split(' ')
                .Where(x => !string.IsNullOrEmpty(x))
                .Select(x => int.Parse(x))
                .ToArray();

            var resultEuclid = RunGCDMethod(values, new GCDMethod(GCD.GetByEuclid));
            var resultStein = RunGCDMethod(values, new GCDMethod(GCD.GetByStein));

            ShowResult(resultEuclid.result, resultStein.result, resultEuclid.watch, resultStein.watch);
        }

        private (int result, Stopwatch watch) RunGCDMethod(int[] values, GCDMethod function)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            watch.Start();
            var result = function(values);
            watch.Stop();
            return (result, watch);
        }

        private void ShowResult(
            int? resultEuclid,
            int? resultStein,
            Stopwatch watchEuclid,
            Stopwatch watchStein)
        {
            resultEuclidLabel.Content = resultEuclidLabel.Content
                .ToString()
                .Split(':')[0]
                + ": "
                + resultEuclid;
            resultSteinLabel.Content = resultSteinLabel.Content
                .ToString()
                .Split(':')[0]
                + ": "
                + resultStein;

            executingTimeEuclid.Content = executingTimeEuclid.Content
                .ToString()
                .Split(':')[0]
                + ": "
                + watchEuclid.ElapsedMilliseconds;

            executingTimeStein.Content = executingTimeStein.Content
                .ToString()
                .Split(':')[0]
                + ": "
                + watchStein.ElapsedMilliseconds;
        }
    }
}
