using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace ClassicCalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        
        public List<char> firstNumber = new List<char>();
        public List<char> secondNumber = new List<char>();
        public MainWindow()
        {
            InitializeComponent();
            firstNumber.Add('0');
            secondNumber.Add('0');

            //this.FontFamily = new FontFamily("Segoe UI");
            
        }
        public string charListToString(List<char> number) 
        {
            string strNumber = "";
            foreach (var num in number)
            {
                strNumber += num;
            }
            return strNumber;
        }

        private void ButtonPercentage(object sender, RoutedEventArgs e)
        {
            /*if (Operation.operationPressed)
            {
                
                Operation.operationPressed = false;
            }
            else 
            {
                Operation.operationPressed = true;
            }*/
        }
        #region MultiplyDivisionPlusMinus
        private void ButtonDivision(object sender, RoutedEventArgs e)
        {
            if (secondNumber.Count>0)
            {
                if (Operation.operationPressed)
                {
                    ButtonEquals(this, e);
                    Operation.operationPressed = true;
                    Operation.actions = Actions.Divide;
                    secondNumber.Clear();
                    if (secondNumber.Count == 0) secondNumber.Add('0');
                }
                else
                {
                    Operation.operationPressed = true;
                    secondNumber.Clear();
                    if (secondNumber.Count == 0) secondNumber.Add('0');
                    Operation.actions = Actions.Divide;
                }
                
            }
        }
        private void ButtonMultiply(object sender, RoutedEventArgs e)
        {
            if (Operation.operationPressed)
            {
                ButtonEquals(this, e);
                Operation.operationPressed = true;
                Operation.actions = Actions.Multiply;
                secondNumber.Clear();
                if (secondNumber.Count == 0) secondNumber.Add('0');
            }
            else
            {
                Operation.operationPressed = true;
                secondNumber.Clear();
                if (secondNumber.Count == 0) secondNumber.Add('0');
                Operation.actions = Actions.Multiply;
            }
        }
        private void ButtonPlus(object sender, RoutedEventArgs e)
        {
            if (Operation.operationPressed)
            {
                ButtonEquals(this, e);
                Operation.operationPressed = true;
                Operation.actions = Actions.Plus;
                secondNumber.Clear();
                if (secondNumber.Count == 0) secondNumber.Add('0');
            }
            else
            {
                Operation.operationPressed = true;
                secondNumber.Clear();
                if (secondNumber.Count == 0) secondNumber.Add('0');
                Operation.actions = Actions.Plus;
            }
        }
        private void ButtonMinus(object sender, RoutedEventArgs e)
        {
            if (Operation.operationPressed)
            {
                ButtonEquals(this, e);
                Operation.operationPressed = true;
                Operation.actions = Actions.Minus;
                secondNumber.Clear();
                if (secondNumber.Count == 0) secondNumber.Add('0');
            }
            else
            {
                Operation.operationPressed = true;
                secondNumber.Clear();
                if (secondNumber.Count==0) secondNumber.Add('0');
                Operation.actions = Actions.Minus;
            }
        }
        #endregion

        private void ButtonEquals(object sender, RoutedEventArgs e)
        {
            if (Operation.operationPressed)
            {
                if (secondNumber.Count > 0)
                {
                    double firstNum; double secondNum;
                    if (firstNumber[0] == '0') firstNumber.Remove(firstNumber[0]);
                    firstNum = Convert.ToDouble(charListToString(firstNumber));
                    secondNum = Convert.ToDouble(charListToString(secondNumber));
                    double result;
                    switch (Operation.actions)
                    {
                        case Actions.Divide:
                            if(secondNumber.Count==0)//(secondNum==0)
                            {
                                accessText.Text = "Error: Dividing by 0";
                                return;
                            }
                            else result = firstNum / secondNum;
                            break;
                        case Actions.Multiply:
                            result = firstNum * secondNum;
                            break;
                        case Actions.Minus:
                            result = firstNum - secondNum;
                            break;
                        case Actions.Plus:
                             result = firstNum + secondNum;
                            break;
                        default:
                            {
                                result = 9999;
                                accessText.Text = "Error: Equals error";
                                return;
                            }
                           
                    }

                    accessText.Text = result.ToString();
                    firstNumber.Clear();
                    firstNumber.Add('0');
                    // secondNumber.Clear();
                    firstNumber.AddRange(result.ToString());
                }
                //Operation.operationPressed = false;
            }
            else
            {
                Operation.operationPressed = true;
                
            }
        }
       
        #region CeCMinusChange
        private void ButtonMinusChange(object sender, RoutedEventArgs e)
        {
            if (Operation.operationPressed)
            {
                if (secondNumber[0] == '-')
                {
                    secondNumber.Remove('-');
                    accessText.Text = charListToString(secondNumber);
                }
                else if (secondNumber[0] == '0') return;
                else
                {
                    secondNumber.Insert(0, '-');
                    accessText.Text = charListToString(secondNumber);
                }

            }
            else
            {
                if (firstNumber[0] == '-')
                {
                    firstNumber.Remove('-');
                    accessText.Text = charListToString(firstNumber);
                }
                else if (firstNumber[0] == '0') return;
                else
                {
                    firstNumber.Insert(0, '-');
                    accessText.Text = charListToString(firstNumber);
                }
            }
        }

        private void ButtonC(object sender, RoutedEventArgs e)
        { //All
            firstNumber.Clear();
            secondNumber.Clear();
            if (firstNumber.Count == 0) firstNumber.Add('0');
            if (secondNumber.Count == 0) secondNumber.Add('0');
            accessText.Text = charListToString(firstNumber);
            Operation.operationPressed = false;
        }
        private void ButtonCE(object sender, RoutedEventArgs e)
        { //Looking at
            if (Operation.operationPressed)
            {
                secondNumber.Clear();
                if (secondNumber.Count == 0) secondNumber.Add('0');
                accessText.Text = charListToString(secondNumber);
            }
            else
            {
                firstNumber.Clear();
                if (firstNumber.Count == 0) firstNumber.Add('0');
                accessText.Text= charListToString(firstNumber);
            }
        }
        #endregion

        #region NumberInputs
        private void ButtonComa(object sender, RoutedEventArgs e)
        {
            if (Operation.operationPressed)
            {
                if (secondNumber.Last() == ',')
                {
                    secondNumber.Remove(',');
                    accessText.Text = charListToString(secondNumber);
                }
                else
                {
                    secondNumber.Add(',');
                    accessText.Text = charListToString(secondNumber);
                }
            }
            else
            {
                if (firstNumber.Last() == ',')
                {
                    firstNumber.Remove(',');
                    accessText.Text = charListToString(firstNumber);
                }
                else
                {
                    firstNumber.Add(',');
                    accessText.Text = charListToString(firstNumber);
                }
            }
        }

        private void Button0(object sender, RoutedEventArgs e)
        {
            if (Operation.operationPressed)
            {
                //if (secondNumber.Count == 0) return;
                if (secondNumber.Count < 16)
                {
                    if (secondNumber.Count == 0) secondNumber.Add('0');
                }
                accessText.Text = charListToString(secondNumber);
            }
            else
            {
                //if (firstNumber.Count == 0) return;
                if (firstNumber.Count < 16)
                {
                    if (secondNumber.Count == 0) firstNumber.Add('0');
                }
                accessText.Text = charListToString(firstNumber);
            }
        }

        private void Button1to9(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            string name = button.Name;
            char buttonNum;
            switch (name)
            {
                case "Button1": buttonNum = '1'; break;
                case "Button2": buttonNum = '2'; break;
                case "Button3": buttonNum = '3'; break;
                case "Button4": buttonNum = '4'; break;
                case "Button5": buttonNum = '5'; break;
                case "Button6": buttonNum = '6'; break;
                case "Button7": buttonNum = '7'; break;
                case "Button8": buttonNum = '8'; break;
                case "Button9": buttonNum = '9'; break;
                  
                default:
                    buttonNum = '1';
                    break;
            }
            //buttonNum = Convert.ToChar(this.Content);

            if (Operation.operationPressed)
            {
                if (secondNumber[0] == '0')
                {
                    if (secondNumber.Count > 1)
                    {
                        if (secondNumber[1] == '-') ;
                    }
                    else
                        secondNumber.Clear();
                }
                if (secondNumber.Count < 16)
                {
                    secondNumber.Add(buttonNum);
                }
                accessText.Text = charListToString(secondNumber);
            }
            else
            {
                if (firstNumber[0] == '0')
                {
                    if(firstNumber.Count>1) 
                    { 
                        if (firstNumber[1] == '-') ; 
                    }
                    else
                        firstNumber.Clear();
                }
                if (firstNumber.Count < 16)
                {
                    firstNumber.Add(buttonNum);
                }
                accessText.Text = charListToString(firstNumber);
            }
        }

#endregion

    }


}


