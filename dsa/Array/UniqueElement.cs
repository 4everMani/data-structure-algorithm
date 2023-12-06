using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class UniqueElement
    {
        public static void Print(int[] arr)
        {
            int answer = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                answer = answer ^ arr[i];
            }
            Console.WriteLine(answer);
        }
    }
}
