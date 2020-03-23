using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    class Program
    {
        delegate string Mdia(int a);
        static void Main(string[] args)
        {
            Mdia semana = (int a) =>
            {
                switch(a)
                {
                    case 1:
                        Console.WriteLine("lunes");
                        break;
                    case 2:
                        Console.WriteLine("martes");
                        break;
                    case 3:
                        Console.WriteLine("miercoles");
                        break;
                    case 4:
                        Console.WriteLine("jueves");
                        break;
                    case 5:
                        Console.WriteLine("viernes");
                        break;
                    case 6:
                        Console.WriteLine("sabado");
                        break;
                    case 7:
                        Console.WriteLine("domingo");
                        break;
                }
                return a.ToString();
                
            };
            Console.WriteLine("introducir un numero para ver que dia de la semana es");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine(semana (z));
            Console.ReadKey();
        }
    }
}
