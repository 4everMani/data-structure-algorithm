using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class MoveNegativeToLeft
    {
        public static void Move(int[] arr)
        {
            int j = 0;
            for (int i = 0; i< arr.Length; i++) 
            { 
                if (arr[i] < 0)
                {
                    (arr[j], arr[i]) = (arr[i], arr[j]);
                    j++;
                }
            }

            PrintArray.Print(arr);
        }
    }
}
