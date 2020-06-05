using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catálogo_de_Programas
{
    public partial class frmCatalogo : Form
    {
        public frmCatalogo()
        {
            InitializeComponent();
        }

        private void btnUni1_Click(object sender, EventArgs e)
        {
            frmUni1 frm = new frmUni1();

            frm.Show();

            this.Hide();
        }

        private void btnUni23_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmUni23 frm = new frmUni23();

            frm.Show();
        }
    

        private void btnUni4_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmUni4 frm = new frmUni4();

            frm.Show();
        }
    

        private void btnUni5_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmUni5 frm = new frmUni5();

            frm.Show();
        }

        private void btnUnidad6_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmUni6 frm = new frmUni6();

            frm.Show();
        }
    }
}
