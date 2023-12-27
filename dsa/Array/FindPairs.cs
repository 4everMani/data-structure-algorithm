using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Array
{
    public class FindPairs
    {
        //Given an array of integers nums and an integer k, return the number of unique k-diff pairs in the array.

        //A k-diff pair is an integer pair (nums[i], nums[j]), where the following are true:

        //0 <= i, j<nums.length
        //i != j
        //|nums[i] - nums[j]| == k

        //Input: nums = [3,1,4,1,5], k = 2
        //Output: 2
        //Explanation: There are two 2-diff pairs in the array, (1, 3) and(3, 5).
        //Although we have two 1s in the input, we should only return the number of unique pairs.

        public static void Solution(int[] nums, int k)
        {
            //Console.WriteLine(ImprovedSolution1(nums, k));
            Console.WriteLine(Improved2(nums, k)) ;
        }

        // 2 Pointers method
        private static int ImprovedSolution1(int[] nums, int k)
        {
            nums = nums.Order().ToArray();
            int i = 0;
            int j = i + 1;
            var dict = new Dictionary<int, int>();
            while (j < nums.Length)
            {
                if (nums[j] - nums[i] == k)
                {
                    var pair = new KeyValuePair<int, int>(nums[i], nums[j]);
                    if (!dict.Contains(pair))
                    {
                        dict.Add(nums[i], nums[j]);
                    }
                    i++;
                    j++;
                }
                else if (nums[j] - nums[i] > k)
                {
                    i++;
                }
                else
                {
                    j++;
                }
                if (i == j)
                {
                    j++;
                }
            }
            return dict.Count;
        }

        // using binary search
        // most efficient
        private static int Improved2(int[] nums, int k)
        {
            nums = nums.Order().ToArray();
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var target = nums[i] + k;
                var start = i + 1;
                int end = nums.Length - 1;
                var value = BinarySearch(nums, start, end, target);
                if (value != -1)
                {
                    var pair = new KeyValuePair<int, int>(nums[i], nums[value]);
                    if (!dict.Contains(pair))
                    {
                        dict.Add(nums[i], nums[value]);
                    }
                }

            }

            return dict.Count;
        }

        private static int BinarySearch(int[] arr, int start, int end, int target)
        {
            int index = -1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return index;
        }
    }
}
