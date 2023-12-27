using System;

namespace Array
{
    public class OddOccurance
    {

        // Given an array which contains duplicate number in pairs.
        // No pair can repeate
        // Find element occurs not in pair
        // [10, 10, 20, 20, 15, 15, 3, 44, 44] => 3
        // [1, 1, 5, 5, 2, 2, 3, 3, 2, 4, 4] => 2


        public static void Solution(int[] nums)
        {
            Console.WriteLine(BinarySearchSolution(nums));
        }

        private static int BinarySearchSolution(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (start == end)
                    return nums[end];
                else if (mid % 2 == 0)
                {
                    if (nums[mid] == nums[mid + 1])
                        start = mid + 2;
                    else
                        end = mid;
                }
                else
                {
                    if (nums[mid] == nums[mid - 1])
                        start = mid + 1;
                    else
                        end = mid - 1;
                }
            }
            return -1;
        }
    }
}
