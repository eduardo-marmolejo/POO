namespace Personas
{
    partial class frmInforme
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
            this.lblEdad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNayarit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMaestros = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAdministrativos = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mayores de edad:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(119, 30);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(13, 13);
            this.lblEdad.TabIndex = 1;
            this.lblEdad.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personas de Nayarit:";
            // 
            // lblNayarit
            // 
            this.lblNayarit.AutoSize = true;
            this.lblNayarit.Location = new System.Drawing.Point(132, 60);
            this.lblNayarit.Name = "lblNayarit";
            this.lblNayarit.Size = new System.Drawing.Size(13, 13);
            this.lblNayarit.TabIndex = 3;
            this.lblNayarit.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Alumno:";
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(111, 118);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(13, 13);
            this.lblAlumno.TabIndex = 6;
            this.lblAlumno.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Maestros:";
            // 
            // lblMaestros
            // 
            this.lblMaestros.AutoSize = true;
            this.lblMaestros.Location = new System.Drawing.Point(119, 147);
            this.lblMaestros.Name = "lblMaestros";
            this.lblMaestros.Size = new System.Drawing.Size(13, 13);
            this.lblMaestros.TabIndex = 8;
            this.lblMaestros.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Administrativo:";
            // 
            // lblAdministrativos
            // 
            this.lblAdministrativos.AutoSize = true;
            this.lblAdministrativos.Location = new System.Drawing.Point(141, 176);
            this.lblAdministrativos.Name = "lblAdministrativos";
            this.lblAdministrativos.Size = new System.Drawing.Size(13, 13);
            this.lblAdministrativos.TabIndex = 10;
            this.lblAdministrativos.Text = "0";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(208, 91);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 219);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblAdministrativos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMaestros);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNayarit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.label1);
            this.Name = "frmInforme";
            this.Text = "Informe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Label lblEdad;
        public System.Windows.Forms.Label lblNayarit;
        public System.Windows.Forms.Label lblAlumno;
        public System.Windows.Forms.Label lblMaestros;
        public System.Windows.Forms.Label lblAdministrativos;
    }
}