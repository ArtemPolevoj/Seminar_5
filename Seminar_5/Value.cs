using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_5
{
    internal class Value
    {
        public static int getInt(string str)
        {
            int number = 0;
        checkNumber:
            Console.WriteLine(str);
            string strNumber = Console.ReadLine();
            try
            {
                number = int.Parse(strNumber);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Ввели не целое число или не верный формат числа.");
                goto checkNumber;
            }
            catch (OverflowException ofe)
            {
                Console.WriteLine("Ввели большое число.");
                goto checkNumber;
            }

            return number;
        }

        public static int[] getArray()
        {
            int lengthArray = Value.getInt("Введите длинну массива");
            if (lengthArray <= 0)
            {
                Console.WriteLine("Ввели не правильную длинну массива");
                lengthArray = Value.getInt("Введите длинну массива");
            }

            int minValue = Value.getInt("Введите минимальное значение массива");
            int mахValue = Value.getInt("Введите максимальное значение массива");

            Random rnd = new Random();
            int[] array = new int[lengthArray];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(minValue, mахValue);
            }
            return array;
        }
    }
}
