using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class SelectionSort
    {
        public static void Sort(int[] nums)
        {
            PrintArray.Print(Solution(nums));
        }

        private static int[] Solution(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int minIndex = -1;
                int minValue = int.MaxValue;

                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[j] < minValue)
                    {
                        minValue = nums[j];
                        minIndex = j;
                    }
                }
                if (minIndex > -1) // checking if array is already sorted
                    (nums[i], nums[minIndex]) = (nums[minIndex], nums[i]);
            }
            return nums;
        }
    }
}
