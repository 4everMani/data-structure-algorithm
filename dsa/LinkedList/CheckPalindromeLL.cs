
namespace LinkedList
{
    public class CheckPalindromeLL
    {
        public static void Solution(int[] nums)
        {
            var ll = ConvertArrayToLL.Convert2LL(nums);
            //Console.WriteLine(NaiveSolution(ll));
            Console.WriteLine(ImprovedSolution(ll)); 
        }

        // Time: O(2n)
        // Space: O(n)
        public static bool NaiveSolution(Node<int> head)
        {
            var mover = head;
            var stack = new Stack<int>();

            while (mover != null)

            {
                stack.Push(mover.Value);
                mover = mover.Next;
            }

            mover = head;

            while (mover != null)
            {
                if (mover.Value != stack.Pop()) return false;
                mover = mover.Next;
            }
            return true;
        }

        // Time: O(2n)
        public static bool ImprovedSolution(Node<int> head)
        {
            var slow = head;
            var fast = head;

            // slow pointer will reach to middle of linkedlist
            while (fast.Next != null && fast.Next.Next != null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;
            }

            // reversing 2nd half of linkedlist
            var reverseLLHead = ReverseLL(slow.Next);

            var first = head;
            var second = reverseLLHead;
            while (second != null)
            {
                if (second.Value != first.Value)
                {
                    // reversing again to make linkedlist look like initial
                    ReverseLL(reverseLLHead);
                    return false;
                } 
                first = first.Next;
                second = second.Next;
            }
            ReverseLL(reverseLLHead);
            return true;
        }

        private static Node<int> ReverseLL(Node<int> head)
        {
            var mover = head;
            Node<int> previousNode = null;

            while (mover != null)
            {
                var frontNode = mover.Next;
                mover.Next = previousNode;
                previousNode = mover;
                mover = frontNode;
            }
            return previousNode;
        }
    }
}
