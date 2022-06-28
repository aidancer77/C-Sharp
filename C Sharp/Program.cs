using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int R = Convert.ToInt32(Console.ReadLine());
            double S1;
            S1 = Math.PI * Math.Pow(R, 2);
            S1 = Math.Round(S1, 1);
            Console.WriteLine("Радиус окружности = {0}", R);
            Console.WriteLine("Площадь окружности = {0}", S1);

            Console.ReadKey();
        }
    }
}
