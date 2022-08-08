using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3};

            Console.WriteLine(SumaArray(array, array.Length - 1));

        }

        /// <summary>
        /// Realiza la suma de lementos del array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        static int SumaArray(int[] array,int index)
        {
            if(index<0){return 0; }
            else
            {
                return array[index] + SumaArray(array, index - 1);
            }
        }
    }
}
