﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bidimensionales_2
{
    public partial class frmOperaciones : Form
    {
        public frmOperaciones()
        {
            InitializeComponent();
        }

        int[,] arrayA = new int[100, 100];
        int[,] arrayB = new int[100, 100];
        int[,] arrayC = new int[100, 100];
        int fil, col, i, j;

        

        String acumA,acumB,acumC;

        

        private void btnTamañoMatriz_Click(object sender, EventArgs e)
        {
            fil = Convert.ToInt16(Interaction.InputBox("Cuantas filas tiene la matriz?"));
            col = Convert.ToInt16(Interaction.InputBox("Cuantas columnas?"));
        }

        

        private void btnDatosA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matriz A", "Ingresar Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            for (i = 0; i < fil; i++)
            {
                acumA += "\r\n";
                for (j = 0; j < col; j++)
                {
                    arrayA[i, j] = Convert.ToInt16(Interaction.InputBox(" Matriz A " +i+", "+j));
                    acumA += arrayA[i, j] + " \n";
                    txtA.Text = acumA;
                }
            }
        }

        

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btnResta_Click(object sender, EventArgs e)
        {
            for (i = 0; i < fil; i++)
            {
                acumC += "\r\n\n";
                for (j = 0; j < col; j++)
                {
                    arrayC[i, j] = arrayA[i, j] - arrayB[i, j];
                    acumC += arrayC[i, j] + " \n";
                    txtC.Text = acumC;
                }

            }
        }
        
        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            for (i = 0; i < fil; i++)
            {
                acumC += "\r\n\n";
                for (j = 0; j < col; j++)
                {
                    arrayC[i, j] = arrayA[i, j] * arrayB[i, j];
                    acumC += arrayC[i, j] + " \n";
                    txtC.Text = acumC;
                }

            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            for (i = 0; i < fil; i++)
            {
                acumC += "\r\n\n";
                for (j = 0; j < col; j++)
                {
                    arrayC[i, j] = arrayA[i, j] / arrayB[i, j];
                    acumC += arrayC[i, j] + " \n";
                    txtC.Text = acumC;
                }

            }
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
    }
}
