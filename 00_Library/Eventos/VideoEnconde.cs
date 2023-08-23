using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Library.Eventos
{
    public class VideoEnconde
    {
        public delegate void VideoEncodedHandler(Video video);
        public event VideoEncodedHandler Encoded;
        public void Encode(Video video){
            Console.WriteLine("Convertendo o vídeo...");
            Thread.Sleep(2000);
            Console.WriteLine("vídeo convertido...");

            Encoded(video);
        }
    }
}
