using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class FindMiddleElementInALL
    {
        // Input = [1, 2, 3, 4, 5]
        // Output = 3
        // Input = [1, 2, 3, 4, 5, 6]
        // Output = 4

        public static void Solution(int[] nums)
        {
            var ll = ConvertArrayToLL.Convert2LL(nums);
            //var result = FindMiddleElementNaive(ll);
            var result = FindMiddleElementImproved(ll);
            Console.WriteLine(result);
        }

        // Time = O(n + n/2)
        private static int FindMiddleElementNaive(Node<int> head)
        {
            var mover = head;
            var count = 0;

            while (mover != null)
            {
                count++;
                mover = mover.Next;
            }
            var middle = (count / 2) + 1;
            mover = head;

            while (middle > 1)
            {
                mover = mover.Next;
                middle--;
            }
            return mover.Value;
        }

        // Time = O(n/2)
        private static int FindMiddleElementImproved(Node<int> head)
        {
            var fast = head;
            var slow = head;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }
            return slow.Value;
        }
    }
}
