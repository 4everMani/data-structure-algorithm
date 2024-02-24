using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DeleteAllOccurancesOfElementInDLL
    {
        // [10, 4, 10, 10, 6, 10], 10
        // [4, 6]
        public static void Solution(int[] list, int key)
        {
            Node<int> head = ConvertArrayToDLL<int>.Convert2DLL(list);
            Node<int> newLL = DeleteAllOccuranceOfAKey(head, key);
            TraverseDLL<int>.Traverse(newLL);
        }

        private static Node<int> DeleteAllOccuranceOfAKey(Node<int> head, int key)
        {
            if (head == null || (head.Next == null && head.Value == key)) return null;
            var mover = head;

            while (mover != null)
            {
                if (mover.Value == key)
                {
                    if (mover.Prev == null)
                    {
                        head = mover.Next;
                        head.Prev = null;
                    }
                    else
                    {
                        mover.Prev.Next = mover.Next;

                        if (mover.Next != null) mover.Next.Prev = mover.Prev;
                    }
                }
                mover = mover.Next;
            }
            return head;
        }
    }
}
