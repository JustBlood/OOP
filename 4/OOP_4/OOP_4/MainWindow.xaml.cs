using OOP_4.StressTest;
using System;
using System.Collections.Generic;
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

namespace OOP_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TestCaseResult[] testCaseResults = new TestCaseResult[10];
        int failureCount;
        public MainWindow()
        {
            InitializeComponent();
            
            Array materialItems = Enum.GetValues(typeof(Material));
            Array crossSectionItems = Enum.GetValues(typeof(CrossSection));
            Array testResultItems = Enum.GetValues(typeof(TestResult));

            foreach (var material in materialItems)
                materials.Items.Add(material);
            foreach (var crossSection in crossSectionItems)
                crossSections.Items.Add(crossSection);
            foreach (var testRusult in testResultItems)
                testResults.Items.Add(testRusult);
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selection = new StringBuilder();

            Material selectedMaterial = (Material)materials.SelectedItem;
            selection.Append(selectedMaterial + " ");

            if (crossSections.SelectedItem != null)
            {
                CrossSection selectedSection = (CrossSection)crossSections.SelectedItem;
                selection.Append(selectedSection + " ");
            }

            if (testResults.SelectedItem != null)
            {
                TestResult selectedResult = (TestResult)testResults.SelectedItem;
                selection.Append(selectedResult);
            }

            result.Content = selection.ToString();
        }

        private void runTests_Click(object sender, RoutedEventArgs e)
        {
            reasonsList.Items.Clear();
            testCaseResults = TestManager.GenerateResult();
            var success = 0;
            var fail = 0;
            for(var i = 0; i < testCaseResults.Length; i++)
            {
                if (testCaseResults[i].Result == TestResult.Fail)
                {
                    fail++;
                    failureCount++;
                    reasonsList.Items.Add("Тест№" + (i + 1) + " завершился с ошибкой: " + testCaseResults[i].ReasonForFailure);
                }
                else
                {
                    success++;
                }
            }
            failures.Content = failures.Content.ToString().Split(':')[0] + ": " + failureCount;
            successTests.Content = successTests.Content.ToString().Split(':')[0] + ": " + success;
            failTests.Content = failTests.Content.ToString().Split(':')[0] + ": " + fail;
        }
    }
}
