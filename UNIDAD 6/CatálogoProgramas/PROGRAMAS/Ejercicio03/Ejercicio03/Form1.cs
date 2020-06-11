using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio03
{
    public partial class FrmRegistroEscolar : Form
    {
        ClassAlumno objAlumno = new ClassAlumno();
        ClassMaestro objMaestro = new ClassMaestro();
        public FrmRegistroEscolar()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            objAlumno.Nombre = txtNomAlumno.Text;
            objAlumno.Fecha = dtpFecha.Value.ToString();
            objAlumno.Curp = txtCurp.Text;
            objAlumno.Telefono = Convert.ToInt32(txtTeléfono.Text.ToString());
            objAlumno.Email = txtEmail.Text;
            objAlumno.NumControl = txtNoControl.Text;
            objAlumno.Carrera = txtCarrera.Text;

            //Entrada de datos
            objAlumno.Cant = Convert.ToInt32(txtMaterias.Text);
            //Inicializar ahora la matriz
            objAlumno.MateriasCal = new string[objAlumno.Cant, 2];
            //Ingresar datos
            for (int i = 0; i < objAlumno.Cant; i++)
            {
                objAlumno.MateriasCal[i, 0] = Microsoft.VisualBasic.Interaction.InputBox("Materia " + (i + 1), "Registro Escolar");
                objAlumno.MateriasCal[i, 1] = Microsoft.VisualBasic.Interaction.InputBox("Calificación " + (i + 1), "Registro Escolar");
            }

        }

        private void btnImprimirMaterias_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < objAlumno.Cant; i++)
            {
                DataGridViewRow Datos = new DataGridViewRow();
                Datos.CreateCells(dgvDatosAlumnos);
                Datos.Cells[0].Value = objAlumno.MateriasCal[i, 0];
                Datos.Cells[1].Value = objAlumno.MateriasCal[i, 1];

                dgvDatosAlumnos.Rows.Add(Datos);

            }
        }

        private void btnImprimirMaterias2_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < objMaestro.Cant2; i++)
            {
                DataGridViewRow Datos2 = new DataGridViewRow();
                Datos2.CreateCells(dgvDatosMaestros);
                Datos2.Cells[0].Value = objMaestro.MateriasImpartidas[i, 0];

                dgvDatosMaestros.Rows.Add(Datos2);
            }
        }

        private void btnRegistrarMaestro_Click_1(object sender, EventArgs e)
        {
            objMaestro.Nombre = txtNomMaestro.Text;
            objMaestro.Fecha = dtpFecha2.Value.ToString();
            objMaestro.Curp = txtCurp2.Text;
            objMaestro.Telefono = Convert.ToInt32(txtTelefono2.Text.ToString());
            objMaestro.Email = txtEmail2.Text;
            objMaestro.NumMaestro = txtNumMaestro.Text;
            objMaestro.Sueldo = Convert.ToInt32(txtSueldo.Text.ToString());


            //Entrada de datos
            objMaestro.Cant2 = Convert.ToInt32(txtMateriasImpartidas.Text);
            //Inicializar ahora la matriz
            objMaestro.MateriasImpartidas = new string[objMaestro.Cant2, 1];
            //Ingresar datos
            for (int i = 0; i < objMaestro.Cant2; i++)
            {
                objMaestro.MateriasImpartidas[i, 0] = Microsoft.VisualBasic.Interaction.InputBox("Materia que imparte " + (i + 1), "Registro Escolar");
            }
        }

        
    }
}
