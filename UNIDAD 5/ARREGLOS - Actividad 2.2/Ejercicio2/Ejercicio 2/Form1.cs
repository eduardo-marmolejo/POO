using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class frmPaises : Form
    {
        ClassPaís objPais = new ClassPaís();
        public frmPaises()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Declaración de variables
            string pais;
            //Entrada de datos
            pais = txtBuscar.Text;
            //Buscamos si el país ingresado existe
            for(int i = 0; i < objPais.cant; i++)
            {
                if (objPais.Países[i, 0].Equals(pais))
                {
                    lblPais.Text = objPais.Países[i, 0];
                    lblPoblacion.Text = objPais.Países[i, 1];
                    lblIdioma.Text = objPais.Países[i, 2];
                    lblColorBandera1.Text = objPais.Países[i, 3];
                    lblColorBandera2.Text = objPais.Países[i, 4];
                    lblColorBandera3.Text = objPais.Países[i, 5];
                    objPais.index = i;
                    objPais.encuentra = 1;

                }
            }
            if (objPais.encuentra == 0)
            {
                MessageBox.Show("El país ingresado no existe", "Registro del País",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Entrada de datos
            objPais.cant = Convert.ToInt32(txtRegistrar.Text);
            //Inicializar ahora la matriz
            objPais.Países = new string[objPais.cant, 6];
            //Ingresar datos
            for(int i = 0; i < objPais.cant; i++)
            {
                objPais.Países[i, 0] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre del país " + (i+1), "Registro del País");
                objPais.Países[i, 1] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la población del país " + (i + 1), "Registro del País");
                objPais.Países[i, 2] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el idioma del país " + (i+1), "Registro del País");
                objPais.Países[i, 3] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el primer color de la bandera " + (i+1), "Registro del País");
                objPais.Países[i, 4] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el segundo color de la bandera " + (i+1), "Registro del País");
                objPais.Países[i, 5] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el tercer color de la bandera " + (i+1), "Registro del País");
            }
        }
    }
    
}
