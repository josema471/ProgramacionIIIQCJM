using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones o = Operaciones.getInstance();
            int opcion = 0;
            while (opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("1. Colocar Valor");
                Console.WriteLine("2. Mostrar Valor");
                Console.WriteLine("3. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduza Numero");
                        int valor = Convert.ToInt32( Console.ReadLine());
                        o.ingresarNumero(valor);
                        break;
                    case 2:

                        o.Mostrar();
                        break;
                    case 3:

                        break;

                }
                Console.ReadKey();
            }
        }
    }
}
