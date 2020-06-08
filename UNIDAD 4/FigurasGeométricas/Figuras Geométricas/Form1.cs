using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Geométricas
{
    public partial class frmFiguras : Form
    {
        ClassCuadrado objCuadrado = new ClassCuadrado();
        ClassTriangulo objTriangulo = new ClassTriangulo();
        ClassCirculo objCirculo = new ClassCirculo();
        public frmFiguras()
        {
            InitializeComponent();
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
                    break;

                case "Triángulo":
                    label2.Text = "Introduce la altura:";
                    txtMedida.Text = "";
                    label3.Text = "Introduce la base:";
                    txtMedida2.Text = "";
                    txtMedida3.Text="";
                    txtMedida.Enabled = true;
                    txtMedida2.Enabled = true;
                    txtMedida3.Enabled = false;
                    break;

                case "Círculo":
                    label2.Text = "Introduce el radio:";
                    label3.Text = "Introduce la medida:";
                    label4.Text = "Introduce la medida:";
                    txtMedida.Text = "";
                    txtMedida2.Enabled = false;
                    txtMedida3.Enabled = false;
                    txtMedida2.Text = "";
                    txtMedida3.Text = "";
                    break;
            }
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
                    objTriangulo.Medida = double.Parse(txtMedida.Text.ToString());
                    objTriangulo.Medida2 = double.Parse(txtMedida2.Text.ToString());
                    objTriangulo.Trinagulo();
                    lblArea.Text = objTriangulo.Area.ToString();
                    lblPerimetro.Text = objTriangulo.Perimetro.ToString();
                    break;

                case "Círculo":
                    objCirculo.Medida = double.Parse(txtMedida.Text.ToString());
                    objCirculo.Circulo();
                    lblArea.Text = objCirculo.Area.ToString();
                    lblPerimetro.Text = objCirculo.Perimetro.ToString();
                    break;
            }
        }
    }
}
