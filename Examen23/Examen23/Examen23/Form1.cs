using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen23
{
    public partial class frmTemperaturas : Form
    {
        ClassTemperatura objTemperaturas = new ClassTemperatura();
        public frmTemperaturas()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objTemperaturas.Temperatura();
            objTemperaturas.temperaturas = cmbUniMedia.Text.ToString();
            objTemperaturas.medida = int.Parse(txtGrados.Text.ToString());


            lblCentígrados.Text = objTemperaturas.centi.ToString();
            lblFahrenheit.Text = objTemperaturas.fahr.ToString();
        }
    }
}
