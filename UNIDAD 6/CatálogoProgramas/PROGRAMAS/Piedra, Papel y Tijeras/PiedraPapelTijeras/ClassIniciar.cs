using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiedraPapelTijeras
{
    class ClassIniciar:ClassPPT,Ippt
    {
        public void IniciarJuego()
        {
            MovimientoArriba = false;
            MovimientosManos = 0;
            TiempoSeleccion = 150;
            GaneActual = "empate";
        }   
    }
}
