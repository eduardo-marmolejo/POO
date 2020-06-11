using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Geométricas_2
{
    public partial class FrmFiguras2 : Form
    {
        ClassCuadrado objCuadrado = new ClassCuadrado();
        ClassCirculo objCirculo = new ClassCirculo();
        ClassEquilátero objEquilatero = new ClassEquilátero();
        ClassIsósceles objIsosceles = new ClassIsósceles();
        ClassEscaleno objEscaleno = new ClassEscaleno();
        public FrmFiguras2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            switch (cmbFiguras.Text)
            {
                case "Cuadrado":
                    objCuadrado.Medida = double.Parse(txtMedida.Text.ToString());
                    objCuadrado.Cuadrado();
                    lblArea.Text = objCuadrado.Area.ToString();
                    lblPerimetro.Text = objCuadrado.Perimetro.ToString();
                    break;

                case "Triángulo":
                    if (cmbTipoTriangulo.Text == "Equilátero")
                    {
                        objEquilatero.Medida = double.Parse(txtMedida.Text.ToString());
                        objEquilatero.Equilatero();
                        lblArea.Text = objEquilatero.Area.ToString();
                        lblPerimetro.Text = objEquilatero.Perimetro.ToString();

                    }
                    else
                    if (cmbTipoTriangulo.Text == "Isósceles")
                    {
                        objIsosceles.Medida = double.Parse(txtMedida.Text);
                        objIsosceles.Medida2 = double.Parse(txtMedida2.Text);
                        objIsosceles.Isosceles();
                        lblArea.Text = objIsosceles.Area.ToString();
                        lblPerimetro.Text = objIsosceles.Perimetro.ToString();
                    }
                    else
                    if (cmbTipoTriangulo.Text == "Escaleno")
                    {
                        objEscaleno.Medida = double.Parse(txtMedida.Text);
                        objEscaleno.Medida2 = double.Parse(txtMedida2.Text);
                        objEscaleno.Medida3 = double.Parse(txtMedida3.Text);
                        objEscaleno.Escaleno();
                        lblArea.Text = objEscaleno.Area.ToString();
                        lblPerimetro.Text = objEscaleno.Perimetro.ToString();
                    }
                    break;

                case "Círculo":
                    objCirculo.Medida = double.Parse(txtMedida.Text.ToString());
                    objCirculo.Circulo();
                    lblArea.Text = objCirculo.Area.ToString();
                    lblPerimetro.Text = objCirculo.Perimetro.ToString();
                    break;
            }
        }

        private void cmbFiguras_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFiguras.Text)
            {
                case "Cuadrado":
                    label2.Text = "Introduce la medida:";
                    label3.Text = "Introduce la medida:";
                    txtMedida.Text = "";
                    txtMedida2.Text = "";
                    txtMedida2.Enabled = false;
                    txtMedida3.Enabled = false;
                    cmbTipoTriangulo.Enabled = false;
                    break;

                case "Triángulo":
                    cmbTipoTriangulo.Enabled = true;
                    label2.Text = "Introduce la medida:";
                    txtMedida.Text = "";
                    break;

                case "Círculo":
                    label2.Text = "Introduce el radio:";
                    label3.Text = "Introduce la medida:";
                    txtMedida.Text = "";
                    txtMedida2.Enabled = false;
                    txtMedida2.Text = "";
                    cmbTipoTriangulo.Enabled = false;
                    break;
            }
        }

        private void cmbTipoTriangulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTipoTriangulo.Text)
            {
                case "Equilátero":
                    txtMedida.Enabled = true;
                    txtMedida2.Enabled = false;
                    txtMedida3.Enabled = false;

                    txtMedida.Text = "";
                    txtMedida2.Text = "";

                    label2.Text = "Introduce una medida:";
                    label3.Text = "Introduce la medida:";

                    /*label3.Text = "Introduce la base:";
                    /*txtMedida.Location = new Point(124, 97);
                    txtMedida2.Location = new Point(124, 130);*/
                    break;

                case "Isósceles":
                    txtMedida.Enabled = true;
                    txtMedida2.Enabled = true;
                    txtMedida3.Enabled = false;
                    label2.Text = "Introduce un lado:";
                    label3.Text = "Introduce la base:";
                    label4.Text = "Introduce la medida:";

                    txtMedida.Text = "";
                    txtMedida2.Text = "";
                    txtMedida3.Text = "";


                    txtMedida.Location = new Point(125, 83);
                    txtMedida2.Location = new Point(125, 116);
                    txtMedida3.Location = new Point(128, 145);
                    break;

                case "Escaleno":
                    txtMedida.Enabled = true;
                    txtMedida2.Enabled = true;
                    txtMedida3.Enabled = true;

                    label2.Text = "Introduce el primer lado:";
                    label3.Text = "Introduce el segundo lado:";
                    label4.Text = "Introduce el tercer lado:";

                    txtMedida.Text = "";
                    txtMedida2.Text = "";

                    txtMedida.Location = new Point(155, 83);
                    txtMedida2.Location = new Point(144, 116);
                    txtMedida3.Location = new Point(164, 145);
                    break;
            }
        }

        private void frmFiguras_Load(object sender, EventArgs e)
        {
            cmbTipoTriangulo.Enabled = false;
        }
    }
}
