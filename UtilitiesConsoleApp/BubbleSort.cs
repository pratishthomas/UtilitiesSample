using System;
using System.Collections.Generic;
using System.Text;

namespace UtilitiesConsoleApp
{
    class BubbleSort
    {
       
      public  static int[] SortUsingBubbleSort(int[] numbers)
        {
            int temp;
            int arrayLength = numbers.Length;
            for (int j = 0; j < arrayLength - 1; j++)
            {
                for (int i = 0; i < arrayLength - j - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                    }
                }
            }

            return numbers;
        }

    }
}
