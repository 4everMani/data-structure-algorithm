
namespace BinarySearch;

public class SingleElementInASortedArray
{
    // You are given a sorted array ‘arr’ of ‘n’ numbers such that every number occurred twice in the array except one, which appears only once.
    // Return the number that appears once.
    // Example:
    // Input: 'arr' = [1,1,2,2,4,5,5]
    // Output: 4 
    // Explanation: 
    // Number 4 only appears once the array.

    public static void Solution(int[] nums)
    {
        int result = FindUnique(nums);
        System.Console.WriteLine(result);
    }

    private static int FindUnique(int[] nums)
    {
        if (nums.Length == 1) return nums[0];
        else if (nums[0] != nums[1]) return nums[0];
        else if (nums[^1] != nums[^2]) return nums[^1];
        else
        {  
            int start = 1;
            int end = nums.Length - 2;

            while(start <= end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] != nums[mid + 1] && nums[mid] != nums[mid - 1])
                {
                    return nums[mid];
                }
                else if (mid % 2 == 0 && nums[mid] == nums[mid + 1] || (mid % 2 == 1 && nums[mid] == nums[mid - 1]))
                {
                    start = mid + 1; 
                }
                else
                { 
                    end = mid - 1; 
                }
            }
            return -1;
        }
    }  

}
