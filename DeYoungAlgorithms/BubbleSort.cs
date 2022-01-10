using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeYoungAlgorithms
{
    class BubbleSort
    {
        int[] array;
        int transactionCount = 0;

        public BubbleSort(int[] numbers)
        {
            array = numbers;   
        }
            

        public int SortContents()
        {
            int temp = 0;

            for (int iteration = 0; iteration < array.Length; iteration++)
            {
                for (int sort = 0; sort < array.Length - 1; sort++)
                {
                    if (array[sort] > array[sort + 1])
                    {
                        temp = array[sort + 1];
                        array[sort + 1] = array[sort];
                        array[sort] = temp;
                        transactionCount++;
                    }
                }
            }
            return transactionCount;




        }
       
    }
}
