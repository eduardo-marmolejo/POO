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
    public partial class frmUni6 : Form
    {
        public frmUni6()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmCatalogo frm = new frmCatalogo();

            frm.Show();
        }

        private void btnArreglos_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmRegistros2 frm = new frmRegistros2();

            frm.Show();
        }

        private void btnArreglosBidi_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmArreglosBidi2 frm = new frmArreglosBidi2();

            frm.Show();
        }

        private void btnMatriz_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/MatrizSumaFCD/MatrizSumaFCD/bin/Debug/MatrizSumaFCD.exe");
        }

        private void btnEjemplo_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Ejemplo1Propuesta - Arreglo/Ejemplo 1 Propuesta/bin/Debug/Ejemplo 1 Propuesta.exe");
        }

        private void btnMaMe_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/MayoryMenor/Número Mayor y Menor/bin/Debug/Número Mayor y Menor.exe");
        }

        private void btnRegProd_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Registro de Productos/RegistroProductos/RegistroProductos/bin/Debug/RegistroProductos.exe");
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/MiPrimeraClase(Video)/MiPrimeraClase/bin/Debug/MiPrimeraClase.exe");
        }

        private void btnTorneo_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/TorneoFutbol/Torneo Futbol/bin/Debug/Torneo Futbol.exe");
        }
    }
}
