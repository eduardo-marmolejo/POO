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
    public partial class frmEjecutables : Form
    {
        public frmEjecutables()
        {
            InitializeComponent();
        }

        private void btnConsola_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/MiPrimerProyectoConsola.exe");
        }

        private void btnWindowsForm_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/MiPrimerProyectoWindowsForm.exe");
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();

            frmUni1 frm = new frmUni1();

            frm.Show();
        }
    }
}
