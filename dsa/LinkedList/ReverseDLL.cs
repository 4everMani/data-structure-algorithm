using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class ReverseDLL
    {
        public static void Solution(int[] arr)
        {
            var head = ConvertArrayToDLL<int>.Convert2DLL(arr);
            //var output = NaiveSolution(head);
            //var output = NaiveSolutionII(head);
            var output = EfficientSolution(head);
            TraverseDLL<int>.Traverse(output);
        }

        // Naive solution as we are manipulating data only
        // Time: O(2N) space: O(1)
        public static Node<int> NaiveSolutionII(Node<int> head)
        {
            if (head == null || head.Next == null) return head;
            var start = head;
            var end = head;
            var count = 1;

            while (end.Next != null)
            {
                count++;
                end = end.Next;
            }

            var i = 1;

            while (i <= count / 2)
            {
                (end.Value, start.Value) = (start.Value, end.Value);
                i++;
                end = end.Prev;
                start = start.Next;
            }
            return head;
        }

        // Naive solution as we are manipulating data only
        // Time: O(2N) space: O(N)
        public static Node<int> NaiveSolution(Node<int> head)
        {
            var stack = new Stack<int>();
            var mover = head;
            while (mover != null)
            {
                stack.Push(mover.Value); 
                mover = mover.Next;
            }

            mover = head;

            while (mover != null)
            {
                mover.Value = stack.Pop();
                mover = mover.Next;
            }
            return head;

        }

        // Efficient solution
        // time: O(n)
        public static Node<int> EfficientSolution(Node<int> head)
        {
            var last = head.Prev;
            var current = head;

            while(current != null)
            {
                last = current.Prev;
                current.Prev = current.Next;
                current.Next = last;
                current = current.Prev;
            }
            return last.Prev;

        }
    }
}
