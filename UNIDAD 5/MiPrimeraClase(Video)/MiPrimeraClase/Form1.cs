using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraClase
{
    public partial class frmPersonas : Form
    {
        ArrayList Personas = new ArrayList();

        public frmPersonas()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmPersonas_Load(object sender, EventArgs e)
        {
            ClassPersona Persona1 = new ClassPersona();
            Persona1.ID = "1010";
            Persona1.Nombre = "Lady";
            Persona1.Apellidos = "Gaga";
            Persona1.Correo = "ladygaga@gmail.com";
            Persona1.FechaNacimiento = new DateTime(1990,3,14);
            Persona1.Salario = 1200000;
            Personas.Add(Persona1);

            ClassPersona Persona2 = new ClassPersona();
            Persona2.ID = "2020";
            Persona2.Nombre = "Daddy";
            Persona2.Apellidos = "Yankee";
            Persona2.Correo = "daddy@yahoo.es";
            Persona2.FechaNacimiento = new DateTime(1987,7,20);
            Persona2.Salario = 2560000;
            Personas.Add(Persona2);

            dgvDatos.DataSource = Personas;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                errorProvider1.SetError(txtID, "Debe ingresar un ID de la persona");
                txtID.Focus();
                return;
            }
            errorProvider1.SetError(txtID, "");

            if (Existe(txtID.Text))
            {
                errorProvider1.SetError(txtID, "ID del empleado ya existe");
                txtID.Focus();
                return;
            }
            errorProvider1.SetError(txtID, "");


            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Debe ingresar un Nombre de la persona");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            if (txtApellidos.Text == "")
            {
                errorProvider1.SetError(txtApellidos, "Debe ingresar un Apellido de la persona");
                txtApellidos.Focus();
                return;
            }
            errorProvider1.SetError(txtApellidos, "");

            Regex regEmail = new Regex(@"^(([^<>()[\]\\.,;:\s@\""]+"
                                     + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                                     + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}]"
                                     + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                                     + @"[a-zA-Z]{2,}))$", 
                                     RegexOptions.Compiled);

            if (!regEmail.IsMatch(txtCorreo.Text))
            {
                errorProvider1.SetError(txtCorreo, "Debe ingresar una dirección de correo válida");
                txtCorreo.Focus();
                return;
            }
            errorProvider1.SetError(txtCorreo, "");

            decimal Salario;
            if (!Decimal.TryParse(txtSalario.Text, out Salario)) 
            {
                errorProvider1.SetError(txtSalario, "Debe ingresar números en el campo salario");
                txtSalario.Focus();
                return;
            }

            if (Salario<0)
            {
                errorProvider1.SetError(txtSalario, "Debe ingresar un número positivo");
                txtSalario.Focus();
                return;
            }

            ClassPersona miPersona = new ClassPersona();
            miPersona.ID = txtID.Text;
            miPersona.Nombre = txtNombre.Text;
            miPersona.Apellidos = txtApellidos.Text;
            miPersona.Correo = txtCorreo.Text;
            miPersona.FechaNacimiento = dtpFechaNacimiento.Value;
            miPersona.Salario =Salario;
            Personas.Add(miPersona);

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = Personas;

            txtID.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtSalario.Clear();
            txtID.Focus();
        }

        private bool Existe(string ID)
        {
            foreach (ClassPersona Persona in Personas)
            {
                if (Persona.ID == ID) return true;
            }
            return false;
        }
    }
}
