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
    public partial class frmArreglosBidi2 : Form
    {
        public frmArreglosBidi2()
        {
            InitializeComponent();
        }

        private void btnBidi11_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/ARREGLOS BIDIMENSIONALES/Bidimensionales1-1/Bidimensionales 1-1/bin/Debug/Bidimensionales 1-1.exe");
        }

        private void btnBidi12_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/ARREGLOS BIDIMENSIONALES/Bidimensionales1-2/Bidimensionales 1-2/bin/Debug/Bidimensionales 1-2.exe");
        }

        private void btnBidi2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/ARREGLOS BIDIMENSIONALES/Bidimensionales2/Bidimensionales 2/bin/Debug/Bidimensionales 2.exe");
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();

            frmUni6 frm = new frmUni6();

            frm.Show();
        }
    }
}
