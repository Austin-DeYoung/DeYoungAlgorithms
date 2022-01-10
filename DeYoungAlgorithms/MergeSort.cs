using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeYoungAlgorithms
{
    class MergeSort
    {
        int[] array;
        int transactionCount = 0;

        public MergeSort(int[] numbers)
        {
            array = numbers;
        }


        public int SortContents(int[] sortArray, int left, int right)
        {
            int mid;

            if (right > left)
            {

                mid = (right + left) / 2;
                SortContents(sortArray, left, mid);
                SortContents(sortArray, (mid + 1), right);

                DoMerge(array, left, (mid + 1), right);
                
            }
            
            return transactionCount;

        }

        public void DoMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[numbers.Length];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];

            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];

            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
            transactionCount++;
        }
    }
}
