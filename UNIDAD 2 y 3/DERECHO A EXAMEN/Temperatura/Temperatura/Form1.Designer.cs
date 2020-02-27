namespace Temperatura
{
    partial class fmrTemperatura
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
            this.txtGrados = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTemperatura = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.lblTemperatura2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce los grados:";
            // 
            // txtGrados
            // 
            this.txtGrados.Location = new System.Drawing.Point(137, 26);
            this.txtGrados.Name = "txtGrados";
            this.txtGrados.Size = new System.Drawing.Size(100, 20);
            this.txtGrados.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione la medida:";
            // 
            // cmbTemperatura
            // 
            this.cmbTemperatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTemperatura.FormattingEnabled = true;
            this.cmbTemperatura.Items.AddRange(new object[] {
            "Centígrados",
            "Fahrenheit"});
            this.cmbTemperatura.Location = new System.Drawing.Point(141, 61);
            this.cmbTemperatura.Name = "cmbTemperatura";
            this.cmbTemperatura.Size = new System.Drawing.Size(121, 21);
            this.cmbTemperatura.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(100, 104);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Conversión de la temperatura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "°";
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(137, 165);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(13, 13);
            this.lblTemperatura.TabIndex = 7;
            this.lblTemperatura.Text = "0";
            // 
            // lblTemperatura2
            // 
            this.lblTemperatura2.AutoSize = true;
            this.lblTemperatura2.Location = new System.Drawing.Point(137, 192);
            this.lblTemperatura2.Name = "lblTemperatura2";
            this.lblTemperatura2.Size = new System.Drawing.Size(13, 13);
            this.lblTemperatura2.TabIndex = 8;
            this.lblTemperatura2.Text = "0";
            // 
            // fmrTemperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 243);
            this.Controls.Add(this.lblTemperatura2);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cmbTemperatura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGrados);
            this.Controls.Add(this.label1);
            this.Name = "fmrTemperatura";
            this.Text = "Temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTemperatura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label lblTemperatura2;
    }
}

