using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using NuevosComponentes;

namespace Graficos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "JSON (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;
            try
            {

                using (BinaryReader br = new BinaryReader(new FileStream(pathConfig, FileMode.Open)))
                {
                    try
                    {
                        columnas = br.ReadInt32();
                        colorLinea = Color.FromArgb(br.ReadInt32());
                        tipoGrafico = br.ReadBoolean() ? ETipoGrafico.BARRAS : ETipoGrafico.LINEA;
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw new FileNotFoundException();
                       
                    }
                }
            }catch(FileNotFoundException ex)
            {
                MessageBox.Show("Error al cargar la configuracion");
                Console.WriteLine(ex.Message);
                columnas = 3;
                colorLinea = Color.Black;
                tipoGrafico = ETipoGrafico.BARRAS;
            }
        }

        public int columnas = 1;
        public Color colorLinea = Color.Black;
        public ETipoGrafico tipoGrafico = ETipoGrafico.BARRAS;
        private string pathConfig = Environment.GetEnvironmentVariable("APPDATA") + "config.bin";

        private List<Grafico> graficos = new List<Grafico>();

        private void MenuAbrir_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    try
                    {

                        string text = sr.ReadToEnd();
                        graficos = JsonSerializer.Deserialize<List<Grafico>>(text);
                        CrearGraficos();
                    }
                    catch (Exception ex) when (ex is JsonException || ex is NotSupportedException || ex is ArgumentNullException || ex is IOException)
                    {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show("Error al leer el archivo. Revisa que el formato es correcto");
                        graficos.Clear();
                    }
                }


            }
        }


        public void CrearGraficos()
        {
            for (int i = Controls.Count-1; i >= 0 ; i--)
            {
                if (Controls[i] is GraficoDeBarras || Controls[i] is Label)
                {
                    Controls.Remove(Controls[i]);
                }
            }
            

            int x = 20;
            int y = 50;
            int cont = 0;
            foreach (Grafico grafico in graficos)
            {
               
                grafico.GraficoDeBarras.Location = new Point(x, y+30);
                grafico.GraficoDeBarras.ForeColor = colorLinea;
                grafico.GraficoDeBarras.TipoGrafico = tipoGrafico;

                Label label = new Label();
                label.Text = grafico.NombreGrafico;
                label.Location = new Point(x + grafico.GraficoDeBarras.Width/3, y);
                label.AutoSize = true;

                Controls.Add(grafico.GraficoDeBarras);
                Controls.Add(label);

                cont++;
                x += grafico.GraficoDeBarras.Width + 30;
                if (cont == columnas)
                {
                    x = 20;
                    y += grafico.GraficoDeBarras.Height + 50;
                    cont = 0;
                }
                

            }
        }

        private void MenuConfiguracion_Click(object sender, EventArgs e)
        {
            (new Config(this)).ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (BinaryWriter bw = new BinaryWriter(new FileStream(pathConfig, FileMode.Create)))
            {
                try
                {
                    bw.Write(columnas);
                    bw.Write(colorLinea.ToArgb());
                    bw.Write(tipoGrafico == ETipoGrafico.BARRAS);
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void MenuSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
