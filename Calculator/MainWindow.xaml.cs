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

        public MainWindow()
        {
            InitializeComponent();
            buttonAC.Click += ButtonAC_Click;
            buttonNegative.Click += ButtonNegative_Click;
            buttonPercentage.Click += ButtonPercentage_Click;
            buttonDivide.Click += ButtonDivide_Click;
            buttonSeven.Click += ButtonSeven_Click;
            buttonEight.Click += ButtonEight_Click;
            buttonNine.Click += ButtonNine_Click;
            buttonMultiply.Click += ButtonMultiply_Click;
            buttonFour.Click += ButtonFour_Click;
            buttonFive.Click += ButtonFive_Click;
            buttonSix.Click += ButtonSix_Click;
            buttonMinus.Click += ButtonMinus_Click;
            buttonOne.Click += ButtonOne_Click;
            buttonTwo.Click += ButtonTwo_Click;
            buttonThree.Click += ButtonThree_Click;
            buttonPlus.Click += ButtonPlus_Click;
            buttonZero.Click += ButtonZero_Click;
            buttonDot.Click += ButtonDot_Click;
            buttonEqual.Click += ButtonEqual_Click;


        }

        private void ButtonEqual_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonDot_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonZero_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonThree_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonTwo_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonOne_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonSix_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonFive_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonFour_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonNine_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonEight_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonSeven_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonPercentage_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonNegative_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber)) 
            {
                lastNumber *= -1;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void ButtonAC_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }
    }
}
