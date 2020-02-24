namespace CFE
{
    partial class fmrCFE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrCFE));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTarifa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btmCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKW = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el Tipo de Contrato:";
            // 
            // cmbTarifa
            // 
            this.cmbTarifa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarifa.FormattingEnabled = true;
            this.cmbTarifa.Items.AddRange(new object[] {
            "Hogar",
            "Negocio"});
            this.cmbTarifa.Location = new System.Drawing.Point(204, 29);
            this.cmbTarifa.Name = "cmbTarifa";
            this.cmbTarifa.Size = new System.Drawing.Size(121, 21);
            this.cmbTarifa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(42, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "El costo es:";
            // 
            // btmCalcular
            // 
            this.btmCalcular.Location = new System.Drawing.Point(108, 107);
            this.btmCalcular.Name = "btmCalcular";
            this.btmCalcular.Size = new System.Drawing.Size(75, 23);
            this.btmCalcular.TabIndex = 3;
            this.btmCalcular.Text = "Calcular pago";
            this.btmCalcular.UseVisualStyleBackColor = true;
            this.btmCalcular.Click += new System.EventHandler(this.btmCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(42, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese los KW consumidos:";
            // 
            // txtKW
            // 
            this.txtKW.Location = new System.Drawing.Point(190, 70);
            this.txtKW.Name = "txtKW";
            this.txtKW.Size = new System.Drawing.Size(100, 20);
            this.txtKW.TabIndex = 5;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.BackColor = System.Drawing.Color.Transparent;
            this.lblCosto.Location = new System.Drawing.Point(105, 153);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(13, 13);
            this.lblCosto.TabIndex = 6;
            this.lblCosto.Text = "0";
            // 
            // fmrCFE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(372, 268);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.txtKW);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btmCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTarifa);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmrCFE";
            this.Text = "CFE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTarifa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btmCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKW;
        private System.Windows.Forms.Label lblCosto;
    }
}

