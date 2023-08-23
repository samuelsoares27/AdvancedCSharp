
using _00_Library;

public class Example
{
    delegate int Calcula(int a, int b);

    static void Main()
    {
        Foto foto = new Foto() { Nome = "foto.jpg", TamanhoX = 1920, TamanhoY = 1080};
        FotoProcessador.Processador(foto);
    }


}
