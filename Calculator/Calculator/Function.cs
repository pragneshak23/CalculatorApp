using System;

namespace Calculator
{
    public static class Function
    {
        public static double Add(double num1,double num2)
        {
            return num1 + num2;
        }
        public static double Sub(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Multi(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double Div(double num1, double num2)
        {
            return num1 / num2;
        }
        public static double Mod(double num1, double num2)
        {
            return num1 % num2;
        }
    }
}
