using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTaskaITI.Day3
{
    public class Calc
    {
        #region Sum
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public double Sum(double a, double b)
        {
            return a + b;
        }

        public string Sum(string a, string b)
        {
            return a + b;
        }

        public double Sum(int a, double b, double c)
        {
            return a + b + c;
        }
        #endregion

        #region Sub
        public int Sub(int a, int b)
        {
            return a - b;
        }

        public double Sub(double a, double b)
        {
            return a - b;
        }

        public double Sub(int a, double b)
        {
            return a - b;
        }
        #endregion

        #region Mul
        public int Mul(int a, int b)
        {
            return a * b;
        }

        public double Mul(double a, double b)
        {
            return a * b;
        }

        public double Mul(int a, double b)
        {
            return a * b;
        }
        #endregion

        #region Div
        public int Div(int a, int b)
        {
            return a / b;
        }

        public double Div(double a, double b)
        {
            return a / b;
        }

        public double Div(int a, double b)
        {
            return a / b;
        }
        #endregion
    }
}
