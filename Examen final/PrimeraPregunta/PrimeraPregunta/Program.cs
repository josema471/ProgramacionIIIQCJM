using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraPregunta
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int n;
                gimnasio p = gimnasio.getinstance();
                Console.Clear();
                Console.WriteLine("1:ingresar atleta");
                Console.WriteLine("2:retirar atleta");
                Console.WriteLine("3:mostrar atleta");
                Console.WriteLine("  ");
                Console.Write("digite un valor entre 1,2,3");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("");



                switch (n)
                {
                    case 1:
                        Console.WriteLine("precio");
                        double precio = double.Parse(Console.ReadLine());
                        Console.WriteLine("nombre");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("sexo");
                        string srTsexo = Console.ReadLine();
                        Console.WriteLine("edad");
                        double edad = double.Parse(Console.ReadLine());
                        Console.WriteLine("peso");
                        double peso = double.Parse(Console.ReadLine());
                        Console.WriteLine("altura");
                        double altura = double.Parse(Console.ReadLine());


                       
                        Sexo sex;
                        Enum.TryParse(srTsexo, out sex);

                        atleta x = new atleta(precio, nombre,sex,edad,peso,altura);
                        p.Insertaratleta(x);
                        break;
                    case 2:

                        break;

                    case 3:
                        p.Mostraratletas();
                        break;
                    default:

                        Console.WriteLine("digite un valor entre 1,2,3");
                        break;
                }
                Console.WriteLine("");
                Console.Write("prescione(intro)para continuar,(esc)para salir.");


            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.ReadKey();
            

            
            





        }
    }
}
