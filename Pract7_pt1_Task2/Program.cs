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
        static void GetParamsSphere(double r, out double s, out double v)
        {
            s = 4 * Math.PI * r * r;
            v = 4.0 / 3 * Math.PI * r * r * r;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = Convert.ToDouble(Console.ReadLine());
            double s;
            double v;
            GetParamsSphere(r, out s, out v);
            Console.WriteLine("{0:.00} {1}",s,v);
            Console.ReadKey();
        }
    }
}