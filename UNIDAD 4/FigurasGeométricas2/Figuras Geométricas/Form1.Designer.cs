namespace Figuras_Geométricas
{
    partial class frmFiguras
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
            this.cmbTipoTriangulo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtMedida2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFiguras = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMedida3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbTipoTriangulo
            // 
            this.cmbTipoTriangulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoTriangulo.FormattingEnabled = true;
            this.cmbTipoTriangulo.Items.AddRange(new object[] {
            "Equilátero",
            "Isósceles",
            "Escaleno"});
            this.cmbTipoTriangulo.Location = new System.Drawing.Point(105, 44);
            this.cmbTipoTriangulo.Name = "cmbTipoTriangulo";
            this.cmbTipoTriangulo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoTriangulo.TabIndex = 29;
            this.cmbTipoTriangulo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoTriangulo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Tipo de triánglo:";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(181, 274);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(13, 13);
            this.lblPerimetro.TabIndex = 27;
            this.lblPerimetro.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Perímetro:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(157, 239);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(13, 13);
            this.lblArea.TabIndex = 25;
            this.lblArea.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Área:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(87, 186);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 23;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtMedida2
            // 
            this.txtMedida2.Location = new System.Drawing.Point(125, 116);
            this.txtMedida2.Name = "txtMedida2";
            this.txtMedida2.Size = new System.Drawing.Size(100, 20);
            this.txtMedida2.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Introduce la medida:";
            // 
            // txtMedida
            // 
            this.txtMedida.Location = new System.Drawing.Point(125, 83);
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.Size = new System.Drawing.Size(100, 20);
            this.txtMedida.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Introduce la medida:";
            // 
            // cmbFiguras
            // 
            this.cmbFiguras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiguras.FormattingEnabled = true;
            this.cmbFiguras.Items.AddRange(new object[] {
            "Cuadrado",
            "Triángulo",
            "Círculo"});
            this.cmbFiguras.Location = new System.Drawing.Point(122, 12);
            this.cmbFiguras.Name = "cmbFiguras";
            this.cmbFiguras.Size = new System.Drawing.Size(121, 21);
            this.cmbFiguras.TabIndex = 18;
            this.cmbFiguras.SelectedIndexChanged += new System.EventHandler(this.cmbFiguras_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Selecciona la figura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Introduce la medida:";
            // 
            // txtMedida3
            // 
            this.txtMedida3.Location = new System.Drawing.Point(128, 145);
            this.txtMedida3.Name = "txtMedida3";
            this.txtMedida3.Size = new System.Drawing.Size(100, 20);
            this.txtMedida3.TabIndex = 31;
            // 
            // frmFiguras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 311);
            this.Controls.Add(this.txtMedida3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTipoTriangulo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtMedida2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMedida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFiguras);
            this.Controls.Add(this.label1);
            this.Name = "frmFiguras";
            this.Text = "Figuras Geométricas";
            this.Load += new System.EventHandler(this.frmFiguras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoTriangulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtMedida2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFiguras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMedida3;
    }
}

