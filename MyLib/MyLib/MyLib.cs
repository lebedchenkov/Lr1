using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib1
    /// <summary>
    /// Calculating mathematical functions
    /// </summary>
{
    public class MyLib
    {
        /// <summary>
        /// Ploshchad
        /// </summary>
        public static double Ploshchad(double x1, double x2, double x3, double y1, double y2, double y3)
        {
            double AB, BC, AC, S, p;
            AB = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            BC = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            AC = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
            p = (AB + BC + AC) / 2;
            if (AB + BC > AC && BC + AC > AB && AC + AB > BC)
            {
                S = Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC));
                return S;
            }
            else
            {
                S = 0;
                return S;
            }
        }
        /// <summary>
        /// Summa_row
        /// </summary>
        public static double Summa_row(double x, int n)
        {
            double S;
            S = 0;
            for (int i = 1; i <= n; i++)
            {
                S = Math.Pow((Math.Sin(x)), n) + S;
            }
            return S;
        }
        /// <summary>
        /// Factorial
        /// </summary>
        public static double Factorial(int n)
        {
            return n * (n - 1);
        }
        /// <summary>
        /// Summa_row2
        /// </summary>
        public static double Summa_row2(int n, double x)
        {
            double S = 1;
            for (int i = 0; i < n; i++)
            {
                double k = Factorial(n);
                S = S + (((n * n + 1) / k) * (Math.Pow((x / 2), n)));
            }
            return S;
        }
        /// <summary>
        /// Error
        /// </summary>
        public static double Error(int n, double x)
        {
            double Sum = Summa_row2(n, x);
            double p = ((x * (x / 4) + (x / 2) + x) * Math.Pow(Math.E, (x / 2)));
            double t = ((Math.Abs(Sum - p) / p) * 100);
            return t;
        }
    }
} 