using Bidimensionales_2;
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
    public partial class frmArreglosBidi : Form
    {
        public frmArreglosBidi()
        {
            InitializeComponent();
        }

        private void btnBidi11_Click(object sender, EventArgs e)
        {
            String Nombreprograma;
            String ruta;

            Nombreprograma = "Bidimensionales 1-1.exe";
            ruta = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            ruta = ruta.Substring(6);
            ruta = String.Concat("\"", ruta, "\\", Nombreprograma, "\"");

            string cmdexeruta = @"C:\Windows\System32\cmd.exe";
            string cmdArguments2 = String.Format("/K {0}", ruta);
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(cmdexeruta, cmdArguments2);
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = psi;
            p.Start();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Bidimensionales 1-1.exe");
        }

        private void btnBidi12_Click(object sender, EventArgs e)
        {
            String Nombreprograma;
            String ruta;

            Nombreprograma = "Bidimensionales 1-2.exe";
            ruta = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            ruta = ruta.Substring(6);
            ruta = String.Concat("\"", ruta, "\\", Nombreprograma, "\"");

            string cmdexeruta = @"C:\Windows\System32\cmd.exe";
            string cmdArguments2 = String.Format("/K {0}", ruta);
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(cmdexeruta, cmdArguments2);
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = psi;
            p.Start();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Bidimensionales 1-2.exe");
        }

        private void btnBidi2_Click(object sender, EventArgs e)
        {
            frmOperaciones frm = new frmOperaciones();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/Bidimensionales 2.exe");
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();

            frmUni5 frm = new frmUni5();

            frm.Show();
        }
    }
}
