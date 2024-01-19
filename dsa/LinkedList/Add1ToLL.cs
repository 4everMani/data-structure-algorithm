using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Add1ToLL
    {
        // input = [1, 5, 9]
        // output = [1, 6, 0]

        public static void Solution(int[] nums)
        {
            var head = ConvertArrayToLL.Convert2LL(nums);
            //Node<int> result = NaiveSolution(head);
            var result = ImprovedSolution(head);
            TraverseDLL<int>.Traverse(result);
        }

        // Time: O(3n)
        private static Node<int> NaiveSolution(Node<int> head)
        {
            var reverseHead = ReverseLL.RecursiveSolution(head);
            var revMover = reverseHead;
            var carry = 1;
           
            while (revMover != null && carry > 0)
            {
                var num = revMover.Value + carry;
                var digit = num % 10;
                carry = num / 10;
                revMover.Value = digit;
                revMover = revMover.Next;
            }
            head = ReverseLL.RecursiveSolution(reverseHead);
            if (carry > 0)
            {
                var tempNode = new Node<int>(carry);
                tempNode.Next = head;
                head = tempNode;
            }
            return head;
        }

        // In naive solution we are taking time O(3n) which is not optimized.
        // We need some sort of solution which can solve the problem in O(n).
        // We can use recursion based solution as it provide facility of backtracking.
        
        // Time : O(n)
        // Space: O(n) coz of call stack
        private static Node<int> ImprovedSolution(Node<int> head)
        {
            var carry = helper(head);
            if (carry > 0)
            {
                var newNode = new Node<int>(carry);
                newNode.Next = head;
                head = newNode;
            }
            return head;
        }

        private static int helper(Node<int> mover)
        {
            if (mover == null) return 1;
            var num = mover.Value + helper(mover.Next);
            var digit = num % 10;
            var carry = num / 10;
            mover.Value = digit;
            return carry;
        }
    }
}
