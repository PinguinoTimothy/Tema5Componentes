using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuevosComponentes
{
    public partial class DibujoAhorcado : UserControl
    {
        public DibujoAhorcado()
        {
            InitializeComponent();
        }

        private int errores;

        [Category("Mis Propiedades")]
        [Description("Numero de errores actuales")]

        public int Errores
        {

            set
            {
                errores = value;
                OnCambiaError(EventArgs.Empty);
                this.Refresh();
                if (errores >= 7)
                {
                    OnAhorcado(EventArgs.Empty);
                }
            }
            get
            {
                return errores;
            }

        }

        [Category("Mis eventos")]
        [Description("Se lanza cuando cambia el numero de errores")]
        public event System.EventHandler CambiaError;
        protected virtual void OnCambiaError(EventArgs e)
        {

            if (CambiaError != null)
            {
                CambiaError(this, e);
            }
        }

        [Category("Mis eventos")]
        [Description("Se lanza cuando se completa el dibujo")]
        public event System.EventHandler Ahorcado;
        protected virtual void OnAhorcado(EventArgs e)
        {

            if (Ahorcado != null)
            {
                Ahorcado(this, e);
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;
            Pen lapiz = new Pen(Color.Black, 3);
            Pen lapiz2 = new Pen(Color.Red, 3);

            for (int i = 0; i < errores; i++)
            {
                switch (i)
                {
                    case 0:
                        g.DrawLine(lapiz, new Point(this.Width - 10, this.Height - 10), new Point(10, this.Height - 10));
                        break;
                    case 1:
                        g.DrawLine(lapiz, new Point(10, this.Height - 10), new Point(10, 10));
                        break;
                    case 2:
                        g.DrawLine(lapiz, new Point(10, 10), new Point(this.Width / 2, 10));
                        break;
                    case 3:
                        g.DrawLine(lapiz, new Point(this.Width / 2, 10), new Point(this.Width / 2, this.Height / 3));
                        break;
                    case 4:
                        g.DrawLine(lapiz, new Point(10, this.Height / 2), new Point(this.Width / 4, this.Height - 10));
                        break;
                    case 5:
                        g.DrawLine(lapiz, new Point(10, this.Height / 4), new Point(this.Width / 5, 10));
                        break;
                    case 6:
                        g.DrawEllipse(lapiz2, this.Width / 2 - 15, this.Height / 3, 30, 20);
                        g.DrawLine(lapiz2, new Point(this.Width / 2, this.Height / 3 + 20), new Point(this.Width / 2, this.Height / 3 + 60));

                        g.DrawLine(lapiz2, new Point(this.Width / 2, this.Height / 3 + 20), new Point(this.Width / 2 - 20, this.Height / 3 + 40));
                        g.DrawLine(lapiz2, new Point(this.Width / 2, this.Height / 3 + 20), new Point(this.Width / 2 + 20, this.Height / 3 + 40));

                        g.DrawLine(lapiz2, new Point(this.Width / 2, this.Height / 3 + 59), new Point(this.Width / 2 - 10, this.Height / 3 + 80));
                        g.DrawLine(lapiz2, new Point(this.Width / 2, this.Height / 3 + 59), new Point(this.Width / 2 + 10, this.Height / 3 + 80));

                        break;
                }
            }

            /*
            int grosor = 0; //Grosor de las líneas de dibujo
            offsetX = 0;
            int offsetY = 0; //Desplazamiento hacia abajo del texto
            int h = this.Font.Height; // Altura de fuente, usada como referencia en varias partes
            //Esta propiedad provoca mejoras en la apariencia o en la eficiencia
            // a la hora de dibujar
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (gradiente)
            {
                LinearGradientBrush gb = new LinearGradientBrush(new PointF(0, 0), new PointF(Width, Height), colorInicial, colorFinal);
                g.FillRectangle(gb, 0, 0, Width, Height);
            }

            //Dependiendo del valor de la propiedad marca dibujamos una
            //Cruz o un Círculo
            switch (Marca)
            {
                case EMarca.Circulo:
                    grosor = 20;
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor, h, h);
                    offsetX = h + grosor * 2;
                    offsetY = grosor;
                    break;
                case EMarca.Cruz:
                    grosor = 3;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, h, h);
                    g.DrawLine(lapiz, h, grosor, grosor, h);
                    offsetX = h + grosor * 2;
                    offsetY = grosor / 2;
                    //Es recomendable liberar recursos de dibujo pues se
                    //pueden realizar muchos y cogen memoria
                    lapiz.Dispose();
                    break;
                case EMarca.Imagen:
                    if (imagenMarca != null)
                    {

                        g.DrawImage(imagenMarca, 0, 0, h, h);
                        offsetX = h;
                    }
                    break;

            }
            Size tam = g.MeasureString(this.Text, this.Font).ToSize();

            //Finalmente pintamos el Texto; desplazado si fuera necesario
            SolidBrush b = new SolidBrush(this.ForeColor);
            g.DrawString(this.Text, this.Font, b, offsetX, offsetY);
            this.Size = new Size(tam.Width + offsetX, tam.Height + offsetY * 2);
            b.Dispose();

            */







        }
    }
}
