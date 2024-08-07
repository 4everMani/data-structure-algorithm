namespace Stack_Queue;

public class QueueUsingStack
{
    // For queue we use two variables therefore we will use two stacks.
    private Stack<int> stack1 = new();
    private Stack<int> stack2 = new();

    // O(2n)
    public void Push(int item)
    {
        if (stack1 == null) stack1.Push(item);
        else
        {
            var count = stack1.Count;
            for (int i = 1; i <= count; i++)
            {
                stack2.Push(stack1.Pop());
            }
            stack1.Push(item);
            count = stack2.Count;
            for (int i = 1; i <= count; i++)
            {
                stack1.Push(stack2.Pop());
            }
        }
    }

    public int Pop()
    {
        return stack1.Pop();
    }

    public int Top()
    {
        return stack1.Peek();
    }

    public int Count() => stack1.Count;


}
