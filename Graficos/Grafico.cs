using NuevosComponentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficos
{
    internal class Grafico
    {
        public Grafico(string nombreGrafico, string textoEjeX, string textoEjeY, int[] valores)
        {
            NombreGrafico = nombreGrafico;
            TextoEjeX = textoEjeX;
            TextoEjeY = textoEjeY;
            Valores = valores;

            GraficoDeBarras graficoDeBarras = new GraficoDeBarras();
            graficoDeBarras.Valores = Valores.ToList();
            graficoDeBarras.TextoEjeX = TextoEjeX;
            graficoDeBarras.TextoEjeY = TextoEjeY;
            graficoDeBarras.TamañoAutomatico = true;
            GraficoDeBarras = graficoDeBarras;

        }

        public string NombreGrafico { get; set; }
        public string TextoEjeX { get; set; }
        public string TextoEjeY { get; set; }
        public int[] Valores { get; set; }
        public GraficoDeBarras GraficoDeBarras { get; set; }

       
    }
}
