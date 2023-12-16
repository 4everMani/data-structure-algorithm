using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class FactorailOfLargeNumber
    {
        public static void Solution(int num)
        {
            var list = new List<int> { };
            list.Add(1);
            for (int i = 2; i <= num; i++)
            {
                int carry = 0;

                for (int j = 0; j < list.Count; j++)
                {
                    var value = i * list[j] + carry;
                    list[j] = value % 10;
                    carry = value / 10;
                }
                while (carry > 0)
                {
                    list.Add(carry%10);
                    carry /= 10;
                };
            }
            list.Reverse();
            
            PrintArray.Print(list.ToArray());
        }
    }
}
