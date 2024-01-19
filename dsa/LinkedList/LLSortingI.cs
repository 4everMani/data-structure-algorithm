using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LLSortingI
    {
        // Sort linkedlist of 0's, 1's and 2's
        public static void Solution(int[] nums)
        {
            var ll = ConvertArrayToLL.Convert2LL(nums);
            var result = Sorting(ll);
            //var result = SortingII(ll);
            TraverseDLL<int>.Traverse(result);    
        }

        // Time: O(n) space: O(1) coz we are final ll is send as output
        private static Node<int> Sorting(Node<int> head)
        {
            var dummyHead0 = new Node<int>(0);
            var dummyHead1 = new Node<int>(1);
            var dummyHead2 = new Node<int>(2);
            var mover0 = dummyHead0;
            var mover1 = dummyHead1;
            var mover2 = dummyHead2;
            var mover = head;
            while (mover != null)
            {
                if (mover.Value == 0)
                {
                    var tempNode = new Node<int>(0);
                    mover0.Next = tempNode;
                    mover0 = tempNode;
                }
                else if (mover.Value == 2)
                {
                    var tempNode = new Node<int>(2);
                    mover2.Next = tempNode;
                    mover2 = tempNode;
                }
                else
                {
                    var tempNode = new Node<int>(1);
                    mover1.Next = tempNode;
                    mover1 = tempNode;
                }
                mover = mover.Next;
            }
            // checking if one is exists
            mover0.Next = dummyHead1.Next != null ? dummyHead1.Next : dummyHead2.Next;
            // checking if two is exists
            mover1.Next = dummyHead2.Next;
            return dummyHead0.Next;
        }

        // Time: O(2n) space: O(1)
        private static Node<int> SortingII(Node<int> head)
        {
            var count0 = 0;
            var count2 = 0;
            var count1 = 0;

            var mover = head;

            while (mover != null)
            {
                if (mover.Value == 0) count0++;
                else if (mover.Value == 2) count2++;
                else count1++;

                mover = mover.Next;
            }
            mover = head;

            while (mover != null)
            {
                if (count0 > 0)
                {
                    mover.Value = 0;
                    count0--;

                }
                else if (count1 > 0)
                {
                    mover.Value = 1;
                    count1--;
                }
                else
                {
                    mover.Value = 2;
                    count2--;
                } 
                

                mover = mover.Next;
            }
            return head;
        }


    }
}
