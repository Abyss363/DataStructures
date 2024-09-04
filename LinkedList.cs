namespace DataStructures;

public class LinkedList<T>
{
    private class Node
    {
        public T Data;
        public Node? Next;

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    private Node? head;

    public void Add(T data)
    {
        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node? current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
        Console.WriteLine($"Added: {data}");
    }

    public bool Remove(T data)
    {
        if (head == null)
        {
            return false;
        }

        if (head.Data!.Equals(data))
        {
            head = head.Next;
            Console.WriteLine($"Removed value: {data}");
            return true;
        }

        Node? current = head;
        while (current.Next != null && !current.Next.Data!.Equals(data))
        {
            current = current.Next;
        }

        if (current.Next == null)
        {
            return false;
        }

        current.Next = current.Next.Next;
        Console.WriteLine($"Removed value: {data}");
        return true;
    }

    public bool Check(T item)
    {
        Node? current = head;

        while (current != null)
        {
            if (current.Data!.Equals(item))
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public int Index(T item)
    {
        Node? current = head;
        int index = 0;

        while (current != null)
        {
            if (current.Data!.Equals(item))
            {
                return index;
            }
            current = current.Next;
            index++;
        }
        return -1;
    }



    // Method to run the linked list operations based on user input
    public void Run()
    {

    }
}
