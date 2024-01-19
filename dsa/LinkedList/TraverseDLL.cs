using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class TraverseDLL<T>
    {
        public static void Traverse(Node<T> head)
        {
            var mover = head;

            while (mover != null)
            {
                Console.Write(mover.Value + " ");
                mover = mover.Next;
            }
            Console.WriteLine();
        }
    }
}
