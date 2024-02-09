using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuevosComponentes
{
     public enum EMarca
{
    Nada,
    Cruz,
    Circulo,
    Imagen
}


    public partial class EtiquetaAviso : Control
    {
        public EtiquetaAviso()
        {
            InitializeComponent();
        }

        int offsetX = 0; //Desplazamiento a la derecha del texto
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;
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
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor,h, h);
                    offsetX = h + grosor * 2;
                    offsetY = grosor;
                    break;
                case EMarca.Cruz:
                    grosor = 3;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, h, h);
                    g.DrawLine(lapiz, h, grosor, grosor, h);
                    offsetX = h + grosor*2;
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


           
            




        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (marca != EMarca.Nada)
            {

                if (e.Location.X < offsetX)
                {
                    this.OnClickEnMarca(e);
                }
            }
        }
     


        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }

        private EMarca marca = EMarca.Nada;
        [Category("Appearance")]
        [Description("Indica el tipo de marca que aparece junto al texto")]
        public EMarca Marca
        {
            set
            {
                marca = value;
                this.Refresh();
            }
            get
            {
                return marca;
            }
        }

        private bool gradiente;
        [Category("Appearance")]
        [Description("Indica si hay un fondo gradiente")]
        public bool Gradiente
        {
            set
            {
                gradiente = value;
                this.Refresh();
            }
            get
            {
                return gradiente;
            }
        }

        private Color colorInicial = Color.Red;
        [Category("Appearance")]
        [Description("Indica el color del gradiente inicial")]
        public Color ColorInicial
        {
            set
            {
                colorInicial = value;
                this.Refresh();
            }
            get
            {
                return colorInicial;
            }
        }

        private Color colorFinal = Color.Blue;
        [Category("Appearance")]
        [Description("Indica el color del gradiente final")]
        public Color ColorFinal
        {
            set
            {
                colorFinal = value;
                this.Refresh();
            }
            get
            {
                return colorFinal;
            }
        }

        private Image imagenMarca;
        [Category("Appearance")]
        [Description("La imagen usada con la opcion de Imagen")]
        public Image ImagenMarca
        {
            set
            {
                imagenMarca = value;
                if (!(value is Image))
                {
                    imagenMarca = null;
                    marca = EMarca.Nada;
                }
                this.Refresh();
            }
            get
            {
                return imagenMarca;
            }
        }


        [Category("Mis eventos")]
        [Description("Se lanza cuando se pulsa la marca")]
        public event System.EventHandler ClickEnMarca;
        protected virtual void OnClickEnMarca(EventArgs e)
        {
            if (ClickEnMarca != null)
            {
                ClickEnMarca(this, e);
            }
        }
        



    }
}
