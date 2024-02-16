using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Figura> figuras = new List<Figura>();
        private Random rand = new Random();
        public Color colorFondo = Color.White;
        public float grosorPincel = 2;


        public void generarFigura(tipoFigura tipo)
        {


            int x = rand.Next(0, pictureBox1.Width);
            int y = rand.Next(0, pictureBox1.Height);

            int width = rand.Next(0, pictureBox1.Width - x);
            int height = rand.Next(0, pictureBox1.Height - y);

            Color color = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            Figura fig = new Figura(tipo, width, height, x, y, color);

            figuras.Add(fig);
            Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            pictureBox1.BackColor = colorFondo;
            Graphics g = e.Graphics;
            Pen lapiz = new Pen(Color.Black, grosorPincel);

            foreach (Figura fig in figuras)
            {
                lapiz.Color = fig.Color;
                switch (fig.Tipo)
                {

                    case tipoFigura.RECTANGULO:
                        g.DrawRectangle(lapiz, new Rectangle(fig.X, fig.Y, fig.Width, fig.Height));
                        break;

                    case tipoFigura.CIRCULO:
                        g.DrawEllipse(lapiz, new Rectangle(fig.X, fig.Y, fig.Width, fig.Width));
                        break;

                    case tipoFigura.TRIANGULO:
                        g.DrawLine(lapiz, new Point(fig.Aleatorio, fig.Y), new Point(fig.X, fig.Y));
                        g.DrawLine(lapiz, new Point(fig.X, fig.Y), new Point(fig.X + fig.Width, fig.Y + fig.Height));
                        g.DrawLine(lapiz, new Point(fig.Aleatorio, fig.Y), new Point(fig.X + fig.Width, fig.Y + fig.Height));

                        break;


                    case tipoFigura.LINEA:
                        g.DrawLine(lapiz, new Point(fig.X, fig.Y), new Point(fig.Width, fig.Height));
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Tag)
            {

                case "circulo":
                    generarFigura(tipoFigura.CIRCULO);
                    break;
                case "rectangulo":
                    generarFigura(tipoFigura.RECTANGULO);
                    break;
                case "triangulo":
                    generarFigura(tipoFigura.TRIANGULO);
                    break;
                case "linea":
                    generarFigura(tipoFigura.LINEA);
                    break;

            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            new config(this).ShowDialog();
            Refresh();
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            if (figuras.Count > 0)
            {
                figuras.RemoveAt(figuras.Count - 1);
                Refresh();
            }
        }

       
    }
}
