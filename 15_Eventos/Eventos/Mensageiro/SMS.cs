using System;
using static _15_Eventos.Eventos.VideoEnconde;

namespace _15_Eventos.Eventos.Mensageiro
{
    public class SMS
    {
        public void EnviarMensagem(object sender, VideoEventArgs args)
        {
            Console.WriteLine($"SMS enviado para o vídeo {args.Video.Nome}");
        }
    }
}
