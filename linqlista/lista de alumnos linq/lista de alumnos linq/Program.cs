﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_alumnos_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno[] listaalumnos = new Alumno[8];
            InsertarTodos(listaalumnos);
            int opcion = 0;
            while (opcion != 7)
            {
                Console.Clear();
                Console.WriteLine("1.- Insertar Alumno");
                Console.WriteLine("2.- Mostrar Alumnos");
                Console.WriteLine("3.- Mostrar Alumnas");
                Console.WriteLine("4.- Ordenar por Nombre");
                Console.WriteLine("5.- Mayores de 20");
                Console.WriteLine("6.- Sexo y Primer Apellido");
                Console.WriteLine("Salir");
                Console.Write("Introduzca opcion ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Insertar(listaalumnos);
                        break;
                    case 2:
                        Mostrar(listaalumnos);
                        break;
                    case 3:
                        MostrarAlumnas(listaalumnos);
                        break;
                    case 4:
                        OrdenarNombre(listaalumnos);
                        break;
                    case 5:
                        Mayores20(listaalumnos);
                        break;
                    case 6:
                        SexoPrimerApellido(listaalumnos);
                        break;
                    case 7:
                        AgruparEdad(listaalumnos);
                        break;
                    case 8:
                        CantidadEdad(listaalumnos);
                        break;
                    case 9:
                        EdadPromedioSexo(listaalumnos);
                        break;
                    case 10:
                        mayorsexoedad(listaalumnos);
                        break;
                    default:
                        break;
                }
            }
        }
        static void Insertar(Alumno[] listaalumnos)
        {

            Console.Write("Introduzca el nro de alumno: ");
            int nroalumno = int.Parse(Console.ReadLine()) - 1;
            Console.Write("Introduzca el Nombre: ");
            String Nombre = Console.ReadLine();
            Console.Write("Introduzca el Primer Apellido: ");
            String PrimerApellido = Console.ReadLine();
            Console.Write("Introduzca el Segundo Apellido: ");
            String SegundoApellido = Console.ReadLine();
            Console.Write("Introduzca el Carnet de Identidad: ");
            String CI = Console.ReadLine();
            Console.Write("Introduzca el Sexo: (M/F) ");
            String Sexo = Console.ReadLine();

            Console.Write("Introduzca la Edad: ");
            int Edad = int.Parse(Console.ReadLine());


            Alumno a = new Alumno(Nombre, PrimerApellido, SegundoApellido, CI, Sexo, Edad);
            listaalumnos[nroalumno] = a;

        }
        static void InsertarTodos(Alumno[] listaalumnos)
        {
            listaalumnos[0] = new Alumno("Antonio", "Arce", "Pacheco", "10390566", "M", 21);
            listaalumnos[1] = new Alumno("Maycol", "Mancilla", "Lora", "10566366", "M", 22);
            listaalumnos[2] = new Alumno("Camila", "Canaviri", "Mamani", "12398414", "F", 19);
            listaalumnos[3] = new Alumno("Kassandra", "Cuellar", "Almendras", "7512719", "F", 21);
            listaalumnos[4] = new Alumno("Danna", "Colque", "Soliz", "65498512", "F", 18);
            listaalumnos[5] = new Alumno("Jhoselin", "Choque", "Ajalla", "12931915", "F", 19);
            listaalumnos[6] = new Alumno("Yerson", "Mallcu", "Lisarazu", "123456789", "M", 26);
            listaalumnos[7] = new Alumno("Manuel", "Quispe", "Calcina", "8565058", "M", 20);
        }

        static void Mostrar(Alumno[] listaalumnos)
        {


            var todos = from l in listaalumnos
                        select l;
            foreach (Alumno a in todos)
            {

                Console.WriteLine("{0} {1} {2} {3} {4}", a.nombre, a.primerapellido, a.segundoapellido, a.ci, a.edad, a.sexo);
            }
            Console.ReadKey();

        }
        static void MostrarAlumnas(Alumno[] listaalumnos)
        {
            var alumnas = from l in listaalumnos
                          where l.sexo == "F"
                          select l;
            foreach (Alumno a in alumnas)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", a.nombre, a.primerapellido, a.segundoapellido, a.ci, a.edad, a.sexo);
            }
            Console.ReadKey();
        }
        public static void OrdenarNombre(Alumno[] listaalumnos)
        {
            var ordenarnombre = from l in listaalumnos
                                orderby l.nombre
                                select l;
            foreach (Alumno a in ordenarnombre)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", a.nombre, a.primerapellido, a.segundoapellido, a.ci, a.edad, a.sexo);
            }
            Console.ReadKey();
        }
        public static void Mayores20(Alumno[] listaalumnos)
        {
            var mayores20 = from l in listaalumnos
                            where l.edad > 20
                            select l;
            foreach (Alumno a in mayores20)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", a.nombre, a.primerapellido, a.segundoapellido, a.ci, a.edad, a.sexo);
            }
            Console.ReadKey();
        }
        public static void SexoPrimerApellido(Alumno[] listaalumnos)
        {
            var SexoApellido = from l in listaalumnos
                               orderby l.sexo, l.primerapellido descending
                               select l;
            foreach (Alumno a in SexoApellido)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", a.nombre, a.primerapellido, a.segundoapellido, a.ci, a.edad, a.sexo);
            }
            Console.ReadKey();
        }
        public static void AgruparEdad(Alumno[] listaalumnos)
        {
            var Edad = from l in listaalumnos
                       orderby l.edad descending
                       group l by l.edad into edad
                       select edad;
            foreach (var GrupoEdades in Edad)
            {
                Console.WriteLine(GrupoEdades.Key);
                foreach (var alumno in GrupoEdades)
                {

                    Console.WriteLine("{0} {1} ", alumno.nombre, alumno.primerapellido);
                }
            }
            Console.ReadKey();
        }
        public static void CantidadEdad(Alumno[] listaalumnos)
        {
            var cantidad = from l in listaalumnos
                           group l by l.edad into edad
                           select new { edad = edad.Key, Cantidad = edad.Count() };
            foreach (var grupoedad in cantidad)
            {

                Console.WriteLine("{0} {1} ", grupoedad.edad, grupoedad.Cantidad);
            }
            Console.ReadKey();
        }
        public static void EdadPromedioSexo(Alumno[] listaalumnos)
        {
            var edad = from l in listaalumnos
                       group l by l.sexo into sexo
                       select new { sexo = sexo.Key, Promedio = sexo.Average(pe => pe.edad) };
            foreach (var grupoedad in edad)
            {

                Console.WriteLine("{0} {1} ", grupoedad.sexo, grupoedad.Promedio);
            }
            Console.ReadKey();
        }

        public static void mayorsexoedad(Alumno[] listaalumnos)
        {
            var mayor = from l in listaalumnos
                       group l by l.sexo into sexo
                       select new { sexo = sexo.Key, Promedio = sexo.Max(pe => pe.edad) };
            foreach (var grupoedad in mayor)
            {

                Console.WriteLine("{0} {1} ", grupoedad.sexo, grupoedad.edad);
            }
            Console.ReadKey();
        }
        public static void mayorsexoedad(Alumno[] listaalumnos)
        {
            var mayor = from l in listaalumnos
                        group l by l.sexo into sexo
                        select new { sexo = sexo.Key, Promedio = sexo.Max(pe => pe.edad) };
            foreach (var grupoedad in mayor)
            {

                Console.WriteLine("{0} {1} ", grupoedad.sexo, grupoedad.edad);
            }
            Console.ReadKey();
        }
        public static void mayorsexoedad(Alumno[] listaalumnos)
        {
            var mayor = from l in listaalumnos
                        group l by l.sexo into sexo
                        select new { sexo = sexo.Key, Promedio = sexo.Max(pe => pe.edad) };
            foreach (var grupoedad in mayor)
            {

                Console.WriteLine("{0} {1} ", grupoedad.sexo, grupoedad.edad);
            }
            Console.ReadKey();
        }
    }
}
