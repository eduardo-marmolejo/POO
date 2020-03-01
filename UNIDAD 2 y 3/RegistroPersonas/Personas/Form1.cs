using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personas
{
    public partial class frmPersonas : Form
    {
        ClassPersonas objPersonas = new ClassPersonas();
        public frmPersonas()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Ingresa el nombre");
                txtNombre.Focus();
                return;
            }

            if (txtPaterno.Text == "")
            {
                errorProvider1.SetError(txtPaterno, "Ingresa el apellido paterno");
                txtPaterno.Focus();
                return;
            }

            if (txtMaterno.Text == "")
            {
                errorProvider1.SetError(txtMaterno, "Ingresa el apellido materno");
                txtMaterno.Focus();
                return;
            }

            if (cmbEstado.Text == "")
            {
                errorProvider1.SetError(cmbEstado, "Selecciona un estado");
                cmbEstado.Focus();
                return;
            }

            if (cmbTipo.Text == "")
            {
                errorProvider1.SetError(cmbTipo, "Selecciona un tipo");
                cmbTipo.Focus();
                return;
            }

            if (txtTelefono.Text == "")
            {
                errorProvider1.SetError(txtTelefono, "Ingresa el número de teléfono");
                txtTelefono.Focus();
                return;
            }

           
            objPersonas.nom = txtNombre.Text;
            objPersonas.paterno = txtPaterno.Text;
            objPersonas.materno = txtMaterno.Text;
            objPersonas.RegPersonas();

            objPersonas.añoActual = int.Parse(DateTime.Today.Year.ToString());
            objPersonas.mesActual = int.Parse(DateTime.Today.Month.ToString());
            objPersonas.diaActual = int.Parse(DateTime.Today.Day.ToString());
            objPersonas.año = int.Parse(dtpEdad.Value.Year.ToString());
            objPersonas.mes = int.Parse(dtpEdad.Value.Month.ToString());
            objPersonas.dia = int.Parse(dtpEdad.Value.Day.ToString());

            objPersonas.Edad();
            objPersonas.estados = cmbEstado.Text;
            objPersonas.Nayarit();
            objPersonas.tipo = cmbTipo.Text;
            objPersonas.Tipasos();
            cmbTipo.Text = objPersonas.tipo.ToString();

            MessageBox.Show("Los datos se registraron correctamente");

            txtNombre.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            dtpEdad.Text = "";
            cmbEstado.Text = "";
            cmbTipo.Text = "";
            txtTelefono.Text = "";


        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            frmInforme informe = new frmInforme();
            informe.lblEdad.Text = objPersonas.conEdad.ToString();
            informe.lblNayarit.Text = objPersonas.conNayarit.ToString();
            informe.lblAlumno.Text = objPersonas.conAlumno.ToString();
            informe.lblMaestros.Text = objPersonas.conMaestros.ToString();
            informe.lblAdministrativos.Text = objPersonas.conAdmin.ToString();
            informe.Show();
        }
    }
}
