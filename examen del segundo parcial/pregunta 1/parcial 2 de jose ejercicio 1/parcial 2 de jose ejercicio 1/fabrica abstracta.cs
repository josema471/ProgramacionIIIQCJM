using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial_2_de_jose_ejercicio_1
{
    interface fabricaAbstracta
    {
        FamiliaPlatos getFamiliaPlatos(string planos, string soperos, string platillos, double precio);
        FamiliaVaso getFamiliaVaso(string wiskero, string champañero, string cervecero, double precio);
        

    }
}
