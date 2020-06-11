namespace Torneo_Futbol_2
{
    partial class frmTorneoFutbol2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTorneoFutbol2));
            this.btnDatosEquipos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudPuntosGanados = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPuntosEmpate = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcularPartidos = new System.Windows.Forms.Button();
            this.txtNumParEquipo = new System.Windows.Forms.TextBox();
            this.nudPuntosPerdidos = new System.Windows.Forms.NumericUpDown();
            this.txtNomTorneo = new System.Windows.Forms.TextBox();
            this.lblPuntosGanados = new System.Windows.Forms.Label();
            this.lblPuntosEmpate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPuntosPerdido = new System.Windows.Forms.Label();
            this.txtNumEquipo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIngresarDatosTorneo = new System.Windows.Forms.Button();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMostrarCampeon = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntosGanados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntosEmpate)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntosPerdidos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDatosEquipos
            // 
            this.btnDatosEquipos.Location = new System.Drawing.Point(62, 313);
            this.btnDatosEquipos.Name = "btnDatosEquipos";
            this.btnDatosEquipos.Size = new System.Drawing.Size(90, 53);
            this.btnDatosEquipos.TabIndex = 20;
            this.btnDatosEquipos.Text = "Ingresar Datos de los Equipo";
            this.btnDatosEquipos.UseVisualStyleBackColor = true;
            this.btnDatosEquipos.Click += new System.EventHandler(this.btnDatosEquipos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.nudPuntosGanados);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nudPuntosEmpate);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.nudPuntosPerdidos);
            this.groupBox2.Controls.Add(this.txtNomTorneo);
            this.groupBox2.Controls.Add(this.lblPuntosGanados);
            this.groupBox2.Controls.Add(this.lblPuntosEmpate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblPuntosPerdido);
            this.groupBox2.Controls.Add(this.txtNumEquipo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnIngresarDatosTorneo);
            this.groupBox2.Controls.Add(this.dtpFechaInicio);
            this.groupBox2.Controls.Add(this.dtpFechaFin);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 283);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Torneo";
            // 
            // nudPuntosGanados
            // 
            this.nudPuntosGanados.Location = new System.Drawing.Point(63, 187);
            this.nudPuntosGanados.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudPuntosGanados.Name = "nudPuntosGanados";
            this.nudPuntosGanados.Size = new System.Drawing.Size(37, 21);
            this.nudPuntosGanados.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Torneo:";
            // 
            // nudPuntosEmpate
            // 
            this.nudPuntosEmpate.Location = new System.Drawing.Point(63, 218);
            this.nudPuntosEmpate.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudPuntosEmpate.Name = "nudPuntosEmpate";
            this.nudPuntosEmpate.Size = new System.Drawing.Size(37, 21);
            this.nudPuntosEmpate.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCalcularPartidos);
            this.groupBox1.Controls.Add(this.txtNumParEquipo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(9, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 60);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Partidos por Equipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Número partidos por Equipo:";
            // 
            // btnCalcularPartidos
            // 
            this.btnCalcularPartidos.ForeColor = System.Drawing.Color.Black;
            this.btnCalcularPartidos.Location = new System.Drawing.Point(278, 23);
            this.btnCalcularPartidos.Name = "btnCalcularPartidos";
            this.btnCalcularPartidos.Size = new System.Drawing.Size(101, 22);
            this.btnCalcularPartidos.TabIndex = 14;
            this.btnCalcularPartidos.Text = "Calcular Partidos";
            this.btnCalcularPartidos.UseVisualStyleBackColor = true;
            this.btnCalcularPartidos.Click += new System.EventHandler(this.btnCalcularPartidos_Click);
            // 
            // txtNumParEquipo
            // 
            this.txtNumParEquipo.Location = new System.Drawing.Point(177, 25);
            this.txtNumParEquipo.Name = "txtNumParEquipo";
            this.txtNumParEquipo.Size = new System.Drawing.Size(95, 21);
            this.txtNumParEquipo.TabIndex = 5;
            // 
            // nudPuntosPerdidos
            // 
            this.nudPuntosPerdidos.Location = new System.Drawing.Point(63, 249);
            this.nudPuntosPerdidos.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudPuntosPerdidos.Name = "nudPuntosPerdidos";
            this.nudPuntosPerdidos.Size = new System.Drawing.Size(37, 21);
            this.nudPuntosPerdidos.TabIndex = 25;
            // 
            // txtNomTorneo
            // 
            this.txtNomTorneo.Location = new System.Drawing.Point(129, 15);
            this.txtNomTorneo.Name = "txtNomTorneo";
            this.txtNomTorneo.Size = new System.Drawing.Size(144, 21);
            this.txtNomTorneo.TabIndex = 1;
            // 
            // lblPuntosGanados
            // 
            this.lblPuntosGanados.AutoSize = true;
            this.lblPuntosGanados.Location = new System.Drawing.Point(6, 189);
            this.lblPuntosGanados.Name = "lblPuntosGanados";
            this.lblPuntosGanados.Size = new System.Drawing.Size(57, 15);
            this.lblPuntosGanados.TabIndex = 20;
            this.lblPuntosGanados.Text = "Ganado :";
            // 
            // lblPuntosEmpate
            // 
            this.lblPuntosEmpate.AutoSize = true;
            this.lblPuntosEmpate.Location = new System.Drawing.Point(8, 220);
            this.lblPuntosEmpate.Name = "lblPuntosEmpate";
            this.lblPuntosEmpate.Size = new System.Drawing.Size(56, 15);
            this.lblPuntosEmpate.TabIndex = 21;
            this.lblPuntosEmpate.Text = "Empate :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número de Equipos:";
            // 
            // lblPuntosPerdido
            // 
            this.lblPuntosPerdido.AutoSize = true;
            this.lblPuntosPerdido.Location = new System.Drawing.Point(8, 251);
            this.lblPuntosPerdido.Name = "lblPuntosPerdido";
            this.lblPuntosPerdido.Size = new System.Drawing.Size(56, 15);
            this.lblPuntosPerdido.TabIndex = 22;
            this.lblPuntosPerdido.Text = "Perdido :";
            // 
            // txtNumEquipo
            // 
            this.txtNumEquipo.Location = new System.Drawing.Point(132, 42);
            this.txtNumEquipo.Name = "txtNumEquipo";
            this.txtNumEquipo.Size = new System.Drawing.Size(141, 21);
            this.txtNumEquipo.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de Inicio:";
            // 
            // btnIngresarDatosTorneo
            // 
            this.btnIngresarDatosTorneo.ForeColor = System.Drawing.Color.Black;
            this.btnIngresarDatosTorneo.Location = new System.Drawing.Point(281, 166);
            this.btnIngresarDatosTorneo.Name = "btnIngresarDatosTorneo";
            this.btnIngresarDatosTorneo.Size = new System.Drawing.Size(107, 57);
            this.btnIngresarDatosTorneo.TabIndex = 10;
            this.btnIngresarDatosTorneo.Text = "Ingresar Datos del Torneo";
            this.btnIngresarDatosTorneo.UseVisualStyleBackColor = true;
            this.btnIngresarDatosTorneo.Click += new System.EventHandler(this.btnIngresarDatosTorneo_Click);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(105, 135);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(95, 21);
            this.dtpFechaInicio.TabIndex = 7;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(93, 162);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(95, 21);
            this.dtpFechaFin.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha de Fin:";
            // 
            // btnMostrarCampeon
            // 
            this.btnMostrarCampeon.Location = new System.Drawing.Point(264, 313);
            this.btnMostrarCampeon.Name = "btnMostrarCampeon";
            this.btnMostrarCampeon.Size = new System.Drawing.Size(90, 53);
            this.btnMostrarCampeon.TabIndex = 18;
            this.btnMostrarCampeon.Text = "Mostrar al Equipo Campeón";
            this.btnMostrarCampeon.UseVisualStyleBackColor = true;
            this.btnMostrarCampeon.Click += new System.EventHandler(this.btnMostrarCampeon_Click);
            // 
            // frmTorneoFutbol2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(469, 385);
            this.Controls.Add(this.btnDatosEquipos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnMostrarCampeon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTorneoFutbol2";
            this.Text = "Torneo de Futbol";
            this.Load += new System.EventHandler(this.frmTorneoFutbol2_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntosGanados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntosEmpate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntosPerdidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDatosEquipos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudPuntosGanados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPuntosEmpate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcularPartidos;
        private System.Windows.Forms.TextBox txtNumParEquipo;
        private System.Windows.Forms.NumericUpDown nudPuntosPerdidos;
        private System.Windows.Forms.TextBox txtNomTorneo;
        private System.Windows.Forms.Label lblPuntosGanados;
        private System.Windows.Forms.Label lblPuntosEmpate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPuntosPerdido;
        private System.Windows.Forms.TextBox txtNumEquipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIngresarDatosTorneo;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMostrarCampeon;
    }
}

