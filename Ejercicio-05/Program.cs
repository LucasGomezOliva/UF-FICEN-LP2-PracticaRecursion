using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena = "aaeeytg";

            Console.WriteLine("\n Cadena: " + cadena);
            Console.WriteLine("\n Cantidad de vocales: " + Vocales(cadena));
        }

        /// <summary>
        /// Busca las vocales de un string
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns>Cantidad de vocales</returns>
        static int Vocales(string cadena)
        {
            int pos = cadena.Length - 1;

            if(pos < 0) { return 0; }
            else
            {
                if (
                cadena[pos] == 'a' ||
                cadena[pos] == 'e' ||
                cadena[pos] == 'i' ||
                cadena[pos] == 'o' ||
                cadena[pos] == 'u')
                {

                    return 1 + Vocales(cadena.Remove(pos));

                }
                else return Vocales(cadena.Remove(pos));
            }
            
        }
    }
}
