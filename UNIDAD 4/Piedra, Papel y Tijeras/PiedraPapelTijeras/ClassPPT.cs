using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiedraPapelTijeras
{
    class ClassPPT
    {
        private int posicionOriginalPlayer1, posicionOiginalPlayer2;
        private int movimientosManos, tiempoSeleccion, tiempoTotalJuego;
        private bool movimientoArriba; 
        private String ganeActual;

        public int PosicionOriginalPlayer1
        {
            set
            {
                posicionOriginalPlayer1 = value;
            }
            get
            {
                return posicionOriginalPlayer1;
            }
        }

        public int PosicionOriginalPlayer2
        {
            set
            {
                posicionOiginalPlayer2 = value;
            }
            get
            {
                return posicionOiginalPlayer2;
            }
        }

        public int MovimientosManos
        {
            set
            {
                movimientosManos = value;
            }
            get
            {
                return movimientosManos;
            }
        }

        public int TiempoSeleccion
        {
            set
            {
                tiempoSeleccion = value;
            }
            get
            {
                return tiempoSeleccion;
            }
        }

        public int TiempoTotalJuego
        {
            set
            {
                tiempoTotalJuego = value;
            }
            get
            {
                return tiempoTotalJuego;
            }
        }

        public bool MovimientoArriba
        {
            set
            {
                movimientoArriba = value;
            }
            get
            {
                return movimientoArriba;
            }
        }

        public String GaneActual
        {
            set
            {
                ganeActual = value;
            }
            get
            {
                return ganeActual;
            }
        }

        public ClassPPT()
        {
            TiempoTotalJuego = 0;
        }
    }
}
