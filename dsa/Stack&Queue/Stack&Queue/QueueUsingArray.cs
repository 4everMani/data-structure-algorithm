namespace Stack_Queue;

public class QueueUsingArray<T>
{
    private T[] Arr = new T[10];

    private int start = -1;
    private int end = -1;

    private int currentSize = 0;

    public void Push(T item)
    {
        if (currentSize == Arr.Length) throw new InvalidOperationException("Queue capacity is full");
        if (currentSize == 0)
        {
            start = 0;
            end = 0;
        }
        else end = (end + 1) % Arr.Length; // modulus is used when end exceds arr.Length but currentSize < arr.Length
        Arr[end] = item;
        currentSize++;
    }

    public T Pop()
    {
        if (currentSize == 0) throw new InvalidOperationException("Queue is empty");
        var temp = Arr[start];
        if (currentSize == 1)
        {
            start = -1;
            end = -1;
        }
        else start = (start + 1) % Arr.Length;
        currentSize--;
        return temp;
    }

    public int Count()
    {
        return currentSize;
    }

    public T Top()
    {
        if (currentSize == 0) throw new InvalidOperationException("Queue is empty");
        return Arr[start];
    }


}
