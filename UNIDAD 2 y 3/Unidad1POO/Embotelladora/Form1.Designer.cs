namespace Embotelladora
{
    partial class FmrEmbotelladora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrEmbotelladora));
            this.lblNiveldeLlenado = new System.Windows.Forms.Label();
            this.txtNivelLlenado = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNiveldeLlenado
            // 
            this.lblNiveldeLlenado.AutoSize = true;
            this.lblNiveldeLlenado.Location = new System.Drawing.Point(12, 34);
            this.lblNiveldeLlenado.Name = "lblNiveldeLlenado";
            this.lblNiveldeLlenado.Size = new System.Drawing.Size(143, 13);
            this.lblNiveldeLlenado.TabIndex = 0;
            this.lblNiveldeLlenado.Text = "Introduce el nivel de llenado:";
            // 
            // txtNivelLlenado
            // 
            this.txtNivelLlenado.Location = new System.Drawing.Point(162, 34);
            this.txtNivelLlenado.Name = "txtNivelLlenado";
            this.txtNivelLlenado.Size = new System.Drawing.Size(100, 20);
            this.txtNivelLlenado.TabIndex = 1;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(283, 34);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // FmrEmbotelladora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 71);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtNivelLlenado);
            this.Controls.Add(this.lblNiveldeLlenado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmrEmbotelladora";
            this.Text = "Verificador de Mililítros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNiveldeLlenado;
        private System.Windows.Forms.TextBox txtNivelLlenado;
        private System.Windows.Forms.Button btnVerificar;
    }
}

