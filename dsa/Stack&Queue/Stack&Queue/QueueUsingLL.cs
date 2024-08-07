namespace Stack_Queue;

public class QueueUsingLL
{
    private Node<int> start;
    private Node<int> end;

    private int size = 0;


    public void Push(int value)
    {
        var temp = new Node<int>(value);
        if (start == null && end == null)
        {
            end = temp;
            start = temp;
        }
        else
        {
            end.Next = temp;
            end = temp;
        }
        size++;
    }

    public int Pop()
    {
        var temp = start;
        start = start.Next;
        if (start.Next == null)
        {
            start = null;
            end = null;
        }
       size--;
       return temp.Value;
    }

    public int Count() => size;

    public int Top() => start.Value;
}
