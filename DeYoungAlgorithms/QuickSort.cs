using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeYoungAlgorithms
{
    class QuickSort
    {
        int[] array;
        int transactionCount = 0;

        public QuickSort(int[] numbers)
        {
            array = numbers;
        }


        public int SortContents(int[] sortArray, int left, int right)
        {
            if (left < right)
            {
                int pivot = DoQuickSort(sortArray, left, right);

                if (pivot > 1)
                    SortContents(sortArray, left, pivot - 1);

                if (pivot + 1 < right)
                    SortContents(sortArray, pivot + 1, right);
            }
            return transactionCount;

        }

        public int DoQuickSort(int[] numbers, int left, int right)
        {
            transactionCount++;
            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                    left++;

                while (numbers[right] > pivot)
                    right--;

                if (left < right)
                {
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
