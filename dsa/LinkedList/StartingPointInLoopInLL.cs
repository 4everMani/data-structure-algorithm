using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class StartingPointInLoopInLL
    {
        public static void Solution()
        {
            var head = new Node<int>(1);
            head.Next = new Node<int>(2);
            head.Next.Next = new Node<int>(3);
            head.Next.Next.Next = new Node<int>(15);
            head.Next.Next.Next.Next = new Node<int>(4);
            head.Next.Next.Next.Next.Next = new Node<int>(13);
            head.Next.Next.Next.Next.Next.Next = new Node<int>(6);
            head.Next.Next.Next.Next.Next.Next.Next = new Node<int>(7);
            head.Next.Next.Next.Next.Next.Next.Next.Next = new Node<int>(8);
            head.Next.Next.Next.Next.Next.Next.Next.Next.Next = new Node<int>(9);
            head.Next.Next.Next.Next.Next.Next.Next.Next.Next.Next = head.Next.Next.Next;

            //Node<int>? result = FindStartPointInLoopNaive(head);
            Node<int>? result = FindStartPointInLoopImproved(head);
            Console.WriteLine(result is null ? "null" : result.Value);

        }

        // Time: O(n)
        // Space: O(n)
        private static Node<int>? FindStartPointInLoopNaive(Node<int> head)
        {
            var set = new HashSet<Node<int>>();
            var mover = head;

            while (mover != null)
            {
                if (set.Contains(mover)) return mover;
                set.Add(mover);
                mover = mover.Next;
            }
            return null;
        }

        private static Node<int>? FindStartPointInLoopImproved(Node<int> head)
        {
            var slow = head;
            var fast = head;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast) // loop is confirmed
                {
                    slow = head;
                    return GetFirstElement(slow, fast); // move slow and fast pointer by one step
                }
            }
            return null;
        }

        private static Node<int> GetFirstElement(Node<int> slow, Node<int> fast)
        {
            while(true)
            {
                slow = slow.Next;
                fast = fast.Next;

                if (slow == fast) return slow;
            }
        }
    }
}
