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

namespace Calculator
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            

            if (sender is Button knapp)
            {
               
                
                switch (knapp.Content)
                {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case ",":
                        text1.Text += knapp.Content;
                        break;


                    case "+":
                        text1.Text += "+";
                        break;

                    case "x":
                        text1.Text += "x";
                        break;

                    case "-":
                        text1.Text += "-";
                        break;

                    case "÷":
                        text1.Text += "÷";
                        break;

                    case "^":
                        text1.Text += "^";
                        break;
                        
                    case "√":
                        text1.Text += "√";
                        break;

                    case "C":
                        text1.Text = "";
                        break;

                    case "=":


                        if (text1.Text.Contains("+"))
                        {
                            var Result = 0.0;
                            var Texten = text1.Text.Split("+");
                            var firstNumber = Convert.ToDouble(Texten[0]);
                            var secondNumber = Convert.ToDouble(Texten[1]);
                            Result = firstNumber + secondNumber;
                            text1.Text = Result + "";
                        }

                        else if (text1.Text.Contains("-"))
                        {
                            var Result = 0.0;
                            var Texten = text1.Text.Split("-");
                            var firstNumber = Convert.ToDouble(Texten[0]);
                            var secondNumber = Convert.ToDouble(Texten[1]);
                            Result = firstNumber - secondNumber;
                            text1.Text = Result + "";
                        }

                        else if (text1.Text.Contains("÷"))
                        {
                            var Result = 0.0;
                            var Texten = text1.Text.Split("÷");
                            var firstNumber = Convert.ToDouble(Texten[0]);
                            var secondNumber = Convert.ToDouble(Texten[1]);
                            Result = firstNumber / secondNumber;
                            text1.Text = Result + "";
                        }

                        else if (text1.Text.Contains("x"))
                        {
                            var Result = 0.0;
                            var Texten = text1.Text.Split("x");
                            var firstNumber = Convert.ToDouble(Texten[0]);
                            var secondNumber = Convert.ToDouble(Texten[1]);
                            Result = firstNumber * secondNumber;
                            text1.Text = Result + "";
                        }

                        else if (text1.Text.Contains("^"))
                        {
                            var Result = 0.0;
                            var Texten = text1.Text.Split("^");
                            var firstNumber = Convert.ToDouble(Texten[0]);
                            var secondNumber = Convert.ToDouble(Texten[1]);
                            Result =  Math.Pow( firstNumber , secondNumber);
                            text1.Text = Result + "";
                        }

                        else if (text1.Text.Contains("√"))
                        {
                            var Result = 0.0;
                            var Texten = text1.Text.Split("√");
                            var secondNumber = Convert.ToDouble(Texten[1]);
                            Result = Math.Sqrt(secondNumber);
                            text1.Text = Result + "";
                        }







                        break;



                    default:
                        break;
                }





            }



        }

        
    }
}
