using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class config : Form
    {
        Form1 parent;
        public config(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }



        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorPreview.BackColor = colorDialog1.Color;

            }

        }

        private void config_Load(object sender, EventArgs e)
        {
            colorPreview.BackColor = parent.colorFondo;
            numGrosor.Value = (decimal)parent.grosorPincel;
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            parent.grosorPincel = (float)numGrosor.Value;
            parent.colorFondo = colorDialog1.Color;
            Close();
        }
    }
}
