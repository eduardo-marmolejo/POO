namespace Catálogo_de_Programas
{
    partial class frmUni23
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUni23));
            this.btnInicio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnExamen = new System.Windows.Forms.Button();
            this.btnRegCon = new System.Windows.Forms.Button();
            this.btnRegPer = new System.Windows.Forms.Button();
            this.btnEmbotelladora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInicio.BackgroundImage")));
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInicio.Location = new System.Drawing.Point(169, 369);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(189, 60);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "En esta parte del programa, es la Unidad 2 y 3, ya que se \r\nevaluaron al mismo ti" +
    "empo, y es por eso que se juntó \r\nen el programa.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCal
            // 
            this.btnCal.BackColor = System.Drawing.SystemColors.Control;
            this.btnCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCal.Location = new System.Drawing.Point(16, 86);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(157, 42);
            this.btnCal.TabIndex = 3;
            this.btnCal.Text = "Calificaciones";
            this.btnCal.UseVisualStyleBackColor = false;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnExamen
            // 
            this.btnExamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExamen.Location = new System.Drawing.Point(369, 73);
            this.btnExamen.Name = "btnExamen";
            this.btnExamen.Size = new System.Drawing.Size(127, 69);
            this.btnExamen.TabIndex = 4;
            this.btnExamen.Text = "Derecho a Examen";
            this.btnExamen.UseVisualStyleBackColor = true;
            this.btnExamen.Click += new System.EventHandler(this.btnExamen_Click);
            // 
            // btnRegCon
            // 
            this.btnRegCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegCon.Location = new System.Drawing.Point(204, 178);
            this.btnRegCon.Name = "btnRegCon";
            this.btnRegCon.Size = new System.Drawing.Size(114, 60);
            this.btnRegCon.TabIndex = 5;
            this.btnRegCon.Text = "Regitro Concierto";
            this.btnRegCon.UseVisualStyleBackColor = true;
            this.btnRegCon.Click += new System.EventHandler(this.btnRegCon_Click);
            // 
            // btnRegPer
            // 
            this.btnRegPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegPer.Location = new System.Drawing.Point(56, 273);
            this.btnRegPer.Name = "btnRegPer";
            this.btnRegPer.Size = new System.Drawing.Size(117, 61);
            this.btnRegPer.TabIndex = 6;
            this.btnRegPer.Text = "Registro Personas";
            this.btnRegPer.UseVisualStyleBackColor = true;
            this.btnRegPer.Click += new System.EventHandler(this.btnRegPer_Click);
            // 
            // btnEmbotelladora
            // 
            this.btnEmbotelladora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmbotelladora.Location = new System.Drawing.Point(338, 291);
            this.btnEmbotelladora.Name = "btnEmbotelladora";
            this.btnEmbotelladora.Size = new System.Drawing.Size(158, 43);
            this.btnEmbotelladora.TabIndex = 7;
            this.btnEmbotelladora.Text = "Embotelladora";
            this.btnEmbotelladora.UseVisualStyleBackColor = true;
            this.btnEmbotelladora.Click += new System.EventHandler(this.btnEmbotelladora_Click);
            // 
            // frmUni23
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(518, 441);
            this.Controls.Add(this.btnEmbotelladora);
            this.Controls.Add(this.btnRegPer);
            this.Controls.Add(this.btnRegCon);
            this.Controls.Add(this.btnExamen);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInicio);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUni23";
            this.Text = "UNIDAD 2 y 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnExamen;
        private System.Windows.Forms.Button btnRegCon;
        private System.Windows.Forms.Button btnRegPer;
        private System.Windows.Forms.Button btnEmbotelladora;
    }
}