using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    public class CalcCore
    {
        public double MinusMethod(double num1, double num2)
        {
            return num1 - num2;
        }
        public double PlusMethod(double num1, double num2)
        {
            return num1 + num2;
        }
        public double MultiplyMethod(double num1, double num2)
        {
            return num1 * num2;
        }
        public double DivideMethod(double num1, double num2)
        {
            return num1 / num2;
        }
        public double PowMethod(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }
        public double SqrtMethod(double num1)
        {
            double res = Math.Sqrt(num1);
            return res;
        }
    }
}
