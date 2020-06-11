using Ejemplo_1_Propuesta;
using MatrizSumaFCD;
using MiPrimeraClase;
using Número_Mayor_y_Menor;
using RegistroProductos;
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
using Torneo_Futbol;

namespace Catálogo_de_Programas
{
    public partial class frmUni5 : Form
    {
        public frmUni5()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Close();

            frmCatalogo frm = new frmCatalogo();

            frm.Show();
        }

        private void btnArreglos_Click(object sender, EventArgs e)
        {
            this.Close();

            frmRegistros frm = new frmRegistros();

            frm.Show();
        }

        private void btnArreglosBidi_Click(object sender, EventArgs e)
        {
            this.Close();

            frmArreglosBidi frm = new frmArreglosBidi();

            frm.Show();
        }

        private void btnMatriz_Click(object sender, EventArgs e)
        {
            frmMatrizSumaFCD frm = new frmMatrizSumaFCD();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/MatrizSumaFCD.exe");
        }

        private void btnEjemplo_Click(object sender, EventArgs e)
        {
            frmPromedio frm = new frmPromedio();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Ejemplo 1 Propuesta.exe");
        }

        private void btnRegProd_Click(object sender, EventArgs e)
        {
            frmRegProd frm = new frmRegProd();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/RegistroProductos.exe");
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            frmPersonas frm = new frmPersonas();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/MiPrimeraClase.exe");
        }

        private void btnTorneo_Click(object sender, EventArgs e)
        {
            frmTorneoFutbol frm = new frmTorneoFutbol();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Torneo Futbol.exe");
        }

        private void btnMaMe_Click(object sender, EventArgs e)
        {
            frmMaMe frm = new frmMaMe();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Número Mayor y Menor.exe");
        }
    }
}
