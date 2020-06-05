using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class frmRegistroEscolar : Form
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

        public frmRegistroEscolar()
        {
            InitializeComponent();
        }

        private void frmRegistroEscolar_Load(object sender, EventArgs e)
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            objAlumno.Nombre = txtNomAlumno.Text;
            objAlumno.Fecha = dtpFecha.Value.ToString();
            objAlumno.Curp = txtCurp.Text;
            objAlumno.Telefono = Convert.ToInt32(txtTeléfono.Text.ToString());
            objAlumno.Email = txtEmail.Text;
            objAlumno.NumControl = txtNoControl.Text;
            objAlumno.Carrera = txtCarrera.Text;

            Archivo.Write(objAlumno.Nombre);
            Archivo.Close();
            Archivo2.Write(objAlumno.Fecha);
            Archivo2.Close();
            Archivo3.Write(objAlumno.Curp);
            Archivo3.Close();
            Archivo4.Write(objAlumno.Telefono);
            Archivo4.Close();
            Archivo5.Write(objAlumno.Email);
            Archivo5.Close();
            Archivo6.Write(objAlumno.NumControl);
            Archivo6.Close();
            Archivo7.Write(objAlumno.Carrera);
            Archivo7.Close();


            //Entrada de datos
            objAlumno.Cant = Convert.ToInt32(txtMaterias.Text);
            //Inicializar ahora la matriz
            objAlumno.MateriasCal = new string[objAlumno.Cant,2];
            //Ingresar datos
            for(int i = 0; i < objAlumno.Cant; i++)
            {
                objAlumno.MateriasCal[i,0] = Microsoft.VisualBasic.Interaction.InputBox("Materia " + (i + 1), "Registro Escolar");
                objAlumno.MateriasCal[i,1] = Microsoft.VisualBasic.Interaction.InputBox("Calificación " + (i + 1), "Registro Escolar");

                Archivo8.Write(objAlumno.MateriasCal[i, 0]);
                Archivo8.Close();
                Archivo9.Write(objAlumno.MateriasCal[i, 1]);
                Archivo9.Close();
            }

        }

        private void btnImprimirMaterias_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < objAlumno.Cant; i++)
            {
               DataGridViewRow Datos = new DataGridViewRow();
                Datos.CreateCells(dgvDatosAlumnos);
                Datos.Cells[0].Value = objAlumno.MateriasCal[i,0];
                Datos.Cells[1].Value = objAlumno.MateriasCal[i,1];

                dgvDatosAlumnos.Rows.Add(Datos);

            }
        }

        private void btnImprimirMaterias2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < objMaestro.Cant2; i++)
            {
                DataGridViewRow Datos2 = new DataGridViewRow();
                Datos2.CreateCells(dgvDatosMaestros);
                Datos2.Cells[0].Value = objMaestro.MateriasImpartidas[i, 0];

                dgvDatosMaestros.Rows.Add(Datos2);
            }
        }

        private void btnRegistrarMaestro_Click(object sender, EventArgs e)
        {
            objMaestro.Nombre = txtNomMaestro.Text;
            objMaestro.Fecha = dtpFecha2.Value.ToString();
            objMaestro.Curp = txtCurp2.Text;
            objMaestro.Telefono = Convert.ToInt32(txtTelefono2.Text.ToString());
            objMaestro.Email = txtEmail2.Text;
            objMaestro.NumMaestro = txtNumMaestro.Text;
            objMaestro.Sueldo = int.Parse(txtSueldo.Text.ToString());

            Archivo10.Write(objMaestro.Nombre);
            Archivo10.Close();
            Archivo11.Write(objMaestro.Fecha);
            Archivo11.Close();
            Archivo12.Write(objMaestro.Curp);
            Archivo12.Close();
            Archivo13.Write(objMaestro.Telefono);
            Archivo13.Close();
            Archivo14.Write(objMaestro.Email);
            Archivo14.Close();
            Archivo15.Write(objMaestro.NumMaestro);
            Archivo15.Close();
            Archivo16.Write(objMaestro.Sueldo);
            Archivo16.Close();

            //Entrada de datos
            objMaestro.Cant2 = Convert.ToInt32(txtMateriasImpartidas.Text);
            //Inicializar ahora la matriz
            objMaestro.MateriasImpartidas = new string[objMaestro.Cant2, 1];
            //Ingresar datos
            for (int i = 0; i < objMaestro.Cant2; i++)
            {
                objMaestro.MateriasImpartidas[i, 0] = Microsoft.VisualBasic.Interaction.InputBox("Materia que imparte " + (i + 1), "Registro Escolar");

                Archivo17.Write(objMaestro.MateriasImpartidas[i, 0]);
                Archivo17.Close();
            }
        }
    }
}
