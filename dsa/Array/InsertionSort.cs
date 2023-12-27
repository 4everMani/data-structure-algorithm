using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class InsertionSort
    {
        public static void Sort(int[] nums)
        {
            PrintArray.Print(SortImplementation(nums));
        }

        private static int[] SortImplementation(int[] nums)
        {
            for (int i = 1; i <nums.Length; i++)
            {
                int key = nums[i];
                int j = i - 1;

                while (j >= 0 && nums[j] > key)
                {
                    nums[j + 1] = nums[j];
                    j--;
                }
                nums[j + 1] = key;
            }

            return nums;
        }
    }
}
