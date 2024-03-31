namespace BinarySearch;

public class NoOfRotation
{
    // You are given an array 'nums' having 'n' distinct integers sorted in ascending order. The array is right rotated 'r' times
    // Find the minimum value of 'r'.
    // Right rotating an array means shifting the element at 'ith' index to (‘i+1') mod 'n' index, for all 'i' from 0 to ‘n-1'.

    // Example:
    // Input: 'n' = 5 , ‘arr’ = [3, 4, 5, 1, 2]

    // Output: 3 
    // Explanation:
    // If we rotate the array [1 ,2, 3, 4, 5] right '3' times then we will get the 'arr'. Thus 'r' = 3.

    public int FindKRotation(int[] nums) {
        var start = 0;
        var end = nums.Length - 1;
        var min = int.MaxValue;
        var idx = -1;
        while (start <= end)
        {
            var mid = start + (end - start) / 2;
            if (nums[start] <= nums[mid])
            {
                if (min > nums[start])
                {
                    idx = start;
                    min = Math.Min(nums[start], min);
                }
                start = mid + 1;
            }
            else
            {
                if (min > nums[mid])
                {
                    idx = mid;
                    min = Math.Min(nums[mid], min);
                }
                end = mid - 1;
            }

        }
        return idx;
    }
}
