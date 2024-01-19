using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class RemoveNthElementFromEnd
    {
        public static void Solution(int[] nums, int n)
        {
            var ll = ConvertArrayToLL.Convert2LL(nums);
            //var result = RemoveNthElement(ll, n);
            var result = RemoveNthElementII(ll, n);
            TraverseDLL<int>.Traverse(result);
        }

        // Time: O(2len) len = length of linkedlist
        private static Node<int>? RemoveNthElement(Node<int> head, int n)
        {
            var count = 0;
            var mover = head;

            while (mover != null)
            {
                count++;
                mover = mover.Next;
            }
            var position = count - n;
            if (position == 0)
            {
                head = head.Next;
            }
            else
            {
                count = 0;
                mover = head;
                while (mover != null)
                {
                    count++;
                    if (position == count)
                    {
                        mover.Next = mover.Next.Next;
                        break;
                    }
                    mover = mover.Next;
                }
            }
            return head;
        }

        // Time: O(len) space: O(1)
        private static Node<int>? RemoveNthElementII(Node<int> head, int n)
        {
            var fast = head;
            var slow = head;

            // using concept of fast and slow pointer
            // fast will covering n steps first
            // after that slow and fast both will take one one step
            // Once fast will reach to the end of ll, 
            // slow will be pointed to node whose next node will be removed
            while (n != 0)
            {
                fast = fast.Next;
                n--;
            }
            if (fast == null)
            {
                head = head.Next;
            }
            else
            {
                while (fast.Next != null)
                {
                    slow = slow.Next;
                    fast = fast.Next;
                }
                slow.Next = slow.Next.Next;
            }
            return head;
        }
    }
}
