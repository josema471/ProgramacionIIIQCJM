using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_2
{
    class Operaciones
    {
        private static Operaciones instance;
        List<Numeros> listanumeros;

        private Operaciones()
        {
            listanumeros = new List<Numeros>();
        }
        public static Operaciones getInstance()
        {
            if (instance == null)
            {
                instance = new Operaciones();
                return instance;
            }
            else
                return instance;

        }
        public void ingresarNumero(int n)
        {
            int Fact = 1;
            for (int i = 1; i <= n; i++)
            {
                Fact = Fact * i;
            }
            int Sumatoria = 0;
            for (int i = 0; i <= n; i++)
            {
                Sumatoria += i;
            }
            listanumeros.Add(new Numeros(n, Fact, Sumatoria));
        }
        public void Mostrar()
        {
            foreach (Numeros o in listanumeros )
            {
                Console.WriteLine(o);
            }



        }
    }
}
