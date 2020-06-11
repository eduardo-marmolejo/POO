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

namespace Torneo_Futbol_2
{
    public partial class frmTorneoFutbol2 : Form
    {
        ClassTorneo objTorneo = new ClassTorneo();
        int Mayor;
        string Ganador;
        TextWriter Archivo;

        public frmTorneoFutbol2()
        {
            InitializeComponent();
        }

        private void btnIngresarDatosTorneo_Click(object sender, EventArgs e)
        {
            objTorneo.NomTorneo = txtNomTorneo.Text.ToString();
            objTorneo.NumEquipos = int.Parse(txtNumEquipo.Text.ToString());
            objTorneo.NumPartidosPorEquipo = int.Parse(txtNumParEquipo.Text.ToString());
            objTorneo.FechaInicio = dtpFechaInicio.Value;
            objTorneo.FechaFin = dtpFechaFin.Value;
            objTorneo.PuntosGanados = (int)nudPuntosGanados.Value;
            objTorneo.PuntosEmpate = (int)nudPuntosEmpate.Value;
            objTorneo.PuntosPerdidos = (int)nudPuntosPerdidos.Value;
            MessageBox.Show("Se guardaron correctamente los datos del torneo de " + objTorneo.NomTorneo, "Torneo de Futbol", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNomTorneo.Clear();
            txtNumEquipo.Clear();
            txtNumParEquipo.Clear();
            btnDatosEquipos.Enabled = true;
        }

        private void btnCalcularPartidos_Click(object sender, EventArgs e)
        {
            objTorneo.NumEquipos = int.Parse(txtNumEquipo.Text.ToString());
            objTorneo.Torneo();
            txtNumParEquipo.Text = objTorneo.NumPartidosPorEquipo.ToString();
        }

        private void btnDatosEquipos_Click(object sender, EventArgs e)
        {
            objTorneo.PuntajeXPartido = new string[objTorneo.NumEquipos, objTorneo.NumEquipos];
            for (int f = 0; f < objTorneo.PuntajeXPartido.GetLength(0); f++)
            {
                objTorneo.PuntajeXPartido[f, 0] = Interaction.InputBox("Introduce el Nombre del equipo Numero :" + (f + 1));
                for (int c = 1; c < objTorneo.PuntajeXPartido.GetLength(1); c++)
                {
                    objTorneo.PuntajeXPartido[f, c] = Interaction.InputBox("Introduce el puntaje Obtenido en el partido numero : " + c);

                }
            }
            objTorneo.SumaPuntajes = new int[objTorneo.NumEquipos];
            objTorneo.CalculcarPunObtenido();
            btnMostrarCampeon.Enabled = true;
        }

        private void btnMostrarCampeon_Click(object sender, EventArgs e)
        {
            MessageBox.Show(objTorneo.CalcularGanador(Mayor, Ganador), "¡Felicidades!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Archivo.Write(objTorneo.CalcularGanador(Mayor, Ganador));
            Archivo.Close();
        }

        private void frmTorneoFutbol2_Load(object sender, EventArgs e)
        {
            Archivo = new StreamWriter("DatosTorneo.txt");
        }
    }
}
