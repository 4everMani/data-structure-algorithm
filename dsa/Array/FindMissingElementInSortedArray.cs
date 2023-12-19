using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace Array
{
    public class FindMissingElementInSortedArray
    {
        //Given a list of n-1 integers and these integers are in the range of 1 to n.
        //There are no duplicates in list.One of the integers is missing in the list.
        //Write an efficient code to find the missing integer.

        //Examples: 
        //Input : arr[] = [1, 2, 3, 4, 6, 7, 8]
        //Output : 5

        //Input : arr[] = [1, 2, 3, 4, 5, 6, 8, 9]
        //Output : 7
        public static void Solution(int[] nums)
        {
            Console.WriteLine(BinarySearchSolution(nums));
        }
        private static int BinarySearchSolution(int[] nums)
        {
            int ans = -1;
            int start = 0;
            int end = nums.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (nums[mid] != mid + 1)
                {
                    ans = mid + 1;
                    end = mid - 1;

                }
                else
                {
                    start = mid + 1;
                }
            }
            return ans;
        }
    }
}
