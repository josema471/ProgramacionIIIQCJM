using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
{
    class Program
    {
        delegate string Mnumeroprimo(int A);
        static void Main(string[] args)
        {
            Mnumeroprimo Primos=(int n)=>
            {
                int a = 0;
                string b;
                for (int i = 1; i < (n + 1); i++)
                {
                    if (n % i == 0)
                    {
                        a++;
                    }
                }
                if (a != 2)
                {
                    b=("No es Primo");
                }
                else
                {
                    b=("Si es Primo");
                }

                return b;
            };
            Console.WriteLine("Ingrese un numero para identificar si es primo o no es primo");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(Primos(N));
            Console.ReadKey();

        }
    }
}
