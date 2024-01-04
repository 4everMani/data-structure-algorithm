using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Array
{
    public class AllocateMinimumNumberOfPages
    {


        //You have N books, each with A[i] number of pages.
        //M students need to be allocated contiguous books,
        //with each student getting at least one book.
        //Out of all the permutations,
        //the goal is to find the permutation where the maximum number of pages allotted
        //to a student should be minimum, out of all possible permutations.

        //Note: Return -1 if a valid assignment is not possible,
        //and allotment should be in contiguous order
        //(see the explanation for better understanding).

         //Input:
        //N = 4
        //A[] = {12,34,67,90}
        //M = 2
        //Output:113
        //Explanation:Allocation can be done in 
        //following ways:
        //{12} and {34, 67, 90} Maximum Pages = 191
        //{12, 34} and {67, 90} Maximum Pages = 157
        //{12, 34, 67} and {90} Maximum Pages = 113.
        //Therefore, the minimum of these cases is 113,
        //which is selected as the output.


        public static void Solution(int n, int[] pages, int m)
        {
            //Console.WriteLine(IsValidSolution(pages, 113, m));
            int totalPages = pages.Sum(); // using System.Linq
            int ans = -1;
            int start = 0;
            int end = totalPages;

            while (start <= end) 
            { 
                int mid = start + (end - start) / 2;
                var isValid = IsValidSolution(pages, mid, m);
                if (isValid)
                {
                    ans = mid < ans || ans == -1 ? mid : ans;
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            Console.WriteLine(ans);

        }

        public static bool IsValidSolution(int[] pages, int target, int m)
        {
            int pageSum = 0;
            int counter = 0;

            for (int i = 0; i < pages.Length; i++)
            {
                if (pages[i] > target) return false;
                if (pageSum + pages[i] > target)
                {
                    counter++;
                    pageSum = pages[i];
                    if (counter > m) return false;
                }
                else
                {
                    pageSum += pages[i];
                }
            }
                return true;
        }
    }
}
