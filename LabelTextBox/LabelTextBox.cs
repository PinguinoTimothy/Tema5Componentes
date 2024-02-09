using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LabelTextBox.LabelTextBox;
using System.Drawing.Design;

namespace LabelTextBox
{
    public partial class LabelTextBox : UserControl
    {
        public LabelTextBox()
        {
            InitializeComponent();
            TextLbl = Name;
            TextTxt = "";
            recolocar();
        }


        public enum EPosicion
        {
            IZQUIERDA, DERECHA
        }

        private EPosicion posicion = EPosicion.IZQUIERDA;
        [Category("Mis Propiedades")]
        [Description("Indica si la Label se sitúa a la IZQUIERDA o DERECHA del Textbox")]
        public EPosicion Poscion
        {
            set
            {
                if (Enum.IsDefined(typeof(EPosicion), value))
                {
                    posicion = value;
            
                    OnPosicionChanged(EventArgs.Empty);
                    Refresh();
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }

            get
            {
                return posicion;
            }
        }

        //Pixeles de separación entre label y textbox
        private int separacion = 0;
        [Category("Mis Propiedades")]
        [Description("Píxels de separación entre Label y Textbox")]
        public int Separacion
        {
            set
            {
                if (value >= 0)
                {
                    separacion = value;
                    OnSeparacionChanged(EventArgs.Empty);
                    Refresh();

                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            get
            {
                return separacion;
            }
        }

        private void recolocar()
        {
            switch (posicion)
            {
                case EPosicion.IZQUIERDA:
                    //Establecemos posición del componente lbl
                    lbl.Location = new Point(0, 0);
                    // Establecemos posición componente txt
                    txt.Location = new Point(lbl.Width + Separacion, 0);
                    
                    this.Width = txt.Width + lbl.Width + Separacion;
                    //Establecemos altura del componente
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
                case EPosicion.DERECHA:
                    //Establecemos posición del componente txt
                    txt.Location = new Point(0, 0);
                    //Establecemos ancho del Textbox
                    this.Width = txt.Width + lbl.Width + Separacion;
                    //Establecemos posición del componente lbl
                    lbl.Location = new Point(txt.Width + Separacion, 0);
                    //Establecemos altura del componente (Puede sacarse del switch)
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
            }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            recolocar();
        }




        [Category("Mis Propiedades")] // O se puede meter en categoría Appearance.
        [Description("Texto asociado a la Label del control")]
        public string TextLbl
        {
            set
            {
                lbl.Text = value;
                recolocar();
            }
            get
            {
                return lbl.Text;
            }
        }
        [Category("Mis Propiedades")]
        [Description("Texto asociado al TextBox del control")]
        public string TextTxt
        {
            set
            {
                txt.Text = value;
            }
            get
            {
                return txt.Text;
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        [Category("Mis eventos")]
        [Description("Se lanza cuando la propiedad Posicion cambia")]
        public event System.EventHandler PosicionChanged;
        protected virtual void OnPosicionChanged(EventArgs e)
        {
            if (PosicionChanged != null)
            {
                PosicionChanged(this, e);
            }
        }


        [Category("Mis eventos")]
        [Description("Se lanza cuando la propiedad Separacion cambia")]
        public event System.EventHandler SeparacionChanged;
        protected virtual void OnSeparacionChanged(EventArgs e)
        {
            if (SeparacionChanged != null)
            {
                SeparacionChanged(this, e);
            }
        }

        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
            this.OnKeyUp(e);
        }



        private void txt_TextChanged(object sender, EventArgs e)
        {
            this.OnTxtChanged(e);
        }




        [Category("Mis eventos")]
        [Description("Se lanza cuando se lanza el evento TextChanged del textbox cambia")]
        public event System.EventHandler TxtChanged;
        protected virtual void OnTxtChanged(EventArgs e)
        {
            if (TxtChanged != null)
            {
                TxtChanged(this, e);
            }
        }



    
        [Category("Mis propiedades")]
        [Description("Cambia el PasswordChar del textbox")]
        public char PswChar
        {
            set
            {
               
                txt.PasswordChar = value;
            }
            get
            {
                return txt.PasswordChar;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            recolocar();
            if (subrayado)
            {
                e.Graphics.DrawLine(new Pen(Color.Violet), lbl.Left, this.Height - 1, lbl.Left + lbl.Width, this.Height - 1);
            }
            else
            {
                    
            }
        }

        private bool subrayado;
        [Category("Mis propiedades")]
        [Description("Subraya el label")]
        public bool Subrayado
        {
            set
            {
                subrayado = value;
                Refresh();
            }
            get
            {
                return subrayado;
            }
        }
    }
}
