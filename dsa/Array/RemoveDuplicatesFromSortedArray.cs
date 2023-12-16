using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml;
using System.Xml.Linq;

namespace Array
{
    public class RemoveDuplicatesFromSortedArray
    {
        //Given an integer array nums sorted in non-decreasing order,
        //remove the duplicates in-place such that each unique element appears
        //only once.
        //The relative order of the elements should be kept the same.
        //Then return the number of unique elements in nums.

        //Consider the number of unique elements of nums to be k,
        //to get accepted, you need to do the following things:

        //Change the array nums such that the first k elements of nums
        //contain the unique elements in the order they were present in
        //nums initially.The remaining elements of nums are not important
        //as well as the size of nums.
        //Return k.
        //Input: nums = [0,0,1,1,1,2,2,3,3,4]
        //Output: 5, nums = [0,1,2,3,4, _, _, _, _, _]
        //Explanation: Your function should return k = 5,
        //with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
        //It does not matter what you leave beyond the returned k(hence they are underscores).

        public static void Solution(int[] nums)
        {
            //Solution1(nums);
            Solution2(nums);
        }

        private static void Solution1(int[] nums)
        {
            var tempList = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    tempList.Add(nums[i]);
                    continue;
                }
                else if (nums[i] != nums[i - 1])
                {
                    tempList.Add(nums[i]);
                }
            }

            for (int j = 0; j < tempList.Count; j++)
            {
                nums[j] = tempList[j];
            }

            Console.Write(tempList.Count + " ");
            PrintArray.Print(nums);
        }

        private static void Solution2(int[] nums)
        {
            int i = 0;
            int j = i + 1;
            var k = 0;

            while (j < nums.Length)
            {
                if (nums[i] != nums[j])
                {
                    k++;
                    i += 1;
                    nums[i] = nums[j];
                   
                }
                j++;
            }

            Console.Write(k + 1);
        }

        private static void Solution3(int[] nums)
        {
            int j = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[j - 1] != nums[i])
                {
                    nums[j] = nums[i];
                    j++;
                }
            }
            Console.Write(j);
        }
    }
}
