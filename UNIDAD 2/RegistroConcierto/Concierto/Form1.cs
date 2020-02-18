using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concierto
{
    public partial class fmrConcierto : Form
    {
        ClassConcierto objConcierto = new ClassConcierto();
        public fmrConcierto()
        {
            InitializeComponent();
        }

        private void btnContabilizar_Click(object sender, EventArgs e)
        {
            if (cmbPersona.Text == "")
            {
                errorProvider1.SetError(cmbPersona, "Seleccionar la persona");
                cmbPersona.Focus();
                return;
            }
            if (cmbNumPer.Text == "")
            {
                errorProvider1.SetError(cmbNumPer, "Seleccione el número de personas");
                cmbNumPer.Focus();
                return;
            }

            objConcierto.persona = cmbPersona.Text.ToString();
            objConcierto.num = int.Parse(cmbNumPer.Text.ToString());
            objConcierto.num2 = int.Parse(cmbNumPer.Text.ToString());
            objConcierto.num3 = int.Parse(cmbNumPer.Text.ToString());
            objConcierto.num4 = int.Parse(cmbNumPer.Text.ToString());
            objConcierto.RegConcierto();
            /*cmbPersona.Text = "";
            cmbNumPer.Text = "";*/
        }

        private void btnRportar_Click(object sender, EventArgs e)
        {
            lblBebes.Text = "Bebes: " + objConcierto.bb.ToString();
            lblNiños.Text = "Niños: " + objConcierto.nn.ToString();
            lblAdultos.Text = "Adultos: " + objConcierto.adu.ToString();
            lblTerceraEdad.Text = "Tercera Edad: " + objConcierto.te.ToString();
        }
    }
}
