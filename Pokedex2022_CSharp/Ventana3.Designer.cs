namespace Pokedex2022_CSharp
{
    partial class Ventana3
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
            this.botonAtrasDatos = new System.Windows.Forms.Button();
            this.Movimiento01 = new System.Windows.Forms.Label();
            this.movimiento02 = new System.Windows.Forms.Label();
            this.movimiento03 = new System.Windows.Forms.Label();
            this.movimiento04 = new System.Windows.Forms.Label();
            this.cajaHabitat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonAtrasDatos
            // 
            this.botonAtrasDatos.Location = new System.Drawing.Point(45, 336);
            this.botonAtrasDatos.Name = "botonAtrasDatos";
            this.botonAtrasDatos.Size = new System.Drawing.Size(181, 76);
            this.botonAtrasDatos.TabIndex = 1;
            this.botonAtrasDatos.Text = "Volver a los Datos del Pokemon";
            this.botonAtrasDatos.UseVisualStyleBackColor = true;
            this.botonAtrasDatos.Click += new System.EventHandler(this.botonAtrasDatos_Click);
            // 
            // Movimiento01
            // 
            this.Movimiento01.Enabled = false;
            this.Movimiento01.Location = new System.Drawing.Point(433, 47);
            this.Movimiento01.Name = "Movimiento01";
            this.Movimiento01.Size = new System.Drawing.Size(232, 68);
            this.Movimiento01.TabIndex = 2;
            this.Movimiento01.Text = "textodeejemplo";
            this.Movimiento01.Click += new System.EventHandler(this.Movimiento01_Click);
            // 
            // movimiento02
            // 
            this.movimiento02.Enabled = false;
            this.movimiento02.Location = new System.Drawing.Point(433, 115);
            this.movimiento02.Name = "movimiento02";
            this.movimiento02.Size = new System.Drawing.Size(232, 68);
            this.movimiento02.TabIndex = 3;
            this.movimiento02.Text = "textodeejemplo";
            // 
            // movimiento03
            // 
            this.movimiento03.Enabled = false;
            this.movimiento03.Location = new System.Drawing.Point(433, 199);
            this.movimiento03.Name = "movimiento03";
            this.movimiento03.Size = new System.Drawing.Size(232, 68);
            this.movimiento03.TabIndex = 4;
            this.movimiento03.Text = "textodeejemplo";
            // 
            // movimiento04
            // 
            this.movimiento04.Enabled = false;
            this.movimiento04.Location = new System.Drawing.Point(433, 281);
            this.movimiento04.Name = "movimiento04";
            this.movimiento04.Size = new System.Drawing.Size(232, 68);
            this.movimiento04.TabIndex = 5;
            this.movimiento04.Text = "textodeejemplo";
            // 
            // cajaHabitat
            // 
            this.cajaHabitat.Location = new System.Drawing.Point(30, 32);
            this.cajaHabitat.Name = "cajaHabitat";
            this.cajaHabitat.Size = new System.Drawing.Size(207, 115);
            this.cajaHabitat.TabIndex = 6;
            this.cajaHabitat.Text = "textoHabitat";
            // 
            // Ventana3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.cajaHabitat);
            this.Controls.Add(this.movimiento04);
            this.Controls.Add(this.movimiento03);
            this.Controls.Add(this.movimiento02);
            this.Controls.Add(this.Movimiento01);
            this.Controls.Add(this.botonAtrasDatos);
            this.Name = "Ventana3";
            this.Text = "Ventana3";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button botonAtrasDatos;
        private System.Windows.Forms.Label Movimiento01;
        private System.Windows.Forms.Label movimiento02;
        private System.Windows.Forms.Label movimiento03;
        private System.Windows.Forms.Label movimiento04;
        private System.Windows.Forms.Label cajaHabitat;
    }
}