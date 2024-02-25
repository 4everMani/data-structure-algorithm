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

            // var result = NaiveSolution(nums, target);
            var result = BetterSolution(nums, target);

            Console.WriteLine($"{result[0]}, {result[1]}");
        }
    
        // Time: O(n^2)
        // Space: O(1)
        private static int[] NaiveSolution(int[] nums, int target)
        {
            var output = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        output[0] = nums[i];
                        output[1] = nums[j];
                        return output;
                    }
                }
            }
            return output;
        }  


        // Time: O(n)
        // Space: O(n)
        private static int[] BetterSolution(int[] nums, int target)
        {
            var output = new int[2];
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];
                if (dict.ContainsKey(diff))
                {
                    output[0] = dict[diff];
                    output[1] = i;
                    return output;
                }
                else if(!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }
            
            return output;
        }     
    
    
        // This solution will work when we requires elements instead of index
        // because this method requires sorting which will not work for index;
        // Time: O(nlogn) + O(n)
        // Space: O(1)
        private static int[] OptimalSolution(int[] nums, int target)
        {
            var output = new int[2];
            var i = 0;
            var j = nums.Length - 1;
            // Array.Sort(nums);
            while(i < j)
            {
                if (nums[i] + nums[j] == target)
                {
                    output[0] = nums[i];
                    output[1] = nums[j];
                    return output;
                }
                else if(nums[i] + nums[j] > target)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }
            return output;
        }
    }
}
