using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuadrado
{
    public partial class fmrCuadrado : Form
    {
        ClassCuadrado objCuadrado = new ClassCuadrado();
        public fmrCuadrado()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objCuadrado.ProcesoCuadrado();
            objCuadrado.medida = int.Parse(txtMedida.Text.ToString());
            lblArea.Text=objCuadrado.area.ToString();
            lblPerimetro.Text = objCuadrado.peri.ToString();
        }
    }
}
