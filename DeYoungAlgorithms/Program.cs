using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DeYoungAlgorithms
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] arrayToSort = DataSets(GetInfo());
            int arraySize = arrayToSort.Length;
            int transactions, sortType;
            Stopwatch stopWatch = new Stopwatch();

            List<int> arrayToList = new List<int>();
            foreach (var item in arrayToSort)
            {
                arrayToList.Add(item);
            }

            #region BubbleSort
            stopWatch.Start();
            BubbleSort bubbleSort = new BubbleSort(arrayToList.ToArray());
            sortType = 1;
            transactions = bubbleSort.SortContents();
            stopWatch.Stop();
            TimeSpan timer = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
                timer.Minutes, timer.Seconds, timer.Milliseconds / 10);
            DisplayStatistics(sortType, elapsedTime, arraySize, transactions);
            #endregion

            #region SelectionSort
            stopWatch.Reset();
            stopWatch.Start();
            SelectionSort selectionSort = new SelectionSort(arrayToList.ToArray());
            sortType = 2;
            transactions = selectionSort.SortContents();
            stopWatch.Stop();
            timer = stopWatch.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
                timer.Minutes, timer.Seconds, timer.Milliseconds / 10);
            DisplayStatistics(sortType, elapsedTime, arraySize, transactions);
            #endregion

            #region InsertionSort
            stopWatch.Reset();
            stopWatch.Start();
            InsertionSort insertionSort = new InsertionSort(arrayToList.ToArray());
            sortType = 3;
            transactions = insertionSort.SortContents();
            stopWatch.Stop();
            timer = stopWatch.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
                timer.Minutes, timer.Seconds, timer.Milliseconds / 10);
            DisplayStatistics(sortType, elapsedTime, arraySize, transactions);
            #endregion

            #region MergeSort
            stopWatch.Reset();
            stopWatch.Start();
            MergeSort mergeSort = new MergeSort(arrayToList.ToArray());
            sortType = 4;
            transactions = mergeSort.SortContents(arrayToList.ToArray(), 0, (arraySize - 1));
            stopWatch.Stop();
            timer = stopWatch.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
                timer.Minutes, timer.Seconds, timer.Milliseconds / 10);
            DisplayStatistics(sortType, elapsedTime, arraySize, transactions);
            #endregion

            #region QuickSort
            stopWatch.Reset();
            stopWatch.Start();
            QuickSort quickSort = new QuickSort(arrayToList.ToArray());
            sortType = 5;
            transactions = quickSort.SortContents(arrayToList.ToArray(), 0, (arraySize - 1));
            stopWatch.Stop();
            timer = stopWatch.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
                timer.Minutes, timer.Seconds, timer.Milliseconds / 10);
            DisplayStatistics(sortType, elapsedTime, arraySize, transactions);
            #endregion

            Console.ReadKey();
        }

        static int GetInfo()
        {
            int input;
            Console.Write("How many numbers in the array? (100 - 100,000)  ");
            return input = Convert.ToInt32(Console.ReadLine());
        }

        static int[] DataSets(int input)
        {
            int possibleValue, arrayCreator = 0, min = 1;
            Random rndNum = new Random();
            int[] numbers = new int[input];

            List<int> values = new List<int>();
            for (int i = 1; i <= input; i++)
            {
                values.Add(i);
            }

            while (arrayCreator < numbers.Length)
            {
                possibleValue = rndNum.Next(min, input + 1);

                if (values.Contains(possibleValue))
                {
                    numbers[arrayCreator] = possibleValue;
                    values.Remove(possibleValue);
                    arrayCreator++;
                }
            }

            return numbers;

        }

        static void DisplayStatistics(int sortChoice, string time, int term, int transactionAmount)
        {
            string sort = "";
            switch (sortChoice)
            {
                case 1:
                    sort = "Bubble Sort";
                    break;
                case 2:
                    sort = "Selection Sort";
                    break;
                case 3:
                    sort = "Insertion Sort";
                    break;
                case 4:
                    sort = "Merge Sort";
                    break;
                case 5:
                    sort = "Quick Sort";
                    break;

                default:
                    break;
            }
            Console.WriteLine("\nIt took the {0} {1} seconds to sort {2} values with {3} transactions.",
                sort, time, term, transactionAmount);
        }

    }
}
