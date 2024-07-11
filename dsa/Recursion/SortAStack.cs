
namespace Recursion;

public class SortAStack
{
    // Given a stack of integers, please sort them using recursion

    public static void Solution()
    {
        Stack<int> stack = new();
        stack.Push(11);
        stack.Push(2);
        stack.Push(32);
        stack.Push(3);
        stack.Push(41);

        // Sort(stack);
        SortStack(stack);

        foreach (int i in stack)
        {
            Console.Write(i);
        }
    }

    private static void Sort(Stack<int> stack)
    {
        int len = stack.Count;
        List<int> list = new();
        for (int i = 0; i < len; i++)
        {
            list.Add(stack.Pop());
        }

        for (int i = 0; i < len; i++)
        {
            int minIndex = FindMin(list, 1, 0);
            stack.Push(list[minIndex]);
            list.RemoveAt(minIndex);
        }
    }
    private static int FindMin(List<int> list, int ind, int minValIndex)
    {
        if (ind >= list.Count) return minValIndex;

        minValIndex = list[ind] > list[minValIndex] ? minValIndex: ind;

        return FindMin(list, ind + 1, minValIndex);

    }

    static void SortStack(Stack<int> stack)
    {
        // Base case: If stack is empty, return
        if (stack.Count == 0)
            return;

        // Remove the top element
        int top = stack.Pop();

        // Sort the remaining stack
        SortStack(stack);

        // Insert the top element back in sorted order
        InsertInSortedOrder(stack, top);
    }

    static void InsertInSortedOrder(Stack<int> stack, int element)
    {
        // Base case: If stack is empty or top of stack is less than or equal to element, push element
        if (stack.Count == 0 || stack.Peek() <= element)
        {
            stack.Push(element);
            return;
        }

        // Remove the top element
        int top = stack.Pop();

        // Insert element in sorted order in the remaining stack
        InsertInSortedOrder(stack, element);

        // Push the top element back
        stack.Push(top);
    }

}
