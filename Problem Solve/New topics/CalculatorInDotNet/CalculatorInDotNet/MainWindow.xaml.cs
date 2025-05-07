using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace CalculatorInDotNet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //private int result = 0;
        //private int? input = null;
        //private bool initial = false;
        //private Dictionary<string, string> _CalculatorOperatrs = new();
        //private List<string> _operatorHolder = new();

        private string? cOptr = null;

        private int? input1 = null;
        private int? input2 = null;



        public MainWindow()
        {
            InitializeComponent();
            //setCalculatorOperators();
        }

        //private void setCalculatorOperators()
        //{
        //    _CalculatorOperatrs.Add("plus", "+");
        //    _CalculatorOperatrs.Add("minus", "-");
        //    _CalculatorOperatrs.Add("multiplication", "*");
        //    _CalculatorOperatrs.Add("division", "/");
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn && btn.Content == "0")
            {
                if (input1 is null)
                { 
                    input1 = 0; 
                    Display.Text = input1.ToString();
                }
                else
                {
                    input2 = 0;
                }
                
            }

            else if (sender is Button btn1 && btn1.Content.ToString() == "1")
            {
                if (input1 is null)
                { input1 = 1;
                    Display.Text = input1.ToString();
                }
                else
                {
                    input2 = 1;
                }
            }
            else if (sender is Button btn2 && btn2.Content.ToString() == "2")
            {
                if (input1 is null)
                { 
                    input1 = 2;
                    Display.Text = input1.ToString();
                }
                else
                {
                    input2 = 2;
                    Display.Text = input2.ToString();
                }
            }
            else if (sender is Button btn3 && btn3.Content == "3")
            {
                if (input1 is null) input1 = 3;
                {
                    input2 = 3;
                }
            }
            else if (sender is Button btn4 && btn4.Content == "4")
            {
                if (input1 is null) input1 = 4;
                else
                {
                    input2 = 4;
                }
            }
            else if (sender is Button btn5 && btn5.Content == "5")
            {
                if (input1 is null) input1 = 5;
                else
                {
                    input2 = 5;
                }
            }
            else if (sender is Button btn6 && btn6.Content == "6")
            {
                if (input1 is null) input1 = 6;
                else
                {
                    input2 = 6;
                }
            }
            else if (sender is Button btn7 && btn7.Content == "7")
            {
                if (input1 is null) input1 = 7;
                else
                {
                    input2 = 7;
                }
            }
            else if (sender is Button btn8 && btn8.Content == "8")
            {
                if (input1 is null) input1 = 8;
                else
                {
                    input2 = 8;
                }
            }
            else if (sender is Button btn9 && btn9.Content == "9")
            {
                if (input1 is null) input1 = 9;
                else
                {
                    input2 = 9;
                }
            }
        }

        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button plusBtn && plusBtn.Content.ToString() == "+")
            {
                cOptr = "+";
            }
        }


        private void ButtonACOnClick(object sender, RoutedEventArgs e)
        { 
        
        }

        private void ButtonCOnClick(object sender, RoutedEventArgs e)
        {

        }

        private void CalculateOnClick(object sender, RoutedEventArgs e)
        {
            if (cOptr == "+")
            {
                Display.Text = (input1 + input2).ToString();
            }
        }
    }
}