using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial_2_de_jose
{
    class ProductoSimple : AbstractProducto
    {


        public ProductoSimple(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;

        }

        public override double getPrecio()
        {
            return this.precio;
        }


    }
}
