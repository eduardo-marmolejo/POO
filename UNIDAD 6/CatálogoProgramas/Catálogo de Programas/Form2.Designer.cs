namespace Catálogo_de_Programas
{
    partial class frmUni1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUni1));
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnPrimSol = new System.Windows.Forms.Button();
            this.btnExa23 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInicio.BackgroundImage")));
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInicio.Location = new System.Drawing.Point(47, 295);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(189, 60);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnPrimSol
            // 
            this.btnPrimSol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimSol.Location = new System.Drawing.Point(64, 12);
            this.btnPrimSol.Name = "btnPrimSol";
            this.btnPrimSol.Size = new System.Drawing.Size(146, 69);
            this.btnPrimSol.TabIndex = 1;
            this.btnPrimSol.Text = "Mi Primera Solución";
            this.btnPrimSol.UseVisualStyleBackColor = true;
            this.btnPrimSol.Click += new System.EventHandler(this.btnPrimSol_Click);
            // 
            // btnExa23
            // 
            this.btnExa23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExa23.Location = new System.Drawing.Point(64, 139);
            this.btnExa23.Name = "btnExa23";
            this.btnExa23.Size = new System.Drawing.Size(146, 69);
            this.btnExa23.TabIndex = 2;
            this.btnExa23.Text = "Examen23";
            this.btnExa23.UseVisualStyleBackColor = true;
            this.btnExa23.Click += new System.EventHandler(this.btnExa23_Click);
            // 
            // frmUni1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(275, 367);
            this.Controls.Add(this.btnExa23);
            this.Controls.Add(this.btnPrimSol);
            this.Controls.Add(this.btnInicio);
            this.DoubleBuffered = true;
            this.Name = "frmUni1";
            this.Text = "UNIDAD 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnPrimSol;
        private System.Windows.Forms.Button btnExa23;
    }
}