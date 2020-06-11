using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiedraPapelTijeras
{
    class Class1
    {
        int PosicionOriginalPlayer1, PosicionOriginalPlayer2;
        int movimientosManos, TiempoSeleccion, TiempoTotalJuego = 0;
        bool MovimientoArriba; String GaneActual = "empate";
        public void IniciarJuego()
        {
            MovimientoArriba = false;
            movimientosManos = 0;
            TiempoSeleccion = 150;
            GaneActual = "empate";

            timer1.Enabled = true;
            timer2.Enabled = true;
            timer1.Start();
            timer2.Start();
        }
    }
}
