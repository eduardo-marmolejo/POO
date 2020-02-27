namespace Examen23
{
    partial class frmTemperaturas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtGrados = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUniMedia = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCentígrados = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de grados:";
            // 
            // txtGrados
            // 
            this.txtGrados.Location = new System.Drawing.Point(142, 23);
            this.txtGrados.Name = "txtGrados";
            this.txtGrados.Size = new System.Drawing.Size(100, 20);
            this.txtGrados.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unidad de medida:";
            // 
            // cmbUniMedia
            // 
            this.cmbUniMedia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUniMedia.FormattingEnabled = true;
            this.cmbUniMedia.Items.AddRange(new object[] {
            "Centígrados",
            "Fahrenheit"});
            this.cmbUniMedia.Location = new System.Drawing.Point(139, 61);
            this.cmbUniMedia.Name = "cmbUniMedia";
            this.cmbUniMedia.Size = new System.Drawing.Size(121, 21);
            this.cmbUniMedia.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(120, 110);
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
            this.label3.Location = new System.Drawing.Point(34, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Temperatura en Centígrados:";
            // 
            // lblCentígrados
            // 
            this.lblCentígrados.AutoSize = true;
            this.lblCentígrados.Location = new System.Drawing.Point(186, 149);
            this.lblCentígrados.Name = "lblCentígrados";
            this.lblCentígrados.Size = new System.Drawing.Size(13, 13);
            this.lblCentígrados.TabIndex = 6;
            this.lblCentígrados.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Temperatura en Fahrenheit:";
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(181, 180);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(13, 13);
            this.lblFahrenheit.TabIndex = 8;
            this.lblFahrenheit.Text = "0";
            // 
            // frmTemperaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 229);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCentígrados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cmbUniMedia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGrados);
            this.Controls.Add(this.label1);
            this.Name = "frmTemperaturas";
            this.Text = "Temperaturas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUniMedia;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCentígrados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFahrenheit;
    }
}