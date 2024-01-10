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
            return Head;

        }

        public Node<T>? RemoveElementAt(int position)
        {
            // we will always get one position argument and one head argument

            if (Head == null) return Head;
            else if (position == 1)
            {
                Head = Head.Next;
            }
            else 
            {
                var count = 0;
                var mover = Head;
                var previousNode = Head;
                while (mover != null)
                {
                    count++;
                    if (count == position)
                    {
                        previousNode.Next = mover.Next;
                        break;
                    }
                    previousNode = mover;
                    mover = mover.Next;
                }
            }
            return Head;   
        }

        public Node<T>? RemoveElement(T value)
        {
            if (Head == null) return Head;
            else if (Head.Value.Equals(value))
            {
                Head = Head.Next;
                return Head;
            }
            var mover = Head;
            var previousNode = Head;

            while (mover != null)
            {
                if (mover.Value.Equals(value))
                {
                    previousNode.Next = mover.Next;
                    break;
                }
                previousNode = mover;
                mover = mover.Next;
            }
            return Head;
        }

        public Node<T>? InsertHead(T value)
        {
            if (Head is null) return new Node<T>(value);

            // creating temp node
            var tempNode = new Node<T>(value);
            // assigning Head to temp -> next
            tempNode.Next = Head;
            // adding new head
            Head = tempNode;
            return Head;
        }

        public Node<T>? InsertTail(T value)
        {
            if (Head is null) return new Node<T>(value);

            // creating temp node
            var tempNode = new Node<T>(value);

            var mover = Head;

            while (mover.Next != null)
            {
                mover = mover.Next;
            }
            mover.Next = tempNode;
            return Head;
        }

        public Node<T>? InsertAt(int position, T value)
        {
            // creating new temp node
            var tempNode = new Node<T>(value);

            // if linkedlist is empty
            if (Head is null)
            {
                if (position == 1)
                {
                    return tempNode;
                }
                else
                {
                    return null;
                }
            }

            // if positon is on head
            else if (position == 1)
            {
                tempNode.Next = Head;
                Head = tempNode;
                return Head;
            }
            else
            {
                var mover = Head;
                var count = 0;
                while (mover != null)
                {
                    count++;
                    if (count == position - 1)
                    {
                        tempNode.Next = mover.Next;
                        mover.Next = tempNode;
                        break;
                    }
                    mover = mover.Next;
                }
                return Head;
            }
        }

        public Node<T>? InsertBeforeValue(T value, T newValue)
        {
            // creating new temp node
            var tempNode = new Node<T>(newValue);

            // if linkedlist is empty
            if (Head is null)
            {
                return null;
            }

            // if positon is on head
            else if (Head.Value.Equals(value))
            {
                tempNode.Next = Head;
                Head = tempNode;
                return Head;
            }
            else
            {
                var mover = Head;
                while (mover != null)
                {
                    if (mover.Next != null && mover.Next.Value.Equals(value))
                    {
                        tempNode.Next = mover.Next;
                        mover.Next = tempNode;
                        break;
                    }
                    mover = mover.Next;
                }
                return Head;
            }
        }

    }
}
