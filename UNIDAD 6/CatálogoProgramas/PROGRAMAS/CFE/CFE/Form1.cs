using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFE
{
    public partial class fmrCFE : Form
    {
        ClassRecibo objRecibo = new ClassRecibo();
        public fmrCFE()
        {
            InitializeComponent();
        }

        private void btmCalcular_Click(object sender, EventArgs e)
        {
            objRecibo.Recibo();
            objRecibo.contrato = cmbTarifa.Text.ToString();
            objRecibo.kw = int.Parse(txtKW.Text.ToString());

            lblCosto.Text = objRecibo.pago.ToString();
        }
    }
}
