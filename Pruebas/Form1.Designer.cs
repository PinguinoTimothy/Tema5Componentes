namespace Pruebas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPosicion = new System.Windows.Forms.Button();
            this.btnSeparacion = new System.Windows.Forms.Button();
            this.btnSubrayado = new System.Windows.Forms.Button();
            this.validateTextBox1 = new NuevosComponentes.ValidateTextBox();
            this.etiquetaAviso1 = new NuevosComponentes.EtiquetaAviso();
            this.labelTextBox1 = new LabelTextBox.LabelTextBox();
            this.graficoDeBarras1 = new NuevosComponentes.GraficoDeBarras();
            this.SuspendLayout();
            // 
            // btnPosicion
            // 
            this.btnPosicion.Location = new System.Drawing.Point(397, 75);
            this.btnPosicion.Name = "btnPosicion";
            this.btnPosicion.Size = new System.Drawing.Size(75, 23);
            this.btnPosicion.TabIndex = 1;
            this.btnPosicion.Text = "Posicion";
            this.btnPosicion.UseVisualStyleBackColor = true;
            this.btnPosicion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSeparacion
            // 
            this.btnSeparacion.Location = new System.Drawing.Point(397, 117);
            this.btnSeparacion.Name = "btnSeparacion";
            this.btnSeparacion.Size = new System.Drawing.Size(75, 23);
            this.btnSeparacion.TabIndex = 2;
            this.btnSeparacion.Text = "Separacion";
            this.btnSeparacion.UseVisualStyleBackColor = true;
            this.btnSeparacion.Click += new System.EventHandler(this.btnSeparacion_Click);
            // 
            // btnSubrayado
            // 
            this.btnSubrayado.Location = new System.Drawing.Point(397, 156);
            this.btnSubrayado.Name = "btnSubrayado";
            this.btnSubrayado.Size = new System.Drawing.Size(75, 23);
            this.btnSubrayado.TabIndex = 4;
            this.btnSubrayado.Text = "Subrayado";
            this.btnSubrayado.UseVisualStyleBackColor = true;
            this.btnSubrayado.Click += new System.EventHandler(this.btnSubrayado_Click);
            // 
            // validateTextBox1
            // 
            this.validateTextBox1.AutoSize = true;
            this.validateTextBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.validateTextBox1.Location = new System.Drawing.Point(130, 139);
            this.validateTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.validateTextBox1.Multilinea = false;
            this.validateTextBox1.Name = "validateTextBox1";
            this.validateTextBox1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.validateTextBox1.Size = new System.Drawing.Size(10, 40);
            this.validateTextBox1.TabIndex = 6;
            this.validateTextBox1.Texto = "";
            this.validateTextBox1.Tipo = NuevosComponentes.eTipo.Numerico;
            // 
            // etiquetaAviso1
            // 
            this.etiquetaAviso1.ColorFinal = System.Drawing.Color.OliveDrab;
            this.etiquetaAviso1.ColorInicial = System.Drawing.Color.Yellow;
            this.etiquetaAviso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaAviso1.Gradiente = false;
            this.etiquetaAviso1.ImagenMarca = null;
            this.etiquetaAviso1.Location = new System.Drawing.Point(469, 198);
            this.etiquetaAviso1.Marca = NuevosComponentes.EMarca.Nada;
            this.etiquetaAviso1.Name = "etiquetaAviso1";
            this.etiquetaAviso1.Size = new System.Drawing.Size(227, 40);
            this.etiquetaAviso1.TabIndex = 5;
            this.etiquetaAviso1.Text = "etiquetaAviso1";
            this.etiquetaAviso1.ClickEnMarca += new System.EventHandler(this.etiquetaAviso1_ClickEnMarca);
            this.etiquetaAviso1.Click += new System.EventHandler(this.etiquetaAviso1_Click);
            // 
            // labelTextBox1
            // 
            this.labelTextBox1.Location = new System.Drawing.Point(92, 75);
            this.labelTextBox1.Name = "labelTextBox1";
            this.labelTextBox1.Poscion = LabelTextBox.LabelTextBox.EPosicion.IZQUIERDA;
            this.labelTextBox1.PswChar = '\0';
            this.labelTextBox1.Separacion = 0;
            this.labelTextBox1.Size = new System.Drawing.Size(172, 20);
            this.labelTextBox1.Subrayado = false;
            this.labelTextBox1.TabIndex = 3;
            this.labelTextBox1.TextLbl = "LabelTextBox";
            this.labelTextBox1.TextTxt = "";
            this.labelTextBox1.PosicionChanged += new System.EventHandler(this.labelTextBox1_PosicionChanged);
            this.labelTextBox1.SeparacionChanged += new System.EventHandler(this.labelTextBox1_SeparacionChanged);
            this.labelTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.labelTextBox1_KeyUp);
            // 
            // graficoDeBarras1
            // 
            this.graficoDeBarras1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.graficoDeBarras1.Location = new System.Drawing.Point(56, 156);
            this.graficoDeBarras1.Name = "graficoDeBarras1";
            this.graficoDeBarras1.Size = new System.Drawing.Size(388, 150);
            this.graficoDeBarras1.TabIndex = 7;
            this.graficoDeBarras1.TamañoAutomatico = false;
            this.graficoDeBarras1.TextoEjeX = null;
            this.graficoDeBarras1.TextoEjeY = null;
            this.graficoDeBarras1.TipoGrafico = NuevosComponentes.ETipoGrafico.LINEA;
            this.graficoDeBarras1.Valores = ((System.Collections.Generic.List<int>)(resources.GetObject("graficoDeBarras1.Valores")));
            this.graficoDeBarras1.ValorMaximo = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.graficoDeBarras1);
            this.Controls.Add(this.validateTextBox1);
            this.Controls.Add(this.etiquetaAviso1);
            this.Controls.Add(this.btnSubrayado);
            this.Controls.Add(this.labelTextBox1);
            this.Controls.Add(this.btnSeparacion);
            this.Controls.Add(this.btnPosicion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPosicion;
        private System.Windows.Forms.Button btnSeparacion;
        private System.Windows.Forms.Button btnSubrayado;
        private NuevosComponentes.EtiquetaAviso etiquetaAviso1;
        private NuevosComponentes.ValidateTextBox validateTextBox1;
 
        private LabelTextBox.LabelTextBox labelTextBox1;
        private NuevosComponentes.GraficoDeBarras graficoDeBarras1;
    }
}

