public class MyStack
{

    private Queue<int> queue;

    public MyStack()
    {
        queue = new Queue<int>();
    }

    public void Push(int x)
    {
        queue.Enqueue(x);

        for (int i = 0; i < queue.Count  - 1; i++)
        {
            int item = queue.Dequeue();
            queue.Enqueue(item);
        }
    }

    public int Pop()
        => queue.Dequeue();


    public int Top()
        => queue.FirstOrDefault();

    public bool Empty()
     => queue.Count == 0;
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */