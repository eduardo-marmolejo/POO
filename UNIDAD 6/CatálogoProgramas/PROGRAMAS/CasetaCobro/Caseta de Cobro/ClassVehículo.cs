using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caseta_de_Cobro
{
    class ClassVehículo
    {
        //Atributos de la clase
        public int cobro;
        public string vehiculo;
        //Métodos de la clase
        public void Vehiculo()
        {
            switch(vehiculo)
            {
                case "Motocicleta":
                    cobro = 50;
                break;

                case "Automóvil":
                    cobro = 112;
                break;

                case "Autobús":
                    cobro = 170;
                break;

                case "Tráiler":
                    cobro = 250;
                break;
            }
        }
    }
}
