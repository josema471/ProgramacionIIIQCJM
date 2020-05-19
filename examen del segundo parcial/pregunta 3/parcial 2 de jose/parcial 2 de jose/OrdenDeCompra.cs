﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace parcial_2_de_jose
{
    class OrdenDeCompra
    {
        private long idOrden;
        private String cliente;
        private Calendar fecha;
        private List<AbstractProducto> listaProductos;

        public OrdenDeCompra(long idOrden, string cliente)
        {
            this.idOrden = idOrden;
            this.cliente = cliente;
            listaProductos = new List<AbstractProducto>();
            //fecha = Calendar.;
        }

        public long getidOrden()
        {
            return idOrden;
        }

        public void setidOrden(long idOrden)
        {
            this.idOrden = idOrden;
        }

        public String getCliente()
        {
            return cliente;
        }

        public void setCliente(String cliente)
        {
            this.cliente = cliente;
        }

        public Calendar getFecha()
        {
            return fecha;
        }

        public void setDateTime(Calendar fecha)
        {
            this.fecha = fecha;
        }

        public List<AbstractProducto> getProductos()
        {
            return listaProductos;
        }

        public void setProductos(List<AbstractProducto> listaproductos)
        {
            this.listaProductos = listaproductos;
        }

        public double getPrecio()
        {

            double precio = 0;
            foreach (AbstractProducto producto in listaProductos)
            {
                precio += producto.getPrecio();
            }
            return precio;
        }

        public void insertarProducto(AbstractProducto producto)
        {
            listaProductos.Add(producto);
        }

        public void eliminarProducto(AbstractProducto producto)
        {
            listaProductos.Remove(producto);
        }

        public void imprimirOrden()
        {

            Console.WriteLine("Orden #: " + idOrden + "                               CLIENTE: " + cliente);
            foreach (AbstractProducto producto in listaProductos)
            {

                Console.WriteLine("{0}        {1}", producto.getNombre(), producto.getPrecio());

            }
            Console.WriteLine("Total de la compra realizada en el supermercado: {0} ", getPrecio());
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}
