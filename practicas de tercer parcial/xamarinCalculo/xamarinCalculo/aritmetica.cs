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

namespace xamarinCalculo
{
    class aritmetica
    {
        public double sumar(int a, int b)
        {
            return a + b;
        }
        public double restar(int a, int b)
        {
            return a - b;
        }
        public double multiplicar(int a, int b)
        {
            return a * b;
        }
        public double dividir(int a, int b)
        {
            return a / b;
        }
        public double raiz(int a, int b)
        {
            return Math.Pow(a, 1 / b);
        }
        public double potencia(int a, int b)
        {
            return Math.Pow(a, b);
        }
    }
}