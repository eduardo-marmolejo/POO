namespace Ejercicio4
{
    partial class frmREG2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmREG2));
            this.label8 = new System.Windows.Forms.Label();
            this.txtRegistrar = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnRegistrar2 = new System.Windows.Forms.Button();
            this.txtRegistrar2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnImprimir2 = new System.Windows.Forms.Button();
            this.dgvDatosAlumnos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDatosMaestros = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosMaestros)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ingrese el número de alumnos:";
            // 
            // txtRegistrar
            // 
            this.txtRegistrar.Location = new System.Drawing.Point(171, 19);
            this.txtRegistrar.Name = "txtRegistrar";
            this.txtRegistrar.Size = new System.Drawing.Size(100, 20);
            this.txtRegistrar.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(277, 17);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(81, 23);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnRegistrar2
            // 
            this.btnRegistrar2.Location = new System.Drawing.Point(274, 235);
            this.btnRegistrar2.Name = "btnRegistrar2";
            this.btnRegistrar2.Size = new System.Drawing.Size(76, 23);
            this.btnRegistrar2.TabIndex = 9;
            this.btnRegistrar2.Text = "Registrar";
            this.btnRegistrar2.UseVisualStyleBackColor = true;
            this.btnRegistrar2.Click += new System.EventHandler(this.btnRegistrar2_Click);
            // 
            // txtRegistrar2
            // 
            this.txtRegistrar2.Location = new System.Drawing.Point(168, 237);
            this.txtRegistrar2.Name = "txtRegistrar2";
            this.txtRegistrar2.Size = new System.Drawing.Size(100, 20);
            this.txtRegistrar2.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(11, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Ingrese el número de maestros:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(382, 17);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(157, 23);
            this.btnImprimir.TabIndex = 10;
            this.btnImprimir.Text = "Imprimir datos de los alumnos";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnImprimir2
            // 
            this.btnImprimir2.Location = new System.Drawing.Point(382, 235);
            this.btnImprimir2.Name = "btnImprimir2";
            this.btnImprimir2.Size = new System.Drawing.Size(157, 23);
            this.btnImprimir2.TabIndex = 11;
            this.btnImprimir2.Text = "Imprimir datos de los maestros";
            this.btnImprimir2.UseVisualStyleBackColor = true;
            this.btnImprimir2.Click += new System.EventHandler(this.btnImprimir2_Click);
            // 
            // dgvDatosAlumnos
            // 
            this.dgvDatosAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatosAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvDatosAlumnos.Location = new System.Drawing.Point(12, 46);
            this.dgvDatosAlumnos.Name = "dgvDatosAlumnos";
            this.dgvDatosAlumnos.Size = new System.Drawing.Size(682, 170);
            this.dgvDatosAlumnos.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fecha de nacimiento";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Curp";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Teléfono";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "No. de control";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Carrera";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Materias";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Calificación";
            this.Column9.Name = "Column9";
            // 
            // dgvDatosMaestros
            // 
            this.dgvDatosMaestros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosMaestros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18});
            this.dgvDatosMaestros.Location = new System.Drawing.Point(12, 263);
            this.dgvDatosMaestros.Name = "dgvDatosMaestros";
            this.dgvDatosMaestros.Size = new System.Drawing.Size(682, 168);
            this.dgvDatosMaestros.TabIndex = 12;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Nombre";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Fecha de nacimiento";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Curp";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Teléfono";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Email";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.HeaderText = "No. de maestro";
            this.Column15.Name = "Column15";
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Sueldo";
            this.Column16.Name = "Column16";
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Materias impartidas";
            this.Column17.Name = "Column17";
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Column18";
            this.Column18.Name = "Column18";
            this.Column18.Visible = false;
            // 
            // frmREG2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(724, 443);
            this.Controls.Add(this.dgvDatosMaestros);
            this.Controls.Add(this.dgvDatosAlumnos);
            this.Controls.Add(this.btnImprimir2);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnRegistrar2);
            this.Controls.Add(this.txtRegistrar2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtRegistrar);
            this.Controls.Add(this.label8);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmREG2";
            this.Text = "Registro Escolar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosMaestros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRegistrar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnRegistrar2;
        private System.Windows.Forms.TextBox txtRegistrar2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnImprimir2;
        private System.Windows.Forms.DataGridView dgvDatosAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridView dgvDatosMaestros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
    }
}

