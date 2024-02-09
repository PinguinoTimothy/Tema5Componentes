using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Paint
{
    public enum tipoFigura
    {
        RECTANGULO,
        CIRCULO,
        TRIANGULO,
        LINEA
    }

    internal class Figura
    {
     

        private tipoFigura tipo;
        private int width;
        private int height;
        private int x;
        private int y;
        private Color color;
        private int aleatorio;

        public Figura()
        {
        }
       private Random rand = new Random();


        public Figura(tipoFigura tipo, int width, int height, int x, int y, Color color)
        {
            Tipo = tipo;
            Width = width;
            Height = height;
            X = x;
            Y = y;
            Color = color;
            rand.Next(X, X + Width);
        }

        internal tipoFigura Tipo
        {
            get => tipo;
            set => tipo = value;
        }
        public int Width
        {
            get => width;
            set => width = value;
        }
        public int Height
        {
            get => height;
            set => height = value;
        }
        public int X
        {
            get => x;
            set => x = value;
        }
        public int Y
        {
            get => y;
            set => y = value;
        }
        public Color Color
        {
            get => color;
            set => color = value;
        }

        public int Aleatorio
        {
            get => aleatorio;
        }
        
        
    }
}
