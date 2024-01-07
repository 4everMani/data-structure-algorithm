using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class ConvertArrayToLL
    {
        public static Node<int> Convert2LL(int[] arr)
        {
            var head = new Node<int>(arr[0]);
            var mover = head;

            for (int i = 1; i < arr.Length; i++)
            {
                var tempNode = new Node<int>(arr[i]);
                mover.Next = tempNode;
                mover = tempNode;
            }
            Console.WriteLine(head.Value);
            return head;
        }
    }
}
