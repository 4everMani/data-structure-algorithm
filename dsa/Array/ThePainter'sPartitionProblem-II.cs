using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Array
{
    public class ThePainter_sPartitionProblem_II
    {

        //Dilpreet wants to paint his dog's home that has n boards with different lengths.
        //The length of ith board is given by arr[i] where arr[] is an array of n integers.
        //He hired k painters for this work and each painter takes 1
        //unit time to paint 1 unit of the board. 

        //The problem is to find the minimum time to get this job done
        //if all painters start together with the constraint that any painter will only
        //paint continuous boards, say boards numbered {2,3,4} or only board {1}
        //or nothing but not boards {2,4,5}.

        //Input:
        //n = 4
        //k = 2
        //arr[] = {10,20,30,40}
        //Output: 60
        //Explanation: The most optimal way to paint:
        // Permutations are:
        //Painter 1 allocation : {10}
        //Painter 2 allocation : {20,30,40}     maxTime = 90

        //Painter 1 allocation : {10,20}
        //Painter 2 allocation : {30,40}        maxTime = 70

        //Painter 1 allocation : {10,20,30}     maxTime = 60
        //Painter 2 allocation : {40}
        //Job will be complete at time = min(90, 70, 60) = 60


        public static void Solution(int[] arr, int n, int k)
        {
            Console.WriteLine(MinTime(arr, n, k));
        }
        public static long MinTime(int[] arr, int n, int k)
        {
            //Your code here
                    long totalTime = 0;
            long start = 0;
            long ans = -1;
            for (int j = 0; j < n; j++) // applying for loop coz arr.Sum() will give overflow error as inputs are very large
            {
                totalTime += arr[j];
            }

            while (start <= totalTime)
            {
                long mid = start + ((totalTime - start) / 2);
                bool isValidTime = IsValidSolution(arr, n, k, mid);

                if (isValidTime)
                {
                    ans = mid < ans || ans == -1 ? mid : ans;
                    totalTime = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return ans;
        }

        public static bool IsValidSolution(int[] nums, int n, int k, long target)
        {
            long totalUnit = 0;
            int counter = 1;

            for (int i = 0; i < n; i++)
            {
                if (nums[i] > target) return false;

                if (totalUnit + nums[i] > target)
                {
                    totalUnit = nums[i];
                    counter += 1;
                    if (counter > k) return false;
                }
                else
                {
                    totalUnit += nums[i];
                }
            }
            return true;
        }
    }
}
