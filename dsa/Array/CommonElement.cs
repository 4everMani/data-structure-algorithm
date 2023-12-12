using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Array
{
    public class CommonElement
    {
        //Given three arrays sorted in increasing order.
        //Find the elements that are common in all three arrays.

        //Input:
        //n1 = 6; A = {1, 5, 10, 20, 40, 80}
        //n2 = 5; B = {6, 7, 20, 80, 100}
        //n3 = 8; C = {3, 4, 15, 20, 30, 70, 80, 120}
        //Output: 20 80
        //Explanation: 20 and 80 are the only
        //common elements in A, B and C.

        public static void Solution(int[] arr1, int[] arr2, int[] arr3, int n1, int n2, int n3)
        {
            MostImproved(arr1, arr2, arr3, n1, n2, n3);
        }

        private static void Improved(int[] arr1, int[] arr2, int[] arr3, int n1, int n2, int n3)
        {
            var elementCountTable = new Dictionary<int, int>();


            for (int i = 0; i < n1; i++)
            {
                if (!elementCountTable.ContainsKey(arr1[i]))
                {
                    elementCountTable.Add(arr1[i], 1);
                }
            }

            for (int i = 0; i < n2; i++)
            {
                if (elementCountTable.ContainsKey(arr2[i]) && elementCountTable[arr2[i]] == 1)
                {
                    elementCountTable[arr2[i]] += 1;
                }
            }

            for (int i = 0; i < n3; i++)
            {
                if (elementCountTable.ContainsKey(arr3[i]) && elementCountTable[arr3[i]] == 2)
                {
                    elementCountTable[arr3[i]] += 1;
                }
            }

            foreach (KeyValuePair<int, int> item in elementCountTable)
            {
                if (item.Value == 3)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    
        private static void MostImproved(int[] arr1, int[] arr2, int[] arr3, int n1, int n2, int n3)
        {
            var set = new HashSet<int>();
            int i = 0;
            int j = 0;
            int k = 0;

            while(i < n1 && j < n2 && k < n3) 
            {
                if (arr1[i] == arr2[j] && arr2[j] == arr3[k])
                {
                    set.Add(arr1[i]);
                    i++;
                    j++;
                    k++;
                }
                else if (arr1[i] < arr2[j])
                {
                    i++;
                }
                else if (arr2[j] < arr3[k])
                {
                    j++;
                }
                else
                {
                    k++;
                }
            }

            foreach(int element in set)
            {
                Console.WriteLine(element);
            }
        }
    }
}
