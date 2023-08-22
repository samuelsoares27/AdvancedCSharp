using System.Threading;

// Sleep
Console.WriteLine($"Inicio");
Thread.Sleep(1000);
Console.WriteLine($"Fim");

//Join thread espera o termino para prosseguir

Thread t1 = new Thread(ThreadRepeticao);
t1.Start();
t1.Join();

Console.WriteLine($"Termino");
Console.WriteLine($"Termino");
Console.WriteLine($"Termino");
Console.WriteLine($"Termino");


static void ThreadRepeticao(object id)
{
    for (int i = 0; i < 1000; i++)
    {
        Console.WriteLine($"Thread: {id} - Número: {i.ToString()} " +
            $"- Id Interno {Thread.CurrentThread.ManagedThreadId}");
    }
}