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
        static double GetHypotenuse(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите катеты первого треугольника");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = GetHypotenuse(x1,y1);
            Console.WriteLine("Введите катеты dnjhjuj треугольника");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = GetHypotenuse(x2, y2);

            if(z1 > z2)
                Console.WriteLine("Гипотенуза первого треугольника больше");
            else
                if (z1 < z2)
                Console.WriteLine("Гипотенуза второго треугольника больше");
            else
                Console.WriteLine("Гипотенузы равны");
            Console.ReadKey();
        }
    }
}