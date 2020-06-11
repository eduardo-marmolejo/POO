
using Ejercicio12;
using Ejercicio22;
using Ejercicio32;
using Ejercicio42;
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
    public partial class frmRegistros2 : Form
    {
        public frmRegistros2()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmUni6 frm = new frmUni6();

            frm.Show();
        }

        private void btnRegPa_Click(object sender, EventArgs e)
        {
            FrmRegistroPaises1 frm = new FrmRegistroPaises1();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/ARREGLOS - Actividad 2.2/Ejercicio1/Ejercicio 1/bin/Debug/Ejercicio 1.exe");

        }

        private void btnRegPa2_Click(object sender, EventArgs e)
        {
            frmPaises22 frm = new frmPaises22();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/ARREGLOS - Actividad 2.2/Ejercicio2/Ejercicio 2/bin/Debug/Ejercicio 2.exe");
        }

        private void btnRegEs_Click(object sender, EventArgs e)
        {
            FrmRegistroEscolar3 frm = new FrmRegistroEscolar3();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/ARREGLOS - Actividad 2.2/Ejercicio3/Ejercicio 3/bin/Debug/Ejercicio 3.exe");
        }

        private void btnRegEs2_Click(object sender, EventArgs e)
        {
            FrmRegEs4 frm = new FrmRegEs4();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/ARREGLOS - Actividad 2.2/Ejercicio4/Ejercicio 3/bin/Debug/Ejercicio 3.exe");
        }
    }
}
