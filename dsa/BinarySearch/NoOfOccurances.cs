
namespace BinarySearch;

public class NoOfOccurances
{
    public static void Solution(int[] nums, int target)
    {
        Console.WriteLine(CountOccurance(nums, target));
    }

    private static int CountOccurance(int[] nums, int target)
    {
        var lastIndex = IndexOfLastOccurance(nums, target);
        var firstIndex = IndexOfFirstOccurance(nums, target);
        return firstIndex == 0 && lastIndex == 0 ? 0 : lastIndex - firstIndex + 1;
    }

    // Time: O(logn)
    private static int IndexOfLastOccurance(int[] nums, int target)
    {
        int start = 0;
        int end = nums.Length - 1;
        int index = 0;

        while (start <= end)
        {
            int mid = start + (end - start) / 2;

            if (nums[mid] == target) 
            {
                index = mid;
                start = mid + 1;
            }
            else if (nums[mid]  > target) end = mid -1;
            else start = mid + 1;
        }
        return index;
    }

    // Time: O(logn)
    private static int IndexOfFirstOccurance(int[] nums, int target)
    {
        int start = 0;
        int end = nums.Length - 1;
        int index = 0;

        while (start <= end)
        {
            int mid = start + (end - start) / 2;

            if (nums[mid] == target)
            {
                index = mid;
                end = mid - 1;
            }
            else if (nums[mid]  > target) end = mid -1;
            else start = mid + 1;
        }
        return index;
    }
}
