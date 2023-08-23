
using _00_Library;

public class Example
{
    delegate int Calcula(int a, int b);

    static void Main()
    {

        //Tela Cadastro: foto Perfil
        Foto fotoperfil = new Foto() { Nome = "fotoPerfil.jpg", TamanhoX = 1920, TamanhoY = 1080 };
        FotoProcessador.filtros = new FotoFiltro().GerarThumb;
        FotoProcessador.Processador(fotoperfil);

        //Tela Cadastro Produtos: Colorir + TamanhoMédio
        Foto fotoProdutos = new Foto() { Nome = "fotoProdutos.jpg", TamanhoX = 1000, TamanhoY = 2000 };
        FotoProcessador.filtros = new FotoFiltro().Colorir;
        FotoProcessador.filtros += new FotoFiltro().RedimensionarTamMedio;
        FotoProcessador.Processador(fotoProdutos);

        //Tela Cadastro Albuns Retrô
        Foto fotoRetro = new Foto() { Nome = "fotoProdutos.jpg", TamanhoX = 500, TamanhoY = 350 };
        FotoProcessador.filtros = new FotoFiltro().PretoBranco;
        FotoProcessador.Processador(fotoRetro);
    }


}
