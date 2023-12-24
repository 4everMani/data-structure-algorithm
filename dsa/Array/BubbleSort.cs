using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class BubbleSort
    {
        public static void Sort(int[] nums)
        {
            PrintArray.Print(Solution(nums));
        }

        private static int[] Solution(int[] nums)
        {
            //for (int i = nums.Length - 1; i > 0; i--)
            //{
            //    for (int j = 0; j <= i -1; j++)
            //    {
            //        if (nums[j] > nums[j + 1])
            //            (nums[j], nums[j+1]) = (nums[j + 1], nums[j]);
            //    }
            //}
            int arrLength = nums.Length;
            for (int i = 0; i < arrLength - 1; i++)
            {
                for (int j = 0; j < arrLength - i - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                        (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
                }
            }
            return nums;
        }
    }
}
