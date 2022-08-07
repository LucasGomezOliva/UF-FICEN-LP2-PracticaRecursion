using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena = "Hola cadena";
            Console.WriteLine("\n Cadena: " + cadena);
            Console.WriteLine("\n Caracteres: " + cadena.Length);

            //Funcion recursiva
            cadena = InvertirRecursivo(cadena);
            Console.WriteLine(cadena);
            
            //Funcion NO recursva
            cadena = Invertir(cadena); 
            Console.WriteLine(cadena);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns>Cadena invertida</returns>
        static string InvertirRecursivo(string cadena)
        {
            uint pos = (uint)cadena.Length - 1;
            if (pos == 0) { 
                return cadena;
            }
            else
            {
                return cadena[(int)pos] + InvertirRecursivo(cadena.Remove((int)pos));
            }
        }

        /// <summary>
        /// Invierte una cadena de caracteres usando Array
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns>Cadena invertida</returns>
        static string Invertir(string cadena)
        {
            char[] charArray = cadena.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}
