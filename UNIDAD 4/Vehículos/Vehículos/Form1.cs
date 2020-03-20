using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;


namespace Vehículos
{
    public partial class frmVehículos : Form
    {
        ClassVehículo objVehiculo = new ClassVehículo();
        ClassAereo objAereo = new ClassAereo();
        public frmVehículos()
        {
            InitializeComponent();
        }

        private void btnArrancar_Click(object sender, EventArgs e)
        {
            objVehiculo.tipocombus = txtTipoCombus.Text.ToString();
            objVehiculo.color = txtColor.Text.ToString();
            objVehiculo.numpuertas = int.Parse(txtNumPuertas.Text.ToString());
            objVehiculo.numllan = int.Parse(txtNumLlantas.Text.ToString());
            MessageBox.Show("RUN RUN");
            objAereo.numAlas = int.Parse(txtAlas.Text.ToString());
            objAereo.numTurbinas = int.Parse(txtTurbinas.Text.ToString());
            objAereo.numHélices = int.Parse(txtHelices.Text.ToString());
            objAereo.tipoAereo = cmbAereo.Text.ToString();

           objVehiculo.arrancarMotor();
            SoundPlayer sonido = new SoundPlayer();
            sonido.SoundLocation = "C:/Users/odrau/Desktop/UNIDAD 4/vocho.wav";
            sonido.Play();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtAlas.Text = "";
            txtColor.Text = "";
            txtHelices.Text="";
            txtNumLlantas.Text = "";
            txtNumPuertas.Text = "";
            txtTipo.Text = "";
            txtTipoCombus.Text= "";
            txtTurbinas.Text = "";
            cmbAereo.Text = "";
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            objVehiculo.arrancarMotor();
            SoundPlayer sonido = new SoundPlayer();
            sonido.SoundLocation = "C:/Usersodrau/Desktop/UNIDAD 4/vocho.wav";
            sonido.Stop();

            MessageBox.Show("PUG!!");
        }

        private void cmbAereo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
