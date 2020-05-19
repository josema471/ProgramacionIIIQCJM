using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial_2_de_jose
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductoSimple carne  = new ProductoSimple("Precio de la carne", 30);
            ProductoSimple papa = new ProductoSimple("precio de la papa", 20 );
            ProductoSimple lechuga = new ProductoSimple("precio de la lechuga", 10);


            ProductoCompuesto ComboFamiliar = new ProductoCompuesto("precio del combo familiar");
            ComboFamiliar.insertarProducto(carne);
            ComboFamiliar.insertarProducto(papa);
            


            OrdenDeCompra compra1 = new OrdenDeCompra(1, "RUTH SALVA");
            compra1.insertarProducto(carne);
            compra1.insertarProducto(carne);
            compra1.insertarProducto(carne);
            compra1.insertarProducto(carne);
            compra1.insertarProducto(carne);
            compra1.imprimirOrden();

            OrdenDeCompra compra2 = new OrdenDeCompra(2, "NICK FERNANDEZ");
            compra2.insertarProducto(ComboFamiliar);
            compra2.insertarProducto(lechuga);
            compra2.insertarProducto(carne);
            compra2.imprimirOrden();

      

            Console.ReadKey();
        }
    }
}
