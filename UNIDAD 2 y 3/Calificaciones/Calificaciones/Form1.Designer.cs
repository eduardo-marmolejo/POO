namespace Calificaciones
{
    partial class fmrCalificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrCalificaciones));
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.lblAprobados = new System.Windows.Forms.Label();
            this.lblReprobados = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.btnReportar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Location = new System.Drawing.Point(45, 29);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(72, 13);
            this.lblCalificacion.TabIndex = 0;
            this.lblCalificacion.Text = "Calificaciones";
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(123, 26);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(100, 20);
            this.txtCalificacion.TabIndex = 1;
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(229, 24);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 23);
            this.btnCapturar.TabIndex = 2;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // lblAprobados
            // 
            this.lblAprobados.AutoSize = true;
            this.lblAprobados.Location = new System.Drawing.Point(49, 60);
            this.lblAprobados.Name = "lblAprobados";
            this.lblAprobados.Size = new System.Drawing.Size(61, 13);
            this.lblAprobados.TabIndex = 5;
            this.lblAprobados.Text = "Aprobados:";
            // 
            // lblReprobados
            // 
            this.lblReprobados.AutoSize = true;
            this.lblReprobados.Location = new System.Drawing.Point(42, 83);
            this.lblReprobados.Name = "lblReprobados";
            this.lblReprobados.Size = new System.Drawing.Size(68, 13);
            this.lblReprobados.TabIndex = 6;
            this.lblReprobados.Text = "Reprobados:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(56, 105);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(54, 13);
            this.lblPromedio.TabIndex = 8;
            this.lblPromedio.Text = "Promedio:";
            // 
            // btnReportar
            // 
            this.btnReportar.Location = new System.Drawing.Point(200, 78);
            this.btnReportar.Name = "btnReportar";
            this.btnReportar.Size = new System.Drawing.Size(75, 23);
            this.btnReportar.TabIndex = 9;
            this.btnReportar.Text = "Reportar";
            this.btnReportar.UseVisualStyleBackColor = true;
            this.btnReportar.Click += new System.EventHandler(this.btnReportar_Click);
            // 
            // fmrCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 137);
            this.Controls.Add(this.btnReportar);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblReprobados);
            this.Controls.Add(this.lblAprobados);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.txtCalificacion);
            this.Controls.Add(this.lblCalificacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmrCalificaciones";
            this.Text = "Registro y Reporte de Calificaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Label lblAprobados;
        private System.Windows.Forms.Label lblReprobados;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Button btnReportar;
    }
}

