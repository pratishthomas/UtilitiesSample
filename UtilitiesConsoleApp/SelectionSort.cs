using System;
using System.Collections.Generic;
using System.Text;

namespace UtilitiesConsoleApp
{
    class SelectionSort
    {

      public static int[] SortUsingSelectionSort( int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int minimum = numbers[i];
                                
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < minimum)
                    {
                        minimum = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = minimum;
                    }
                        
                }
                numbers[i] = minimum;
            }
            return numbers;
        }
        
    }
}
