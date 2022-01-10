using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeYoungAlgorithms
{
    class InsertionSort
    {
        int[] array;
        int transactionCount = 0;

        public InsertionSort(int[] numbers)
        {
            array = numbers;
        }


        public int SortContents()
        {
            for (int index = 0; index < array.Length - 1; index++)
            {
                int value = index + 1;

                while (value > 0)
                {
                    if (array[value - 1] > array[value])
                    {
                        transactionCount++;
                        int temp = array[value - 1];
                        array[value - 1] = array[value];
                        array[value] = temp;

                    }
                    value--;
                }
            }


            return transactionCount;

        }
    }
}
