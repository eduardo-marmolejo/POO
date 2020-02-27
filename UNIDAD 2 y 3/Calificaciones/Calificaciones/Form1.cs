using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calificaciones
{
    public partial class fmrCalificaciones : Form
    {
        ClassCalificaciones objcalificacion = new ClassCalificaciones();
        public fmrCalificaciones()
        {
            InitializeComponent();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            //ClassCalificaciones objcalificacion = new ClassCalificaciones();
            objcalificacion.cal = int.Parse(txtCalificacion.Text.ToString());
            objcalificacion.RegCapCal();
            txtCalificacion.Text = "";

        }

        private void btnReportar_Click(object sender, EventArgs e)
        {
            //ClassCalificaciones objcalificacion = new ClassCalificaciones();
            lblAprobados.Text = "Aprobados: "+objcalificacion.aprobados.ToString();
            lblReprobados.Text = "Reprobados: "+objcalificacion.reprobados.ToString();
            lblPromedio.Text = "Promedio: "+objcalificacion.promedio.ToString();

        }

 
    }
}
