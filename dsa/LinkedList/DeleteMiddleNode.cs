using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DeleteMiddleNode
    {
        public static void Solution(int[] list)
        {
            var head = ConvertArrayToLL.Convert2LL(list);
            //Node<int> result = DeleteMiddleNodeNaive(head);
            Node<int> result = DeleteMiddleNodeImproved(head);
            TraverseDLL<int>.Traverse(result);

        }

        // Time: O(n + n/2)
        // Space: O(1)
        private static Node<int> DeleteMiddleNodeNaive(Node<int> head)
        {
            if (head == null || head.Next == null) return null;

            var mover = head;
            var length = 0;

            while (mover != null)
            {
                length++;
                mover = mover.Next;
            }

            var position = (length / 2);
            mover = head;

            while (mover != null)
            {
                position--;

                if(position == 0)
                {
                    mover.Next = mover.Next.Next;
                    break;
                }
                mover = mover.Next;

            }
            return head;


        }

        // Time: O(n)
        private static Node<int> DeleteMiddleNodeImproved(Node<int> head)
        {
            if (head == null || head.Next == null) return null;

            var slow = head;
            var fast = head;
            Node<int> prev = null;

            while (fast != null && fast.Next != null)
            {
                prev = slow;
                fast = fast.Next.Next;
                slow = slow.Next;
            }

            prev.Next = slow.Next;
            
            return head;

        }
    }
}
