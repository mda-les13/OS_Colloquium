public class LinkedListNode<T>
{
    public T Value { get; set; }
    public LinkedListNode<T> Next { get; set; }

    public LinkedListNode(T value)
    {
        Value = value;
    }
}

public class LinkedListReverser
{
    public LinkedListNode<T> Reverse<T>(LinkedListNode<T> head)
    {
        LinkedListNode<T> previous = null;
        LinkedListNode<T> current = head;
        LinkedListNode<T> next = null;

        while (current != null)
        {
            next = current.Next;
            current.Next = previous;
            previous = current;
            current = next;
        }

        return previous;
    }
}
