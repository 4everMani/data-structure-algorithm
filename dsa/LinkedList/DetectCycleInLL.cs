using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DetectCycleInLL
    {
        public static void Solution()
        {
            // creating a cycle
            var head = new Node<int>(1);
            head.Next = new Node<int>(2);
            head.Next.Next = new Node<int>(3);
            head.Next.Next.Next = new Node<int>(4);
            head.Next.Next.Next.Next = head;

            bool result = DetectCycleImproved(head);
            Console.WriteLine(result);

            // No cycle
            var head2 = new Node<int>(1);
            head.Next = new Node<int>(2);
            head.Next.Next = new Node<int>(3);
            head.Next.Next.Next = new Node<int>(4);
            head.Next.Next.Next.Next = new Node<int>(5);

            bool result2 = DetectCycleImproved(head2);
            Console.WriteLine(result2);
        }

        // Time: O(n)
        // Space: O(n)
        private static bool DetectCycleNaive(Node<int> head)
        {
            var mover = head;
            var set = new HashSet<Node<int>>();

            while (mover != null)
            {
                if (set.Contains(mover)) return true;
                set.Add(mover);
                mover = mover.Next;
            }
            return false;
        }

        // Time: O(n)
        private static bool DetectCycleImproved(Node<int> head)
        {
            if (head == null || head.Next == null) return false;
            // if (head.next.next == null) return head == head.next;
            var fast = head;
            var slow = head;
            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
                if (fast == slow) return true;
            }
            return false;
        }
    }
}
