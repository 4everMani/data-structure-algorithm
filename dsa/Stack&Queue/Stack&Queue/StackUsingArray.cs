using Microsoft.VisualBasic;

namespace Stack_Queue;

public class StackUsingArray<T>
{
    private T[] StackArr { get;  set;}

    private int Top { get; set; }   

    public StackUsingArray(int sizeOfArray)
    {
        StackArr = new T[sizeOfArray];
        Top = -1;
    }

    public void Push(T value)
    {
        if (Top == StackArr.Length) throw new InvalidOperationException("Maximum size of stack is reached");
        Top += 1;
        StackArr[Top] = value;
    }

    public T Pop()
    {
        if (Top == -1) throw new InvalidOperationException("Stack is empty");
        var tempValue = StackArr[Top];
        Top -= 1;
        return tempValue;
    }

    public int Count()
    {
        return Top + 1;
    }

    public T Peek()
    {
        return StackArr[Top];
    }

    // all have time complexity have O(1);



    
}
