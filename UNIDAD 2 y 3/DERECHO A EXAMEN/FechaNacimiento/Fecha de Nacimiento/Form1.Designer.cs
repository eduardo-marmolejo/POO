namespace Fecha_de_Nacimiento
{
    partial class frmFechaNacimiento
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblMayorEdad = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Fecha de Nacimiento:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(168, 26);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(96, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // lblMayorEdad
            // 
            this.lblMayorEdad.AutoSize = true;
            this.lblMayorEdad.Location = new System.Drawing.Point(136, 115);
            this.lblMayorEdad.Name = "lblMayorEdad";
            this.lblMayorEdad.Size = new System.Drawing.Size(16, 13);
            this.lblMayorEdad.TabIndex = 2;
            this.lblMayorEdad.Text = "...";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(100, 63);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // frmFechaNacimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 165);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblMayorEdad);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label1);
            this.Name = "frmFechaNacimiento";
            this.Text = "Fecha de Nacimiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblMayorEdad;
        private System.Windows.Forms.Button btnVerificar;
    }
}

