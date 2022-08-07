using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint number = 4;

            Console.WriteLine("\n Numero: " + number);
            Console.WriteLine("\n Resultado: " + sumSquares(number));
        }

        /// <summary>
        /// Realiza la suma de los cuadrados de los numeros de 0 a number 
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Resultado</returns>
        static uint sumSquares(uint number)
        {
            if (number == 0) return 0;

            else
            {
                return (uint)Math.Pow(number, 2) + sumSquares(number - 1);
            }
        }
    }
}
