namespace Catálogo_de_Programas
{
    partial class frmArreglosBidi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArreglosBidi));
            this.btnBidi11 = new System.Windows.Forms.Button();
            this.btnBidi12 = new System.Windows.Forms.Button();
            this.btnBidi2 = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBidi11
            // 
            this.btnBidi11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBidi11.Location = new System.Drawing.Point(23, 45);
            this.btnBidi11.Name = "btnBidi11";
            this.btnBidi11.Size = new System.Drawing.Size(209, 35);
            this.btnBidi11.TabIndex = 0;
            this.btnBidi11.Text = "Bidimensionales 1-1";
            this.btnBidi11.UseVisualStyleBackColor = true;
            this.btnBidi11.Click += new System.EventHandler(this.btnBidi11_Click);
            // 
            // btnBidi12
            // 
            this.btnBidi12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBidi12.Location = new System.Drawing.Point(23, 106);
            this.btnBidi12.Name = "btnBidi12";
            this.btnBidi12.Size = new System.Drawing.Size(209, 38);
            this.btnBidi12.TabIndex = 1;
            this.btnBidi12.Text = "Bidimensionales 1-2";
            this.btnBidi12.UseVisualStyleBackColor = true;
            this.btnBidi12.Click += new System.EventHandler(this.btnBidi12_Click);
            // 
            // btnBidi2
            // 
            this.btnBidi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBidi2.Location = new System.Drawing.Point(23, 170);
            this.btnBidi2.Name = "btnBidi2";
            this.btnBidi2.Size = new System.Drawing.Size(209, 38);
            this.btnBidi2.TabIndex = 2;
            this.btnBidi2.Text = "Bidimensionales 2";
            this.btnBidi2.UseVisualStyleBackColor = true;
            this.btnBidi2.Click += new System.EventHandler(this.btnBidi2_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtras.BackgroundImage")));
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtras.Location = new System.Drawing.Point(68, 254);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(104, 60);
            this.btnAtras.TabIndex = 9;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // frmArreglosBidi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(293, 331);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnBidi2);
            this.Controls.Add(this.btnBidi12);
            this.Controls.Add(this.btnBidi11);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmArreglosBidi";
            this.Text = "Arreglos Bidimensionales";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBidi11;
        private System.Windows.Forms.Button btnBidi12;
        private System.Windows.Forms.Button btnBidi2;
        private System.Windows.Forms.Button btnAtras;
    }
}