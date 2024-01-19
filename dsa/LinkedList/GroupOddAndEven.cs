using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class GroupOddAndEven
    {
        // Group odd postion element and then group even placed element
        // Input => [1, 3, 4, 2, 5, 6]
        // Output => [1, 4, 5, 3, 2, 6]
        public static void Solution(int[] nums)
        {
            var ll = ConvertArrayToLL.Convert2LL(nums);
            //var result = GroupOddAndEvenPositionElement(ll);
            var result = GroupOddAndEevenPositionElementII(ll);
            TraverseDLL<int>.Traverse(result);
        }

        // Time: O(n) Space: (n)
        private static Node<int> GroupOddAndEvenPositionElement(Node<int> head)
        {
            var dummyOddLL = new Node<int>(-1);
            var dummyEvevnLL = new Node<int>(0);
            var moverOdd = dummyOddLL;
            var moverEvevn = dummyEvevnLL;
            var count = 0;

            while (head != null)
            {
                count++;
                if (count % 2 == 0)
                {
                    moverEvevn.Next = new Node<int>(head.Value);
                    moverEvevn = moverEvevn.Next;
                }
                else
                {
                    moverOdd.Next = new Node<int>(head.Value);
                    moverOdd = moverOdd.Next;
                }
                head = head.Next;
            }
            //adding evenLL without dummyNode at the end of oddLL
            moverOdd.Next = dummyEvevnLL.Next;

            // returing entire oddLL without dummyNode
            return dummyOddLL.Next;
        }
    
        // Time: O(n)
        private static Node<int>? GroupOddAndEevenPositionElementII(Node<int> head)
        {
            if (head == null || head.Next == null) return head;
            var oddMover = head;
            var evenHeader = head.Next;
            var evenMover = evenHeader;

            while (evenMover != null && evenMover.Next != null) // applying condition over evenNode coz oddNode can be null only if evenNode is null
            {
                oddMover.Next = oddMover.Next.Next;
                oddMover = oddMover.Next;
                evenMover.Next = evenMover.Next.Next;
                evenMover = evenMover.Next;
            }
            oddMover.Next = evenHeader;
            return head;

        }
    }
}
