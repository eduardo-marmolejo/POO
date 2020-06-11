namespace Ejemplo_1_Propuesta_2
{
    partial class frmPromedio2
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
            this.cmbCal = new System.Windows.Forms.ComboBox();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCal
            // 
            this.cmbCal.FormattingEnabled = true;
            this.cmbCal.Location = new System.Drawing.Point(143, 6);
            this.cmbCal.Name = "cmbCal";
            this.cmbCal.Size = new System.Drawing.Size(121, 21);
            this.cmbCal.TabIndex = 11;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(88, 93);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(13, 13);
            this.lblPromedio.TabIndex = 10;
            this.lblPromedio.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Promedio:";
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(67, 47);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(151, 23);
            this.btnCapturar.TabIndex = 8;
            this.btnCapturar.Text = "Capturar/Obtener Promedio";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Calificaciones Registras:";
            // 
            // frmPromedio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 122);
            this.Controls.Add(this.cmbCal);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.label1);
            this.Name = "frmPromedio2";
            this.Text = "Promedio";
            this.Load += new System.EventHandler(this.frmPromedio2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCal;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Label label1;
    }
}

