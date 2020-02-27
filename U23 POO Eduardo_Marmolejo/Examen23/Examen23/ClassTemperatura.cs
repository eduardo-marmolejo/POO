using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen23
{
    class ClassTemperatura
    {
        //Atributos de la clase
        public double centi, fahr, medida;
        public string temperaturas;

        //Métodos de la clase
        public void Temperatura()
        {
            switch(temperaturas)
            {
                case "Centígrados":
                    fahr = (medida * 1.8) - 32;
                break;

                case "Fahrenheit":
                    centi = (medida + 32) / 1.8;
                break;
            }
        }
    }
}
