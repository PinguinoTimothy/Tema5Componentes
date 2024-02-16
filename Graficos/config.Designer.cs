namespace Graficos
{
    partial class config
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(config));
            this.cbColumnas = new System.Windows.Forms.ComboBox();
            this.rbBarras = new System.Windows.Forms.RadioButton();
            this.rbLineas = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbColumnas
            // 
            this.cbColumnas.FormattingEnabled = true;
            this.cbColumnas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbColumnas.Location = new System.Drawing.Point(142, 26);
            this.cbColumnas.Name = "cbColumnas";
            this.cbColumnas.Size = new System.Drawing.Size(35, 21);
            this.cbColumnas.TabIndex = 0;
            // 
            // rbBarras
            // 
            this.rbBarras.AutoSize = true;
            this.rbBarras.Location = new System.Drawing.Point(141, 63);
            this.rbBarras.Name = "rbBarras";
            this.rbBarras.Size = new System.Drawing.Size(107, 17);
            this.rbBarras.TabIndex = 1;
            this.rbBarras.TabStop = true;
            this.rbBarras.Text = "Grafico de Barras";
            this.rbBarras.UseVisualStyleBackColor = true;
            this.rbBarras.CheckedChanged += new System.EventHandler(this.rbLineas_CheckedChanged);
            // 
            // rbLineas
            // 
            this.rbLineas.AutoSize = true;
            this.rbLineas.Location = new System.Drawing.Point(141, 86);
            this.rbLineas.Name = "rbLineas";
            this.rbLineas.Size = new System.Drawing.Size(108, 17);
            this.rbLineas.TabIndex = 2;
            this.rbLineas.TabStop = true;
            this.rbLineas.Text = "Grafico de Lineas";
            this.rbLineas.UseVisualStyleBackColor = true;
            this.rbLineas.CheckedChanged += new System.EventHandler(this.rbLineas_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero de Columnas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo de Grafico:";
            // 
            // lbColor
            // 
            this.lbColor.FormattingEnabled = true;
            this.lbColor.Location = new System.Drawing.Point(141, 131);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(125, 82);
            this.lbColor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Color de Linea:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(28, 180);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 33);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 248);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbLineas);
            this.Controls.Add(this.rbBarras);
            this.Controls.Add(this.cbColumnas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "config";
            this.Text = "Configuracion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbColumnas;
        private System.Windows.Forms.RadioButton rbBarras;
        private System.Windows.Forms.RadioButton rbLineas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
    }
}