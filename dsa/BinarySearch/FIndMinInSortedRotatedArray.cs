namespace BinarySearch;

public class FIndMinInSortedRotatedArray
{

    public static void Solution(int[] nums)
    {
        System.Console.WriteLine(FindMin(nums));
    }


    private static int FindMin(int[] nums) {
        var start = 0;
        var end = nums.Length - 1;
        var min = int.MaxValue;
        while (start <= end)
        {
            var mid = start + (end - start) / 2;
            if (nums[start] <= nums[mid])
            {
                min = Math.Min(nums[start], min);
                start = mid + 1;
            }
            else
            {
                min = Math.Min(nums[mid], min);
                end = mid - 1;
            }

        }
        return min;
    }

}
