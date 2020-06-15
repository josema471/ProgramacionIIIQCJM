using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace aplicaciongimnasiopastel
{
    class atleta
    {
        string precio;
        string nombre;
        Sexo sexo;
        string edad;
        string peso;
        string altura;

        public atleta(string precio, string nombre, Sexo sexo, string edad, string peso, string altura)
        {
            this.precio = precio;
            this.nombre = nombre;
            this.sexo = sexo;
            this.edad = edad;
            this.peso = peso;
            this.altura = altura;
        }
        public string getprecio()
        {
            return precio;
        }
        public void setprecio(string precio)
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
        public string getedad()
        {
            return edad;
        }
        public void setedad(string edad)
        {
            this.edad = edad;
        }
        public string getpeso()
        {
            return peso;
        }
        public void setpeso(string peso)
        {
            this.peso = peso;
        }
        public string getaltura()
        {
            return altura;
        }
        public void setaltura(string altura)
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
