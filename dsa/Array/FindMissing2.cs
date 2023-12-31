﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class FindMissing2
    {
        public static void Solution(int[] nums)
        {
            // given element will be from 1 to n
            // and total size of array will be n + 1 ;
            for (int i = 0; i < nums.Length; i++)
            {
                int indexToVisit = Math.Abs(nums[i]);
                if (nums[indexToVisit - 1] > 0)
                {
                    nums[indexToVisit - 1] *= -1;
                }
            }

            PrintArray.Print(nums);
        }
    }
}
