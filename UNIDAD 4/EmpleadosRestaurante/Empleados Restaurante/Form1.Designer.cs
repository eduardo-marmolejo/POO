namespace Empleados_Restaurante
{
    partial class frmEmpleado
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
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbZona = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCaja = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione un Empleado:";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Items.AddRange(new object[] {
            "Mesero",
            "Repartidor",
            "Cajero"});
            this.cmbEmpleado.Location = new System.Drawing.Point(146, 25);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cmbEmpleado.TabIndex = 1;
            this.cmbEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleado_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Introduzca la cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(136, 107);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Introduzca la cantidad:";
            // 
            // txtCantidad2
            // 
            this.txtCantidad2.Location = new System.Drawing.Point(133, 142);
            this.txtCantidad2.Name = "txtCantidad2";
            this.txtCantidad2.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Introduzca la cantidad:";
            // 
            // txtCantidad3
            // 
            this.txtCantidad3.Location = new System.Drawing.Point(133, 178);
            this.txtCantidad3.Name = "txtCantidad3";
            this.txtCantidad3.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad3.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Zona:";
            // 
            // cmbZona
            // 
            this.cmbZona.FormattingEnabled = true;
            this.cmbZona.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbZona.Location = new System.Drawing.Point(337, 25);
            this.cmbZona.Name = "cmbZona";
            this.cmbZona.Size = new System.Drawing.Size(121, 21);
            this.cmbZona.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Caja:";
            // 
            // cmbCaja
            // 
            this.cmbCaja.FormattingEnabled = true;
            this.cmbCaja.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbCaja.Location = new System.Drawing.Point(336, 62);
            this.cmbCaja.Name = "cmbCaja";
            this.cmbCaja.Size = new System.Drawing.Size(121, 21);
            this.cmbCaja.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fecha de Nacimiento:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(133, 69);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 20);
            this.dtpFecha.TabIndex = 13;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(336, 121);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "El sueldo es:";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(392, 181);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(13, 13);
            this.lblSueldo.TabIndex = 16;
            this.lblSueldo.Text = "0";
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 225);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbCaja);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbZona);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCantidad3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantidad2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.label1);
            this.Name = "frmEmpleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidad2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbZona;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCaja;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSueldo;
    }
}

