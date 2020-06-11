using Empleados_Restaurante;
using Figuras_Geométricas;
using Figuras_Geométricas_2;
using Interfaces_Ejercicio_1;
using Operaciones;
using PiedraPapelTijeras;
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
using Vehículos;

namespace Catálogo_de_Programas
{
    public partial class frmUni4 : Form
    {
        public frmUni4()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmCatalogo frm = new frmCatalogo();

            frm.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleado frm = new frmEmpleado();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Empleados Restaurante.exe");
        }

        private void btnFigGeo_Click(object sender, EventArgs e)
        {
            frmFiguras frm = new frmFiguras();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Figuras Geométricas.exe");
        }

        private void btnFigGeo2_Click(object sender, EventArgs e)
        {
            FrmFiguras2 frm = new FrmFiguras2();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Figuras Geométricas 2.exe");
        }

        private void btnPPT_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/PiedraPapelTijeras.exe");
        }

        private void btnInterface_Click(object sender, EventArgs e)
        {
            frmCalculadora frm = new frmCalculadora();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Interfaces Ejercicio 1.exe");
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            frmOperacion frm = new frmOperacion();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Operaciones.exe");
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            frmVehículos frm = new frmVehículos();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Vehículos.exe");
        }
    }
}
