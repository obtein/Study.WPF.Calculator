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
        double lastNumber, result;
        SelectedOperator selectedOperator;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonDot_Click ( object sender, RoutedEventArgs e )
        {
            if ( resultLabel.Content.ToString().Contains( "." ) )
            {
                // Do nothing
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}.";
            }
        }

        private void ButtonEqual_Click ( object sender, RoutedEventArgs e )
        {
            double newNumber;
            if ( double.TryParse( resultLabel.Content.ToString(), out newNumber ) )
            {
                switch ( selectedOperator )
                {
                    case SelectedOperator.Addition:
                        result = SimpleMath.Add(lastNumber,newNumber);
                        break;
                    case SelectedOperator.Division:
                        result = SimpleMath.Divide(lastNumber,newNumber);
                        break;
                    case SelectedOperator.Multiplication:
                        result = SimpleMath.Multiply(lastNumber,newNumber);
                        break;
                    case SelectedOperator.Substraction:
                        result = SimpleMath.Substract(lastNumber,newNumber);
                        break;
                }
            }
            resultLabel.Content = result.ToString();
        }

        private void ButtonNumber_Click(object sender, RoutedEventArgs e)
        {
            int selectedValue = int.Parse(( sender as Button ).Content.ToString());

            if ( resultLabel.Content.ToString() == "0" )
            {
                resultLabel.Content = $"{selectedValue}";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}{selectedValue}";
            }
        }

        private void OperationButton_Click ( object sender, RoutedEventArgs e )
        {
            if ( double.TryParse( resultLabel.Content.ToString(), out lastNumber ) )
            {
                resultLabel.Content = "0";
            }
            if ( sender == buttonMultiply )
                selectedOperator = SelectedOperator.Multiplication;
            else if ( sender == buttonDivide )
                selectedOperator = SelectedOperator.Division;
            else if ( sender == buttonPlus )
                selectedOperator = SelectedOperator.Addition;
            else if ( sender == buttonMinus )
                selectedOperator = SelectedOperator.Substraction;
        }

        private void ButtonPercentage_Click(object sender, RoutedEventArgs e)
        {
            if ( double.TryParse( resultLabel.Content.ToString(), out lastNumber ) )
            {
                if(lastNumber != 0)
                    lastNumber /= 100;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void ButtonNegative_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber)) 
            {
                if(lastNumber != 0)
                    lastNumber *= -1;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void ButtonAC_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }
    }

    public enum SelectedOperator
    {
        Addition,
        Substraction,
        Multiplication,
        Division
    }

}
