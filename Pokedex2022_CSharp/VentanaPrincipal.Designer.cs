namespace Pokedex2022_CSharp
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.izquierda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.derecha = new System.Windows.Forms.Button();
            this.nombrePokemon = new System.Windows.Forms.Label();
            this.botonInfo = new System.Windows.Forms.Button();
            this.botonEvoluciones = new System.Windows.Forms.Button();
            this.imagenPre = new System.Windows.Forms.PictureBox();
            this.imagenPos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPos)).BeginInit();
            this.SuspendLayout();
            // 
            // izquierda
            // 
            this.izquierda.BackColor = System.Drawing.Color.Transparent;
            this.izquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izquierda.Location = new System.Drawing.Point(163, 607);
            this.izquierda.Name = "izquierda";
            this.izquierda.Size = new System.Drawing.Size(40, 40);
            this.izquierda.TabIndex = 0;
            this.izquierda.Text = "<";
            this.izquierda.UseVisualStyleBackColor = false;
            this.izquierda.Click += new System.EventHandler(this.izquierda_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(344, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // derecha
            // 
            this.derecha.BackColor = System.Drawing.Color.Transparent;
            this.derecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.derecha.Location = new System.Drawing.Point(232, 607);
            this.derecha.Name = "derecha";
            this.derecha.Size = new System.Drawing.Size(40, 40);
            this.derecha.TabIndex = 2;
            this.derecha.Text = ">";
            this.derecha.UseVisualStyleBackColor = false;
            this.derecha.Click += new System.EventHandler(this.derecha_Click);
            // 
            // nombrePokemon
            // 
            this.nombrePokemon.BackColor = System.Drawing.Color.Transparent;
            this.nombrePokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePokemon.Location = new System.Drawing.Point(354, 312);
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.Size = new System.Drawing.Size(224, 27);
            this.nombrePokemon.TabIndex = 3;
            this.nombrePokemon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            
            // 
            // botonInfo
            // 
            this.botonInfo.Location = new System.Drawing.Point(340, 671);
            this.botonInfo.Margin = new System.Windows.Forms.Padding(2);
            this.botonInfo.Name = "botonInfo";
            this.botonInfo.Size = new System.Drawing.Size(238, 45);
            this.botonInfo.TabIndex = 4;
            this.botonInfo.Text = "Ver todos los datos del Pokemon";
            this.botonInfo.UseVisualStyleBackColor = true;
            this.botonInfo.Click += new System.EventHandler(this.botonInfo_Click);
            // 
            // botonEvoluciones
            // 
            this.botonEvoluciones.Location = new System.Drawing.Point(340, 528);
            this.botonEvoluciones.Name = "botonEvoluciones";
            this.botonEvoluciones.Size = new System.Drawing.Size(238, 23);
            this.botonEvoluciones.TabIndex = 5;
            this.botonEvoluciones.Text = "Ver Linea Evolutiva";
            this.botonEvoluciones.UseVisualStyleBackColor = true;
            this.botonEvoluciones.Click += new System.EventHandler(this.botonEvoluciones_Click);
            // 
            // imagenPre
            // 
            this.imagenPre.BackColor = System.Drawing.Color.Transparent;
            this.imagenPre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagenPre.Location = new System.Drawing.Point(340, 557);
            this.imagenPre.Name = "imagenPre";
            this.imagenPre.Size = new System.Drawing.Size(106, 109);
            this.imagenPre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenPre.TabIndex = 6;
            this.imagenPre.TabStop = false;
            // 
            // imagenPos
            // 
            this.imagenPos.BackColor = System.Drawing.Color.Transparent;
            this.imagenPos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagenPos.Location = new System.Drawing.Point(471, 557);
            this.imagenPos.Name = "imagenPos";
            this.imagenPos.Size = new System.Drawing.Size(107, 109);
            this.imagenPos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenPos.TabIndex = 7;
            this.imagenPos.TabStop = false;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 837);
            this.Controls.Add(this.imagenPos);
            this.Controls.Add(this.imagenPre);
            this.Controls.Add(this.botonEvoluciones);
            this.Controls.Add(this.botonInfo);
            this.Controls.Add(this.nombrePokemon);
            this.Controls.Add(this.derecha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.izquierda);
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button izquierda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button derecha;
        private System.Windows.Forms.Label nombrePokemon;
        private System.Windows.Forms.Button botonInfo;
        private System.Windows.Forms.Button botonEvoluciones;
        private System.Windows.Forms.PictureBox imagenPre;
        private System.Windows.Forms.PictureBox imagenPos;
    }
}