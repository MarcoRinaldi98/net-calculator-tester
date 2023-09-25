using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    public static class Calculator
    {
        // Metodo per sommare due numeri
        public static float Add(float num1, float num2) 
        { 
            return num1 + num2; 
        }

        // Metodo per sottrarre due numeri
        public static float Subtract(float num1, float num2) 
        { 
            if (num1 > num2)
            {
                return num1 - num2;
            } else
            {
                return num2 - num1;
            }
        }

        // Metodo per dividere due numeri
        public static float Divide(float num1, float num2)
        {
            if (num1 == 0 || num2 == 0)
            {
                return 0;
            }
            else
            {
                return num1 / num2;
            }
        }

        // Metodo per moltiplicare due numeri
        public static float Multiply(float num1, float num2) 
        { 
            return num1 * num2; 
        }
    }
}
