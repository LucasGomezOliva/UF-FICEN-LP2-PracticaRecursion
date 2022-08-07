using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint numero = 2;
            Console.WriteLine("Numero:" + numero);
            Console.WriteLine("Cantidad de digitos:" + CantidadDigitos(numero));
        }

        /// <summary>
        /// Indica la cantidad de digitos de un numero
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Cantidad de digitos</returns>
        static uint CantidadDigitos(uint numero)
        {
            if(numero < 10) { return 1; }

            else
            {
                return 1 + CantidadDigitos(numero / 10);
            }
        }
    }
}
