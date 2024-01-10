using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DoublyLinkedList<T>
    {
        public Node<T>? Head { get; private set; }

        public DoublyLinkedList()
        {
            Head = null;
        }

        public Node<T> Convert2DLL(T[] arr)
        {
            Head = new Node<T>(arr[0]);
            var mover = Head;

            for (int i = 1; i < arr.Length; i++)
            {
                var tempNode = new Node<T>(arr[i]);
                tempNode.Prev = mover;
                mover.Next = tempNode;
                mover = tempNode;
            }
            return Head;
        }

        public void Traverse()
        {
            var mover = Head;
            while (mover != null)
            {
                Console.Write(mover.Value + " ");
                mover = mover.Next;
            }
            Console.WriteLine();
        }

        public Node<T>? DeleteHead()
        {
            if (Head == null || Head.Next == null) return null;
            Head = Head.Next;
            Head.Prev = null;
            return Head;
        }

        public Node<T>? DeleteTail()
        {
            if (Head == null || Head.Next == null) return null;
            var mover = Head;

            while (mover.Next != null)
            {
                mover = mover.Next;
            }
            mover.Prev.Next = null;
            mover.Prev = null;
            return Head;
        }

        public Node<T>? DeleteAt(int position)
        {
            if (Head == null) return Head;
            else if (position == 1)
            {
                if (Head.Next == null)
                {
                    Head = null;
                    return Head;
                }
                Head = Head.Next;
                Head.Prev = null;
                return Head;
            }
            else
            {
                var count = 0;
                var mover = Head;
                while (mover != null && position > 0)
                {
                    count++;
                    if (count == position)
                    {
                        mover.Prev.Next = mover.Next;
                        if (mover.Next != null) mover.Next.Prev = mover.Prev;
                        mover.Next = null;
                        mover.Prev = null;
                        break;

                    }
                    mover = mover.Next;
                }
                return Head;
            }
        }

        public Node<T>? DeleteByValue(T value)
        {
            if (Head == null) return Head;
            else if (Head.Value.Equals(value))
            {
                if (Head.Next == null)
                {
                    Head = null;
                    return Head;
                }
                Head = Head.Next;
                Head.Prev = null;
                return Head;
            }
            else
            {
                var mover = Head;
                while (mover != null)
                {
                    if (mover.Value.Equals(value))
                    {
                        mover.Prev.Next = mover.Next;
                        if (mover.Next != null) mover.Next.Prev = mover.Prev;
                        mover.Next = null;
                        mover.Prev = null;
                        break;
                    }
                    mover = mover.Next;
                }
                return Head;
            }
        }

        public Node<T>? InsertBeforeHead(T value)
        {
            var tempNode = new Node<T>(value);
            if (Head == null)
            {
                Head = tempNode;
            }
            else
            {
                tempNode.Next = Head;
                Head.Prev = tempNode;
                Head = tempNode;
            }
            return Head;
        }

        public Node<T>? InsertBeforeTail(T value)
        {
            if (Head.Next == null) return InsertBeforeHead(value);
            var tempNode = new Node<T>(value);
            var mover = Head;
            while (mover.Next != null)
            {
                mover = mover.Next;
            }
            tempNode.Next = mover;
            tempNode.Prev = mover.Prev;
            mover.Prev.Next = tempNode;
            mover.Prev = tempNode;
            return Head;
        }

        public Node<T>? InsertBeforeKthElement(int position, T value)
        {
            if (position == 1) return InsertBeforeHead(value);
            var tempNode = new Node<T>(value);
            var mover = Head;
            var count = 0;
            while (mover!= null)
            {
                count++;
                if (count == position)
                {
                    tempNode.Next = mover;
                    tempNode.Prev = mover.Prev;
                    mover.Prev.Next = tempNode;
                    mover.Prev = tempNode;
                    break;
                }
                mover = mover.Next;
            }
            return Head;
        }

        public Node<T>? InsertBeforeGivenElement(T givenNodeValue, T value)
        {
            if (Head.Value.Equals(givenNodeValue)) return InsertBeforeHead(value);
            var tempNode = new Node<T>(value);
            var mover = Head;
            while (mover != null)
            {
                if (mover.Value.Equals(givenNodeValue))
                {
                    tempNode.Next = mover;
                    tempNode.Prev = mover.Prev;
                    mover.Prev.Next = tempNode;
                    mover.Prev = tempNode;
                    break;
                }
                mover = mover.Next;
            }
            return Head;
        }
    }
}
