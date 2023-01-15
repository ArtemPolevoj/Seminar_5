using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_5
{
    internal class Difference
    {
        public static void minMax(int[] array)
        {
            Print.array(array);
            int min = array[0];
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
                else if (array[i] < min) min = array[i];
            }

            Console.WriteLine("Разница между минимальным и максимальными значениями массива = " + (max - min));
        }
    }
}
