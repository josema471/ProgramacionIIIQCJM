using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gimnasioservidor
{
    class atleta
    {
        double precio;
        string nombre;
        Sexo sexo;
        double edad;
        double peso;
        double altura;

        public atleta(double precio, string nombre, Sexo sexo, double edad, double peso, double altura)
        {
            this.precio = precio;
            this.nombre = nombre;
            this.sexo = sexo;
            this.edad = edad;
            this.peso = peso;
            this.altura = altura;
        }
        public double getprecio()
        {
            return precio;
        }
        public void setprecio(double precio)
        {
            this.precio = precio;
        }
        public string getnombre()
        {
            return nombre;
        }
        public void setnombre(string nombre)
        {
            this.nombre = nombre;
        }
        public Sexo getsexo()
        {
            return sexo;
        }
        public void setSexo(Sexo sexo)
        {
            this.sexo = sexo;
        }
        public double getedad()
        {
            return edad;
        }
        public void setedad(double edad)
        {
            this.edad = edad;
        }
        public double getpeso()
        {
            return peso;
        }
        public void setpeso(double peso)
        {
            this.peso = peso;
        }
        public double getaltura()
        {
            return altura;
        }
        public void setaltura(double altura)
        {
            this.altura = altura;
        }
        public override string ToString()
        {
            return "precio: " + precio + "  nombre:" + nombre + "  sexo:" + sexo + "  edad:" + edad + "  peso:" + peso + "  altura:" + altura;
        }




    }
    enum Sexo
    {
        Masculino, Femenino
    }
}
