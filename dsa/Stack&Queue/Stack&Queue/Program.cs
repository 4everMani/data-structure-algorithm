
using Stack_Queue;

// var stack = new StackUsingArray<int>(10);
// stack.Push(1);
// stack.Push(2);
// stack.Push(3);
// System.Console.WriteLine(stack.Count());
// System.Console.WriteLine(stack.Peek());
// System.Console.WriteLine(stack.Pop());
// System.Console.WriteLine(stack.Count());
// System.Console.WriteLine(stack.Peek());
// stack.Push(99);
// System.Console.WriteLine(stack.Count());
// System.Console.WriteLine(stack.Peek());

// var stackLL = new StackUsingLL();
// stackLL.Push(1);
// stackLL.Push(2);
// stackLL.Push(3);
// System.Console.WriteLine(stackLL.Count());
// System.Console.WriteLine(stackLL.Peek());
// System.Console.WriteLine(stackLL.Pop());
// System.Console.WriteLine(stackLL.Count());
// System.Console.WriteLine(stackLL.Peek());
// stackLL.Push(99);
// System.Console.WriteLine(stackLL.Count());
// System.Console.WriteLine(stackLL.Peek());

var queueLL = new QueueUsingLL();

// queueLL.Push(1);
// queueLL.Push(2);
// queueLL.Push(3);
// System.Console.WriteLine(queueLL.Count());
// System.Console.WriteLine(queueLL.Top());
// System.Console.WriteLine(queueLL.Pop());
// System.Console.WriteLine(queueLL.Count());
// System.Console.WriteLine(queueLL.Top());
// queueLL.Push(99);
// System.Console.WriteLine(queueLL.Count());
// System.Console.WriteLine(queueLL.Top());

// var stackQ = new StackUsingQueue();
// stackQ.Push(55);
// stackQ.Push(56);
// stackQ.Push(57);
// System.Console.WriteLine(stackQ.Count());
// System.Console.WriteLine(stackQ.Peek());
// System.Console.WriteLine(stackQ.Pop());
// System.Console.WriteLine(stackQ.Count());
// System.Console.WriteLine(stackQ.Peek());
// stackQ.Push(99);
// System.Console.WriteLine(stackQ.Count());
// System.Console.WriteLine(stackQ.Peek());

var queueS = new QueueUsingStack();
queueS.Push(11);
queueS.Push(21);
queueS.Push(31);
System.Console.WriteLine(queueS.Count());
System.Console.WriteLine(queueS.Top());
System.Console.WriteLine(queueS.Pop());
System.Console.WriteLine(queueS.Count());
System.Console.WriteLine(queueS.Top());
queueS.Push(99);
System.Console.WriteLine(queueS.Count());
System.Console.WriteLine(queueS.Top());

