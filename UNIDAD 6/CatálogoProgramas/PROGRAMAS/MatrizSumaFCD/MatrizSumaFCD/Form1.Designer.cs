namespace MatrizSumaFCD
{
    partial class frmMatrizSumaFCD
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
            this.txtSumaFilas = new System.Windows.Forms.TextBox();
            this.txtSumaColumnas = new System.Windows.Forms.TextBox();
            this.txtMatriz = new System.Windows.Forms.TextBox();
            this.btnSumaColumnas = new System.Windows.Forms.Button();
            this.btnSumaFilas = new System.Windows.Forms.Button();
            this.btnTamañoMatriz = new System.Windows.Forms.Button();
            this.btnSumaDiagonal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudNumMatriz = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSumaDiagonal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSumaFilas
            // 
            this.txtSumaFilas.Location = new System.Drawing.Point(194, 37);
            this.txtSumaFilas.Multiline = true;
            this.txtSumaFilas.Name = "txtSumaFilas";
            this.txtSumaFilas.Size = new System.Drawing.Size(38, 126);
            this.txtSumaFilas.TabIndex = 14;
            // 
            // txtSumaColumnas
            // 
            this.txtSumaColumnas.Location = new System.Drawing.Point(41, 175);
            this.txtSumaColumnas.Multiline = true;
            this.txtSumaColumnas.Name = "txtSumaColumnas";
            this.txtSumaColumnas.Size = new System.Drawing.Size(123, 26);
            this.txtSumaColumnas.TabIndex = 12;
            // 
            // txtMatriz
            // 
            this.txtMatriz.Location = new System.Drawing.Point(41, 37);
            this.txtMatriz.Multiline = true;
            this.txtMatriz.Name = "txtMatriz";
            this.txtMatriz.Size = new System.Drawing.Size(123, 126);
            this.txtMatriz.TabIndex = 10;
            // 
            // btnSumaColumnas
            // 
            this.btnSumaColumnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumaColumnas.Location = new System.Drawing.Point(61, 217);
            this.btnSumaColumnas.Name = "btnSumaColumnas";
            this.btnSumaColumnas.Size = new System.Drawing.Size(80, 48);
            this.btnSumaColumnas.TabIndex = 2;
            this.btnSumaColumnas.Text = "Suma Columnas";
            this.btnSumaColumnas.UseVisualStyleBackColor = true;
            this.btnSumaColumnas.Click += new System.EventHandler(this.btnSumaColumnas_Click);
            // 
            // btnSumaFilas
            // 
            this.btnSumaFilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumaFilas.Location = new System.Drawing.Point(255, 70);
            this.btnSumaFilas.Name = "btnSumaFilas";
            this.btnSumaFilas.Size = new System.Drawing.Size(80, 48);
            this.btnSumaFilas.TabIndex = 1;
            this.btnSumaFilas.Text = "Suma Filas";
            this.btnSumaFilas.UseVisualStyleBackColor = true;
            this.btnSumaFilas.Click += new System.EventHandler(this.btnSumaFilas_Click);
            // 
            // btnTamañoMatriz
            // 
            this.btnTamañoMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTamañoMatriz.Location = new System.Drawing.Point(224, 11);
            this.btnTamañoMatriz.Name = "btnTamañoMatriz";
            this.btnTamañoMatriz.Size = new System.Drawing.Size(123, 20);
            this.btnTamañoMatriz.TabIndex = 0;
            this.btnTamañoMatriz.Text = "Tamaño de la Matriz";
            this.btnTamañoMatriz.UseVisualStyleBackColor = true;
            this.btnTamañoMatriz.Click += new System.EventHandler(this.btnTamañoMatriz_Click);
            // 
            // btnSumaDiagonal
            // 
            this.btnSumaDiagonal.Location = new System.Drawing.Point(295, 268);
            this.btnSumaDiagonal.Name = "btnSumaDiagonal";
            this.btnSumaDiagonal.Size = new System.Drawing.Size(95, 36);
            this.btnSumaDiagonal.TabIndex = 18;
            this.btnSumaDiagonal.Text = "Suma en Diagonal";
            this.btnSumaDiagonal.UseVisualStyleBackColor = true;
            this.btnSumaDiagonal.Click += new System.EventHandler(this.btnSumaDiagonal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ingresa el tamaño de la Matriz:";
            // 
            // nudNumMatriz
            // 
            this.nudNumMatriz.Location = new System.Drawing.Point(170, 11);
            this.nudNumMatriz.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumMatriz.Name = "nudNumMatriz";
            this.nudNumMatriz.Size = new System.Drawing.Size(43, 20);
            this.nudNumMatriz.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Suma de los elementos en diagonal:";
            // 
            // lblSumaDiagonal
            // 
            this.lblSumaDiagonal.AutoSize = true;
            this.lblSumaDiagonal.Location = new System.Drawing.Point(196, 280);
            this.lblSumaDiagonal.Name = "lblSumaDiagonal";
            this.lblSumaDiagonal.Size = new System.Drawing.Size(13, 13);
            this.lblSumaDiagonal.TabIndex = 24;
            this.lblSumaDiagonal.Text = "0";
            // 
            // frmMatrizSumaFCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 318);
            this.Controls.Add(this.lblSumaDiagonal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudNumMatriz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSumaDiagonal);
            this.Controls.Add(this.btnSumaColumnas);
            this.Controls.Add(this.btnSumaFilas);
            this.Controls.Add(this.txtSumaFilas);
            this.Controls.Add(this.btnTamañoMatriz);
            this.Controls.Add(this.txtSumaColumnas);
            this.Controls.Add(this.txtMatriz);
            this.Name = "frmMatrizSumaFCD";
            this.Text = "MatrizSumaFCD";
            this.Load += new System.EventHandler(this.frmMatrizSumaFCD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSumaFilas;
        private System.Windows.Forms.TextBox txtSumaColumnas;
        private System.Windows.Forms.TextBox txtMatriz;
        private System.Windows.Forms.Button btnSumaColumnas;
        private System.Windows.Forms.Button btnSumaFilas;
        private System.Windows.Forms.Button btnTamañoMatriz;
        private System.Windows.Forms.Button btnSumaDiagonal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudNumMatriz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSumaDiagonal;
    }
}

