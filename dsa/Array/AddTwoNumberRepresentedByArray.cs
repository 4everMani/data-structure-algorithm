using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Array
{
    public class AddTwoNumberRepresentedByArray
    {
        public static void Solution(int[] arr1, int[] arr2)
        {
            int n = arr1.Length -1;
            int m = arr2.Length -1;
            int carry = 0;
            var value = string.Empty;
            while (n >= 0 && m >=0)
            {
                int num = arr1[n] + arr2[m] + carry;
                int digit = num % 10;
                carry = num / 10;
                value = $"{digit}{value}";
                n--;
                m--;
            }
            while (n >= 0)
            {
                int num = arr1[n]  + carry;
                int digit = num % 10;
                carry = num / 10;
                value = $"{digit}{value}";
                n--;
            }
            while (m >= 0)
            {
                int num = arr2[m] + carry;
                int digit = num % 10;
                carry = num / 10;
                value = $"{digit}{value}";
                n--;
            }
            if (carry != 0)
            {
                value = $"{carry}{value}";
            }
            while (value[0] == '0')
            {
                value = value.Remove(0, 1);
            }
            Console.WriteLine(value);
        }
    }
}
