using Bidimensionales22;
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
            String Nombreprograma;
            String ruta;

            Nombreprograma = "Bidimensionales1-12.exe";
            ruta = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            ruta = ruta.Substring(6);
            ruta = String.Concat("\"", ruta, "\\", Nombreprograma, "\"");

            string cmdexeruta = @"C:\Windows\System32\cmd.exe";
            string cmdArguments2 = String.Format("/K {0}", ruta);
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(cmdexeruta, cmdArguments2);
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = psi;
            p.Start();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/ARREGLOS BIDIMENSIONALES/Bidimensionales1-1/Bidimensionales 1-1/bin/Debug/Bidimensionales 1-1.exe");
        }

        private void btnBidi12_Click(object sender, EventArgs e)
        {
            String Nombreprograma;
            String ruta;

            Nombreprograma = "Bidimensionales1-22.exe";
            ruta = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            ruta = ruta.Substring(6);
            ruta = String.Concat("\"", ruta, "\\", Nombreprograma, "\"");

            string cmdexeruta = @"C:\Windows\System32\cmd.exe";
            string cmdArguments2 = String.Format("/K {0}", ruta);
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(cmdexeruta, cmdArguments2);
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = psi;
            p.Start();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/ARREGLOS BIDIMENSIONALES/Bidimensionales1-2/Bidimensionales 1-2/bin/Debug/Bidimensionales 1-2.exe");
        }

        private void btnBidi2_Click(object sender, EventArgs e)
        {
            frmOperaciones2 frm = new frmOperaciones2();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/ARREGLOS BIDIMENSIONALES/Bidimensionales2/Bidimensionales 2/bin/Debug/Bidimensionales 2.exe");
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();

            frmUni6 frm = new frmUni6();

            frm.Show();
        }
    }
}
