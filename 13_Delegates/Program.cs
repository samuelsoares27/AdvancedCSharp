
public class Example
{
    delegate int Calcula(int a, int b);
    
    static void Main()
    {
        Calcula calcSoma = new Calcula(Soma);
        int resultadoSoma = calcSoma(10, 20);
        Console.WriteLine($"Resultado: {resultadoSoma}");

        Calcula calcSub = new Calcula(Subtrair);
        int resultadoSub = calcSub(30, 20);
        Console.WriteLine($"Resultado: {resultadoSub}");
    }

    private static int Soma(int a, int b)
    {
        return a + b;
    }

    private static int Subtrair(int a, int b)
    {
        return a - b;
    }

}
