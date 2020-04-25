using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class frmRegistroEscolar : Form
    {
        ArrayList Escolar = new ArrayList();
        ClassPersona objPersona = new ClassPersona();
        ClassAlumno objAlumno = new ClassAlumno();
        ClassMaestro objMaestro = new ClassMaestro();
        public frmRegistroEscolar()
        {
            InitializeComponent();
        }

        private void frmRegistroEscolar_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Entrada de datos
            objAlumno.Cant = Convert.ToInt32(txtRegistrar.Text);
            //Inicializar ahora la matriz
            objAlumno.DatosAlumno = new string[objAlumno.Cant, 9];
            //Ingresar datos
            for (int i = 0; i < objAlumno.Cant; i++)
            {
                objAlumno.DatosAlumno[i, 0] = Microsoft.VisualBasic.Interaction.InputBox("Nombre " + (i + 1), "Registro Escolar");
                objAlumno.DatosAlumno[i, 1] = Microsoft.VisualBasic.Interaction.InputBox("Fecha " + (i + 1), "Registro Escolar");
                objAlumno.DatosAlumno[i, 2] = Microsoft.VisualBasic.Interaction.InputBox("Curp " + (i + 1), "Registro Escolar");
                objAlumno.DatosAlumno[i, 3] = Microsoft.VisualBasic.Interaction.InputBox("Teléfono " + (i + 1), "Registro Escolar");
                objAlumno.DatosAlumno[i, 4] = Microsoft.VisualBasic.Interaction.InputBox("Email " + (i + 1), "Registro Escolar");
                objAlumno.DatosAlumno[i, 5] = Microsoft.VisualBasic.Interaction.InputBox("Número de control " + (i + 1), "Registro Escolar");
                objAlumno.DatosAlumno[i, 6] = Microsoft.VisualBasic.Interaction.InputBox("Carrera " + (i + 1), "Registro Escolar");
                objAlumno.DatosAlumno[i, 7] = Microsoft.VisualBasic.Interaction.InputBox("Materia " + (i + 1), "Registro Escolar");
                objAlumno.DatosAlumno[i, 8] = Microsoft.VisualBasic.Interaction.InputBox("Calificacion " + (i + 1), "Registro Escolar");
            }

            for (int i = 0; i < objAlumno.Cant; i++)
            {
                DataGridViewRow Datos = new DataGridViewRow();
                Datos.CreateCells(dgvDatosAlumnos);
                Datos.Cells[0].Value = objAlumno.DatosAlumno[i, 0];
                Datos.Cells[1].Value = objAlumno.DatosAlumno[i, 1];
                Datos.Cells[2].Value = objAlumno.DatosAlumno[i, 2];
                Datos.Cells[3].Value = objAlumno.DatosAlumno[i, 3];
                Datos.Cells[4].Value = objAlumno.DatosAlumno[i, 4];
                Datos.Cells[5].Value = objAlumno.DatosAlumno[i, 5];
                Datos.Cells[6].Value = objAlumno.DatosAlumno[i, 6];
                Datos.Cells[7].Value = objAlumno.DatosAlumno[i, 7];
                Datos.Cells[8].Value = objAlumno.DatosAlumno[i, 8];

                dgvDatosAlumnos.Rows.Add(Datos);
            }
        }

        private void btnRegistrar2_Click(object sender, EventArgs e)
        {
            //Entrada de datos
            objMaestro.Cant2 = Convert.ToInt32(txtRegistrar2.Text);
            //Inicializar ahora la matriz
            objMaestro.DatosMaestros = new string[objMaestro.Cant2, 8];
            //Ingresar datos
            for (int i = 0; i < objMaestro.Cant2; i++)
            {
                objMaestro.DatosMaestros[i, 0] = Microsoft.VisualBasic.Interaction.InputBox("Nombre " + (i + 1), "Registro Escolar");
                objMaestro.DatosMaestros[i, 1] = Microsoft.VisualBasic.Interaction.InputBox("Fecha de nacimiento " + (i + 1), "Registro Escolar");
                objMaestro.DatosMaestros[i, 2] = Microsoft.VisualBasic.Interaction.InputBox("Curp " + (i + 1), "Registro Escolar");
                objMaestro.DatosMaestros[i, 3] = Microsoft.VisualBasic.Interaction.InputBox("Teléfono " + (i + 1), "Registro Escolar");
                objMaestro.DatosMaestros[i, 4] = Microsoft.VisualBasic.Interaction.InputBox("Email " + (i + 1), "Registro Escolar");
                objMaestro.DatosMaestros[i, 5] = Microsoft.VisualBasic.Interaction.InputBox("Número de maestro " + (i + 1), "Registro Escolar");
                objMaestro.DatosMaestros[i, 6] = Microsoft.VisualBasic.Interaction.InputBox("Sueldo " + (i + 1), "Registro Escolar");
                objMaestro.DatosMaestros[i, 7] = Microsoft.VisualBasic.Interaction.InputBox("Materia que imparte " + (i + 1), "Registro Escolar");
            }

            for (int i = 0; i < objMaestro.Cant2; i++)
            {
                DataGridViewRow Datos2 = new DataGridViewRow();
                Datos2.CreateCells(dgvDatosAlumnos);
                Datos2.Cells[0].Value = objMaestro.DatosMaestros[i, 0];
                Datos2.Cells[1].Value = objMaestro.DatosMaestros[i, 1];
                Datos2.Cells[2].Value = objMaestro.DatosMaestros[i, 2];
                Datos2.Cells[3].Value = objMaestro.DatosMaestros[i, 3];
                Datos2.Cells[4].Value = objMaestro.DatosMaestros[i, 4];
                Datos2.Cells[5].Value = objMaestro.DatosMaestros[i, 5];
                Datos2.Cells[6].Value = objMaestro.DatosMaestros[i, 6];
                Datos2.Cells[7].Value = objMaestro.DatosMaestros[i, 7];

                dgvDatosMaestros.Rows.Add(Datos2);
            }
        }
    }
}
