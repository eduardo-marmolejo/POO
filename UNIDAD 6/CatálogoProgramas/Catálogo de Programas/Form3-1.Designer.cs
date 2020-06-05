namespace Catálogo_de_Programas
{
    partial class frmDeExa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeExa));
            this.btnCaseta = new System.Windows.Forms.Button();
            this.btnCFE = new System.Windows.Forms.Button();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnFecha = new System.Windows.Forms.Button();
            this.btnTemperatura = new System.Windows.Forms.Button();
            this.btnVacaciones = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCaseta
            // 
            this.btnCaseta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaseta.Location = new System.Drawing.Point(57, 76);
            this.btnCaseta.Name = "btnCaseta";
            this.btnCaseta.Size = new System.Drawing.Size(121, 67);
            this.btnCaseta.TabIndex = 0;
            this.btnCaseta.Text = "Caseta de Cobro";
            this.btnCaseta.UseVisualStyleBackColor = true;
            this.btnCaseta.Click += new System.EventHandler(this.btnCaseta_Click);
            // 
            // btnCFE
            // 
            this.btnCFE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCFE.Location = new System.Drawing.Point(301, 89);
            this.btnCFE.Name = "btnCFE";
            this.btnCFE.Size = new System.Drawing.Size(84, 41);
            this.btnCFE.TabIndex = 1;
            this.btnCFE.Text = "CFE";
            this.btnCFE.UseVisualStyleBackColor = true;
            this.btnCFE.Click += new System.EventHandler(this.btnCFE_Click);
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuadrado.Location = new System.Drawing.Point(55, 178);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(123, 45);
            this.btnCuadrado.TabIndex = 2;
            this.btnCuadrado.Text = "Cuadrado";
            this.btnCuadrado.UseVisualStyleBackColor = true;
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // btnFecha
            // 
            this.btnFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecha.Location = new System.Drawing.Point(276, 172);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(131, 56);
            this.btnFecha.TabIndex = 3;
            this.btnFecha.Text = "Fecha de Nacimiento";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // btnTemperatura
            // 
            this.btnTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemperatura.Location = new System.Drawing.Point(43, 269);
            this.btnTemperatura.Name = "btnTemperatura";
            this.btnTemperatura.Size = new System.Drawing.Size(144, 42);
            this.btnTemperatura.TabIndex = 4;
            this.btnTemperatura.Text = "Temperatura";
            this.btnTemperatura.UseVisualStyleBackColor = true;
            this.btnTemperatura.Click += new System.EventHandler(this.btnTemperatura_Click);
            // 
            // btnVacaciones
            // 
            this.btnVacaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVacaciones.Location = new System.Drawing.Point(276, 269);
            this.btnVacaciones.Name = "btnVacaciones";
            this.btnVacaciones.Size = new System.Drawing.Size(141, 42);
            this.btnVacaciones.TabIndex = 5;
            this.btnVacaciones.Text = "Vacaciones";
            this.btnVacaciones.UseVisualStyleBackColor = true;
            this.btnVacaciones.Click += new System.EventHandler(this.btnVacaciones_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtras.BackgroundImage")));
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtras.Location = new System.Drawing.Point(12, 379);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(104, 60);
            this.btnAtras.TabIndex = 7;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // frmDeExa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(455, 451);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnVacaciones);
            this.Controls.Add(this.btnTemperatura);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.btnCuadrado);
            this.Controls.Add(this.btnCFE);
            this.Controls.Add(this.btnCaseta);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDeExa";
            this.Text = "Derecho a Examen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCaseta;
        private System.Windows.Forms.Button btnCFE;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.Button btnTemperatura;
        private System.Windows.Forms.Button btnVacaciones;
        private System.Windows.Forms.Button btnAtras;
    }
}