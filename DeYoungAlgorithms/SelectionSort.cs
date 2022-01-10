using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeYoungAlgorithms
{
    class SelectionSort
    {

        int[] array;
        int transactionCount = 0;

        public SelectionSort(int[] numbers)
        {
             array = numbers;

        }


        public int SortContents()
        {
            int temp = 0;

            int min_position;

            for (int i = 0; i < array.Length - 1; i++)
            {
                min_position = i;

                for (int nextValue = i + 1; nextValue < array.Length; nextValue++)
                {
                    if (array[nextValue] < array[min_position])
                    {
                        min_position = nextValue;
                    }
                }

                if (min_position != i)
                {
                    temp = array[i];
                    array[i] = array[min_position];
                    array[min_position] = temp;
                    transactionCount++;
                }
            }

            return transactionCount;
        
           




        }
    }
}
