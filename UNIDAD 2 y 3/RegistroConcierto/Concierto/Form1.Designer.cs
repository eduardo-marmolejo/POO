namespace Concierto
{
    partial class fmrConcierto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrConcierto));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPersona = new System.Windows.Forms.ComboBox();
            this.cmbNumPer = new System.Windows.Forms.ComboBox();
            this.btnContabilizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNiños = new System.Windows.Forms.Label();
            this.lblBebes = new System.Windows.Forms.Label();
            this.lblAdultos = new System.Windows.Forms.Label();
            this.lblTerceraEdad = new System.Windows.Forms.Label();
            this.btnRportar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asistente:";
            // 
            // cmbPersona
            // 
            this.cmbPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersona.FormattingEnabled = true;
            this.cmbPersona.Items.AddRange(new object[] {
            "Bebes",
            "Niños",
            "Adultos",
            "Tercera Edad"});
            this.cmbPersona.Location = new System.Drawing.Point(73, 25);
            this.cmbPersona.Name = "cmbPersona";
            this.cmbPersona.Size = new System.Drawing.Size(146, 21);
            this.cmbPersona.TabIndex = 1;
            // 
            // cmbNumPer
            // 
            this.cmbNumPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumPer.FormattingEnabled = true;
            this.cmbNumPer.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbNumPer.Location = new System.Drawing.Point(237, 25);
            this.cmbNumPer.Name = "cmbNumPer";
            this.cmbNumPer.Size = new System.Drawing.Size(44, 21);
            this.cmbNumPer.TabIndex = 2;
            // 
            // btnContabilizar
            // 
            this.btnContabilizar.Location = new System.Drawing.Point(134, 67);
            this.btnContabilizar.Name = "btnContabilizar";
            this.btnContabilizar.Size = new System.Drawing.Size(75, 23);
            this.btnContabilizar.TabIndex = 3;
            this.btnContabilizar.Text = "Contabilizar";
            this.btnContabilizar.UseVisualStyleBackColor = true;
            this.btnContabilizar.Click += new System.EventHandler(this.btnContabilizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(131, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Asistentes";
            // 
            // lblNiños
            // 
            this.lblNiños.AutoSize = true;
            this.lblNiños.BackColor = System.Drawing.Color.Transparent;
            this.lblNiños.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiños.ForeColor = System.Drawing.Color.White;
            this.lblNiños.Location = new System.Drawing.Point(109, 170);
            this.lblNiños.Name = "lblNiños";
            this.lblNiños.Size = new System.Drawing.Size(44, 14);
            this.lblNiños.TabIndex = 5;
            this.lblNiños.Text = "Niños:";
            // 
            // lblBebes
            // 
            this.lblBebes.AutoSize = true;
            this.lblBebes.BackColor = System.Drawing.Color.Transparent;
            this.lblBebes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebes.ForeColor = System.Drawing.Color.White;
            this.lblBebes.Location = new System.Drawing.Point(106, 147);
            this.lblBebes.Name = "lblBebes";
            this.lblBebes.Size = new System.Drawing.Size(49, 14);
            this.lblBebes.TabIndex = 6;
            this.lblBebes.Text = "Bebes:";
            // 
            // lblAdultos
            // 
            this.lblAdultos.AutoSize = true;
            this.lblAdultos.BackColor = System.Drawing.Color.Transparent;
            this.lblAdultos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdultos.ForeColor = System.Drawing.Color.White;
            this.lblAdultos.Location = new System.Drawing.Point(101, 194);
            this.lblAdultos.Name = "lblAdultos";
            this.lblAdultos.Size = new System.Drawing.Size(56, 14);
            this.lblAdultos.TabIndex = 7;
            this.lblAdultos.Text = "Adultos:";
            // 
            // lblTerceraEdad
            // 
            this.lblTerceraEdad.AutoSize = true;
            this.lblTerceraEdad.BackColor = System.Drawing.Color.Transparent;
            this.lblTerceraEdad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerceraEdad.ForeColor = System.Drawing.Color.White;
            this.lblTerceraEdad.Location = new System.Drawing.Point(71, 217);
            this.lblTerceraEdad.Name = "lblTerceraEdad";
            this.lblTerceraEdad.Size = new System.Drawing.Size(91, 14);
            this.lblTerceraEdad.TabIndex = 8;
            this.lblTerceraEdad.Text = "Tercera Edad:";
            // 
            // btnRportar
            // 
            this.btnRportar.Location = new System.Drawing.Point(134, 242);
            this.btnRportar.Name = "btnRportar";
            this.btnRportar.Size = new System.Drawing.Size(75, 23);
            this.btnRportar.TabIndex = 9;
            this.btnRportar.Text = "Reportar";
            this.btnRportar.UseVisualStyleBackColor = true;
            this.btnRportar.Click += new System.EventHandler(this.btnRportar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // fmrConcierto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(310, 309);
            this.Controls.Add(this.btnRportar);
            this.Controls.Add(this.lblTerceraEdad);
            this.Controls.Add(this.lblAdultos);
            this.Controls.Add(this.lblBebes);
            this.Controls.Add(this.lblNiños);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnContabilizar);
            this.Controls.Add(this.cmbNumPer);
            this.Controls.Add(this.cmbPersona);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmrConcierto";
            this.Text = "Concierto";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPersona;
        private System.Windows.Forms.ComboBox cmbNumPer;
        private System.Windows.Forms.Button btnContabilizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNiños;
        private System.Windows.Forms.Label lblBebes;
        private System.Windows.Forms.Label lblAdultos;
        private System.Windows.Forms.Label lblTerceraEdad;
        private System.Windows.Forms.Button btnRportar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

