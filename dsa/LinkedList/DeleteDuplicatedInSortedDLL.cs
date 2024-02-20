using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DeleteDuplicatesInSortedDLL
    {
        public static void Solution(int[] nums)
        {
            var head = ConvertArrayToDLL<int>.Convert2DLL(nums);
            Node<int> result = Improved(head);
            TraverseDLL<int>.Traverse(result);
        }

        private static Node<int> Improved(Node<int> head)
        {
            if (head == null || head.Next == null) return head;

            var mover = head.Next;
            while (mover != null)
            {
                if (mover.Prev.Value == mover.Value)
                {
                    mover.Prev.Next = mover.Next;
                    if(mover.Next != null) mover.Next.Prev = mover.Prev;
                }
                mover = mover.Next;
            }
            return head;
        }
    }
}
