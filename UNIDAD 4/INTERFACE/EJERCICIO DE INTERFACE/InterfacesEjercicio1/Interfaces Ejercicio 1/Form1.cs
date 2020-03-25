using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces_Ejercicio_1
{
    public partial class frmCalculadora : Form
    {
        ClassSuma objSuma = new ClassSuma();
        ClassResta objResta = new ClassResta();
        ClassMultiplicación objMultiplicacion = new ClassMultiplicación();
        ClassDivision objDivision = new ClassDivision();
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnRango_Click(object sender, EventArgs e)
        {
            switch (cmbSigno.Text)
            {
                case "+":
                    objSuma.Num = double.Parse(txtNum.Text.ToString());
                    objSuma.Num2 = double.Parse(txtNum2.Text.ToString());
                    objSuma.Calcular();
                    lblResultado.Text = "El resultado de la suma es: " + objSuma.Resultado.ToString();
                    break;

                case "-":
                    objResta.Num = double.Parse(txtNum.Text.ToString());
                    objResta.Num2 = double.Parse(txtNum2.Text.ToString());
                    objResta.Calcular();
                    lblResultado.Text = "El resultado de la resta es: " + objResta.Resultado.ToString();
                    break;

                case "*":
                    objMultiplicacion.Num = double.Parse(txtNum.Text.ToString());
                    objMultiplicacion.Num2 = double.Parse(txtNum2.Text.ToString());
                    objMultiplicacion.Calcular();
                    lblResultado.Text = "El resultado de la multiplicación es: " + objMultiplicacion.Resultado.ToString();
                    break;

                case "/":
                    objDivision.Num = double.Parse(txtNum.Text.ToString());
                    objDivision.Num2 = double.Parse(txtNum2.Text.ToString());
                    objDivision.Calcular();
                    lblResultado.Text = "El resultado de la división es: " + objDivision.Resultado.ToString();
                    break;
            }
        }
    }
}
