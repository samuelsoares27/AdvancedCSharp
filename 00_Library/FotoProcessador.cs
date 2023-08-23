using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Library
{
    public class FotoProcessador
    {
        public static void Processador(Foto foto)
        {
            var filtros = new FotoFiltro();
            filtros.Colorir(foto);
            filtros.GerarThumb(foto);
            filtros.PretoBranco(foto);
            filtros.RedimensionarTamMedio(foto);
        }
    }
}
