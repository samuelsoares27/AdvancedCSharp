using System.Threading;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Thread {i}");
    Thread t1 = new Thread(ThreadRepeticao);    
    t1.Start(i);
}

Console.ReadKey();

static void ThreadRepeticao(object id)
{
    for (int i = 0; i < 1000; i++)
    {
        Console.WriteLine($"Thread: {id} - Número: {i.ToString()} " +
            $"- Id Interno {Thread.CurrentThread.ManagedThreadId}");
    }
}
