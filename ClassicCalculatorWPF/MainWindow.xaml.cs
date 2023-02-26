using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;

namespace ClassicCalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<char> firstNumber = new List<char>();
        public MainWindow()
        {
            InitializeComponent();
            //this.FontFamily = new FontFamily("Segoe UI");
            
        }
        public string numberToString(List<char> number) 
        {
            string strNumber = "";
            foreach (var num in number)
            {
                strNumber += num;
            }
            return strNumber;
        }

        private void divisionRest_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button0(object sender, RoutedEventArgs e)
        {
            if (firstNumber.Count < 16)
            { 
                firstNumber.Add('0');
            }
            accessText.Text = numberToString(firstNumber);
        }

        private void Button1(object sender, RoutedEventArgs e)
        {
            if (firstNumber.Count < 16)
            {
                firstNumber.Add('1');
            }
            accessText.Text = numberToString(firstNumber);
        }

        private void Button2(object sender, RoutedEventArgs e)
        {
            if (firstNumber.Count < 16)
            {
                firstNumber.Add('2');
            }
            accessText.Text = numberToString(firstNumber);
        }

        private void Button3(object sender, RoutedEventArgs e)
        {
            if (firstNumber.Count < 16)
            {
                firstNumber.Add('3');
            }
            accessText.Text = numberToString(firstNumber);
        }

        private void Button4(object sender, RoutedEventArgs e)
        {
            if (firstNumber.Count < 16)
            {
                firstNumber.Add('4');
            }
            accessText.Text = numberToString(firstNumber);
        }

        private void Button5(object sender, RoutedEventArgs e)
        {
            if (firstNumber.Count < 16)
            {
                firstNumber.Add('5');
            }
            accessText.Text = numberToString(firstNumber);
        }

        private void Button6(object sender, RoutedEventArgs e)
        {
            if (firstNumber.Count < 16)
            {
                firstNumber.Add('6');
            }
            accessText.Text = numberToString(firstNumber);
        }

        private void Button7(object sender, RoutedEventArgs e)
        {
            if (firstNumber.Count < 16)
            {
                firstNumber.Add('7');
            }
            accessText.Text = numberToString(firstNumber);
        }

        private void Button8(object sender, RoutedEventArgs e)
        {
            if (firstNumber.Count < 16)
            {
                firstNumber.Add('8');
            }
            accessText.Text = numberToString(firstNumber);
        }

        private void Button9(object sender, RoutedEventArgs e)
        {
            if (firstNumber.Count < 16)
            {
                firstNumber.Add('9');
            }
            accessText.Text = numberToString(firstNumber);
        }

    }
}
