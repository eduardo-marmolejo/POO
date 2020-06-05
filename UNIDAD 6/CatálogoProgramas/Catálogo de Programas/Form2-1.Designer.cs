namespace Catálogo_de_Programas
{
    partial class frmEjecutables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEjecutables));
            this.btnWindowsForm = new System.Windows.Forms.Button();
            this.btnConsola = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWindowsForm
            // 
            this.btnWindowsForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWindowsForm.Location = new System.Drawing.Point(146, 203);
            this.btnWindowsForm.Name = "btnWindowsForm";
            this.btnWindowsForm.Size = new System.Drawing.Size(160, 49);
            this.btnWindowsForm.TabIndex = 4;
            this.btnWindowsForm.Text = "WindowsForm";
            this.btnWindowsForm.UseVisualStyleBackColor = true;
            this.btnWindowsForm.Click += new System.EventHandler(this.btnWindowsForm_Click);
            // 
            // btnConsola
            // 
            this.btnConsola.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsola.Location = new System.Drawing.Point(148, 51);
            this.btnConsola.Name = "btnConsola";
            this.btnConsola.Size = new System.Drawing.Size(121, 67);
            this.btnConsola.TabIndex = 3;
            this.btnConsola.Text = "Consola";
            this.btnConsola.UseVisualStyleBackColor = true;
            this.btnConsola.Click += new System.EventHandler(this.btnConsola_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtras.BackgroundImage")));
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtras.Location = new System.Drawing.Point(165, 345);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(104, 60);
            this.btnAtras.TabIndex = 8;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // frmEjecutables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(437, 437);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnWindowsForm);
            this.Controls.Add(this.btnConsola);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEjecutables";
            this.Text = "EJECUTABLES";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWindowsForm;
        private System.Windows.Forms.Button btnConsola;
        private System.Windows.Forms.Button btnAtras;
    }
}