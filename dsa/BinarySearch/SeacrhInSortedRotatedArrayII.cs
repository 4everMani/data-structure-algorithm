namespace BinarySearch;

public class SeacrhInSortedRotatedArrayII
{

    // array will have duplicates

    // Example 1:
    // Input: nums = [2,5,6,0,0,1,2], target = 0
    // Output: true

    // Example 2:
    // Input: nums = [2,5,6,0,0,1,2], target = 3
    // Output: false

    public static void Solution(int[] nums, int target)
    {
        System.Console.WriteLine(Search(nums, target));
    }

    public static bool Search(int[] nums, int target) {
        var start = 0;
        var end = nums.Length - 1;

        while (start <= end)
        {
            var mid = start + (end - start) / 2;
            if (nums[mid] == target) return true;
            else if (nums[mid] == nums[start] && nums[mid] == nums[end]) 
            {
                start += 1;
                end -= 1;
                continue;
            }
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
        return false;
    }

}
