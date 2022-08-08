using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint A_n = 5;
            uint A_r = 3;

            Console.WriteLine("C({0},{1}) = " + Combinatorio(A_n, A_r), A_n, A_r);

            uint B_n = 9;
            uint B_r = 4;

            Console.WriteLine("C({0},{1}) = " + Combinatorio(B_n, B_r), B_n, B_r);
        }

        /// <summary>
        /// Las combinaciones de n elementos tomados de r en r
        /// </summary>
        /// <param name="n">Conjunto n</param>
        /// <param name="r">Elementos r</param>
        /// <returns>Combinaciones</returns>
        static uint Combinatorio(uint n, uint r)
        {
            if (r == 0) { return 1; }

            if (n == 0) { return 0; }

            else
            {
                return Combinatorio(n - 1, r - 1) + Combinatorio(n - 1, r);
            }
        }
    }
}
