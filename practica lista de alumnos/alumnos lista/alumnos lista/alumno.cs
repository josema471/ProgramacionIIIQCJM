using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alumnos_lista
{
    class alumno
    {
        public alumno(string nombre, string primerapellido, string segundoapellido, string ci, int edad)
        {
            this.nombre = nombre;
            this.primerapellido = primerapellido;
            this.segundoapellido = segundoapellido;
            this.ci = ci;
            this.edad = edad;
        }

        string nombre {set;get;}
        string primerapellido {set;get;}
        string segundoapellido{set;get;}
        string ci { set; get; }
        int edad { set; get; }


    }
}
