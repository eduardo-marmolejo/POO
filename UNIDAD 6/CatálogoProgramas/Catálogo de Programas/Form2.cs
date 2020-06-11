using Examen23;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catálogo_de_Programas
{
    public partial class frmUni1 : Form
    {
        public frmUni1()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Close();

            frmCatalogo frm = new frmCatalogo();

            frm.Show();
        }

        private void btnPrimSol_Click(object sender, EventArgs e)
        {
            this.Close();

            frmEjecutables frm = new frmEjecutables();

            frm.Show();
        }

        private void btnExa23_Click(object sender, EventArgs e)
        {
            frmTemperaturas frm = new frmTemperaturas();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Examen23.exe");
        }
    }
}
