using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fecha_de_Nacimiento
{
    public partial class frmFechaNacimiento : Form
    {
        ClassPersona objPerosna = new ClassPersona();
        public frmFechaNacimiento()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            objPerosna.año = int.Parse(DateTime.Today.Year.ToString());
            objPerosna.mes = int.Parse(DateTime.Today.Month.ToString());
            objPerosna.dia = int.Parse(DateTime.Today.Day.ToString());
            objPerosna.años = int.Parse(dtpFecha.Value.Year.ToString());
            objPerosna.mess = int.Parse(dtpFecha.Value.Month.ToString());
            objPerosna.dias = int.Parse(dtpFecha.Value.Day.ToString());
            objPerosna.MayorEdad();
            lblMayorEdad.Text = objPerosna.me;
            objPerosna.me = "";
        }
    }
}
