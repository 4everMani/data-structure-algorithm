﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class FirstOccurrenceInSortedArray
    {
        public static int Solution(int[] nums, int target)
        {
            return Improved(nums, target);
        }

        private static int BruteForce(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    Console.WriteLine(i);
                    return i;
                }
            }
            Console.WriteLine(-1);
            return -1;
        }

        private static int Improved(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            int firstOccuranceIndex = -1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    firstOccuranceIndex = mid;
                    right = mid - 1;
                    
                }

                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }

                else
                {
                    right = mid - 1;
                }
            }
            Console.WriteLine(firstOccuranceIndex);
            return firstOccuranceIndex;
        }
    }
}
