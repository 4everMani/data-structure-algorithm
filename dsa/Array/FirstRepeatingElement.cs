using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
namespace Array
{
    public class FirstRepeatingElement
    {
        //Given an array arr[] of size n, find the first repeating element.
        //The element should occur more than once and the index of its first
        //occurrence should be the smallest.

        //Note:- The position you return should be according to 1-based indexing. 

        //Input:
        //n = 7
        //arr[] = {1, 5, 3, 4, 3, 5, 6}
        //Output: 2
        //Explanation: 
        //5 is appearing twice and
        //its first appearence is at index 2 
        //which is less than 3 whose first
        //occuring index is 3.

        public static void Solution(int[] arr, int n)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]] = dict[arr[i]] + 1;
                }
                else
                {
                    dict.Add(arr[i], 1);
                }
            }

            
            for (int i = 0; i < n; ++i)
            {
                if (dict.ContainsKey(arr[i]) && dict[arr[i]] > 1)
                {
                    Console.WriteLine(i + 1);
                    return;
                }
            }
        }
    }
}
