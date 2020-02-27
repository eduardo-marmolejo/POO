using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vacaciones
{
    public partial class fmrVacaciones : Form
    {
        ClassEmpleado objEmpleado = new ClassEmpleado();
        public fmrVacaciones()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objEmpleado.Vacaciones();
            objEmpleado.años = int.Parse(txtAños.Text.ToString());
            //objEmpleado.vac = itxtAños.ToString());

            lblVacaciones.Text = objEmpleado.vac.ToString();

           // txtAños.Text="";
        }
    }
}
