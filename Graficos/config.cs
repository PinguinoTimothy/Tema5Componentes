using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficos
{
    public partial class config : Form
    {
        Form1 parent;
        public config(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
            cbColumnas.SelectedIndex = parent.columnas-1;
            lbColor.Items.Add(Color.Black);
            lbColor.Items.Add(Color.Red);
            lbColor.Items.Add(Color.Yellow);
            lbColor.Items.Add(Color.Blue);
            lbColor.Items.Add(Color.Green);
            lbColor.SelectedItem = parent.colorLinea;
            if (parent.tipoGrafico == NuevosComponentes.ETipoGrafico.BARRAS)
            {
                rbBarras.Checked = true;
            }
            else
            {
                rbLineas.Checked = true;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            parent.columnas = int.Parse(cbColumnas.SelectedItem.ToString());
            if (lbColor.SelectedItem != null)
            {
            parent.colorLinea = (Color)lbColor.SelectedItem;
            }
            parent.tipoGrafico = rbBarras.Checked ? NuevosComponentes.ETipoGrafico.BARRAS : NuevosComponentes.ETipoGrafico.LINEA;
            Close();
        }

        private void rbLineas_CheckedChanged(object sender, EventArgs e)
        {
           
                lbColor.Enabled = rbLineas.Checked;
           
        }
    }
}
