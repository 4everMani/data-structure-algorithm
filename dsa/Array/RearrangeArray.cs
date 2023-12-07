using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
namespace Array
{
    public class RearrangeArray
    {


        //        You are given a 0-indexed integer array nums of even length consisting of an equal number of positive and negative integers.

        //        You should rearrange the elements of nums such that the modified array follows the given conditions:

        //        Every consecutive pair of integers have opposite signs.
        //        For all integers with the same sign, the order in which they were present in nums is preserved.
        //        The rearranged array begins with a positive integer.
        //        Return the modified array after rearranging the elements to satisfy the aforementioned conditions

        //      Input: nums = [3,1,-2,-5,2,-4]
        //      Output: [3,-2,1,-5,2,-4]


        // BruteForce
        //public static int[] Solution(int[] nums)
        //{
        //    int arrCount = nums.Length;
        //    var positiveArr = new List<int>();
        //    var negativeArr = new List<int>();
        //    var finalArr = new List<int>();

        //    for (int i = 0; i < arrCount; i++)
        //    {
        //        if (nums[i] > 0)
        //        {
        //            positiveArr.Add(nums[i]);
        //        }
        //        else
        //        {
        //            negativeArr.Add(nums[i]);
        //        }
        //    }

        //    for (int i = 0; i < arrCount / 2; i++)
        //    {
        //        finalArr.Add(positiveArr[i]);
        //        finalArr.Add(negativeArr[i]);
        //    }

        //    return finalArr.ToArray();
        //}

        // Small space improvement
        public static int[] Solution(int[] nums)
        {
            int[] tempArr = new int[nums.Length];
            int[] finalArr = new int[nums.Length];
            var left = 0;
            var right = nums.Length - 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    tempArr[left] = nums[i];
                    left++;
                }
                else if (nums[i] < 0)
                {
                    tempArr[right] = nums[i];
                    right--;
                }
            }
            left = 0;
            right = nums.Length - 1;
            var index = 0;
            while (left < right)
            {
                finalArr[index] = tempArr[left];
                finalArr[index + 1] = tempArr[right];
                index += 2;
                left++;
                right--;
            }

            return finalArr;
        }



    }
}
