namespace Pruebas
{
    partial class PruebaReproductor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PruebaReproductor));
            this.btnCarpeta = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.reproductor1 = new NuevosComponentes.Reproductor();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCarpeta
            // 
            this.btnCarpeta.Location = new System.Drawing.Point(28, 399);
            this.btnCarpeta.Name = "btnCarpeta";
            this.btnCarpeta.Size = new System.Drawing.Size(75, 39);
            this.btnCarpeta.TabIndex = 1;
            this.btnCarpeta.Text = "Seleccionar Carpeta";
            this.btnCarpeta.UseVisualStyleBackColor = true;
            this.btnCarpeta.Click += new System.EventHandler(this.btnCarpeta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 366);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 409);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // reproductor1
            // 
            this.reproductor1.Location = new System.Drawing.Point(365, 384);
            this.reproductor1.Minutos = 0;
            this.reproductor1.Name = "reproductor1";
            this.reproductor1.Segundos = 0;
            this.reproductor1.Size = new System.Drawing.Size(120, 54);
            this.reproductor1.TabIndex = 0;
            this.reproductor1.DesbordaTiempo += new System.EventHandler(this.reproductor1_DesbordaTiempo);
            this.reproductor1.PlayClick += new System.EventHandler(this.reproductor1_PlayClick);
            this.reproductor1.Load += new System.EventHandler(this.reproductor1_Load);
            // 
            // PruebaReproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCarpeta);
            this.Controls.Add(this.reproductor1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PruebaReproductor";
            this.Text = "PruebaReproductor";
            this.Load += new System.EventHandler(this.PruebaReproductor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NuevosComponentes.Reproductor reproductor1;
        private System.Windows.Forms.Button btnCarpeta;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}