using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator
{
    public class SimpleMath
    {

        public static double Add ( double x, double y )
        {
            return x + y;
        }

        public static double Substract ( double x, double y )
        {
            return x - y;
        }

        public static double Multiply ( double x, double y )
        {
            return x * y;
        }

        public static double Divide ( double x, double y )
        {
            if ( y == 0 )
            {
                MessageBox.Show("Division by 0 is not supported", "Wrong operation", MessageBoxButton.OK, MessageBoxImage.Error);
                return 0;
            }

            return x / y;
        }
    }
}
