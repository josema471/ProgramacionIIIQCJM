using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial_2_de_jose_ejercicio_1
{
    abstract class FamiliaPlatos
    {
        protected string planos;
        protected string soperos;
        protected string platillos;
        double precio;

        public FamiliaPlatos(string planos, string soperos, string platillos, double precio)
        {
            this.planos = planos;
            this.soperos = soperos;
            this.platillos = platillos;
            this.precio = precio;
        }
        public override string ToString()
        {
            return "planos:" + planos + " soperos:" + soperos + " platillos:" + platillos + "precio" + precio;
        }
        public string getplanos()
        {
            return planos;
        }
        public void setplanos(string nombre)
        {
            this.planos = nombre;
        }
        public string getsoperos()
        {
            return soperos;
        }
        public void setsoperos(string nombre)
        {
            this.soperos = nombre;
        }
        public string getplatillos()
        {
            return platillos;
        }
        public void setplatillos(string nombre)
        {
            this.platillos = nombre;
        }





        public double getprecio()
        {
            return precio;
        }
        public void setprecio(double precio)
        {
            this.precio = precio;
        }
    }
}
