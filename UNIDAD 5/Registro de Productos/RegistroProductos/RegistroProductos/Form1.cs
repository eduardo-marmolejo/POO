using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroProductos
{
    public partial class frmRegProd : Form
    {
        RegProd objRegProd = new RegProd();
        public frmRegProd()
        {
            InitializeComponent();
            btnBuscar.Enabled = false;
            btnVender.Enabled = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Entrada de datos
            objRegProd.CantProd = Convert.ToInt32(txtCantProd.Text);
            //Inicializar la matriz
            objRegProd.NomProducto = new string[objRegProd.CantProd, 3];
            //Ingresar datos a la matriz
            for (int i=0;i<objRegProd.CantProd;i++)
            {
                objRegProd.NomProducto[i, 0] = Microsoft.VisualBasic.Interaction.InputBox("Registre el nombre del producto" + (i + 1), "Tienda de Abarrotes");
                objRegProd.NomProducto[i, 1] = Microsoft.VisualBasic.Interaction.InputBox("Registre el precio del producto" + (i + 1), "Tienda de Abarrotes");
                objRegProd.NomProducto[i, 2] = Microsoft.VisualBasic.Interaction.InputBox("Registre el Stock del producto" + (i + 1), "Tienda de Abarrotes");
            }
            btnBuscar.Enabled = true;
            txtCantProd.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Entrada de datos
            objRegProd.Producto = txtNomProd.Text;
            //Busacar si el producto existe
            for (int i=0;i<objRegProd.CantProd;i++)
            {
                if (objRegProd.NomProducto[i,0].Equals(objRegProd.Producto))
                {
                    lblPrecio.Text = objRegProd.NomProducto[i, 1];
                    lblStock.Text = objRegProd.NomProducto[i, 2];
                    objRegProd.index=i;
                    btnVender.Enabled = true;
                    objRegProd.Buscar = 1;

                }
            }
            txtVender.Clear();
            if (objRegProd.Buscar == 0)
            {
                MessageBox.Show("No se encuentra el producto", "Tienda de Abarrotes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnVender.Enabled = false;
            }
            btnVender.Enabled = true;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            int Cant, Stock;
            Cant = Convert.ToInt32(txtVender.Text);
            Stock = Convert.ToInt32(lblStock.Text);
            if (Cant<=Stock)
            {
                //Dismiuir el stock
                objRegProd.NomProducto[objRegProd.index,2] =Convert.ToString(Stock - Cant);
            }
            else
            {
                MessageBox.Show("No hay suficiente Stock", "Tienda de Abarrotes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtNomProd.Clear();
            lblPrecio.Text="0";
            lblStock.Text = "0";
        }
    }
}
