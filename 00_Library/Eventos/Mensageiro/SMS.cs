using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Library.Eventos.Mensageiro
{
    public class SMS
    {
        public void EnviarMensagem(Video video)
        {
            Console.WriteLine($"SMS enviado para o vídeo {video.Nome}");
        }
    }
}
