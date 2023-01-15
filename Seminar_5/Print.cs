using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_5
{
    internal class Print
    {
        public static void array(int[] arr)
        {
            Console.Write("Полученный массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    Console.Write(arr[i] + ".");
                }
                else
                {
                    Console.Write(arr[i] + ", ");
                }
            }
            Console.WriteLine();
        }
    }
}
