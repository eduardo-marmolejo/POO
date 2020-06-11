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

namespace MatrizSumaFCD2
{
    public partial class frmMatrizSumaFCD2 : Form
    {
        MatrizSumas objMatrizSumas = new MatrizSumas();
        string Acum;
        string AcumC;
        string AcumF;
        string AcumD;

        TextWriter archivofila;
        TextWriter archivocolumna;
        TextWriter archivodiagonal;
        public frmMatrizSumaFCD2()
        {
            InitializeComponent();
        }

        private void btnTamañoMatriz_Click(object sender, EventArgs e)
        {
            //Definir el tamaño del arreglo
            objMatrizSumas.MatrizBidi = new int[(int)nudNumMatriz.Value, (int)nudNumMatriz.Value];
            //Ingresar los datos
            for (int f = 0; f < objMatrizSumas.MatrizBidi.GetLength(0); f++)
            {
                Acum += "\r\n";
                for (int c = 0; c < objMatrizSumas.MatrizBidi.GetLength(1); c++)
                {
                    objMatrizSumas.MatrizBidi[f, c] = Convert.ToInt16(Interaction.InputBox("Introduce el elemento [" + f + "] [" + c + "]"));
                    Acum += objMatrizSumas.MatrizBidi[f, c];
                    txtMatriz.Text = Acum;
                }
            }
        }

        private void btnSumaFilas_Click(object sender, EventArgs e)
        {
            objMatrizSumas.SumaFilas = new int[(int)nudNumMatriz.Value];
            objMatrizSumas.SumaFila();
            for (int f = 0; f < objMatrizSumas.SumaFilas.Length; f++)
            {
                AcumF += objMatrizSumas.SumaFilas[f] + " ";
                txtSumaFilas.Text = AcumF;
            }
            archivofila.Write(AcumF);
            archivofila.Close();
        }

        private void btnSumaColumnas_Click(object sender, EventArgs e)
        {
            objMatrizSumas.SumaColumnas = new int[(int)nudNumMatriz.Value];
            objMatrizSumas.SumaColumna();
            for (int f = 0; f < objMatrizSumas.SumaColumnas.Length; f++)
            {
                AcumC += objMatrizSumas.SumaColumnas[f] + "\n";
                txtSumaColumnas.Text = AcumC;
            }
            archivocolumna.Write(AcumC);
            archivocolumna.Close();
        }

        private void btnSumaDiagonal_Click(object sender, EventArgs e)
        {
            lblSumaDiagonal.Text = objMatrizSumas.SumaDiagonal();
            archivodiagonal.Write(objMatrizSumas.SumaDiagonal());
            archivodiagonal.Close();
        }

        private void frmMatrizSumaFCD2_Load(object sender, EventArgs e)
        {
            archivofila = new StreamWriter("ArchivoFilas2.txt");
            archivocolumna = new StreamWriter("ArchivoColumnas2.txt");
            archivodiagonal = new StreamWriter("ArchivoDiag2.txt");
        }
    }
}
