using System;
using System.Threading;

public class Example
{
    private static ManualResetEvent manual01 = new ManualResetEvent(false);
    private static AutoResetEvent auto01 = new AutoResetEvent(false);

    static void Main()
    {

        //Thread thread1 = new Thread(Executa01);
        //thread1.Start();
        Thread thread2 = new Thread(Executa02);
        thread2.Start();

        Thread.Sleep(5000);
        auto01.Set();

        Thread.Sleep(5000);
        auto01.Set();
    }

    private static void Executa01()
    {
        Console.WriteLine($"01 Iniciando - Executa01");
        manual01.WaitOne();
        Console.WriteLine($"02 Executando - Executa01");
        Console.WriteLine($"03 Executando - Executa01");
        manual01.WaitOne();
        Console.WriteLine($"04 Finalizado - Executa01");
    }

    private static void Executa02()
    {
        Console.WriteLine($"01 Iniciando - Executa02");
        auto01.WaitOne();
        Console.WriteLine($"02 Executando - Executa02");
        Console.WriteLine($"03 Executando - Executa02");
        auto01.WaitOne();
        Console.WriteLine($"04 Finalizado - Executa02");
    }
}
