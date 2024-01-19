using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class FindIntersectionPointInYLL
    {
        // You will be given two linkedlist
        // Your task will be to fing first intersection between both of them
        // Example
        // ll1 => [3, 1, 4, 6, 2]
        // ll2 => [1, 2, 4, 5, 4, 6, 2]
        // output = 4

        public static void Solution()
        {
            var ll1 = new Node<int>(3);
            ll1.Next = new Node<int>(1);
            ll1.Next.Next = new Node<int>(4);
            ll1.Next.Next.Next = new Node<int>(6);
            ll1.Next.Next.Next.Next = new Node<int>(2);

            var ll2 = new Node<int>(1);
            ll2.Next = new Node<int>(2);
            ll2.Next.Next = new Node<int>(4);
            ll2.Next.Next.Next = new Node<int>(5);
            ll2.Next.Next.Next.Next = ll1.Next.Next;

            //int? result = NaiveSolution(ll1, ll2);
            //int? result = ImprovedSolution(ll1, ll2);
            int? result = BestSolution(ll1, ll2);

            Console.WriteLine(result is not null ? result : "No intersection point");
        }

        // Time: O(n1 + n2) n1 = length of ll1, n2= length of ll n2
        // Space: O(n1)
        private static int? NaiveSolution(Node<int> ll1, Node<int> ll2)
        {
            var set = new HashSet<Node<int>>();
            var moverL1 = ll1;

            while (moverL1 != null)
            {
                set.Add(moverL1);
                moverL1 = moverL1.Next;
            }

            var moverL2 = ll2;
            while (moverL2 != null)
            {
                if (set.Contains(moverL2)) return moverL2.Value;
                moverL2 = moverL2.Next;
            }
            return null;
        }

        // Time: O(n1 + n2 + difference + n1 - difference)
        // Time: O(n1 + n2 + n1)
        // Time: O(2n1 + n2)
        private static int? ImprovedSolution(Node<int> ll1, Node<int> ll2)
        {
            var moverLL1 = ll1;
            var moverLL2 = ll2;
            var countLL1 = 0;
            var countLL2 = 0;

            while (moverLL1 != null)
            {
                countLL1++;
                moverLL1 = moverLL1.Next;
            }

            while (moverLL2 != null)
            {
                countLL2++;
                moverLL2 = moverLL2.Next;
            }

            var difference = Math.Abs(countLL1 - countLL2);
            moverLL1 = ll1;
            moverLL2 = ll2;
            if (difference != 0)
            {
                while (difference > 0)
                {
                    _ = countLL1 > countLL2 ? moverLL1 = moverLL1.Next : moverLL2 =moverLL2.Next;
                    difference -= 1;
                }
            }

            while (moverLL1 != null)
            {
                if (moverLL2 == moverLL1) return moverLL1.Value;
                moverLL1 = moverLL1.Next;
                moverLL2 = moverLL2.Next;
            }
            return null;
        }

        //Time: O(n1 + n2) if intersecton not found
        private static int? BestSolution(Node<int> ll1,  Node<int> ll2)
        {
            if (ll1 == null || ll2 == null) return null;
            var moverLL1 = ll1;
            var moverLL2 = ll2;

            while (true)
            {
                if (moverLL1 == moverLL2) return moverLL1.Value;
                else if (moverLL2.Next == null && moverLL1.Next == null)
                {
                    return null;
                }
                else
                {
                    moverLL1 = moverLL1.Next == null ? ll2 : moverLL1.Next;
                    moverLL2 = moverLL2.Next == null ? ll1 : moverLL2.Next;
                }
            }
        }
    }
}
