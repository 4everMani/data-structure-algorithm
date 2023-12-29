using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class ExponentialSearch
    {
        public static void Search(int[] nums, int target)
        {
            Console.WriteLine(FindIndex(nums, target));
        }

        private static int FindIndex(int[] nums, int target)
        {
            if (nums[0] == target) return 0;
            int i = 1;
            int n = nums.Length - 1;
            while (i <= n && nums[i] <= target)
                i *= 2;
            int start = i / 2;
            int end = int.Min(n, i);
            return BinarySearch(nums, start, end, target);
        }

        private static int BinarySearch(int[] nums, int start, int end, int target)
        {
            int index = -1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] == target) return mid;
                else if (nums[mid] > target) end = mid - 1;
                //if (nums[mid] >= target)
                //{
                //    index = mid;
                //    end = mid - 1;
                //}
                else start = mid + 1;
            }
            return index;
        }
    }
}
