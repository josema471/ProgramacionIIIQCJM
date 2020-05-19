using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial_2_de_jose_ejercicio_1
{
    abstract class FamiliaVaso
    {
        protected string wiskero;
        protected string champañero;
        protected string cervecero;
        double precio;

        public FamiliaVaso(string wiskero, string champañero, string cervecero ,double precio)
        {
            this.wiskero = wiskero;
            this.champañero = champañero;
            this.cervecero = cervecero;
            this.precio = precio;
        }
        public override string ToString()
        {
            return "wiskero:" + wiskero + " champañero:" + champañero + " cervecero:" + cervecero + "precio:" + precio;
        }
        public string getwiskero()
        {
            return wiskero;
        }
        public void setwiskero(string nombre)
        {
            this.wiskero = nombre;
        }
        public string getchampañero()
        {
            return champañero;
        }
        public void setchampañero(string nombre)
        {
            this.champañero = nombre;
        }
        public string getcervecero()
        {
            return cervecero;
        }
        public void setcervecero(string nombre)
        {
            this.cervecero = nombre;
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
