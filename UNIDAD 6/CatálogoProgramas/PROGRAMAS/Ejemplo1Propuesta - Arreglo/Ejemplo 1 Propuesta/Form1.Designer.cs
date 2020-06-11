namespace Ejemplo_1_Propuesta
{
    partial class frmPromedio
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
            this.btnCapturar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.cmbCal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calificaciones Registras:";
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(67, 66);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(151, 23);
            this.btnCapturar.TabIndex = 2;
            this.btnCapturar.Text = "Capturar/Obtener Promedio";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Promedio:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(88, 112);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(13, 13);
            this.lblPromedio.TabIndex = 4;
            this.lblPromedio.Text = "0";
            // 
            // cmbCal
            // 
            this.cmbCal.FormattingEnabled = true;
            this.cmbCal.Location = new System.Drawing.Point(143, 25);
            this.cmbCal.Name = "cmbCal";
            this.cmbCal.Size = new System.Drawing.Size(121, 21);
            this.cmbCal.TabIndex = 6;
            // 
            // frmPromedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 141);
            this.Controls.Add(this.cmbCal);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.label1);
            this.Name = "frmPromedio";
            this.Text = "Promedio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.ComboBox cmbCal;
    }
}

