using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatura
{
    public partial class fmrTemperatura : Form
    {
        ClassTemperatura objTemperatura = new ClassTemperatura();
        public fmrTemperatura()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objTemperatura.Temperatura();
            objTemperatura.num = int.Parse(txtGrados.Text.ToString());
            objTemperatura.temperatura = cmbTemperatura.Text.ToString();

            lblTemperatura.Text = objTemperatura.temp.ToString();
            lblTemperatura2.Text = objTemperatura.temp2.ToString();
        }
    }
}
