public class MyCircularQueue
{
    private int[] data;
    private int head;
    private int tail;
    private int size;
    private int capacity;

    /** Initialize your data structure here. Set the size of the queue to be k. */
    public MyCircularQueue(int k)
    {
        capacity = k;
        data = new int[capacity];
        head = 0;
        tail = -1;
        size = 0;
    }

    /** Insert an element into the circular queue. Return true if the operation is successful. */
    public bool EnQueue(int value)
    {
        if (IsFull())
        {
            return false;
        }

        tail = (tail + 1) % capacity;
        data[tail] = value;
        size++;
        return true;
    }

    /** Delete an element from the circular queue. Return true if the operation is successful. */
    public bool DeQueue()
    {
        if (IsEmpty())
        {
            return false;
        }

        head = (head + 1) % capacity;
        size--;
        return true;
    }

    /** Get the front item from the queue. */
    public int Front()
    {
        if (IsEmpty())
        {
            return -1;
        }

        return data[head];
    }

    /** Get the last item from the queue. */
    public int Rear()
    {
        if (IsEmpty())
        {
            return -1;
        }

        return data[tail];
    }

    /** Checks whether the circular queue is empty or not. */
    public bool IsEmpty()
    {
        return size == 0;
    }

    /** Checks whether the circular queue is full or not. */
    public bool IsFull()
    {
        return size == capacity;
    }
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */