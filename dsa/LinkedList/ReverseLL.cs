using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class ReverseLL
    {
        public static void Solution(int[] nums)
        {
            var ll = ConvertArrayToLL.Convert2LL(nums);
            //var result = NaiveSolution(ll);
            //var result = ImprovedSolution(ll);
            var result = RecursiveSolution(ll);
            TraverseDLL<int>.Traverse(result);
        }

        // Time: O(2n) n: lenth of linkedlist
        // Space: O(n)
        private static Node<int> NaiveSolution(Node<int> head)
        {
            var stack = new Stack<int>();
            var mover = head;

            while (mover != null)
            {
                stack.Push(mover.Value);
                mover = mover.Next;
            }
            mover = head;

            while (stack.Count == 0)
            {
                mover.Value = stack.Pop();
                mover = mover.Next;
            }
            return head;
        }

        // Time: O(n)
        private static Node<int> ImprovedSolution(Node<int> head)
        {
            var mover = head;
            Node<int> previous = null;

            while (mover != null)
            {
                var front = mover.Next;
                mover.Next = previous;
                previous = mover;
                mover = front;
            }
            return previous;
        }

        // Time: O(n)
        public static Node<int> RecursiveSolution(Node<int> head)
        {
            if (head == null || head.Next == null) return head;

            var newHead = RecursiveSolution(head.Next);
            var front = head.Next;
            front.Next = head;
            head.Next = null;
            return newHead;
        }
    }
}
