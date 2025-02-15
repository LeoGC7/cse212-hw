using System;

public class Node<T>
{
    public T Data;
    public Node<T> Next;

    public Node(T data)
    {
        Data = data;
        Next = null;
    }
}

// Stack using Linked List
public class Stack<T>
{
    private Node<T> top;

    public void Push(T data)
    {
        Node<T> newNode = new Node<T>(data);
        newNode.Next = top;
        top = newNode;
    }

    public T Pop()
    {
        if (IsEmpty()) throw new InvalidOperationException("Stack is empty.");
        T data = top.Data;
        top = top.Next;
        return data;
    }

    public T GetTop()
    {
        if (IsEmpty()) throw new InvalidOperationException("Stack is empty.");
        return top.Data;
    }

    public bool IsEmpty()
    {
        return top == null;
    }
}

// Queue using Linked List
public class Queue<T>
{
    private Node<T> front;
    private Node<T> rear;
    private int count;

    public void Enqueue(T data)
    {
        Node<T> newNode = new Node<T>(data);
        if (rear != null) rear.Next = newNode;
        rear = newNode;
        if (front == null) front = newNode;
        count++;
    }

    public T Dequeue()
    {
        if (IsEmpty()) throw new InvalidOperationException("Queue is empty.");
        T data = front.Data;
        front = front.Next;
        if (front == null) rear = null;
        count--;
        return data;
    }

    public bool IsEmpty()
    {
        return front == null;
    }

    public int Size()
    {
        return count;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Stack Example:");
        Stack<int> stack = new Stack<int>();
        stack.Push(10);
        stack.Push(20);
        Console.WriteLine($"Top Element: {stack.GetTop()}");
        Console.WriteLine($"Popped: {stack.Pop()}");

        Console.WriteLine("\nQueue Example:");
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(10);
        queue.Enqueue(20);
        Console.WriteLine($"Dequeued: {queue.Dequeue()}");
        Console.WriteLine($"Queue Size: {queue.Size()}");
    }
}
