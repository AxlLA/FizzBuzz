using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using FizzBuzProject.Services;
using Microsoft.Extensions.Configuration;

namespace FizzBuzProject.Models
{
    public class FizzBuzz : ControllerBase
    {
        string fizz;
        string buzz;
        private static IConfiguration _config;
        static int maxValue;

        public FizzBuzz(IConfiguration configuration)
        {
            this.fizz = "Fizz";
            this.buzz = "Buzz";
            _config = configuration;
            maxValue = MaxValue();

            
        }

        public FizzBuzz(int maxValueParam)
        {
            this.fizz = "Fizz";
            this.buzz = "Buzz";
            maxValue = maxValueParam;
        }

        public string fizzBuzz(int numIntroducido)
        {
            Funciones funciones = new Funciones();
            string cadenaRetorno = String.Empty;
            
            for (int i=numIntroducido;i < maxValue ; i++)
            {
                switch (checkFizzBuzz(i))
                {
                    case 1:
                        cadenaRetorno += funciones.contruirCadena(getBuzz());
                        break;
                    case 2:
                        cadenaRetorno += funciones.contruirCadena(getFizz());
                        break;
                    case 3:
                        cadenaRetorno += funciones.contruirCadena(getFizzBuzz());
                        break;
                    default:
                        cadenaRetorno += funciones.contruirCadena(i.ToString());
                        break;
                }
            }
            cadenaRetorno = funciones.comprobacionUltimoCaracter(cadenaRetorno);
           LogFileService.LogFile(cadenaRetorno);
            return cadenaRetorno;
        }

        

        public string getFizzBuzz()
        {
            return this.fizz +""+ this.buzz;
        }

        public string getFizz()
        {
            return this.fizz;
        }

        public string getBuzz()
        {
            return this.buzz;
        }

        public static int checkFizzBuzz(int numIntroducido)
        {
            int numBandera = 0;
            if (numIntroducido >= 0 && numIntroducido <= maxValue)
            {
                if (Funciones.calculadora(3,numIntroducido) == 0 && Funciones.calculadora(5,numIntroducido) == 0)
                {
                    numBandera = 3;
                }else if (Funciones.calculadora(3,numIntroducido) == 0)
                {
                    numBandera = 2;
                }else if (Funciones.calculadora(5, numIntroducido) ==0)
                {
                    numBandera = 1;
                }else
                {
                    numBandera = 0;
                }
            }
            return numBandera;
        }

        public static int MaxValue()
        {

            string maxValue = _config.GetSection("MaxValue").Value;

            return  Int32.Parse(maxValue);
            
        }
    }
}