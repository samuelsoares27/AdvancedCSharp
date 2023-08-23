using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Library.Eventos.Mensageiro
{
    public class Email
    {
        public void EnviarEmail(Video video)
        {
            Console.WriteLine($"E-mail enviado para o vídeo {video.Nome}");
        }
    }
}
