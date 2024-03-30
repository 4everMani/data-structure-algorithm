

namespace BinarySearch
{
    public class CeilTheFloor
    {

        // Question: https://www.naukri.com/code360/problems/ceiling-in-a-sorted-array_1825401?utm_source=striver&utm_medium=website&utm_campaign=a_zcoursetuf

        //You're given a sorted array 'a' of 'n' integers and an integer 'x
        //Find the floor and ceiling of 'x' in 'a[0..n-1

        //Note:
        //Floor of 'x' is the largest element in the array which is smaller than or equal to 'x'.
        //Ceiling of 'x' is the smallest element in the array greater than or equal to 'x'.


        //Example:
        //Input: 
        //n=6, x=5, a=[3, 4, 7, 8, 8, 10
        //Output:
        //4, 7

        //Explanation:
        //The floor and ceiling of 'x' = 5 are 4 and 7, respectively.

        public static void Solution(int[] nums, int target)
        {

        }

        public static int[] GetFloorAndCeil(int[] nums, int n, int target)
        {
            var output = new int[n];
            output[1] = FindCeiling(nums, target);
            output[0] = FindFloor(nums, target);
            return output;
        }

        //Floor of 'x' is the largest element in the array which is smaller than or equal to 'x'.
        private static int FindFloor(int[] nums, int target)
        {
            int floor = -1;
            int start = 0;
            int end = nums.Length - 1;

            if (nums[start] > target)
            {
                return -1;
            }

            while (start <= end)
            {
                var mid = start + (start + end) / 2;

                if (nums[mid] <= target)
                {
                    floor = nums[mid];
                    start = mid + 1;
                }
                else
                {
                     end = mid - 1;
                }
            }
            return floor;
        }

        //Ceiling of 'x' is the smallest element in the array greater than or equal to 'x'.
        private static int FindCeiling(int[] nums, int target)
        {
            int ceiling = int.MaxValue;
            int start = 0;
            int end = nums.Length - 1;
            if (target > nums[end]) return -1;

            while (start <= end)
            {
                var mid = start + (start + end) / 2;

                if (nums[mid] >= target)
                {
                    ceiling = nums[mid];
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return ceiling;
        }
    }
}
