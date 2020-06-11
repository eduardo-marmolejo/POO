using Caseta_de_Cobro;
using CFE;
using Cuadrado;
using Fecha_de_Nacimiento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temperatura;
using Vacaciones;

namespace Catálogo_de_Programas
{
    public partial class frmDeExa : Form
    {
        public frmDeExa()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();

            frmUni23 frm = new frmUni23();

            frm.Show();
        }

        private void btnCaseta_Click(object sender, EventArgs e)
        {
            frmCaseta frm = new frmCaseta();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Caseta de Cobro.exe");
        }

        private void btnCFE_Click(object sender, EventArgs e)
        {
            fmrCFE frm = new fmrCFE();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/CFE.exe");
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            fmrCuadrado frm = new fmrCuadrado();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Cuadrado.exe");
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            frmFechaNacimiento frm = new frmFechaNacimiento();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Fecha de Nacimiento.exe");
        }

        private void btnTemperatura_Click(object sender, EventArgs e)
        {
            fmrTemperatura frm = new fmrTemperatura();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Temperatura.exe");
        }

        private void btnVacaciones_Click(object sender, EventArgs e)
        {
            fmrVacaciones frm = new fmrVacaciones();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Vacaciones.exe");
        }
    }
}
