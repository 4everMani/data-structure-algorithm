
namespace BinarySearch;

public class SearchInSortedRotatedArray
{
    public static void Solution(int[] nums, int target)
    {
        int index = Search(nums, target);
        System.Console.WriteLine(index);
    }

    private static int Search(int[] nums, int target)
    {
        var start = 0;
        var end = nums.Length - 1;

        while (start <= end)
        {
            var mid = start + (end - start) / 2;
            if (nums[mid] == target) return mid;
            else if (nums[mid] >= nums[start])
            {
                if (target >= nums[start] && target < nums[mid])
                {
                    end = mid - 1;
                }
                else start = mid + 1;
            }
            else 
            {
                if (target > nums[mid] && target <= nums[end])
                {
                    start = mid + 1;
                }
                else end = mid - 1;
            }
        }
        return -1;
    }
}
