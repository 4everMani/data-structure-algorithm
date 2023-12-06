using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class SortZeroAndOne
    {
        public static int[] Sort(int[] arr)
        {

            var zeroCount = 0;
            var oneCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    zeroCount += 1;
                }
                if (arr[i] == 1)
                {
                    oneCount += 1;
                }
            }

            var index = 0;

            while (zeroCount > 0)
            {
                arr[index] = 0;
                index++;
                zeroCount -= 1;
            }

            while (oneCount > 0)
            {
                arr[index] = 1;
                index++;
                oneCount -= 1;
            }
            return arr;
        }
    }
}
