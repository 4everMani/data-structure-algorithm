using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
    public class LinkedList<T>
    {
        public Node<T>? Head { get; set; }

        public LinkedList()
        {
            Head = null;
        }

        // For all the operations below, Head will be always given in the question

        // Traversing a LL
        public void Traverse()
        {
            var mover = Head; // to prevent tempering head

            while (mover != null)
            {
                Console.Write(mover.Value + " ");
                mover = mover.Next;
            }
            Console.WriteLine();
        }

        // LinkedList Length
        public int Length()
        {
            var mover = Head; // to prevent tempering head
            int count = 0;

            while (mover != null)
            {
                mover = mover.Next;
                count++;
            }
            Console.WriteLine(count);
            return count;
        }

        // Search in LinkedList
        public bool CheckElementPresent(T element)
        {
            var mover = Head;

            while (mover != null)
            {
                if (mover.Value.Equals(element)) 
                {
                    Console.WriteLine(true);
                    return true;
                }
                mover = mover.Next;
            }
            Console.WriteLine(false);
            return false;
        }

        public Node<T>? RemoveHead()
        {
            if (Head == null) return Head;
            Head = Head.Next;
            Traverse();
            return Head;
        }

        public Node<T>? RemoveTail()
        {
            if (Head == null || Head.Next == null) return null;
            
            var mover = Head;
            while (mover.Next.Next != null)
            {
                mover = mover.Next;
            }
            mover.Next = null;
            Traverse();
            return Head;

        }
        //public Node<T>? DeleteNode(T element)
        //{
        //    else
        //    {
                

        //        var tempNode = mover.Next.Next;
        //        if (tempNode != null)
        //        {
        //            mover.Next = tempNode;
        //        }
        //        else mover.Next = null;
        //    }
           

        //    Traverse();
        //    return Head;
        //}
    }
}
