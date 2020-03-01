using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicando_mis_ejercicios
{
    class Program
    {
        delegate double raizes(double a, double b, double c);
        static void Main(string[] args)
        {
            raizes positivos = (double a, double b, double c) =>
            {
                double x;
                x = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);

                return (-b + x) / (2 * a);
            };
            raizes negativas = (double a, double b, double c) =>
            {
                double x;
                x = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);

                return (-b - x) / (2 * a);
            };
            Console.WriteLine(positivos(1, 8, 3));
            Console.WriteLine(negativas(1, 8, 3));
            Console.ReadKey();


        }
    }
}
