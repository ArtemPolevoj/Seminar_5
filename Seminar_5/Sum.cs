using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_5
{
    internal class Sum
    {
        public static void getOddPosition(int[] array)
        {
            Print.array(array);
            int result = 0;
            for (int i = 1; i < array.Length; i = i + 2)
            {
                result = result + array[i];
            }
            Console.WriteLine("Сумма чисел на нечётных позициях в массиве = " + result);
        }
    }
}
