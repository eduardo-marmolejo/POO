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
    public partial class frmRegistros : Form
    {
        public frmRegistros()
        {
            InitializeComponent();
        }

        private void btnRegPa_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Ejercicio 1.exe");
        }

        private void btnRegPa2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Ejercicio 2.exe");
        }

        private void btnRegEs_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Ejercicio 3.exe");
        }

        private void btnRegEs2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Ejercicio 4.exe");
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();

            frmUni5 frm = new frmUni5();

            frm.Show();
        }
    }
}
