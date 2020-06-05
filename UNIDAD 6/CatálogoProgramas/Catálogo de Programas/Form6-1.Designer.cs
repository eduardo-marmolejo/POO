namespace Catálogo_de_Programas
{
    partial class frmRegistros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistros));
            this.btnRegPa = new System.Windows.Forms.Button();
            this.btnRegPa2 = new System.Windows.Forms.Button();
            this.btnRegEs = new System.Windows.Forms.Button();
            this.btnRegEs2 = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegPa
            // 
            this.btnRegPa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegPa.Location = new System.Drawing.Point(50, 57);
            this.btnRegPa.Name = "btnRegPa";
            this.btnRegPa.Size = new System.Drawing.Size(95, 56);
            this.btnRegPa.TabIndex = 0;
            this.btnRegPa.Text = "Registro Países";
            this.btnRegPa.UseVisualStyleBackColor = true;
            this.btnRegPa.Click += new System.EventHandler(this.btnRegPa_Click);
            // 
            // btnRegPa2
            // 
            this.btnRegPa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegPa2.Location = new System.Drawing.Point(211, 57);
            this.btnRegPa2.Name = "btnRegPa2";
            this.btnRegPa2.Size = new System.Drawing.Size(100, 58);
            this.btnRegPa2.TabIndex = 1;
            this.btnRegPa2.Text = "Registro Países 2";
            this.btnRegPa2.UseVisualStyleBackColor = true;
            this.btnRegPa2.Click += new System.EventHandler(this.btnRegPa2_Click);
            // 
            // btnRegEs
            // 
            this.btnRegEs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegEs.Location = new System.Drawing.Point(50, 199);
            this.btnRegEs.Name = "btnRegEs";
            this.btnRegEs.Size = new System.Drawing.Size(99, 60);
            this.btnRegEs.TabIndex = 2;
            this.btnRegEs.Text = "Registro Escolar";
            this.btnRegEs.UseVisualStyleBackColor = true;
            this.btnRegEs.Click += new System.EventHandler(this.btnRegEs_Click);
            // 
            // btnRegEs2
            // 
            this.btnRegEs2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegEs2.Location = new System.Drawing.Point(201, 199);
            this.btnRegEs2.Name = "btnRegEs2";
            this.btnRegEs2.Size = new System.Drawing.Size(110, 60);
            this.btnRegEs2.TabIndex = 3;
            this.btnRegEs2.Text = "Registro Escolar 2";
            this.btnRegEs2.UseVisualStyleBackColor = true;
            this.btnRegEs2.Click += new System.EventHandler(this.btnRegEs2_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtras.BackgroundImage")));
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtras.Location = new System.Drawing.Point(12, 337);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(104, 60);
            this.btnAtras.TabIndex = 8;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // frmRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(357, 401);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnRegEs2);
            this.Controls.Add(this.btnRegEs);
            this.Controls.Add(this.btnRegPa2);
            this.Controls.Add(this.btnRegPa);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistros";
            this.Text = "REGISTROS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegPa;
        private System.Windows.Forms.Button btnRegPa2;
        private System.Windows.Forms.Button btnRegEs;
        private System.Windows.Forms.Button btnRegEs2;
        private System.Windows.Forms.Button btnAtras;
    }
}