using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebas
{
    public partial class PruebaReproductor : Form
    {
        public PruebaReproductor()
        {
            InitializeComponent();
        }

        string carpeta;
        List<FileInfo> files = new List<FileInfo>();
        private void btnCarpeta_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {


                DirectoryInfo dir = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                string[] patterns = new[] { "*.jpg", "*.jpeg", "*.jpe", "*.jif", "*.jfif", "*.jfi", "*.webp", "*.gif", "*.png", "*.apng", "*.bmp", "*.dib", "*.tiff", "*.tif", "*.svg", "*.svgz", "*.ico", "*.xbm" };

                files.Clear();


                foreach (string pattern in patterns)
                {
                    files.AddRange(dir.GetFiles(pattern));
                }
                if (files.Count > 0)
                {
                    timer1.Start();
                }



            }
        }

        private int fotoActual = 0;
        int segundos = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;
            reproductor1.Segundos++;
            if (segundos >= interval)
            {
                fotoActual++;
                segundos = 0;
            }
            if (files.Count > 0)
            {


                if (fotoActual > files.Count - 1)
                {
                    fotoActual = 0;
                }

                pictureBox1.ImageLocation = files[fotoActual].FullName;
            }
                
            
        }

        private void reproductor1_PlayClick(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void PruebaReproductor_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 20; i++)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.SelectedIndex = 0;
        }

        int interval;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            interval =  (int) comboBox1.SelectedItem;
        }

        private void reproductor1_Load(object sender, EventArgs e)
        {

        }

        private void reproductor1_DesbordaTiempo(object sender, EventArgs e)
        {
            reproductor1.Minutos++;
        }
    }


}

