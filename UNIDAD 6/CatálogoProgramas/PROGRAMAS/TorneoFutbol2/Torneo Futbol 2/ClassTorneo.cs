using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torneo_Futbol_2
{
    class ClassTorneo
    {
        public string NomTorneo { get; set; }
        public int NumEquipos { get; set; }
        public int NumPartidosPorEquipo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int PuntosGanados { get; set; }
        public int PuntosEmpate { get; set; }
        public int PuntosPerdidos { get; set; }
        public string[,] PuntajeXPartido { get; set; }
        public int[] SumaPuntajes { get; set; }

        public void Torneo()
        {
            NumPartidosPorEquipo = NumEquipos - 1;
        }

        public void CalculcarPunObtenido()
        {
            int p = 0;

            for (int i = 0; i < PuntajeXPartido.GetLength(0); i++)
            {
                int suma = 0;
                int acum = 0;
                for (int j = 1; j < PuntajeXPartido.GetLength(1); j++)
                {
                    suma = Convert.ToInt32(PuntajeXPartido[i, j]);
                    acum += suma;
                }
                SumaPuntajes[p] = acum;
                p++;
            }


        }

        public string CalcularGanador(int Mayor, string Ganador)
        {


            int NumeroGanador = 0;
            int f = 0;
            for (int i = 0; i < SumaPuntajes.Length; i++)
            {
                if (SumaPuntajes[i] > Mayor)
                {
                    Mayor = SumaPuntajes[i];
                    NumeroGanador = f;
                }
                f++;
            }
            Ganador = "El equipo Ganador es " + PuntajeXPartido[NumeroGanador, 0] + " Con " + Mayor + " puntos";
            return Ganador;
        }
    }
}
