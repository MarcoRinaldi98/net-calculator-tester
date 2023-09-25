﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    public static class Calculator
    {
        public static float Add(float num1, float num2) 
        { 
            return num1 + num2; 
        }

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

        public static float Multiply(float num1, float num2) 
        { 
            return num1 * num2; 
        }
    }
}
