using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alumnos_lista
{
    class Program
    {
      
        static void Main(string[] args)
        {
            alumno[] listaalumnos = new alumno[8];
            int opcion = 0;
            while(opcion!=3)
            {
                Console.WriteLine("1.insertar alumno");
                Console.WriteLine("2.mostrar alumnos");
                Console.WriteLine("3.salir");
                Console.WriteLine("introduzca opcion");
                opcion = int.Parse(Console.ReadLine());

                switch(opcion)
                {
                    case 1:
                        insertar(listaalumnos);
                    break;
                    case 2:

                    break;
                 
                }
            }
        }
        static void Mostrar(alumno[] listaalumnos)
        {
            foreach(alumno a in listaalumnos)
            {
                if(a!=null)
                Console.WriteLine("{0}{1}{2}{3}{4}", a.nombre, a.primerapellido, a.segundoapellido, a.ci, a.edad);
            }
        }
        static void insertar(alumno[]listaalumnos)
        {
            Console.Write("introduzca el numero del alumno");
            int nroalumno = int.Parse(Console.ReadLine());
            Console.Write("introduzca el nombre");
            string nombre = Console.ReadLine();
            Console.Write("introduzca el primer apellido");
            string primerapellido = Console.ReadLine();
            Console.Write("introduzca el segundo apellido");
            string segundoapellido = Console.ReadLine();
            Console.Write("introduzca el ci");
            string  ci = Console.ReadLine();
            Console.Write("introduzca el sexo");
            string sexo = (Console.ReadLine());
            Console.Write("introduzca la edad");
            int edad = int.Parse(Console.ReadLine());
            alumno a = new alumno(nombre, primerapellido, segundoapellido, ci,sexo,edad);
            listaalumnos[nroalumno] = a;
        }
        static void Insertartodos(alumno[]listaalumnos)
        {
            listaalumnos[0] = new alumno("antonio", "arce", "pacheco", "10390566", "m", 21);
        }
    }
}
