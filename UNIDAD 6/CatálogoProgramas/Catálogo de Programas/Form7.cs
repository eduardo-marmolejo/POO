using Ejemplo_1_Propuesta_2;
using MatrizSumaFCD2;
using MiPrimeraClase2;
using Número_Mayor_y_Menor_2;
using RegistroProductos2;
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
using Torneo_Futbol_2;

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
            frmMatrizSumaFCD2 frm = new frmMatrizSumaFCD2();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/MatrizSumaFCD/MatrizSumaFCD/bin/Debug/MatrizSumaFCD.exe");
        }

        private void btnEjemplo_Click(object sender, EventArgs e)
        {
            frmPromedio2 frm = new frmPromedio2();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Ejemplo1Propuesta - Arreglo/Ejemplo 1 Propuesta/bin/Debug/Ejemplo 1 Propuesta.exe");
        }

        private void btnMaMe_Click(object sender, EventArgs e)
        {
            frmMaMe2 frm = new frmMaMe2();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/MayoryMenor/Número Mayor y Menor/bin/Debug/Número Mayor y Menor.exe");
        }

        private void btnRegProd_Click(object sender, EventArgs e)
        {
            frmRegProd2 frm = new frmRegProd2();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Registro de Productos/RegistroProductos/RegistroProductos/bin/Debug/RegistroProductos.exe");
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            frmPersonas2 frm = new frmPersonas2();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/MiPrimeraClase(Video)/MiPrimeraClase/bin/Debug/MiPrimeraClase.exe");
        }

        private void btnTorneo_Click(object sender, EventArgs e)
        {
            frmTorneoFutbol2 frm = new frmTorneoFutbol2();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/TorneoFutbol/Torneo Futbol/bin/Debug/Torneo Futbol.exe");
        }
    }
}
