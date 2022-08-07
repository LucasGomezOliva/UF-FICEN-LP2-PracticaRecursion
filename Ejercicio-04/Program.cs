using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena = "neuquen";
            Console.WriteLine("La palabra: " + cadena + Palindromo(cadena));
        }

        /// <summary>
        /// Indica si una cadena es o no un palindromo
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        static string Palindromo(string cadena) {
            if (cadena == InvertirRecursivo(cadena))
                return "\nEs palindromo";
            else
                return "\nNo es palindromo";
        }
        /// <summary>
        /// Invierte una cadena de caracteres
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns>Cadena de caracteres ivertida</returns>
        static string InvertirRecursivo(string cadena)
        {
            uint pos = (uint)cadena.Length - 1;
            if (pos == 0)
            {
                return cadena;
            }
            else
            {
                return cadena[(int)pos] + InvertirRecursivo(cadena.Remove((int)pos));
            }
        }
    }
}
