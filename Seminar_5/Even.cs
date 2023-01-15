using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_5
{
    internal class Even
    {
        public static void getCount(int[] array)
        {
            Print.array(array);
            int count = 0;
            foreach (var i in array)
            {
                if (i % 2 == 0) count++;
            }
            Console.WriteLine("Количество чётных чисел в массиве = " + count);
        }
    }
}
