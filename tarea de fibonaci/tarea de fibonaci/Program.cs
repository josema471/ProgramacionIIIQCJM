using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_de_fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Ingrese el numero");
            n = int.Parse(Console.ReadLine());
            int aux = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("fibonaci" + (i + 1) + FactorialRecursivo(i));
            }

            Console.ReadKey();
        }

        static int FactorialRecursivo(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * FactorialRecursivo(n - 1) + n * FactorialRecursivo(n - 2);
        }

    }
}
