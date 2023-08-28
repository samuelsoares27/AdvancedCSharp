using System;
using static _15_Eventos.Eventos.VideoEnconde;

namespace _15_Eventos.Eventos.Mensageiro
{
    public class Email
    {
        public void EnviarEmail(object sender, VideoEventArgs args)
        {
            Console.WriteLine($"E-mail enviado para o vídeo {args.Video.Nome}");
        }
    }
}
