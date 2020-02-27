namespace Vacaciones
{
    partial class fmrVacaciones
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
            this.txtAños = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVacaciones = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Años trabajados:";
            // 
            // txtAños
            // 
            this.txtAños.Location = new System.Drawing.Point(115, 27);
            this.txtAños.Name = "txtAños";
            this.txtAños.Size = new System.Drawing.Size(100, 20);
            this.txtAños.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Días de Vacaciones:";
            // 
            // lblVacaciones
            // 
            this.lblVacaciones.AutoSize = true;
            this.lblVacaciones.Location = new System.Drawing.Point(140, 64);
            this.lblVacaciones.Name = "lblVacaciones";
            this.lblVacaciones.Size = new System.Drawing.Size(13, 13);
            this.lblVacaciones.TabIndex = 3;
            this.lblVacaciones.Text = "0";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(245, 39);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // fmrVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 107);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblVacaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAños);
            this.Controls.Add(this.label1);
            this.Name = "fmrVacaciones";
            this.Text = "Vacaciones de trabajo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAños;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVacaciones;
        private System.Windows.Forms.Button btnCalcular;
    }
}

