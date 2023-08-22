using System.Threading;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Thread {i}");
    Thread t1 = new Thread(ThreadRepeticao);

    t1.Start();
}


static void ThreadRepeticao()
{
    for (int i = 0; i < 1000; i++)
    {
        Console.WriteLine($"Número: {i.ToString()}");
    }
}
