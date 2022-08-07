using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 1234;
            Console.WriteLine(InvertirRecursivo(numero, CantidadDigitos(numero)-1));
           // InvertirNoRecursivo();
            //InvertirNoRecursivo();
        }

        /// <summary>
        /// 
        /// </summary>
        static int InvertirRecursivo(int num, int pos)
        {
            if (num < 10){
                return num;
            }
            else{
                return num % 10 * (int)Math.Pow(10, pos) + InvertirRecursivo(num / 10, pos - 1);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        static void InvertirNoRecursivo(int numero)
        {

        }

        static int CantidadDigitos(int numero)
        {
            if (numero < 10) { return 1; }

            else
            {
                return 1 + CantidadDigitos(numero / 10);
            }
        }
    }
}
