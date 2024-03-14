using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Array
{
    public class MajorityElement_II
    {


        //Given an integer array of size n, find all elements that appear more than ⌊ n/3 ⌋ times.

        //Example 1:

        //Input: nums = [3,2,3]
        //        Output: [3]

        //        Example 2:
        //Input: nums = [1]
        //        Output: [1]
       
        //        Example 3:
        //Input: nums = [1,2]
        //        Output: [1,2]

        public static void Solution(int[] nums)
        {
            List<int> output = NaiveSolution(nums);

            foreach (var num in output)
            {
                Console.Write(num + ", ");
            }
        }

        // Time: O(2n)
        // Space: O (n)
        private static List<int> NaiveSolution(int[] nums)
        {
            var n = nums.Length;
            var dict = new Dictionary<int, int>();
            var output = new List<int>();

            for (int i = 0; i < n; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], 1);
                }
                else
                {
                    dict[nums[i]] += 1;

                }
            }

            foreach (var key in dict.Keys)
            {
                var count = dict[key];
                if (count > n / 3) output.Add(key);
            }
            return output;
        }

        // Time: O(nlogn + n)
        // space: O(1)
        private static List<int> ImprovedSolution(int[] nums)
        {
            var n = nums.Length;
            System.Array.Sort(nums);
            var output = new List<int>();
            var count = 1;
            for (int i = 1; i < n; i++)
            {
                if (nums[i] == nums[i - 1]) count++;
                else
                {
                    if (count > n / 3)
                    {
                        output.Add(nums[i - 1]);
                    }
                    count = 1;
                }

            }
            if (count > n / 3)
            {
                output.Add(nums[n - 1]);
            }
            return output;
        }

        private static List<int> OptimalSolution(int[] nums)
        {
            // we need to find number of elements who are more than n/3.
            // means we need to find the element who are more than 33%.
            // therefore at max two elements can exists in an array who has more than n/3 frequency.
            var n = nums.Length;
            var count1 = 0;
            var count2 = 0;

            var el1 = int.MinValue;
            var el2 = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                if (count1 == 0 && el2 != nums[i])
                {
                    count1++;
                    el1 = nums[i];
                }
                else if (count2 == 0 && el1 != nums[i])
                {
                    count2++;
                    el2 = nums[i];
                }
                else if (el1 == nums[i]) count1++;
                else if (el2 == nums[i]) count2++;
                else
                {
                    count1--;
                    count2--;
                }
            }

            count1 = 0;
            count2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] == el1) count1++;
                else if (nums[i] == el2) count2++;

            }
            List<int> output = new List<int>();
            if (count1 > n / 3) output.Add(el1);
            if (count2 > n / 3) output.Add(el2);
            return output;
        }
    }
}
