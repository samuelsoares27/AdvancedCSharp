using System;
using System.Windows.Forms;
using _15_Eventos.Eventos;
using _15_Eventos.Eventos.Mensageiro;

namespace _15_Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnVideoEncode.Click += btnVideoEncode_Click;
        }

        private void btnVideoEncode_Click(object sender, EventArgs e)
        {
            Video video = new Video() { Nome = "video.mp4" };
            
            VideoEnconde videoEnconde = new VideoEnconde();

            //videoEnconde.Encode += new Email().EnviarEmail;


            videoEnconde.Encode(video);
        }
    }
}
