using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib1;

namespace Mybibl
{
    /// <summary>
    /// program for checking the use of the library MyLib
    /// </summary>
    class Program
    {
        /// <summary>
        /// calling library methods from MyLib.dll
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double x1, x2, x3, y1, y2, y3, x, S;
            int n;
            Console.WriteLine("Задание1:");
            Console.WriteLine("Введите координаты первой вершины:");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты второй вершины:");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты третьей вершины:");
            x3 = Convert.ToDouble(Console.ReadLine());
            y3 = Convert.ToDouble(Console.ReadLine());
            // calling the calculation method "Ploshchad" from the library
            S = MyLib.Ploshchad(x1, x2, x3, y1, y2, y3);
            Console.WriteLine("Площадь треугольника = " + S + " кв.ед.");
            Console.WriteLine("Задание2:"); 
            Console.WriteLine("Введите число:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите натуральное число рядов:");
            n = Convert.ToInt32(Console.ReadLine());
            // calling the calculation method "Summa_row" from the library
            S = Math.Round(MyLib.Summa_row(x, n), 3);
            Console.WriteLine("Сумма ряда = " + S);
            Console.WriteLine("Задание3:");
            Console.WriteLine("Введите число:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите натуральное число рядов:");
            n = Convert.ToInt32(Console.ReadLine());
            // calling the calculation method "Error" from the library
            S = Math.Round(MyLib.Error(n, x), 3);
            Console.WriteLine("Погрешность = " + S + " %");
            Console.ReadKey();
        }
    }
}
