using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_2
{
    class Numeros
    {
        int numero;
        int nrofactorial;
        int nrosumatoria;

        public Numeros(int numero, int nrofactorial, int nrosumatoria)
        {
            this.numero = numero;
            this.nrofactorial = nrofactorial;
            this.nrosumatoria = nrosumatoria;
        }
        public override string ToString()
        {
            return "Numero:" +numero+ " Factorial:"  +nrofactorial +" Sumatoria:" + nrosumatoria ;
        }
    }
}
