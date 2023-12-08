using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class TwoSum
    {

        //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

        //You may assume that each input would have exactly one solution, and you may not use the same element twice.

        //You can return the answer in any order.

        //Input: nums = [2,7,11,15], target = 9
        //Output: [0,1]

        public static void Solution(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                int pointer = i + 1;

                while (pointer < nums.Length)
                {
                    if (nums[pointer] + nums[i] == target)
                    {
                        Console.WriteLine(i + "," + pointer);
                        break;
                    }
                    pointer++;
                } 
            }
        }
    }
}
