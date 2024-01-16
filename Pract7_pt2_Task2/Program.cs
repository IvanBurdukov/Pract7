using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Pract7
{
    class Program
    {
        static void GetParamsCube(double a, out double s, out double v)
        {
            s = 6 * (a * a);
            v = a * a * a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону куба");
            double a = Convert.ToDouble(Console.ReadLine());
            double s;
            double v;
            GetParamsCube(a, out s, out v);
            Console.WriteLine("{0:.00} {0:.00}", s, v);
            Console.ReadKey();
        }
    }
}