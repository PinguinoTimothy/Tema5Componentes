using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuevosComponentes
{
        [
        DefaultProperty("Segundos"),
        DefaultEvent("PlayClick")
        ]
    public partial class Reproductor : UserControl
    {
        public Reproductor()
        {
            InitializeComponent();
      
        }

        private int minutos;
        private int segundos;

        [Category("Mis Propiedades")]
        [Description("Minutos desde que empezó la reproduccion")]
        [Browsable(false)]
        public int Minutos
        {
        
            set
            {

                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    if (value > 59)
                    {
                        minutos = 0;
                    }
                    else
                    {
                        minutos = value;

                    }
                }
                tiempo.Text = string.Format("{0:D2}:{1:D2}", minutos, segundos);
            }
            get
            {
            return minutos; 
            }

        }

        [Category("Mis Propiedades")]
        [Description("Segundos desde que empezó la reproduccion")]
        [Browsable(false)]
        public int Segundos
        {
            set
            {

                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    if (value > 59)
                    {
                        segundos = value % 60;
                        OnDesbordaTiempo(EventArgs.Empty);

                    }
                    else
                    {
                        segundos = value;

                    }
                }
                tiempo.Text = string.Format("{0:D2}:{1:D2}", minutos, segundos);
            }
            get
            {
                return segundos;
            }
        }

         Image play = Properties.Resources.play;
        Image pause = Properties.Resources.pause;



        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnPlay.BackgroundImage = btnPlay.BackgroundImage == pause ? play : pause;
            OnPlayPressed(EventArgs.Empty);
        }

        [Category("Mis eventos")]
        [Description("Se lanza cuando segundos supera 59")]
        public event System.EventHandler DesbordaTiempo;
        protected virtual void OnDesbordaTiempo(EventArgs e)
        {

            if (DesbordaTiempo != null)
            {
                DesbordaTiempo(this, e);
            }
        }

        [Category("Mis eventos")]
        [Description("Se lanza cuando se pulsa el boton de play/pause")]
        public event System.EventHandler PlayClick;
        protected virtual void OnPlayPressed(EventArgs e)
        {

            if (PlayClick != null)
            {
                PlayClick(this, e);
            }
        }

       
    }
}
