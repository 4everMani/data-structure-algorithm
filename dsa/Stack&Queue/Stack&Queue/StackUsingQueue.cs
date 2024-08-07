namespace Stack_Queue;

public class StackUsingQueue
{
    private Queue<int> queue = new();


    // O(n)
    public void Push(int value)
    {
        queue.Enqueue(value);
        var size = queue.Count;

        for (int i = 1; i < size; i++)
        {
            var item = queue.Dequeue();
            queue.Enqueue(item);
        }
    }

    public int Pop()
    {
        return queue.Dequeue();
    }

    public int Peek()
    {
        return queue.Peek();
    }

    public int Count()
    {
        return queue.Count;
    }
}
