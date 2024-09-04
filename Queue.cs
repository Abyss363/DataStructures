// This is a circular queue
namespace DataStructures;

public class Queue<T>
{
    public int capacity;
    public int front;
    public int rear;
    public int size;
    public T[] queue;

    public Queue(int capacity)
    {
        this.capacity = capacity;
        queue = new T[capacity];
        front = 0;
        rear = -1;
        size = 0;
    }

    public Queue()
    {
        this.capacity = 10;
        queue = new T[10];
        front = 0;
        rear = -1;
        size = 0;
    }

    public bool IsEmpty()
    {
        return size == 0;
    }

    public bool IsFull()
    {
        return size == capacity;
    }

    public void Enqueue(T value)
    {
        if (IsFull())
        {
            Resize();
        }
        rear = (rear + 1) % capacity;
        queue[rear] = value;
        size++;
        Console.WriteLine($"Enqueued value: {value}");
    }

    public void Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("QUEUE UNDERFLOW!! No value to dequeue.");
        }
        else
        {
            T dequeueValue = queue[front];
            front = (front + 1) % capacity;
            size--;
            Console.WriteLine($"Dequeued value: {dequeueValue}");
        }
    }

    public int Size()
    {
        return size;
    }

    public void Resize()
    {
        int newCapacity = capacity * 2;
        T[] newQueue = new T[newCapacity];

        for (int i = 0; i < size; i++)
        {
            newQueue[i] = queue[(front + i) % capacity];
        }

        queue = newQueue;
        front = 0;
        rear = size - 1;
        capacity = newCapacity;
    }

    public void Run()
    {

    }
}
