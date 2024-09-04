namespace DataStructures;

public class Stack<T>
{
    public int capacity;
    public int top = 0;
    public T[] stack;
    public bool infiniteStack;

    public Stack(int capacity)
    {
        this.capacity = capacity;
        stack = new T[capacity];
        Console.WriteLine("New stack created");
        infiniteStack = false;
    }

    public Stack()
    {
        this.capacity = 10;
        stack = new T[capacity];
        Console.WriteLine("New infinite stack created");
        infiniteStack = true;
    }

    public bool IsEmpty()
    {
        return top == 0;
    }

    public void Push(T value)
    {
        if (top == capacity)
        {
            if (infiniteStack)
            
                Resize();
                Console.WriteLine("STACK OVERFLOW!! Cannot add another value to stack.");
                return;
            
        }
        stack[top] = value;
        top++;
        Console.WriteLine($"Pushed value: {value}");

    }

    public void Pop()
    {
        if (IsEmpty())
 
            Console.WriteLine("STACK UNDERFLOW!! NO VALUE TO POP");
  
            top--;
            T popValue = stack[top];
            Console.WriteLine($"Popped value: {popValue}");
       
    }

    public void Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("STACK IS EMPTY");
        }
        else
        {
            T peekValue = stack[top - 1];
            Console.WriteLine($"Top value: {peekValue}");
        }
    }

    public int Size()
    {
        return top;
    }

    public void Resize()
    {
        capacity *= 2;
        T[] newStack = new T[capacity];
        Array.Copy(stack, newStack, stack.Length);
        stack = newStack;
    }


}
