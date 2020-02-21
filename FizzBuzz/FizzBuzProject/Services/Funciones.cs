using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzProject.Services
{
    public class Funciones
    {
        public string contruirCadena(string parametro1)
        {
            return parametro1 + ", ";
        }
        public static int calculadora(int mod, int numIntroducido)
        {
            return numIntroducido % mod;
        }
        public string comprobacionUltimoCaracter(string cadena)
        {
            if (cadena.EndsWith(", ") || cadena.EndsWith(','))
            {
                return cadena.TrimEnd().Remove(cadena.Length-2);
            }
            else
            {
                return cadena;
            }
        }
    }
}
