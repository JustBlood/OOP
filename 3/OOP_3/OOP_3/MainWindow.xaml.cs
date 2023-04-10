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
using OOP_4;

namespace OOP_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TestCaseResult[] results = new TestCaseResult[10];
        List<bool> isSuccessIteration = new List<bool>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShutDownButton_Click(object sender, RoutedEventArgs e)
        {
            bool isSuccess = true;
            var deviceSwitch = new SwitchDevice();
            try
            {
                deviceSwitch.Step1();
            }
            catch(PowerGeneratorCommsException ex)
            {
                isSuccess = false;
                exceptionsHandlerTextBlock.Text += $"{ex.GetType().Name} Exception in step 1:\n{ex.Message}\n\n";
            }

            try
            {
                deviceSwitch.Step2();
                deviceSwitch.Step3();
            }
            catch(Exception ex)
            {
                isSuccess = false;
                exceptionsHandlerTextBlock.Text += $"{ex.GetType().Name} Exception in step 2:\n{ex.Message}\n\n";
            }

            try
            {
                deviceSwitch.Step3();
                deviceSwitch.Step4();
            }
            catch(Exception ex)
            {
                isSuccess = false;
                exceptionsHandlerTextBlock.Text += $"{ex.GetType().Name} Exception in step 3:\n{ex.Message}\n\n";
            }
            try
            {
                deviceSwitch.Step4();
                deviceSwitch.Step5();
            }
            catch (Exception ex)
            {
                isSuccess = false;
                exceptionsHandlerTextBlock.Text += $"{ex.GetType().Name} Exception in step 4:\n{ex.Message}\n\n";
            }
            try
            {
                deviceSwitch.Step5();
                deviceSwitch.Step6();
            }
            catch (Exception ex)
            {
                isSuccess = false;
                exceptionsHandlerTextBlock.Text += $"{ex.GetType().Name} Exception in step 5:\n{ex.Message}\n\n";
            }
            try
            {
                deviceSwitch.Step6();
                deviceSwitch.Step7();
            }
            catch (Exception ex)
            {
                isSuccess = false;
                exceptionsHandlerTextBlock.Text += $"{ex.GetType().Name} Exception in step 6:\n{ex.Message}\n\n";
            }
            try
            {
                deviceSwitch.Step7();
                deviceSwitch.Step8();
            }
            catch (Exception ex)
            {
                isSuccess = false;
                exceptionsHandlerTextBlock.Text += $"{ex.GetType().Name} Exception in step 7:\n{ex.Message}\n\n";
            }
            try
            {
                deviceSwitch.Step8();
            }
            catch (SignallingException ex)
            {
                isSuccess = false;
                exceptionsHandlerTextBlock.Text += $"{ex.GetType().Name} Exception in step 8:\n{ex.Message}\n\n";
            }
            isSuccessIteration.Add(isSuccess);
            successes.Content = successes.Content.ToString().Split(':')[0] + ": " + isSuccessIteration.Where(x => x).Count();
            failures.Content = failures.Content.ToString().Split(':')[0] + ": " + isSuccessIteration.Where(x => !x).Count();
        }
    }
}
