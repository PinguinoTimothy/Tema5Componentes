using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pruebas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelTextBox1.Poscion = labelTextBox1.Poscion == LabelTextBox.LabelTextBox.EPosicion.IZQUIERDA ? LabelTextBox.LabelTextBox.EPosicion.DERECHA : LabelTextBox.LabelTextBox.EPosicion.IZQUIERDA;
        }

        private void labelTextBox1_PosicionChanged(object sender, EventArgs e)
        {
            this.Text = labelTextBox1.Poscion.ToString();

        }

        private void btnSeparacion_Click(object sender, EventArgs e)
        {
                    
            if (labelTextBox1.Separacion >= 50)
            {
                labelTextBox1.Separacion = 5;
            }
            else
            {
            labelTextBox1.Separacion += 5;
            }
        }

        private void labelTextBox1_SeparacionChanged(object sender, EventArgs e)
        {
            this.Text = labelTextBox1.Separacion.ToString();
        }

        private void labelTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
                this.Text = "Letra: " + e.KeyCode;
            

        }

        private void btnSubrayado_Click(object sender, EventArgs e)
        {
            labelTextBox1.Subrayado = !labelTextBox1.Subrayado;
        }

        private void etiquetaAviso1_Click(object sender, EventArgs e)
        {

        }

        private void etiquetaAviso1_ClickEnMarca(object sender, EventArgs e)
        {
            Debug.WriteLine("1");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            validateTextBox1.Texto = validateTextBox1.Height.ToString();
        }
    }
}
