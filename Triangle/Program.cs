using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            double p, S2;

            if (a * a + b * b == c * c)
            {
                S2 = (a * b) / 2;
                Console.WriteLine("Треугольник является прямоугольным, площадь S = {0}", S2);
            }
            else
            {
                p = (a + b + c) / 2;
                p = Math.Round(p, 1);
                S2 = Convert.ToDouble(Math.Sqrt(p * ((p - a) * (p - b) * (p - c))));
                S2 = Math.Round(S2, 1);
                Console.WriteLine("Площадь треугольника S = {0}", S2);
            }

            Console.ReadKey();
        }
    }
}
