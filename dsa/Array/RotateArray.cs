using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Array
{
    public class RotateArray
    {

        // Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.



        //Example 1:

        //Input: nums = [1,2,3,4,5,6,7], k = 3
        //Output: [5,6,7,1,2,3,4]
        //Explanation:
        //rotate 1 steps to the right: [7,1,2,3,4,5,6]
        //rotate 2 steps to the right: [6,7,1,2,3,4,5]
        //rotate 3 steps to the right: [5,6,7,1,2,3,4]


        // naive approach
        //public void Rotate(int[] nums, int k)
        //{
        //    for (int i = 1; i <= k; i++)
        //    {
        //        int right = nums.Length - 1;
        //        var temp = nums[right];

        //        while (right > 0)
        //        {
        //            nums[right] = nums[right - 1];
        //            right -= 1;
        //        }
        //        nums[right] = temp;

        //    }
        //}

        public static void Solution(int[] nums, int k)
        {
            var result = RotateOptimal(nums, k);
            foreach (var item in result)
            {
                Console.Write(item + ", ");
            }
        }

        // Time: O(2n)
        // Space: O(n)
        public static int[] RotateNaiveI(int[] nums, int k)
        {
            int[] arr = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int newIndex = (i + k) % nums.Length;
                arr[newIndex] = nums[i];

            }
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = arr[i];

            }
            return nums;
        }

        // Time: O(k * n)
        private static int[] RotateNaiveII(int[] arr, int k)
        {

            var n = arr.Length;
            // if length is 7 and we want 7 rotation then we will get same array
            // So if rotation is 8 then 7 + 1 rotation i.e. 8 % 7 = 1
            k = k % n;
            
            while(k > 0)
            {
                var val = arr[n - 1];
                var j = n - 1;
                while (j > 0)
                {
                    
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[0] = val;
                k--;
            } 
            return arr;
        }

        // Time: O(n - k) + O(k) + O(n - k) => O(2n - k)
        // Space: O(n-k)
        private static int[] RotateNaiveIII(int[] arr, int k)
        {
            var n = arr.Length;
            k = k % n;
            var temp = new List<int>();
            for (int i = 0; i < (n-k); i++)
            {
                temp.Add(arr[i]);
            }

            // shifting
            for (int i = 0; i < k; i++)
            {
                arr[i] = arr[(n - k) + i];
            }

            for (int i = 0 ; i < temp.Count; i++)
            {
                arr[k+i] = temp[i];
            }
            return arr;
        }

        // Time: O(2n)
        private static int[] RotateOptimal(int[] nums, int k)
        {
            var n = nums.Length;
            k = k % n;

            nums = Reverse(nums, 0, (n - k) - 1);
            nums = Reverse(nums, (n-k), (n - 1));
            return Reverse(nums, 0 , n-1);
        }

        private static int[] Reverse(int[] arr, int startIndex, int endIndex)
        {
            while(startIndex < endIndex)
            {
                var temp = arr[startIndex];
                arr[startIndex] = arr[endIndex];
                arr[endIndex] = temp;
                startIndex++;
                endIndex--;
            }
            return arr;
        }


    }
}
