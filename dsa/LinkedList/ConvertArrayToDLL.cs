using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class ConvertArrayToDLL<T>
    {
        public static Node<T> Convert2DLL(T[] arr)
        {
            var head = new Node<T>(arr[0]);
            var mover = head;

            for (int i = 1; i < arr.Length; i++)
            {
                var tempNode = new Node<T>(arr[i]);
                tempNode.Prev = mover;
                mover.Next = tempNode;
                mover = tempNode;
            }
            return head;
        }
    }
}
