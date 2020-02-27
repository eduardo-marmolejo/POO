namespace Caseta_de_Cobro
{
    partial class frmCaseta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaseta));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVehiculo = new System.Windows.Forms.ComboBox();
            this.btnCobro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el vehículo:";
            // 
            // cmbVehiculo
            // 
            this.cmbVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehiculo.FormattingEnabled = true;
            this.cmbVehiculo.Items.AddRange(new object[] {
            "Motocicleta",
            "Automóvil",
            "Autobús",
            "Tráiler"});
            this.cmbVehiculo.Location = new System.Drawing.Point(182, 44);
            this.cmbVehiculo.Name = "cmbVehiculo";
            this.cmbVehiculo.Size = new System.Drawing.Size(121, 21);
            this.cmbVehiculo.TabIndex = 1;
            // 
            // btnCobro
            // 
            this.btnCobro.Location = new System.Drawing.Point(141, 89);
            this.btnCobro.Name = "btnCobro";
            this.btnCobro.Size = new System.Drawing.Size(75, 23);
            this.btnCobro.TabIndex = 2;
            this.btnCobro.Text = "Cobrar";
            this.btnCobro.UseVisualStyleBackColor = true;
            this.btnCobro.Click += new System.EventHandler(this.btnCobro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(120, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Debe pagar:";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.BackColor = System.Drawing.Color.Transparent;
            this.lblPago.Location = new System.Drawing.Point(193, 165);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(13, 13);
            this.lblPago.TabIndex = 4;
            this.lblPago.Text = "0";
            // 
            // frmCaseta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(355, 325);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCobro);
            this.Controls.Add(this.cmbVehiculo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCaseta";
            this.Text = "Caseta de Cobro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVehiculo;
        private System.Windows.Forms.Button btnCobro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPago;
    }
}

