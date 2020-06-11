using Ejercicio_1;
using Ejercicio_2;
using Ejercicio03;
using Ejercicio4;
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
            frmPaises frm = new frmPaises();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Ejercicio 1.exe");
        }

        private void btnRegPa2_Click(object sender, EventArgs e)
        {
            frmPaises2 frm = new frmPaises2();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Ejercicio 2.exe");
        }

        private void btnRegEs_Click(object sender, EventArgs e)
        {
            FrmRegistroEscolar frm = new FrmRegistroEscolar();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Ejercicio 3.exe");
        }

        private void btnRegEs2_Click(object sender, EventArgs e)
        {
            frmREG2 frm = new frmREG2();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Ejercicio 4.exe");
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();

            frmUni5 frm = new frmUni5();

            frm.Show();
        }
    }
}
