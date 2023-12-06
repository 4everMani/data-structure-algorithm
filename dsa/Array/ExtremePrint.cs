using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class ExtremePrint
    {
        public static void Print(int[] arr)
        {
            var left = 0;
            var right = arr.Length - 1;

            while (left <= right)
            {
                if (left == right)
                {
                    Console.Write(arr[left] + ", ");
                }
                else
                {
                    Console.Write(arr[left] + ", ");
                    Console.Write(arr[right] + ", ");
                }
                left += 1;
                right -= 1;
            }
        }
    }
}
