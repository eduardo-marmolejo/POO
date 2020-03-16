using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados_Restaurante
{
    public partial class frmEmpleado : Form
    {
        ClassMesero objMesero = new ClassMesero();
        ClassRepartidor objRepartidor = new ClassRepartidor();
        ClassCajero objCajero = new ClassCajero();
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            cmbZona.Enabled = false;
            cmbCaja.Enabled = false;
        }

        private void cmbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbEmpleado.Text)
            {
                case "Mesero":
                    label2.Text = "Pago por día:";
                    label3.Text = "Días trabjados:";
                    label4.Text = "Propinas";
                    txtCantidad.Clear();
                    txtCantidad2.Clear();
                    txtCantidad3.Clear();
                    cmbZona.Enabled = false;
                    cmbCaja.Enabled = false;
                    cmbCaja.Text = "";
                    cmbZona.Text = "";
                    break;

                case "Repartidor":
                    cmbZona.Enabled = true;
                    cmbCaja.Enabled = false;
                    cmbCaja.Text = "";
                    label2.Text = "Pago por día:";
                    label3.Text = "Días trabjados:";
                    label4.Text = "Pedidos entregados:";
                    txtCantidad.Clear();
                    txtCantidad2.Clear();
                    txtCantidad3.Clear();
                    break;

                case "Cajero":
                    cmbCaja.Enabled = true;
                    cmbZona.Enabled = false;
                    cmbZona.Text="";
                    label2.Text = "Pago por día:";
                    label3.Text = "Días trabjados:";
                    label4.Text = "Introduzca la cantidad:";
                    txtCantidad3.Enabled = false;
                    txtCantidad.Clear();
                    txtCantidad2.Clear();
                    txtCantidad3.Clear();
                    break;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            switch (cmbEmpleado.Text)
            {
                case "Mesero":
                    objMesero.Pago = double.Parse(txtCantidad.Text);
                    objMesero.Fecha = dtpFecha.Value.ToString();
                    objMesero.Diastra = double.Parse(txtCantidad2.Text);
                    objMesero.Propina = double.Parse(txtCantidad3.Text);
                    objMesero.calcularSueldo();
                    lblSueldo.Text = objMesero.Sueldo.ToString();
                    break;

                case "Repartidor":
                    objRepartidor.Fecha = dtpFecha.Value.ToString();
                    objRepartidor.Zona = cmbZona.Text;
                    objRepartidor.Pago = double.Parse(txtCantidad.Text);
                    objRepartidor.Diastra = double.Parse(txtCantidad2.Text);
                    objRepartidor.Abonos = double.Parse(txtCantidad3.Text);
                    objRepartidor.calcularSueldo();
                    lblSueldo.Text = objRepartidor.Sueldo.ToString();
                    break;

                case "Cajero":
                    objCajero.Fecha = dtpFecha.Value.ToString();
                    objCajero.NumCaja = cmbCaja.Text;
                    objCajero.Pago = double.Parse(txtCantidad.Text);
                    objCajero.Diastra = double.Parse(txtCantidad2.Text);
                    objCajero.calcularSueldo();
                    lblSueldo.Text = objCajero.Sueldo.ToString();
                    break;
            }
            
            /*objMesero.calcularSueldo();
            objMesero.Pago = double.Parse(txtCantidad.Text);
            objMesero.Fecha = dtpFecha.Value.ToString();
            objMesero.Diastra = double.Parse(txtCantidad2.Text);
            objMesero.Propina = double.Parse(txtCantidad3.Text);
            objMesero.calcularSueldo();
            lblSueldo.Text = objMesero.Sueldo.ToString();

            objRepartidor.calcularSueldo();
            objRepartidor.Fecha = dtpFecha.Value.ToString();
            objRepartidor.Zona = cmbZona.Text;
            objRepartidor.Pago = double.Parse(txtCantidad.Text);
            objRepartidor.Diastra = double.Parse(txtCantidad2.Text);
            objRepartidor.Abonos = double.Parse(txtCantidad3.Text);
            objRepartidor.calcularSueldo();
            lblSueldo.Text = objRepartidor.Sueldo.ToString();

            //objCajero.calcularSueldo();
            objCajero.Fecha = dtpFecha.Value.ToString();
            objCajero.NumCaja = cmbCaja.Text;
            objMesero.Pago = double.Parse(txtCantidad.Text);
            objMesero.Diastra = double.Parse(txtCantidad2.Text);
            objCajero.calcularSueldo();
            lblSueldo.Text = objCajero.Sueldo.ToString();*/

        }
    }
}
