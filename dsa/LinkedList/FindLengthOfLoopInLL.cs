using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class FindLengthOfLoopInLL
    {
        public static void Solution()
        {
            // creating a cycle
            var head = new Node<int>(1);
            head.Next = new Node<int>(2);
            head.Next.Next = new Node<int>(3);
            head.Next.Next.Next = new Node<int>(4);
            head.Next.Next.Next.Next = head;

            //int result = FindLengthNaive(head);
            int result = FindLengthImproved(head);
            Console.WriteLine(result);

            // No cycle
            var head2 = new Node<int>(1);
            head.Next = new Node<int>(2);
            head.Next.Next = new Node<int>(3);
            head.Next.Next.Next = new Node<int>(4);
            head.Next.Next.Next.Next = new Node<int>(5);

            //int result2 = FindLengthNaive(head2);
            int result2 = FindLengthNaive(head2);
            Console.WriteLine(result2);
        }

        // Time: O(n)
        // Space: O(n)
        // Using dict to detect loop and keep track of length
        private static int FindLengthNaive(Node<int> head2)
        {
            var dict = new Dictionary<Node<int>, int>();
            var mover = head2;
            var position = 1;

            while (mover != null)
            {
                if (dict.ContainsKey(mover)) return position - dict[mover];
                dict.Add(mover, position);
                position++;
                mover = mover.Next;
            }
            return 0;
        }

        // Time: O(2n)
        // Space = O(1)
        // Using Turtoise & Hare method to detect cycle and count length
        private static int FindLengthImproved(Node<int> head)
        {
            var slow = head;
            var fast = head;
            var count = 0;

            while (fast != null && fast.Next != null)
            {
                if (slow == fast)
                {
                    count = FindLengthHelper(slow, fast);
                    return count;
                }
                slow = slow.Next;
                fast = fast.Next.Next;
            }
            return count;
        }

        private static int FindLengthHelper(Node<int> slow, Node<int> fast)
        {
            slow = slow.Next;
            var len = 1;
            while (slow != fast)
            {
                len++;
                slow = slow.Next;
            }
            return len;
        }
    }
}
