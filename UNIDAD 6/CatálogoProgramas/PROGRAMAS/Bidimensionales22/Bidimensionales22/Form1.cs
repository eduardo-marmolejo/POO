using Microsoft.VisualBasic;
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

namespace Bidimensionales22
{
    public partial class frmOperaciones2 : Form
    {
        public frmOperaciones2()
        {
            InitializeComponent();
        }

        int[,] arrayA = new int[100, 100];
        int[,] arrayB = new int[100, 100];
        int[,] arrayC = new int[100, 100];
        int fil, col, i, j;
        TextWriter Archivo;
        TextWriter Archivo2;
        TextWriter Archivo3;

        private void btnDatosA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matriz A", "Ingresar Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            for (i = 0; i < fil; i++)
            {
                acumA += "\r\n";
                for (j = 0; j < col; j++)
                {
                    arrayA[i, j] = Convert.ToInt16(Interaction.InputBox(" Matriz A " + i + ", " + j));
                    acumA += arrayA[i, j] + " \n";
                    txtA.Text = acumA;
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDatosB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matriz B", "Ingresar Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            for (i = 0; i < fil; i++)
            {
                acumB += "\r\n";
                for (j = 0; j < col; j++)
                {
                    arrayB[i, j] = Convert.ToInt16(Interaction.InputBox(" Matriz B " + i + ", " + j));
                    acumB += arrayB[i, j] + " \n";
                    txtB.Text = acumB;
                }
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            for (i = 0; i < fil; i++)
            {
                acumC += "\r\n\n";
                for (j = 0; j < col; j++)
                {
                    arrayC[i, j] = arrayA[i, j] + arrayB[i, j];
                    acumC += arrayC[i, j] + " \n";
                    txtC.Text = acumC;

                    Archivo.Write(acumC);
                    Archivo.Close();
                }

            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            for (i = 0; i < fil; i++)
            {
                acumC2 += "\r\n\n";
                for (j = 0; j < col; j++)
                {
                    arrayC[i, j] = arrayA[i, j] - arrayB[i, j];
                    acumC2 += arrayC[i, j] + " \n";
                    txtC.Text = acumC2;

                    Archivo2.Write(acumC2);
                    Archivo2.Close();
                }

            }
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            for (i = 0; i < fil; i++)
            {
                acumC3 += "\r\n\n";
                for (j = 0; j < col; j++)
                {
                    arrayC[i, j] = arrayA[i, j] * arrayB[i, j];
                    acumC3 += arrayC[i, j] + " \n";
                    txtC.Text = acumC3;

                    Archivo3.Write(acumC3);
                    Archivo3.Close();
                }

            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            for (i = 0; i < fil; i++)
            {
                acumC4 += "\r\n\n";
                for (j = 0; j < col; j++)
                {
                    arrayC[i, j] = arrayA[i, j] / arrayB[i, j];
                    acumC4 += arrayC[i, j] + " \n";
                    txtC.Text = acumC4;

                    Archivo4.Write(acumC4);
                    Archivo4.Close();
                }

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            acumA = "";
            acumB = "";
            acumC = "";
        }

        private void frmOperaciones2_Load(object sender, EventArgs e)
        {
            Archivo = new StreamWriter("Datos.txt");
            Archivo2 = new StreamWriter("Datos2.txt");
            Archivo3 = new StreamWriter("Datos3.txt");
            Archivo4 = new StreamWriter("Datos4.txt");
        }

        TextWriter Archivo4;

        String acumA, acumB, acumC, acumC2, acumC3, acumC4, ConArchivo;

        private void btnTamañoMatriz_Click(object sender, EventArgs e)
        {
            fil = Convert.ToInt16(Interaction.InputBox("Cuantas filas tiene la matriz?"));
            col = Convert.ToInt16(Interaction.InputBox("Cuantas columnas?"));
        }
    }
}
