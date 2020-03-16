using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones
{
    public partial class frmOperacion : Form
    {
        ClassOperación objOperacion = new ClassOperación();
        ClassSuma objSuma = new ClassSuma();
        ClassResta objResta = new ClassResta();
        ClassMultiplicación objMultiplicacion = new ClassMultiplicación();
        ClassDivisión objDivision = new ClassDivisión();
        public frmOperacion()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            switch (cmbOperacion.Text)
            {
                case "+":
                    objSuma.Suma();
                    objSuma.Valor1 = float.Parse(txtValor1.Text.ToString());
                    objSuma.Valor2 = float.Parse(txtValor2.Text.ToString());
                    lblResultado.Text = objSuma.Resultado.ToString();
                    break;

                case "-":
                    objResta.Resta();
                    objResta.Valor1 = float.Parse(txtValor1.Text.ToString());
                    objResta.Valor2 = float.Parse(txtValor2.Text.ToString());
                    lblResultado.Text = objResta.Resultado.ToString();
                    break;

                case "*":
                    objMultiplicacion.Multiplicacion();
                    objMultiplicacion.Valor1 = float.Parse(txtValor1.Text.ToString());
                    objMultiplicacion.Valor2 = float.Parse(txtValor2.Text.ToString());
                    lblResultado.Text = objMultiplicacion.Resultado.ToString();
                    break;

                case "/":
                    objDivision.Division();
                    objDivision.Valor1 = float.Parse(txtValor1.Text.ToString());
                    objDivision.Valor2 = float.Parse(txtValor2.Text.ToString());
                    lblResultado.Text = objDivision.Resultado.ToString();
                    break;
            }

            /*objSuma.Suma();
            objResta.Resta();
            objMultiplicacion.Multiplicacion();
            objDivision.Division();
            objOperacion.Valor1 = float.Parse(txtValor1.Text.ToString());
            objOperacion.Valor2 = float.Parse(txtValor2.Text.ToString());
            lblSuma.Text = objSuma.Resultado.ToString();
            lblResta.Text = objResta.Resultado.ToString();
            lblMultiplicacion.Text = objMultiplicacion.Resultado.ToString();
            lblDivision.Text = objDivision.Resultado.ToString();*/
        }
    }
}
