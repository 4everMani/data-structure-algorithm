

namespace BinarySearch
{
    public class ImplementLowerBound
    {

        // Question: https://www.codingninjas.com/codestudio/problems/lower-bound_8165382?utm_source=striver&utm_medium=website&utm_campaign=a_zcoursetuf

        //You are given an array 'nums' sorted in non-decreasing order and a number 'x
        //You must return the index of lower bound of 'x

        //Note:
        //For a sorted array 'nums', 'lower_bound' of a number 'x' is defined as the smallest index 'idx' such that the value 'nums[idx]' is not less than 'x
        //If all numbers are smaller than 'x', then 'n' should be the 'lower_bound' of 'x', where 'n' is the size of array
        //Consider 0-based indexing.

        //Example:
        //Input: ‘arr’ = [1, 2, 2, 3] and 'x' = 
        //Output: 0
        //Explanation: Index '0' is the smallest index such that 'arr[0]' is not less than 'x'.

        public static void Solution(int[] nums, int x)
        {
            int result = OptimalSolution(nums, x);
            Console.WriteLine(result);
        }

        private static int OptimalSolution(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            int smallestIndex = end;

            if (target > nums[end]) return nums.Length;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if ((nums[mid] >= target))
                {
                    smallestIndex = mid;
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return smallestIndex;
        }
    }
}
