namespace Stack_Queue;


// Implementing stack using LL has one benefits that we are not limited to space
// All operation will take O(1) time
// Space will be count of item in stack
public class StackUsingLL
{
    private Node<int> top;

    private int size = 0;

    public void Push(int x)
    {
        var temp = new Node<int>(x);
        temp.Next = top;
        top = temp;
        size++;
    }

    public int Pop()
    {
        var temp = top;
        top = top.Next;
        size--;
        return temp.Value;
    }

    public int Peek()
    {
        if (top == null) throw new InvalidOperationException("Stack is empty");
        return top.Value;
    }

    public int Count()
    {
        return size;
    }

}
