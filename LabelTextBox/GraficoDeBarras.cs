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
    public enum ETipoGrafico
    {
        BARRAS,
        LINEA
    }
    public partial class GraficoDeBarras : UserControl
    {
        public GraficoDeBarras()
        {
            InitializeComponent();
            valores.Add(1);
            valores.Add(4);
            valores.Add(2);
            valores.Add(3);
            valores.Add(1);
            valores.Add(10);
            valores.Add(14);
            valores.Add(11);



        }

        private List<int> valores = new List<int>();
        
        [Category("Mis Propiedades")]
        [Description("Valores del grafico")]
        public List<int> Valores
        {
            set
            {
                valores = value;
                Refresh();
            }
            get
            {
                return valores;
            }
        }

        

        private int valorMaximo;
        
        [Category("Mis Propiedades")]
        [Description("Valor maximo del grafico")]
        public int ValorMaximo
        {
            set
            {
                valorMaximo = value;
                Refresh();
            }
            get
            {
                return valorMaximo;
            }
        }
        

        private bool tamañoAutomatico;
        
        [Category("Mis Propiedades")]
        [Description("Define si el tamaño de los ejes es automatico o manual")]
        public bool TamañoAutomatico
        {
            set
            {
                tamañoAutomatico = value;
                Refresh();
            }
            get
            {
                return tamañoAutomatico;
            }

        }
        

        private string textoEjeX;
        
        [Category("Mis Propiedades")]
        [Description("Define el texto del eje X")]
        public string TextoEjeX
        {
            set
            {
                textoEjeX = value;
                Refresh();
            }
            get
            {
                return textoEjeX;
            }

        }
        

        private string textoEjeY;
        
        [Category("Mis Propiedades")]
        [Description("Define el texto del eje Y")]
        public string TextoEjeY
        {
            set
            {
                textoEjeY = value;
                Refresh();
            }
            get
            {
                return textoEjeY;
            }

        }
        
        private ETipoGrafico tipoGrafico = ETipoGrafico.BARRAS;
        
        [Category("Mis Propiedades")]
        [Description("Define si el grafico es de barras o de linea")]
        public ETipoGrafico TipoGrafico
        {
            set
            {
                tipoGrafico = value;
                Refresh();
            }
            get
            {
                return tipoGrafico;
            }

        }

        

        private Color[] colores = { Color.Green, Color.Blue, Color.Yellow };
        private int colorActual = 0;
       

        protected override void OnPaint(PaintEventArgs e)
        {
        
            base.OnPaint(e);
            
            Graphics g = e.Graphics;
            Pen lapiz = new Pen(Color.Black, 2);
            int width = this.Width - 20;
            int height = this.Height - 20;

            g.DrawLine(lapiz,new Point(20,height),new Point(width,height));
            g.DrawString(textoEjeX, this.Font, Brushes.Black, (this.Width -5) / 3, this.Height-15);
            g.DrawLine(lapiz, new Point(20,0), new Point(20, height));
            g.TranslateTransform(15, this.Height / 3);
            g.RotateTransform(90);
            g.DrawString(textoEjeY, this.Font, Brushes.Black, 0, 0);
            g.ResetTransform();

            int tamañoMaximoAux;


            if (tamañoAutomatico)
            {
                tamañoMaximoAux = valores.Max();
            }
            else
            {
                tamañoMaximoAux = valorMaximo;
            }
            if (tamañoMaximoAux == 0)
            {
                tamañoMaximoAux = 1;
            }


            if (tipoGrafico == ETipoGrafico.BARRAS)
            {
                colorActual = 0;
                for (int i = 0; i < valores.Count; i++)
                {
                    if (valores[i] > tamañoMaximoAux)
                    {
                        lapiz.Color = Color.Red;
                        g.DrawLine(lapiz, new Point((width) / valores.Count * (i + 1), height), new Point((width) / valores.Count * (i + 1), 0));

                    }
                    else
                    {
                        lapiz.Color = colores[colorActual];

                        g.DrawLine(lapiz, new Point((width) / valores.Count * (i + 1), height), new Point((width) / valores.Count * (i + 1), ((height) / tamañoMaximoAux * (tamañoMaximoAux - valores[i]))));
                    }

                    colorActual++;
                    if (colorActual >= 3)
                    {
                        colorActual = 0;
                    }
                }
            }
            else
            {
                SolidBrush b = new SolidBrush(Color.Black);

                Point anteriorPunto = new Point(20,height);
                for (int i = 0; i < valores.Count; i++)
                {
                    Point puntoActual = new Point((width) / valores.Count * (i + 1), ((height) / tamañoMaximoAux * (tamañoMaximoAux - valores[i])));
                    if (valores[i] > tamañoMaximoAux)
                    {
                        puntoActual.Y = 0;
                        g.FillRectangle(Brushes.Red, new Rectangle(puntoActual, new Size(5, 5)));


                    }
                    else
                    {
                        g.FillRectangle(b, new Rectangle(puntoActual, new Size(5, 5)));

                    }
              
                    puntoActual.X += 2;
                    lapiz.Color = this.ForeColor;
                    g.DrawLine(lapiz,anteriorPunto,puntoActual);
                    anteriorPunto = puntoActual;
                }
            }
        }
    }
}
