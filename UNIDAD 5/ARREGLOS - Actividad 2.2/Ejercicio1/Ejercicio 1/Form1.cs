using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class frmPaises : Form
    {
        ArrayList Paises = new ArrayList();
        public frmPaises()
        {
            InitializeComponent();
        }

        private void frmPaises_Load(object sender, EventArgs e)
        {
            ClassPaís Pais1 = new ClassPaís();
            dgvDatos.DataSource = Paises;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtPais.Text == "")
            {
                errorProvider1.SetError(txtPais, "Debe ingresar un País");
                txtPais.Focus();
                return;
            }
            errorProvider1.SetError(txtPais, "");

            if (Existe(txtPais.Text))
            {
                errorProvider1.SetError(txtPais, "El País ya existe");
                txtPais.Focus();
                return;
            }
            errorProvider1.SetError(txtPais, "");


            Double Poblacion;
            if (!Double.TryParse(txtPoblacion.Text, out Poblacion))
            {
                errorProvider1.SetError(txtPoblacion, "Debe ingresar el número de población");
                txtPoblacion.Focus();
                return;
            }

            if (Poblacion < 0)
            {
                errorProvider1.SetError(txtPoblacion, "Debe ingresar un números positivos");
                txtPoblacion.Focus();
                return;
            }

            if (txtIdioma.Text == "")
            {
                errorProvider1.SetError(txtIdioma, "Debe ingresar el idioma correcto");
                txtIdioma.Focus();
                return;
            }
            errorProvider1.SetError(txtIdioma, "");

            if (txtColorBandera.Text=="")
            {
                errorProvider1.SetError(txtColorBandera, "Debe ingresar los colores correctos");
                txtColorBandera.Focus();
                return;
            }
            errorProvider1.SetError(txtColorBandera, "");

            if (txtColorBandera2.Text == "")
            {
                errorProvider1.SetError(txtColorBandera2, "Debe ingresar los colores correctos");
                txtColorBandera2.Focus();
                return;
            }
            errorProvider1.SetError(txtColorBandera2, "");

            if (txtColorBandera3.Text == "")
            {
                errorProvider1.SetError(txtColorBandera3, "Debe ingresar los colores correctos");
                txtColorBandera3.Focus();
                return;
            }
            errorProvider1.SetError(txtColorBandera3, "");

            ClassPaís miPais = new ClassPaís();
            miPais.País = txtPais.Text;
            miPais.Poblacion = Poblacion;
            miPais.Idioma = txtIdioma.Text;
            miPais.Color1 = txtColorBandera.Text;
            miPais.Color2 = txtColorBandera2.Text;
            miPais.Color3 = txtColorBandera3.Text;
            Paises.Add(miPais);

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = Paises;

            txtPais.Clear();
            txtPoblacion.Clear();
            txtIdioma.Clear();
            txtColorBandera.Clear();
            txtColorBandera2.Clear();
            txtColorBandera3.Clear();
        }

        private bool Existe(string NomPais)
        {
            foreach (ClassPaís Pais in Paises)
            {
                if (Pais.País == NomPais) return true;
            }
            return false;
        }
    }
}
