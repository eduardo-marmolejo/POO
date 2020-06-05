using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        ClassAlumno objAlumno = new ClassAlumno();
        ClassMaestro objMaestro = new ClassMaestro();

        TextWriter Archivo;
        TextWriter Archivo2;
        TextWriter Archivo3;
        TextWriter Archivo4;
        TextWriter Archivo5;
        TextWriter Archivo6;
        TextWriter Archivo7;
        TextWriter Archivo8;
        TextWriter Archivo9;

        TextWriter Archivo10;
        TextWriter Archivo11;
        TextWriter Archivo12;
        TextWriter Archivo13;
        TextWriter Archivo14;
        TextWriter Archivo15;
        TextWriter Archivo16;
        TextWriter Archivo17;

        public Form1()
        {
            InitializeComponent();
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

                Archivo.Write(objAlumno.DatosAlumno[i, 0]);
                Archivo.Close();
                Archivo2.Write(objAlumno.DatosAlumno[i, 1]);
                Archivo2.Close();
                Archivo3.Write(objAlumno.DatosAlumno[i, 2]);
                Archivo3.Close();
                Archivo4.Write(objAlumno.DatosAlumno[i, 3]);
                Archivo4.Close();
                Archivo5.Write(objAlumno.DatosAlumno[i, 4]);
                Archivo5.Close();
                Archivo6.Write(objAlumno.DatosAlumno[i, 5]);
                Archivo6.Close();
                Archivo7.Write(objAlumno.DatosAlumno[i, 6]);
                Archivo7.Close();
                Archivo8.Write(objAlumno.DatosAlumno[i, 7]);
                Archivo8.Close();
                Archivo9.Write(objAlumno.DatosAlumno[i, 8]);
                Archivo9.Close();
            }
            //Habilitamos el botón de imprimir
            btnImprimir.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Archivo = new StreamWriter("DatosNombre.txt");
            Archivo2 = new StreamWriter("DatosFecha.txt");
            Archivo3 = new StreamWriter("DatosCurp.txt");
            Archivo4 = new StreamWriter("DatosTelefono.txt");
            Archivo5 = new StreamWriter("DatosEmail.txt");
            Archivo6 = new StreamWriter("DatosNumControl.txt");
            Archivo7 = new StreamWriter("DatosCarrera.txt");
            Archivo8 = new StreamWriter("DatosMaterias.txt");
            Archivo9 = new StreamWriter("DatosCalificacion.txt");

            Archivo10 = new StreamWriter("DatosNombreM.txt");
            Archivo11 = new StreamWriter("DatosFechaM.txt");
            Archivo12 = new StreamWriter("DatosCurpM.txt");
            Archivo13 = new StreamWriter("DatosTelefonoM.txt");
            Archivo14 = new StreamWriter("DatosEmailM.txt");
            Archivo15 = new StreamWriter("DatosNoMaestro.txt");
            Archivo16 = new StreamWriter("DatosSueldo.txt");
            Archivo17 = new StreamWriter("DatosMateriasImpar.txt");
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
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

                Archivo10.Write(objMaestro.DatosMaestros[i, 0]);
                Archivo10.Close();
                Archivo11.Write(objMaestro.DatosMaestros[i, 1]);
                Archivo11.Close();
                Archivo12.Write(objMaestro.DatosMaestros[i, 2]);
                Archivo12.Close();
                Archivo13.Write(objMaestro.DatosMaestros[i, 3]);
                Archivo13.Close();
                Archivo14.Write(objMaestro.DatosMaestros[i, 4]);
                Archivo14.Close();
                Archivo15.Write(objMaestro.DatosMaestros[i, 5]);
                Archivo15.Close();
                Archivo16.Write(objMaestro.DatosMaestros[i, 6]);
                Archivo16.Close();
                Archivo17.Write(objMaestro.DatosMaestros[i, 7]);
                Archivo17.Close();
            }
            btnImprimir2.Enabled = true;
        }

        private void btnImprimir2_Click(object sender, EventArgs e)
        {
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
