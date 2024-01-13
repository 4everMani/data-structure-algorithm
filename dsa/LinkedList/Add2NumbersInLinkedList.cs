using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LinkedList
{
    public class Add2NumbersInLinkedList
    {
        // input = [3, 5], [4, 5, 9, 9]
        // output = [7, 0, 0, 0, 1]
        public static void Solution(int[] first, int[] second)
        {
            var ll1 = ConvertArrayToLL.Convert2LL(first);
            var ll2 = ConvertArrayToLL.Convert2LL(second);
            var result = Sum(ll1, ll2);
            TraverseDLL<int>.Traverse(result);

        }

        public static Node<int> Sum(Node<int> head1, Node<int> head2)
        {
            // adding a dummy node
            // whenever you are creating a new LL, always use concept of dummy node
            var dummyNode = new Node<int>(-1);

            var mover1 = head1;
            var mover2 = head2;
            var mover3 = dummyNode;
            var carry = 0;

            while (mover1 != null || mover2 != null)
            {
                int num1 = mover1 is null ? 0 : mover1.Value;
                int num2 = mover2 is null ? 0 : mover2.Value;

                int num = num1 + num2 + carry;
                int digit = num % 10;
                carry = num / 10;

                mover3.Next = new Node<int>(digit);
                mover3 = mover3.Next;

                mover1 = mover1 is null ? null : mover1.Next;
                mover2 = mover2 is null ? null : mover2.Next;
            }

            if (carry > 0)
            {
                mover3.Next = new Node<int>(carry);
            }

            // removing dummy node(optional step)
            var tempHead = dummyNode;
            var newHead = dummyNode.Next;
            tempHead.Next = null;
            return newHead;

        }
    }
}
