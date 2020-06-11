using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_1_Propuesta_2
{
    public partial class frmPromedio2 : Form
    {
        ClassPromedio objPromedio = new ClassPromedio();

        TextWriter Archivo;

        public frmPromedio2()
        {
            InitializeComponent();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            double[] Cal = new double[5];
            Cal[0] = 90;
            Cal[1] = 100;
            Cal[2] = 70;
            Cal[3] = 80;
            Cal[4] = 50;
            for (int x = 0; x <= 4; x++)
            {
                cmbCal.Items.Add(Cal[x]);
                objPromedio.NumCal = objPromedio.NumCal + Cal[x];
            }
            objPromedio.Promedio();
            lblPromedio.Text = objPromedio.Promedion.ToString();
            Archivo.Write(objPromedio.Promedion);
            Archivo.Close();
        }

        private void frmPromedio2_Load(object sender, EventArgs e)
        {
            Archivo = new StreamWriter("DatosEjemplo.txt");
        }
    }
}
