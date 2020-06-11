using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehículos
{
    class ClassAereo:ClassVehículo
    {
        public int numTurbinas, numAlas, numHélices;
        public string tipoAereo;

        public ClassAereo()
        {
            numAlas = 0;
            numTurbinas = 0;
            numHélices = 0;
            tipoAereo = "";

        }

        public string enVuelo(string estado)
        {
            return "El "+ tipoAereo+"está volando "+estado;
        }
    }
}
