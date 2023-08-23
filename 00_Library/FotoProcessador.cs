using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Library
{
    public class FotoProcessador
    {
        public delegate void FotoFiltroHandler(Foto foto);

        public static FotoFiltroHandler filtros;

        public static void Processador(Foto foto)
        {
            filtros(foto);
        }
    }
}
