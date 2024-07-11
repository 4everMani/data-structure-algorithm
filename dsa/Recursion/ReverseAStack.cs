
namespace Recursion;

public class ReverseAStack
{
    public static void Solution()
    {
        Stack<int> stack = new();
        stack.Push(11);
        stack.Push(2);
        stack.Push(32);
        stack.Push(3);
        stack.Push(41);

        // Sort(stack);
        Reverse(stack);

        foreach (int i in stack)
        {
            Console.Write(i);
        }
    }

    private static void Reverse(Stack<int> stack)
    {
        if (stack.Count == 0) return;
        
        int top = stack.Pop();

        Reverse(stack);

        InsertInOrder(stack, top);
    }

    private static void InsertInOrder(Stack<int> stack, int topElement)
    {
        if (stack.Count == 0) 
        {
            stack.Push(topElement);
            return;
        }

        int top = stack.Pop();
        InsertInOrder(stack, topElement);
        stack.Push(top);
    }
}
