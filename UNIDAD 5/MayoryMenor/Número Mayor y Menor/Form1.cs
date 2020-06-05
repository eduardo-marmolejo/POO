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

namespace Número_Mayor_y_Menor
{
    public partial class frmMaMe : Form
    {
        MayorMenor objNumeros = new MayorMenor();
        int Mayor;
        int Menor;
        string maymer;
        public frmMaMe()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Darle valor a los atributos
            objNumeros.Cant = (int)nudCanNum.Value;
            //Implementar el nud al atributos 
            objNumeros.Cant = (int)nudCanNum.Value
                ;
            objNumeros.NumCant = new int[objNumeros.Cant];

            for (int i = 0; i < objNumeros.NumCant.GetLength(0); i++)
            {
                objNumeros.NumCant[i] = Convert.ToInt32(Interaction.InputBox("Agrega el numero " + (i + 1)));
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(objNumeros.CalcularMay(Mayor, maymer, Menor), "Los numero mayor es: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void frmMaMe_Load(object sender, EventArgs e)
        {
            
        }
    }
}
