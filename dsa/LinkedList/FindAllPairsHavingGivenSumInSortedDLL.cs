using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class FindAllPairsHavingGivenSumInSortedDLL
    {
        
        public static void Solution(int[] nums, int sum)
        {
            Node<int> head = ConvertArrayToDLL<int>.Convert2DLL(nums);

            //List<List<int>> result = MostNaiveSolution(head, sum);
            //List<List<int>> result = NaiveSolution(head, sum);
            List<List<int>> result = ImprovedSolution(head, sum);

            foreach (List<int> list in result)
            {
                Console.WriteLine($"{list[0]}, {list[1]}");
            }

        }

        // Time: O(n^2)
        // Space: O(1)
        private static List<List<int>> MostNaiveSolution(Node<int> head, int sum)
        {
            var mover1 = head;
            var mover2 = head.Next;
            var output = new List<List<int>>();

            while (mover1.Next != null)
            {
                if (mover1.Value + mover2.Value == sum)
                {
                    output.Add([mover1.Value, mover2.Value]);
                    mover1 = mover1.Next;
                    mover2 = mover1.Next;
                    continue;
                }
                mover2 = mover2.Next;

                if (mover2 == null || (mover1.Value + mover2.Value > sum))
                {
                    mover1 = mover1.Next;
                    mover2 = mover1.Next;
                }
            }
            return output;
        }

        // Time: O(n)
        // Space: O(n)
        private static List<List<int>> NaiveSolution(Node<int> head, int sum)
        {
            var set = new HashSet<int>();
            var mover = head;
            var output = new List<List<int>>();

            while (mover != null)
            {
                var diff = sum - mover.Value;

                if (set.Contains(diff))
                {
                    output.Add(new List<int> { diff, mover.Value });
                }
                else
                {
                    set.Add(mover.Value);
                }

                mover = mover.Next;
            }
            return output;
        }

        // Time: O(2n)
        // Space: O(1)
        private static List<List<int>> ImprovedSolution(Node<int> head, int sum)
        {
            var start = head;
            var end = head;
            var output = new List<List<int>>();
            // moving towards end of the DLL
            while (end.Next != null)
            {
                end = end.Next;
            }

            while(start != end)
            {
                if ((start.Value + end.Value) == sum)
                {
                    output.Add([start.Value, end.Value]);
                    start = start.Next;
                }
                else if ((start.Value + end.Value) < sum) start = start.Next;
                else end = end.Prev;
            }
            return output;
        }
    }
}
