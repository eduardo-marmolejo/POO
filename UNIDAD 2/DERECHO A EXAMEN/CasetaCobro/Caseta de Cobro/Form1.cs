using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caseta_de_Cobro
{
    public partial class frmCaseta : Form
    {
        ClassVehículo objVehiculo = new ClassVehículo();
        public frmCaseta()
        {
            InitializeComponent();
        }

        private void btnCobro_Click(object sender, EventArgs e)
        {
            objVehiculo.Vehiculo();
            objVehiculo.vehiculo = cmbVehiculo.Text.ToString();
            lblPago.Text = objVehiculo.cobro.ToString();
        }
    }
}
