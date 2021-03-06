﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio22
{
    public partial class frmPaises22 : Form
    {
        ClassPaís objPais = new ClassPaís();

        TextWriter Archivo;
        TextWriter Archivo2;
        TextWriter Archivo3;
        TextWriter Archivo4;
        TextWriter Archivo5;
        TextWriter Archivo6;
        public frmPaises22()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Entrada de datos
            objPais.cant = Convert.ToInt32(txtRegistrar.Text);
            //Inicializar ahora la matriz
            objPais.Países = new string[objPais.cant, 6];
            //Ingresar datos
            for (int i = 0; i < objPais.cant; i++)
            {
                objPais.Países[i, 0] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre del país " + (i + 1), "Registro del País");
                objPais.Países[i, 1] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la población del país " + (i + 1), "Registro del País");
                objPais.Países[i, 2] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el idioma del país " + (i + 1), "Registro del País");
                objPais.Países[i, 3] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el primer color de la bandera " + (i + 1), "Registro del País");
                objPais.Países[i, 4] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el segundo color de la bandera " + (i + 1), "Registro del País");
                objPais.Países[i, 5] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el tercer color de la bandera " + (i + 1), "Registro del País");
            }
        }

        private void frmPaises22_Load(object sender, EventArgs e)
        {
            Archivo = new StreamWriter("DatosPaís2.txt");
            Archivo2 = new StreamWriter("DatosPoblación2.txt");
            Archivo3 = new StreamWriter("DatosIdioma2.txt");
            Archivo4 = new StreamWriter("DatosColor12.txt");
            Archivo5 = new StreamWriter("DatosColor22.txt");
            Archivo6 = new StreamWriter("DatosColor32.txt");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Declaración de variables
            string pais;
            //Entrada de datos
            pais = txtBuscar.Text;
            //Buscamos si el país ingresado existe
            for (int i = 0; i < objPais.cant; i++)
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

                    Archivo.Write(lblPais.Text);
                    Archivo.Close();
                    Archivo2.Write(lblPoblacion.Text);
                    Archivo2.Close();
                    Archivo3.Write(lblIdioma.Text);
                    Archivo3.Close();
                    Archivo4.Write(lblColorBandera1.Text);
                    Archivo4.Close();
                    Archivo5.Write(lblColorBandera2.Text);
                    Archivo5.Close();
                    Archivo6.Write(lblColorBandera3.Text);
                    Archivo6.Close();
                }
            }
            if (objPais.encuentra == 0)
            {
                MessageBox.Show("El país ingresado no existe", "Registro del País", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
