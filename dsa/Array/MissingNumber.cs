using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Array
{
    public class MissingNumber
    {
//        Given an array nums containing n distinct numbers in the range[0, n], return the only number in the range that is missing from the array.
//        Example 1:

//      Input: nums = [3, 0, 1]
//      Output: 2
//      Explanation: n = 3 since there are 3 numbers, so all numbers are in the range [0,3]. 2 is the missing number in the range since it does not appear in nums.
   
        
        public int Solution(int[] nums)
        {
            int length = nums.Length;
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                    sum += nums[i];
                }

                int totalSum = length * (length + 1) / 2;

                return totalSum - sum;
            }
        
    }
}
