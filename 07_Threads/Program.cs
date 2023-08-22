using System.Threading;



Thread t1 = new Thread(ThreadRepeticao);

t1.Start();

for (int i = 0; i < 10000; i++)
{
    Console.WriteLine($"TESTE TESTE: {i.ToString()}");
}


static void ThreadRepeticao()
{
    for(int i = 0; i < 10000; i++)
    {
        Console.WriteLine($"Número: {i.ToString()}");
    }
}
