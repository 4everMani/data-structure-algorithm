using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class ThreeSum
    {
        //Given an integer array nums, return all the triplets[nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

        //Notice that the solution set must not contain duplicate triplets.



        //Example 1:
        //Input: nums = [-1, 0, 1, 2, -1, -4]
        //Output: [[-1,-1,2], [-1,0,1]]
        //Explanation: 
        //nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
        //nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
        //nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
        //The distinct triplets are[-1, 0, 1] and[-1, -1, 2].
        //Notice that the order of the output and the order of the triplets does not matter.
        
        //Example 2:
        //Input: nums = [0, 1, 1]
        //Output: []
        //Explanation: The only possible triplet does not sum up to 0.
        
        //Example 3:
        //Input: nums = [0, 0, 0]
        //Output: [[0,0,0]]
        //Explanation: The only possible triplet sums up to 0.

        public static void Solution(int[] nums)
        {
            //IList<IList<int>> result = NaiveSolution(nums);
            //IList<IList<int>> result = BetterSolution(nums);
            IList<IList<int>> result = OptimalSolution(nums);

            foreach (var item in result)
            {
                foreach(var num in item)
                {
                    Console.Write(num + ", ");
                }
                Console.WriteLine();
            }
        }

        // Time: O(n^3)
        // Space: O(2 * no. of triplet)
        private static IList<IList<int>> NaiveSolution(int[] nums)
        {
            var n = nums.Length;
            var output = new List<IList<int>>();
            var set = new HashSet<string>();
            for (int  i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        var sum = nums[i] + nums[j] + nums[k];
                        if (sum == 0)
                        {
                            var tempList = new List<int> { nums[i], nums[j], nums[k] }.Order().ToList();
                            var tempString = string.Empty;
                            foreach(var num in tempList)
                            {
                                tempString += num;
                            }
                            if (!set.Contains(tempString))
                            {
                                output.Add(tempList);
                                set.Add(tempString);
                            }
                        }
                    }

                }
            }

            return output;
        }
    
        // Time: O(n^2)
        // Space: O(2 * no. of triplets) + O(n)
        private static IList<IList<int>> BetterSolution(int[] nums)
        {
            var n = nums.Length;
            var output = new List<IList<int>>();
            var uniqueNum = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var set = new HashSet<int>();
                for (int j = i + 1; j < n; j++)
                {
                    var num = (nums[i] + nums[j]) * -1;
                    
                    if (!set.Contains(num)) set.Add(nums[j]);
                    else
                    {
                        set.Add(num);
                        var tempList = new List<int> { nums[i], nums[j], num }.Order().ToList();
                        var tempString = string.Empty;
                        foreach (var item in tempList)
                        {
                            tempString += item;
                        }
                        if (!uniqueNum.Contains(tempString))
                        {
                            output.Add(tempList);
                            uniqueNum.Add(tempString);
                        }
                    }
                    
                }
            }
            return output;
        }

        // Time: O(nlogn) + O(n^2)
        // Space: O(2 * no. of triplets)
        private static IList<IList<int>> OptimalSolution(int[] nums)
        {
            var n = nums.Length;
            System.Array.Sort(nums);
            var output = new List<IList<int>>();
            var uniqueTriplets = new HashSet<string>();

            for (int i = 0; i < n - 2; i++)
            {
                int j = i + 1;
                int k = n - 1;

                while(j != k)
                {
                    var sum = nums[i] + nums[j] + nums[k];

                    if (sum == 0)
                    {
                        var tempTriplet = new List<int> { nums[i], nums[j], nums[k] };
                        var tempString = string.Empty;
                        foreach (var item in tempTriplet)
                        {
                            tempString += item;
                        }
                        if (!uniqueTriplets.Contains(tempString))
                        {
                            uniqueTriplets.Add(tempString);
                            output.Add(tempTriplet);
                        }
                        j++;
                    }
                    else if (sum > 0) k--;
                    
                    else j++;

                }
            }
            return output;
        }
    }
}
