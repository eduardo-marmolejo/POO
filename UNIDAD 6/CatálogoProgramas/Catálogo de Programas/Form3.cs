using Calificaciones;
using Concierto;
using Embotelladora;
using Personas;
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

namespace Catálogo_de_Programas
{
    public partial class frmUni23 : Form
    {
        public frmUni23()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Close();

            frmCatalogo frm = new frmCatalogo();

            frm.Show();
        }

        private void btnExamen_Click(object sender, EventArgs e)
        {
            this.Close();

            frmDeExa frm = new frmDeExa();

            frm.Show();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            fmrCalificaciones frm = new fmrCalificaciones();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Calificaciones.exe");
        }

        private void btnRegCon_Click(object sender, EventArgs e)
        {
            fmrConcierto frm = new fmrConcierto();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Concierto.exe");
        }

        private void btnRegPer_Click(object sender, EventArgs e)
        {
            frmPersonas frm = new frmPersonas();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Personas.exe");
        }

        private void btnEmbotelladora_Click(object sender, EventArgs e)
        {
            FmrEmbotelladora frm = new FmrEmbotelladora();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Embotelladora.exe");
        }
    }
}
