using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraPregunta
{
    class gimnasio
    {
        string nombre;
        string direccion;
        int numero;
        List<atleta> Listadeatletas;
        private static gimnasio instance;

        public static gimnasio getinstance()
        {
            if (instance == null)
            {
                instance = new gimnasio();
            }
            return instance;
        }

        private gimnasio()
        {
            this.nombre = "gimnasio univalle";
            this.direccion = "pasaje guillermina";
            this.numero = 64255233;
            Listadeatletas = new List<atleta>();
        }
        public void Insertaratleta(atleta x)
        {
            Listadeatletas.Add(x);
        }
        public void Removeraatleta(atleta y)
        {
            Listadeatletas.Remove(y);
        }
        public string Mostraratletas()
        {
            string lista = " ";
            foreach (atleta z in Listadeatletas)
            {
                lista += z;
            }
            return nombre + direccion + numero + lista;
        }
    }
}
