using System;
using System.Collections.Generic;

namespace UtilitiesConsoleApp
{
    delegate void MyDelegate();
    delegate bool RunThroughGauntlet(int number);
    class Program
    {
        static bool GetNumbersLessThanFive(int x) { return x < 5; }
        static bool GetNumbersLessThanTen(int x) { return x < 10; }
        static bool GetNumbersGreaterThanNine(int x) { return x > 9; }
        static void Main(string[] args)
        {
            RunOldTopics();

            Console.Read();
        }

        private static void RunOldTopics()
        {
            int[] numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            InvokeDelegatesBySendingMethods(numbers);
            RunLambdaExpression(numbers);
            int[] numbersArray = new int[] { 5, 2, 1, 6, 4, 3, 9, 8 };
            SelectionSort(numbersArray);
            BubbleSort(numbersArray);
        }

        private static void BubbleSort(int[] numbersArray)
        {
            Console.WriteLine("---------Bubble Sort-----------");
            foreach (int number in UtilitiesConsoleApp.BubbleSort.SortUsingBubbleSort(numbersArray))
            {
                Console.WriteLine(number);
            }
        }

        private static void SelectionSort(int[] numbersArray)
        {
            Console.WriteLine("---------Selection Sort-------");
            foreach (int number in UtilitiesConsoleApp.SelectionSort.SortUsingSelectionSort(numbersArray))
            {
                Console.WriteLine(number);
            }
        }

        private static void RunLambdaExpression(int[] numbers)
        {
            Console.WriteLine("-----------Running Lambda Expressions---------------");
            IEnumerable<int> result2 = RunNumbersThroughGauntlet(numbers, n => n > 11);
            foreach (int number in result2)
            {
                Console.WriteLine(number);
            }
        }

        private static void InvokeDelegatesBySendingMethods(int[] numbers)
        {
            IEnumerable<int> result = RunNumbersThroughGauntlet(numbers, GetNumbersGreaterThanNine);
            Console.WriteLine("------------Invoking Delegate by sending methods-----------");
            foreach (int number in result)
            {
                Console.WriteLine(number);
            }
        }

        static IEnumerable<int> RunNumbersThroughGauntlet(IEnumerable<int> numbers, RunThroughGauntlet gauntlet)
        {
            foreach (int number in numbers)
            {
                if (gauntlet(number))
                    yield return number;
            }
        }

        static IEnumerable<int> GetAllNumberLessThanFive(IEnumerable<int> numbers)
        {
            foreach (int number in numbers)
            {
                if (number < 5)
                    yield return number;
            }
        }

        static IEnumerable<int> GetAllNumbersGreaterThanTen(IEnumerable<int> numbers)
        {
            foreach (int number in numbers)
            {
                if (number > 10)
                    yield return number;
            } 
        }
    }
}
