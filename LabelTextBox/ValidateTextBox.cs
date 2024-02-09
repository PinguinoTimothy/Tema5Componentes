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
   public enum eTipo
    {
    Numerico,
    Textual
    }
    public partial class ValidateTextBox : UserControl
    {
        public ValidateTextBox()
        {
            InitializeComponent();
            textBox1.Width = this.Width - 20;
            this.Height = textBox1.Height + 20;
        }

        private void ValidateTextBox_Resize(object sender, EventArgs e)
        {
            textBox1.Width = this.Width - 20;
            this.Height = textBox1.Height + 20;
        }

        [Category("Mis Propiedades")]
        [Description("Text del TextBox interno")]

        public string Texto
        {

            set
            {
                textBox1.Text = value;
            }
            get
            {
                return textBox1.Text;
            }

        }
    
        [Category("Mis Propiedades")]
        [Description("Multiline del TextBox interno")]

        public bool Multilinea
        {

            set
            {
                textBox1.Multiline = value;
            }
            get
            {
                return textBox1.Multiline;
            }

        }

        private eTipo tipo;
        [Category("Mis Propiedades")]
        [Description("Text del TextBox interno")]

        public eTipo Tipo
        {

            set
            {
                tipo = value;
                actu();
            }
            get
            {
                return tipo;
            }

        }
        bool correcto = false;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Pen lapiz = new Pen(Color.Red, 2);
            if (correcto)
            {
                lapiz.Color = Color.Green;
            }
            g.DrawRectangle(lapiz, 5, 5, this.Width - 10, this.Height - 10);
        }

        [Category("Mis eventos")]
        [Description("Evento TextChanged del TextBox interno")]
        public event System.EventHandler TextChange;
        protected virtual void OnTextChange(EventArgs e)
        {

            if (TextChange != null)
            {
                TextChange(this, e);
            }
        }
        int aux;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OnTextChange(e);
            actu();
         
        }

        private void actu()
        {
            if (tipo == eTipo.Numerico)
            {

                correcto = int.TryParse(textBox1.Text.Trim(), out _);
            }
            else
            {
                correcto = !textBox1.Text.Any(char.IsDigit);
            }
            this.Refresh();
        }

      
    }
}
