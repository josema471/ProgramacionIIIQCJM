using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    class Program
    {
        delegate string Mdelegado(int a, int b);
        static void Main(string[] args)
        {
            Mdelegado mult = (int a, int b) =>
            {
                string aux;
                if (a % b == 0)
                    aux = "si es un multiplo";
                else
                    aux = "no es un multiplo";
                return aux;
            };

            Console.WriteLine(mult(4, 2));
            Console.ReadKey();
        }
    }
}
