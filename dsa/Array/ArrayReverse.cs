using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class ArrayReverse
    {
        public static int[] Reverse(int[] inputArr)
        {
            var left = 0;
            var right = inputArr.Length - 1;
            while (left < right)
            {
                // using touple
                (inputArr[left], inputArr[right]) = (inputArr[right], inputArr[left]);

                //var temp = inputArr[left];
                //inputArr[left] = inputArr[right];
                //inputArr[right] = temp;
                left += 1;
                right -= 1;
            }
            return inputArr;
        }
    }
}
