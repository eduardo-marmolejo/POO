using MiPrimerProyectoWindowsForm;
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
    public partial class frmEjecutables : Form
    {
        public frmEjecutables()
        {
            InitializeComponent();
        }

        private void btnConsola_Click(object sender, EventArgs e)
        {
            String Nombreprograma;
            String ruta;

            Nombreprograma = "MiPrimerProyectoConsola.exe";
            ruta = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            ruta = ruta.Substring(6);
            ruta = String.Concat("\"", ruta, "\\", Nombreprograma, "\"");

            string cmdexeruta = @"C:\Windows\System32\cmd.exe";
            string cmdArguments2 = String.Format("/K {0}", ruta);
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(cmdexeruta, cmdArguments2);
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = psi;
            p.Start();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/MiPrimerProyectoConsola.exe");
        }

        private void btnWindowsForm_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            frm.Show();

            //Process.Start(@"C:/Users/odrau/Desktop/UNIDAD 6/CatálogoProgramas/PROGRAMAS/MiPrimerProyectoWindowsForm.exe");
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();

            frmUni1 frm = new frmUni1();

            frm.Show();
        }
    }
}
